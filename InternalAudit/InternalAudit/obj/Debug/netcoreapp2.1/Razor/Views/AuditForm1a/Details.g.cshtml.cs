#pragma checksum "D:\Minku's Internal Audit Project\InternalAuditMinku\InternalAuditMinku\InternalAudit\InternalAudit\Views\AuditForm1a\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6c59e3f1d45f016ce2618990e6f84b4a56cf0636"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AuditForm1a_Details), @"mvc.1.0.view", @"/Views/AuditForm1a/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/AuditForm1a/Details.cshtml", typeof(AspNetCore.Views_AuditForm1a_Details))]
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
#line 1 "D:\Minku's Internal Audit Project\InternalAuditMinku\InternalAuditMinku\InternalAudit\InternalAudit\Views\_ViewImports.cshtml"
using InternalAudit;

#line default
#line hidden
#line 2 "D:\Minku's Internal Audit Project\InternalAuditMinku\InternalAuditMinku\InternalAudit\InternalAudit\Views\_ViewImports.cshtml"
using InternalAudit.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c59e3f1d45f016ce2618990e6f84b4a56cf0636", @"/Views/AuditForm1a/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"843a2c94a12d37d6f224245557ffb217a35f7bcc", @"/Views/_ViewImports.cshtml")]
    public class Views_AuditForm1a_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<InternalAudit.Models.AuditPdlForm1a>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(44, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Minku's Internal Audit Project\InternalAuditMinku\InternalAuditMinku\InternalAudit\InternalAudit\Views\AuditForm1a\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/Internal.cshtml";

#line default
#line hidden
            BeginContext(137, 128, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>AuditPdlForm1a</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(266, 49, false);
#line 15 "D:\Minku's Internal Audit Project\InternalAuditMinku\InternalAuditMinku\InternalAudit\InternalAudit\Views\AuditForm1a\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FinancialYear));

#line default
#line hidden
            EndContext();
            BeginContext(315, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(359, 45, false);
#line 18 "D:\Minku's Internal Audit Project\InternalAuditMinku\InternalAuditMinku\InternalAudit\InternalAudit\Views\AuditForm1a\Details.cshtml"
       Write(Html.DisplayFor(model => model.FinancialYear));

#line default
#line hidden
            EndContext();
            BeginContext(404, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(448, 44, false);
#line 21 "D:\Minku's Internal Audit Project\InternalAuditMinku\InternalAuditMinku\InternalAudit\InternalAudit\Views\AuditForm1a\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.District));

#line default
#line hidden
            EndContext();
            BeginContext(492, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(536, 40, false);
#line 24 "D:\Minku's Internal Audit Project\InternalAuditMinku\InternalAuditMinku\InternalAudit\InternalAudit\Views\AuditForm1a\Details.cshtml"
       Write(Html.DisplayFor(model => model.District));

#line default
#line hidden
            EndContext();
            BeginContext(576, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(620, 48, false);
#line 27 "D:\Minku's Internal Audit Project\InternalAuditMinku\InternalAuditMinku\InternalAudit\InternalAudit\Views\AuditForm1a\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Institutions));

#line default
#line hidden
            EndContext();
            BeginContext(668, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(712, 44, false);
#line 30 "D:\Minku's Internal Audit Project\InternalAuditMinku\InternalAuditMinku\InternalAudit\InternalAudit\Views\AuditForm1a\Details.cshtml"
       Write(Html.DisplayFor(model => model.Institutions));

#line default
#line hidden
            EndContext();
            BeginContext(756, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(800, 52, false);
#line 33 "D:\Minku's Internal Audit Project\InternalAuditMinku\InternalAuditMinku\InternalAudit\InternalAudit\Views\AuditForm1a\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.NoOfInstitutions));

#line default
#line hidden
            EndContext();
            BeginContext(852, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(896, 48, false);
#line 36 "D:\Minku's Internal Audit Project\InternalAuditMinku\InternalAuditMinku\InternalAudit\InternalAudit\Views\AuditForm1a\Details.cshtml"
       Write(Html.DisplayFor(model => model.NoOfInstitutions));

#line default
#line hidden
            EndContext();
            BeginContext(944, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(988, 56, false);
#line 39 "D:\Minku's Internal Audit Project\InternalAuditMinku\InternalAuditMinku\InternalAudit\InternalAudit\Views\AuditForm1a\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.InstPendingPrevMonth));

#line default
#line hidden
            EndContext();
            BeginContext(1044, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1088, 52, false);
#line 42 "D:\Minku's Internal Audit Project\InternalAuditMinku\InternalAuditMinku\InternalAudit\InternalAudit\Views\AuditForm1a\Details.cshtml"
       Write(Html.DisplayFor(model => model.InstPendingPrevMonth));

#line default
#line hidden
            EndContext();
            BeginContext(1140, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1184, 58, false);
#line 45 "D:\Minku's Internal Audit Project\InternalAuditMinku\InternalAuditMinku\InternalAudit\InternalAudit\Views\AuditForm1a\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.InstCompletedThisMonth));

#line default
#line hidden
            EndContext();
            BeginContext(1242, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1286, 54, false);
#line 48 "D:\Minku's Internal Audit Project\InternalAuditMinku\InternalAuditMinku\InternalAudit\InternalAudit\Views\AuditForm1a\Details.cshtml"
       Write(Html.DisplayFor(model => model.InstCompletedThisMonth));

#line default
#line hidden
            EndContext();
            BeginContext(1340, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1384, 55, false);
#line 51 "D:\Minku's Internal Audit Project\InternalAuditMinku\InternalAuditMinku\InternalAudit\InternalAudit\Views\AuditForm1a\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.InstPendingEndMonth));

#line default
#line hidden
            EndContext();
            BeginContext(1439, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1483, 51, false);
#line 54 "D:\Minku's Internal Audit Project\InternalAuditMinku\InternalAuditMinku\InternalAudit\InternalAudit\Views\AuditForm1a\Details.cshtml"
       Write(Html.DisplayFor(model => model.InstPendingEndMonth));

#line default
#line hidden
            EndContext();
            BeginContext(1534, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1581, 71, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "67b07f58e5cb4c2a9210b24ba38915eb", async() => {
                BeginContext(1644, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 59 "D:\Minku's Internal Audit Project\InternalAuditMinku\InternalAuditMinku\InternalAudit\InternalAudit\Views\AuditForm1a\Details.cshtml"
                           WriteLiteral(Model.AuditPdlForm1ArecNo);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1652, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1660, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f0af0a326c6b473ea7b6119c278a02d4", async() => {
                BeginContext(1682, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1698, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<InternalAudit.Models.AuditPdlForm1a> Html { get; private set; }
    }
}
#pragma warning restore 1591
