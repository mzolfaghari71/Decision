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
    
    #line 1 "..\..\Views\Title\_Edit.cshtml"
    using Decision.Common.Helpers;
    
    #line default
    #line hidden
    using Decision.Common.MVC;
    using Decision.Utility;
    using Decision.Web.HtmlHelpers;
    using MvcSiteMapProvider.Web.Html;
    using MvcSiteMapProvider.Web.Html.Models;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Title/_Edit.cshtml")]
    public partial class _Views_Title__Edit_cshtml : System.Web.Mvc.WebViewPage<Decision.ViewModel.Title.EditTitleViewModel>
    {
        public _Views_Title__Edit_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("<div");

WriteLiteral(" class=\"col-md-12\"");

WriteAttribute("id", Tuple.Create(" id=\"", 106), Tuple.Create("\"", 126)
, Tuple.Create(Tuple.Create("", 111), Tuple.Create("title-", 111), true)
            
            #line 3 "..\..\Views\Title\_Edit.cshtml"
, Tuple.Create(Tuple.Create("", 117), Tuple.Create<System.Object, System.Int32>(Model.Id
            
            #line default
            #line hidden
, 117), false)
);

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"panel panel-default\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"panel-heading\"");

WriteLiteral(">\r\n            <h3");

WriteLiteral(" class=\"panel-title\"");

WriteLiteral(">\r\n                <i");

WriteLiteral(" class=\"fa fa-edit\"");

WriteLiteral("></i>\r\n               \r\n            </h3>\r\n        </div>\r\n        <div");

WriteLiteral(" class=\"panel-body\"");

WriteLiteral(">\r\n");

            
            #line 12 "..\..\Views\Title\_Edit.cshtml"
            
            
            #line default
            #line hidden
            
            #line 12 "..\..\Views\Title\_Edit.cshtml"
             using (Ajax.BeginForm(MVC.Title.Edit(), new AjaxOptions { HttpMethod = "POST", OnComplete = "editOnComplete(xhr, status, '" + Model.Id + "','#editButton" + Model.Id + "')" }, new { @class = "form-horizontal", id = Model.Id, autocomplete = "off", data_ajax_update = "title-" + Model.Id }))
            {
                
            
            #line default
            #line hidden
            
            #line 14 "..\..\Views\Title\_Edit.cshtml"
           Write(Html.AntiForgeryToken());

            
            #line default
            #line hidden
            
            #line 14 "..\..\Views\Title\_Edit.cshtml"
                                        
                
            
            #line default
            #line hidden
            
            #line 15 "..\..\Views\Title\_Edit.cshtml"
           Write(Html.HiddenFor(model => model.Id));

            
            #line default
            #line hidden
            
            #line 15 "..\..\Views\Title\_Edit.cshtml"
                                                  
                
            
            #line default
            #line hidden
            
            #line 16 "..\..\Views\Title\_Edit.cshtml"
           Write(Html.HiddenFor(model => model.RowVersion));

            
            #line default
            #line hidden
            
            #line 16 "..\..\Views\Title\_Edit.cshtml"
                                                          
                
            
            #line default
            #line hidden
            
            #line 17 "..\..\Views\Title\_Edit.cshtml"
           Write(Html.HiddenFor(model => model.Type));

            
            #line default
            #line hidden
            
            #line 17 "..\..\Views\Title\_Edit.cshtml"
                                                    
                
            
            #line default
            #line hidden
            
            #line 18 "..\..\Views\Title\_Edit.cshtml"
           Write(Html.HiddenFor(model => model.Category));

            
            #line default
            #line hidden
            
            #line 18 "..\..\Views\Title\_Edit.cshtml"
                                                        

            
            #line default
            #line hidden
WriteLiteral("                <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 20 "..\..\Views\Title\_Edit.cshtml"
               Write(Html.LabelFor(model => model.Name, new { @class = "control-label col-md-2" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    <div");

WriteLiteral(" class=\"col-md-8\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 22 "..\..\Views\Title\_Edit.cshtml"
                   Write(Html.NoAutoCompleteTextBoxFor(model => model.Name));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                        ");

            
            #line 23 "..\..\Views\Title\_Edit.cshtml"
                   Write(Html.ValidationMessageFor(model => model.Name, null, new { @class = "text-danger" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </div>\r\n                </div>\r\n");

            
            #line 26 "..\..\Views\Title\_Edit.cshtml"

            }

            
            #line default
            #line hidden
WriteLiteral("        </div>\r\n        <div");

WriteLiteral(" class=\"panel-footer \"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"pull-left\"");

WriteLiteral(">\r\n                <button");

WriteLiteral(" type=\"button\"");

WriteAttribute("id", Tuple.Create(" id=\"", 1528), Tuple.Create("\"", 1573)
            
            #line 31 "..\..\Views\Title\_Edit.cshtml"
, Tuple.Create(Tuple.Create("", 1533), Tuple.Create<System.Object, System.Int32>(string.Format("editButton{0}",Model.Id)
            
            #line default
            #line hidden
, 1533), false)
);

WriteLiteral(" autocomplete=\"off\"");

WriteAttribute("onclick", Tuple.Create(" onclick=\"", 1593), Tuple.Create("\"", 1643)
, Tuple.Create(Tuple.Create("", 1603), Tuple.Create("AjaxForm.CustomSubmit(this,", 1603), true)
, Tuple.Create(Tuple.Create(" ", 1630), Tuple.Create("\'", 1631), true)
            
            #line 31 "..\..\Views\Title\_Edit.cshtml"
                                                             , Tuple.Create(Tuple.Create("", 1632), Tuple.Create<System.Object, System.Int32>(Model.Id
            
            #line default
            #line hidden
, 1632), false)
, Tuple.Create(Tuple.Create("", 1641), Tuple.Create("\')", 1641), true)
);

WriteLiteral(" data-loading-text=\"در حال ارسال اطلاعات\"");

WriteLiteral(" class=\"btn btn-success btn-sm\"");

WriteLiteral(">\r\n                    <i");

WriteLiteral(" class=\"fa fa-check-square-o\"");

WriteLiteral("></i>\r\n                    ذخیره تغییرات\r\n                </button>\r\n            " +
"    <a");

WriteLiteral(" class=\"btn btn-default btn-sm\"");

WriteLiteral(" data-ajax=\"true\"");

WriteLiteral("\r\n                   data-ajax-mode=\"REPLACE-WITH\"");

WriteLiteral(" data-ajax-complete=\"cancelEditOnComplete(xhr, status)\"");

WriteLiteral("\r\n                   data-ajax-update=\"#title-");

            
            #line 37 "..\..\Views\Title\_Edit.cshtml"
                                       Write(Model.Id);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(" data-ajax-method=\"POST\"");

WriteAttribute("href", Tuple.Create("\r\n                   href=\"", 2090), Tuple.Create("\"", 2160)
            
            #line 38 "..\..\Views\Title\_Edit.cshtml"
, Tuple.Create(Tuple.Create("", 2117), Tuple.Create<System.Object, System.Int32>(Url.Action(MVC.Title.CancelEdit(Model.Id))
            
            #line default
            #line hidden
, 2117), false)
);

WriteLiteral(" role=\"button\"");

WriteLiteral(">\r\n                    <i");

WriteLiteral(" class=\"fa fa-arrow-right\"");

WriteLiteral("></i>\r\n                    انصراف\r\n                </a>\r\n            </div>\r\n    " +
"        <div");

WriteLiteral(" class=\"clearfix\"");

WriteLiteral("></div>\r\n        </div>\r\n    </div>\r\n</div>");

        }
    }
}
#pragma warning restore 1591