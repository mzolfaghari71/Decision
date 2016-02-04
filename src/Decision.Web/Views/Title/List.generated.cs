﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Optimization;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    
    #line 1 "..\..\Views\Title\List.cshtml"
    using Decision.Common.Helpers;
    
    #line default
    #line hidden
    using Decision.Common.MVC;
    using Decision.Utility;
    using Decision.Web.HtmlHelpers;
    using MvcSiteMapProvider.Web.Html;
    using MvcSiteMapProvider.Web.Html.Models;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Title/List.cshtml")]
    public partial class _Views_Title_List_cshtml : System.Web.Mvc.WebViewPage<Decision.ViewModel.Title.TitleListViewModel>
    {
        public _Views_Title_List_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Views\Title\List.cshtml"
  
    ViewBag.Title = "مشاهده لیست عنوان ها";

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 6 "..\..\Views\Title\List.cshtml"
Write(Html.AntiForgeryToken());

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<div");

WriteLiteral(" class=\"panel panel-default\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"panel-heading\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"col-md-2\"");

WriteLiteral(">\r\n                <a");

WriteLiteral(" class=\"btn btn-default btn-sm\"");

WriteLiteral(" data-ajax=\"true\"");

WriteLiteral(" data-ajax-mode=\"replace\"");

WriteLiteral(" data-ajax-success=\"onSuccessFormValidation(data, status, xhr,\'createTitleForm\',\'" +
"modal\')\"");

WriteLiteral("\r\n                   data-ajax-update=\"#modal\"");

WriteAttribute("href", Tuple.Create(" href=\"", 521), Tuple.Create("\"", 559)
            
            #line 13 "..\..\Views\Title\List.cshtml"
, Tuple.Create(Tuple.Create("", 528), Tuple.Create<System.Object, System.Int32>(Url.Action(MVC.Title.Create())
            
            #line default
            #line hidden
, 528), false)
);

WriteLiteral(" role=\"button\"");

WriteLiteral("><i");

WriteLiteral(" class=\"fa fa-plus\"");

WriteLiteral("></i>درج عنوان جدید</a>\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"col-md-9\"");

WriteLiteral(">\r\n");

            
            #line 16 "..\..\Views\Title\List.cshtml"
                
            
            #line default
            #line hidden
            
            #line 16 "..\..\Views\Title\List.cshtml"
                 using (Ajax.BeginForm(MVC.Title.ListAjax(), new AjaxOptions { AllowCache = false, HttpMethod = "POST", OnComplete = "searchOnComplete(xhr,status,'#progress','#titlePager','#titleList')" }, new { @class = "form-horizontal search", autocomplete = "off", id = "titleSearchForm" }))
                {
                    
            
            #line default
            #line hidden
            
            #line 18 "..\..\Views\Title\List.cshtml"
               Write(Html.Hidden("PageIndex", Model.Request.PageIndex));

            
            #line default
            #line hidden
            
            #line 18 "..\..\Views\Title\List.cshtml"
                                                                      

            
            #line default
            #line hidden
WriteLiteral("                    <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"col-lg-3\"");

WriteLiteral(">\r\n");

WriteLiteral("                            ");

            
            #line 21 "..\..\Views\Title\List.cshtml"
                       Write(Html.EnumDropDownListFor(a => Model.Request.Type, "انتخاب نوع", new { Name = "Type", @class = "form-control" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n                        </div>\r\n                        <div");

WriteLiteral(" class=\"col-lg-3\"");

WriteLiteral(">\r\n");

WriteLiteral("                            ");

            
            #line 25 "..\..\Views\Title\List.cshtml"
                       Write(Html.EnumDropDownListFor(a => Model.Request.Category, "انتخاب گروه", new { Name = "Category", @class = "form-control" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n                        </div>\r\n                        <div");

WriteLiteral(" class=\"col-lg-5\"");

WriteLiteral(">\r\n                            <div");

WriteLiteral(" class=\"input-group\"");

WriteLiteral(">\r\n                                <input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" name=\"Name\"");

WriteLiteral(" class=\"form-control\"");

WriteLiteral("\r\n                                       placeholder=\"نام عنوان\"");

WriteLiteral(">\r\n                                <span");

WriteLiteral(" class=\"input-group-btn\"");

WriteLiteral(">\r\n                                    <button");

WriteLiteral(" type=\"button\"");

WriteLiteral(" id=\"titleSearchButton\"");

WriteLiteral(" onclick=\"directSearchPaging(\'#progress\', \'titleSearchForm\', \'#titlePager\', \'#tit" +
"leList\')\"");

WriteLiteral(" autocomplete=\"off\"");

WriteLiteral(" data-loading-text=\"جستجو\"");

WriteLiteral(" class=\"btn btn-success btn-sm search\"");

WriteLiteral(">\r\n                                        <i");

WriteLiteral(" class=\"fa fa-search\"");

WriteLiteral("></i>         جستجو\r\n                                    </button>\r\n             " +
"                   </span>\r\n                            </div>\r\n                " +
"        </div>\r\n                    </div>\r\n");

            
            #line 40 "..\..\Views\Title\List.cshtml"


                }

            
            #line default
            #line hidden
WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"panel-body\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(" id=\"titleList\"");

WriteLiteral(">\r\n");

            
            #line 48 "..\..\Views\Title\List.cshtml"
            
            
            #line default
            #line hidden
            
            #line 48 "..\..\Views\Title\List.cshtml"
               Html.RenderPartial(MVC.Title.Views.ViewNames._ListAjax, Model);
            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"panel-footer padding-5-5\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"col-md-offset-2 col-md-8\"");

WriteLiteral(">\r\n                <button");

WriteLiteral(" data-page=\"2\"");

WriteLiteral(" id=\"titlePager\"");

WriteLiteral(" onclick=\"doPaging(this, \'#progress\', \'titleSearchForm\')\"");

WriteLiteral(" class=\"btn btn-info btn-block btn-sm\"");

WriteLiteral(" type=\"button\"");

WriteLiteral(">\r\n                    بیشتر\r\n                </button>\r\n            </div>\r\n    " +
"    </div>\r\n        <div");

WriteLiteral(" id=\"progress\"");

WriteLiteral(" align=\"center\"");

WriteLiteral(" style=\"display: none\"");

WriteLiteral(">\r\n            <img");

WriteAttribute("src", Tuple.Create(" src=\"", 3114), Tuple.Create("\"", 3164)
            
            #line 60 "..\..\Views\Title\List.cshtml"
, Tuple.Create(Tuple.Create("", 3120), Tuple.Create<System.Object, System.Int32>(Url.Content("~/Content/images/loading.gif")
            
            #line default
            #line hidden
, 3120), false)
);

WriteLiteral(" alt=\"loading...\"");

WriteLiteral("/>\r\n        </div>\r\n    </div>\r\n</div>\r\n");

DefineSection("Menu", () => {

WriteLiteral("\r\n");

            
            #line 65 "..\..\Views\Title\List.cshtml"
    
            
            #line default
            #line hidden
            
            #line 65 "..\..\Views\Title\List.cshtml"
      Html.RenderPartial(MVC.Shared.Views._PublicSettingSideBarMenu);
            
            #line default
            #line hidden
WriteLiteral("\r\n");

});

DefineSection("Scripts", () => {

WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 68 "..\..\Views\Title\List.cshtml"
Write(Scripts.Render("~/bundles/jqueryval"));

            
            #line default
            #line hidden
WriteLiteral("\r\n    <script>\r\n        $(function () {\r\n            $(document).on(\"change\", \"#T" +
"ype\", function () {\r\n                $.get(\'");

            
            #line 72 "..\..\Views\Title\List.cshtml"
                  Write(Url.Action(MVC.Title.IsEnableCategory()));

            
            #line default
            #line hidden
WriteLiteral(@"', { type: $(this).val() }, function (data, status, xhr) {

                    var result = xhr.responseText;
                    if (result == ""ok"") {
                        $('#titleCategory').show();
                    } else {
                        $('#titleCategory').hide();
                    }
                });
            });
        });
    </script>
");

});

        }
    }
}
#pragma warning restore 1591