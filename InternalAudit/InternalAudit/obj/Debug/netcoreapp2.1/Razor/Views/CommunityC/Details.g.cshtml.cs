#pragma checksum "D:\Minku's Internal Audit Project\InternalAuditMinku\InternalAuditMinku\InternalAudit\InternalAudit\Views\CommunityC\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0f5839de71b2c24ed63ac361b09adf70508d12ef"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CommunityC_Details), @"mvc.1.0.view", @"/Views/CommunityC/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/CommunityC/Details.cshtml", typeof(AspNetCore.Views_CommunityC_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f5839de71b2c24ed63ac361b09adf70508d12ef", @"/Views/CommunityC/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"843a2c94a12d37d6f224245557ffb217a35f7bcc", @"/Views/_ViewImports.cshtml")]
    public class Views_CommunityC_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<InternalAudit.Models.CommunityFormC>
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
#line 3 "D:\Minku's Internal Audit Project\InternalAuditMinku\InternalAuditMinku\InternalAudit\InternalAudit\Views\CommunityC\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/Internal.cshtml";

#line default
#line hidden
            BeginContext(137, 128, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>CommunityFormC</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(266, 50, false);
#line 15 "D:\Minku's Internal Audit Project\InternalAuditMinku\InternalAuditMinku\InternalAudit\InternalAudit\Views\CommunityC\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DistrictOffice));

#line default
#line hidden
            EndContext();
            BeginContext(316, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(360, 46, false);
#line 18 "D:\Minku's Internal Audit Project\InternalAuditMinku\InternalAuditMinku\InternalAudit\InternalAudit\Views\CommunityC\Details.cshtml"
       Write(Html.DisplayFor(model => model.DistrictOffice));

#line default
#line hidden
            EndContext();
            BeginContext(406, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(450, 57, false);
#line 21 "D:\Minku's Internal Audit Project\InternalAuditMinku\InternalAuditMinku\InternalAudit\InternalAudit\Views\CommunityC\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.OfficerPersonnelsName));

#line default
#line hidden
            EndContext();
            BeginContext(507, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(551, 53, false);
#line 24 "D:\Minku's Internal Audit Project\InternalAuditMinku\InternalAuditMinku\InternalAudit\InternalAudit\Views\CommunityC\Details.cshtml"
       Write(Html.DisplayFor(model => model.OfficerPersonnelsName));

#line default
#line hidden
            EndContext();
            BeginContext(604, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(648, 44, false);
#line 27 "D:\Minku's Internal Audit Project\InternalAuditMinku\InternalAuditMinku\InternalAudit\InternalAudit\Views\CommunityC\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PostName));

#line default
#line hidden
            EndContext();
            BeginContext(692, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(736, 40, false);
#line 30 "D:\Minku's Internal Audit Project\InternalAuditMinku\InternalAuditMinku\InternalAudit\InternalAudit\Views\CommunityC\Details.cshtml"
       Write(Html.DisplayFor(model => model.PostName));

#line default
#line hidden
            EndContext();
            BeginContext(776, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(820, 41, false);
#line 33 "D:\Minku's Internal Audit Project\InternalAuditMinku\InternalAuditMinku\InternalAudit\InternalAudit\Views\CommunityC\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Grade));

#line default
#line hidden
            EndContext();
            BeginContext(861, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(905, 37, false);
#line 36 "D:\Minku's Internal Audit Project\InternalAuditMinku\InternalAuditMinku\InternalAudit\InternalAudit\Views\CommunityC\Details.cshtml"
       Write(Html.DisplayFor(model => model.Grade));

#line default
#line hidden
            EndContext();
            BeginContext(942, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(986, 47, false);
#line 39 "D:\Minku's Internal Audit Project\InternalAuditMinku\InternalAuditMinku\InternalAudit\InternalAudit\Views\CommunityC\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.JoiningDate));

#line default
#line hidden
            EndContext();
            BeginContext(1033, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1077, 43, false);
#line 42 "D:\Minku's Internal Audit Project\InternalAuditMinku\InternalAuditMinku\InternalAudit\InternalAudit\Views\CommunityC\Details.cshtml"
       Write(Html.DisplayFor(model => model.JoiningDate));

#line default
#line hidden
            EndContext();
            BeginContext(1120, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1164, 42, false);
#line 45 "D:\Minku's Internal Audit Project\InternalAuditMinku\InternalAuditMinku\InternalAudit\InternalAudit\Views\CommunityC\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Gender));

#line default
#line hidden
            EndContext();
            BeginContext(1206, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1250, 38, false);
#line 48 "D:\Minku's Internal Audit Project\InternalAuditMinku\InternalAuditMinku\InternalAudit\InternalAudit\Views\CommunityC\Details.cshtml"
       Write(Html.DisplayFor(model => model.Gender));

#line default
#line hidden
            EndContext();
            BeginContext(1288, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1332, 44, false);
#line 51 "D:\Minku's Internal Audit Project\InternalAuditMinku\InternalAuditMinku\InternalAudit\InternalAudit\Views\CommunityC\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Religion));

#line default
#line hidden
            EndContext();
            BeginContext(1376, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1420, 40, false);
#line 54 "D:\Minku's Internal Audit Project\InternalAuditMinku\InternalAuditMinku\InternalAudit\InternalAudit\Views\CommunityC\Details.cshtml"
       Write(Html.DisplayFor(model => model.Religion));

#line default
#line hidden
            EndContext();
            BeginContext(1460, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1504, 44, false);
#line 57 "D:\Minku's Internal Audit Project\InternalAuditMinku\InternalAuditMinku\InternalAudit\InternalAudit\Views\CommunityC\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Category));

#line default
#line hidden
            EndContext();
            BeginContext(1548, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1592, 40, false);
#line 60 "D:\Minku's Internal Audit Project\InternalAuditMinku\InternalAuditMinku\InternalAudit\InternalAudit\Views\CommunityC\Details.cshtml"
       Write(Html.DisplayFor(model => model.Category));

#line default
#line hidden
            EndContext();
            BeginContext(1632, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1676, 45, false);
#line 63 "D:\Minku's Internal Audit Project\InternalAuditMinku\InternalAuditMinku\InternalAudit\InternalAudit\Views\CommunityC\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FormRecNo));

#line default
#line hidden
            EndContext();
            BeginContext(1721, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1765, 41, false);
#line 66 "D:\Minku's Internal Audit Project\InternalAuditMinku\InternalAuditMinku\InternalAudit\InternalAudit\Views\CommunityC\Details.cshtml"
       Write(Html.DisplayFor(model => model.FormRecNo));

#line default
#line hidden
            EndContext();
            BeginContext(1806, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1853, 71, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c0b61f09ae7a48b799e84eac028daa70", async() => {
                BeginContext(1916, 4, true);
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
#line 71 "D:\Minku's Internal Audit Project\InternalAuditMinku\InternalAuditMinku\InternalAudit\InternalAudit\Views\CommunityC\Details.cshtml"
                           WriteLiteral(Model.CommunityFormCrecNo);

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
            BeginContext(1924, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1932, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2df59e0e667e4e56bf650e56bcd2bf8f", async() => {
                BeginContext(1954, 12, true);
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
            BeginContext(1970, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<InternalAudit.Models.CommunityFormC> Html { get; private set; }
    }
}
#pragma warning restore 1591