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
    using Decision.Common.MVC;
    using Decision.Utility;
    using Decision.Web.HtmlHelpers;
    using MvcSiteMapProvider.Web.Html;
    using MvcSiteMapProvider.Web.Html.Models;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Interview/_ListAjax.cshtml")]
    public partial class _Views_Interview__ListAjax_cshtml : System.Web.Mvc.WebViewPage<Decision.ViewModel.Interview.InterviewListViewModel>
    {
        public _Views_Interview__ListAjax_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Views\Interview\_ListAjax.cshtml"
 foreach (var interview in Model.Interviews)
{
    
            
            #line default
            #line hidden
            
            #line 4 "..\..\Views\Interview\_ListAjax.cshtml"
Write(Html.Partial(MVC.Interview.Views._InterviewItem, interview));

            
            #line default
            #line hidden
            
            #line 4 "..\..\Views\Interview\_ListAjax.cshtml"
                                                                
}
            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591