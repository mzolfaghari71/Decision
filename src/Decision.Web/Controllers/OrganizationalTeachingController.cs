﻿using System;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Web.UI;
using Decision.Common.Controller;
using Decision.Common.Filters;
using Decision.Common.Helpers.Extentions;
using Decision.Common.Helpers.Json;
using Decision.DataLayer.Context;
using Decision.DomainClasses.Entities.TeacherInfo;
using Decision.ServiceLayer.Contracts.TeacherInfo;
using Decision.ServiceLayer.Security;
using Decision.ViewModel.EducationalExperience;
using Decision.Web.Extentions;
using Decision.Web.Filters;
using MvcSiteMapProvider;

namespace Decision.Web.Controllers
{
    
    [RoutePrefix("Teacher/OrganizationalTeaching")]
    [Route("{action}")]
    [Mvc5Authorize(AssignableToRolePermissions.CanManageOrganizationalTeaching)]
    public partial class OrganizationalTeachingController : Controller
    {
        #region	Fields

        private readonly IReferentialTeacherService _referentialTeacherService;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IEducationalExperienceService _educationalExperienceService;
        #endregion

        #region	Ctor
        public OrganizationalTeachingController(IReferentialTeacherService referentialTeacherService,IUnitOfWork unitOfWork, IEducationalExperienceService educationalExperienceService)
        {
            _unitOfWork = unitOfWork;
            _educationalExperienceService = educationalExperienceService;
            _referentialTeacherService = referentialTeacherService;
        }
        #endregion

        #region List,ListAjax
        [HttpGet]
        [Route("List/{TeacherId}")]
        [TeacherAuthorize]
        [MvcSiteMapNode(ParentKey = "Teacher_Details", Title = "لیست سوابق تدریس سازمانی استاد", PreservedRouteParameters = "TeacherId")]
        public virtual async Task<ActionResult> List(Guid TeacherId)
        {
            
            var viewModel = await _educationalExperienceService.GetPagedListAsync(new EducationalExperienceSearchRequest
            {
                TeacherId = TeacherId,
                Type = EducationalExperienceType.TeachingInOrganizational
            });
            return View( viewModel);
        }
        //[CheckReferrer]
        [HttpPost]
        [AjaxOnly]
        [OutputCache(Location = OutputCacheLocation.None, NoStore = true, Duration = 0)]
        public virtual async Task<ActionResult> ListAjax(EducationalExperienceSearchRequest request)
        {
            if (!_referentialTeacherService.CanManageTeacher(request.TeacherId)) return HttpNotFound();
            request.Type=EducationalExperienceType.TeachingInOrganizational;
            var viewModel = await _educationalExperienceService.GetPagedListAsync(request);
            if (viewModel.EducationalExperiences == null || !viewModel.EducationalExperiences.Any())
                return Content("no-more-info");

            return PartialView(MVC.OrganizationalTeaching.Views._ListAjax, viewModel);
        }
        #endregion

        #region Create
        [HttpGet]
        [AjaxOnly]
        public virtual async Task<ActionResult> Create(Guid TeacherId)
        {
            if (!_referentialTeacherService.CanManageTeacher(TeacherId)) return HttpNotFound();
            var viewModel =
                await
                    _educationalExperienceService.GetForCreate(TeacherId,
                        EducationalExperienceType.TeachingInOrganizational);
            return PartialView(MVC.OrganizationalTeaching.Views._Create, viewModel);
        }

        [AjaxOnly]
        [HttpPost]
        [ValidateAntiForgeryToken]
        //[CheckReferrer]
        [Audit(Description = "درج سابقه تدریس در مراکر سازمانی برای استاد")]
        public virtual async Task<ActionResult> Create(AddEducationalExperienceViewModel viewModel)
        {
            if (!_referentialTeacherService.CanManageTeacher(viewModel.TeacherId)) return HttpNotFound();
            if (!ModelState.IsValid)
            {
                await _educationalExperienceService.FillAddViewModel(viewModel);
                return new JsonNetResult
                {
                    Data = new
                    {
                        success = false,
                        View =
                            this.RenderPartialViewToString(MVC.OrganizationalTeaching.Views._Create, viewModel)
                    }
                };
            }
            var newOrganizationalTeaching = await _educationalExperienceService.Create(viewModel);
            return new JsonNetResult
            {
                Data = new
                {
                    success = true,
                    View =
                        this.RenderPartialViewToString(MVC.OrganizationalTeaching.Views._OrganizationalTeachingItem, newOrganizationalTeaching)
                }
            };
        }
        #endregion

        #region Edit
        [HttpGet]
        [AjaxOnly]
        [OutputCache(Location = OutputCacheLocation.None, NoStore = true, Duration = 0)]
        public virtual async Task<ActionResult> Edit(Guid? id)
        {
            if (id == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            var viewModel = await _educationalExperienceService.GetForEditAsync(id.Value);
            if (viewModel == null) return HttpNotFound();
            if (!_referentialTeacherService.CanManageTeacher(viewModel.TeacherId)) return HttpNotFound();
            return PartialView(MVC.OrganizationalTeaching.Views._Edit, viewModel);
        }

        [HttpPost]
        //[CheckReferrer]
        [AjaxOnly]
        [ValidateAntiForgeryToken]
        [Audit(Description = "ویرایش سابقه تدریس در مراکر سازمانی")]
        public virtual async Task<ActionResult> Edit(EditEducationalExperienceViewModel viewModel)
        {
            if (!_referentialTeacherService.CanManageTeacher(viewModel.TeacherId)) return HttpNotFound();
            if (!await _educationalExperienceService.IsInDb(viewModel.Id))

                if (!ModelState.IsValid)
                {
                    await _educationalExperienceService.FillEditViewModel(viewModel);
                    return new JsonNetResult
                    {
                        Data = new
                        {
                            success = false,
                            View =
                                this.RenderPartialViewToString(MVC.OrganizationalTeaching.Views._Edit, viewModel)
                        }
                    };
                }

            await _educationalExperienceService.EditAsync(viewModel);
            var message = await _unitOfWork.ConcurrencySaveChangesAsync();
            if (message.HasValue()) this.AddErrors("TitleId", string.Format(message, "سابقه تدریس سازمانی استاد"));

            if (ModelState.IsValid)
            {
                var OrganizationalTeaching =
                    await _educationalExperienceService.GetEducationalExperienceViewModel(viewModel.Id);
                return new JsonNetResult
                {
                    Data = new
                    {
                        success = true,
                        View =
                            this.RenderPartialViewToString(MVC.OrganizationalTeaching.Views._OrganizationalTeachingItem, OrganizationalTeaching)
                    }
                };
            }
            await _educationalExperienceService.FillEditViewModel(viewModel);
            return new JsonNetResult
            {
                Data = new
                {
                    success = false,
                    View =
                        this.RenderPartialViewToString(MVC.OrganizationalTeaching.Views._Edit, viewModel)
                }
            };
        }

        #endregion

        #region Delete
        [HttpPost]
        [AjaxOnly]
        //[CheckReferrer]
        [ValidateAntiForgeryToken]
        [Audit(Description = "حذف سابقه تدریس در مراکر سازمانی")]
        [OutputCache(Location = OutputCacheLocation.None, NoStore = true, Duration = 0)]
        public virtual async Task<ActionResult> Delete(Guid id,Guid TeacherId)
        {
            if (!_referentialTeacherService.CanManageTeacher(TeacherId)) return HttpNotFound();
            await _educationalExperienceService.DeleteAsync(id);
            return Content("ok");
        }
        #endregion

        #region CancelEdit
        [HttpPost]
        [AjaxOnly]
        public virtual async Task<ActionResult> CancelEdit(Guid? id)
        {
            if (id == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            var viewModel = await _educationalExperienceService.GetEducationalExperienceViewModel(id.Value);
            if (viewModel == null) return HttpNotFound();
            return PartialView(MVC.OrganizationalTeaching.Views._OrganizationalTeachingItem, viewModel);
        }
        #endregion
    }
}