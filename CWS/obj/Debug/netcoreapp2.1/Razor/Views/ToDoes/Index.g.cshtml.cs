#pragma checksum "C:\Users\ziedb\source\repos\CWS\CWS\Views\ToDoes\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "33326adb5709746eaa51c5da6fed70aa3dbc4a48"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ToDoes_Index), @"mvc.1.0.view", @"/Views/ToDoes/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ToDoes/Index.cshtml", typeof(AspNetCore.Views_ToDoes_Index))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\ziedb\source\repos\CWS\CWS\Views\_ViewImports.cshtml"
using CWS;

#line default
#line hidden
#line 2 "C:\Users\ziedb\source\repos\CWS\CWS\Views\_ViewImports.cshtml"
using CWS.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"33326adb5709746eaa51c5da6fed70aa3dbc4a48", @"/Views/ToDoes/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"42dbd92aaaf17c9437177d8d152bb8bb171c41f7", @"/Views/_ViewImports.cshtml")]
    public class Views_ToDoes_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CWS.Models.ToDo>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("zmdi zmdi-plus"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(37, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\ziedb\source\repos\CWS\CWS\Views\ToDoes\Index.cshtml"
  
    ViewData["Title"] = "To Do";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(127, 496, true);
            WriteLiteral(@"
<div class=""row"" style=""margin-left: 20px;"">
    <div class=""col-lg-12"">
        <div class=""au-card au-card--no-shadow au-card--no-pad m-b-40"">
            <div class=""au-card-title"" style=""background-image:url('images/bg-title-01.jpg');"">
                <div class=""bg-overlay bg-overlay--blue""></div>
                <h3>
                    <i class=""zmdi zmdi-format-list-bulleted""></i>To Do
                </h3>
                <button class=""au-btn-plus"">
                    ");
            EndContext();
            BeginContext(623, 50, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cac24db1d08a4988a5414938b8328fa2", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(673, 282, true);
            WriteLiteral(@"
                </button>
            </div>
            <div class=""au-task js-list-load"">
                <div class=""au-task__title"">
                    <p>Tasks xxxxxxxxxxxxxxxxxxxxxx</p>
                </div>
                <div class=""au-task-list js-scrollbar3"">
");
            EndContext();
#line 25 "C:\Users\ziedb\source\repos\CWS\CWS\Views\ToDoes\Index.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
            BeginContext(1028, 225, true);
            WriteLiteral("                        <div class=\"au-task__item au-task__item--danger\">\r\n                            <div class=\"au-task__item-inner\">\r\n                                <h5 class=\"task\">\r\n                                    ");
            EndContext();
            BeginContext(1254, 46, false);
#line 30 "C:\Users\ziedb\source\repos\CWS\CWS\Views\ToDoes\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.TasKContent));

#line default
#line hidden
            EndContext();
            BeginContext(1300, 216, true);
            WriteLiteral("\r\n                                </h5>\r\n                                <span class=\"time\">Html.DisplayFor(modelItem => item.TaskDateTime)</span>\r\n                            </div>\r\n                        </div>\r\n");
            EndContext();
#line 35 "C:\Users\ziedb\source\repos\CWS\CWS\Views\ToDoes\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(1539, 238, true);
            WriteLiteral("                </div>\r\n                <div class=\"au-task__footer\">\r\n                    <button class=\"au-btn au-btn-load js-load-btn\">load more</button>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CWS.Models.ToDo>> Html { get; private set; }
    }
}
#pragma warning restore 1591