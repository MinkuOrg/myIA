#pragma checksum "D:\Minku's Internal Audit Project\InternalAuditMinku\InternalAuditMinku\InternalAudit\InternalAudit\Views\Institutions\InstitutionsDelete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "af0f0ac68b5d7a00c36422a5fe5fc213dc4db991"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Institutions_InstitutionsDelete), @"mvc.1.0.view", @"/Views/Institutions/InstitutionsDelete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Institutions/InstitutionsDelete.cshtml", typeof(AspNetCore.Views_Institutions_InstitutionsDelete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af0f0ac68b5d7a00c36422a5fe5fc213dc4db991", @"/Views/Institutions/InstitutionsDelete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"843a2c94a12d37d6f224245557ffb217a35f7bcc", @"/Views/_ViewImports.cshtml")]
    public class Views_Institutions_InstitutionsDelete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<InternalAudit.Models.TblMasterInstitutions>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(51, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Minku's Internal Audit Project\InternalAuditMinku\InternalAuditMinku\InternalAudit\InternalAudit\Views\Institutions\InstitutionsDelete.cshtml"
  
    ViewData["Title"] = "InstitutionsDelete";
    Layout = "~/Views/Shared/Internal.cshtml";

#line default
#line hidden
            BeginContext(155, 521, true);
            WriteLiteral(@"<div class=""content"">
    <div class=""container-fluid"">
        <div class=""row"">
            <div class=""col-md-12"">
                <div class=""card"">
                    <div class=""card-header card-header-primary"">
                        <div class=""row"">
                            <div class=""col-md-5"">
                                <h4 class=""card-title"">Institutions Master</h4>
                            </div>
                            <div class=""col-md-7"">
                                ");
            EndContext();
            BeginContext(677, 115, false);
#line 18 "D:\Minku's Internal Audit Project\InternalAuditMinku\InternalAuditMinku\InternalAudit\InternalAudit\Views\Institutions\InstitutionsDelete.cshtml"
                           Write(Html.ActionLink("Back", "InstitutionsDetails", "Institutions", null, new { @class = "btn btn-default pull-right" }));

#line default
#line hidden
            EndContext();
            BeginContext(792, 126, true);
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n                    </div><br />\r\n\r\n                    ");
            EndContext();
            BeginContext(918, 729, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "45eb4d7008d44381bcc1473561191e4f", async() => {
                BeginContext(958, 167, true);
                WriteLiteral("\r\n                        <div class=\"form-group\">\r\n                            <h6 class=\"p-4\">Are you sure you want to delete this</h6>\r\n                            ");
                EndContext();
                BeginContext(1125, 51, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c0cb57ae394d43d18ba1bd0142f3fbcb", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 26 "D:\Minku's Internal Audit Project\InternalAuditMinku\InternalAuditMinku\InternalAudit\InternalAudit\Views\Institutions\InstitutionsDelete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.InstitutionsRecNo);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1176, 464, true);
                WriteLiteral(@"
                        </div>
                        <div class=""card-footer text-center"">
                            <div class=""row col-12"" style=""justify-content:center;"">
                                <div class=""col-1"">
                                    <input type=""submit"" value=""Delete"" class=""btn btn-primary"" />
                                </div>
                            </div>
                        </div>
                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1647, 82, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
            EndContext();
#line 41 "D:\Minku's Internal Audit Project\InternalAuditMinku\InternalAuditMinku\InternalAudit\InternalAudit\Views\Institutions\InstitutionsDelete.cshtml"
 if (ViewData["Msg"] != null)
{
    InternalAudit.DTO.MessageDTO msg = ViewData["Msg"] as InternalAudit.DTO.MessageDTO;
    

#line default
#line hidden
            BeginContext(1857, 62, false);
#line 44 "D:\Minku's Internal Audit Project\InternalAuditMinku\InternalAuditMinku\InternalAudit\InternalAudit\Views\Institutions\InstitutionsDelete.cshtml"
Write(await Html.PartialAsync("~/Views/Shared/_ShowMsg.cshtml", msg));

#line default
#line hidden
            EndContext();
#line 44 "D:\Minku's Internal Audit Project\InternalAuditMinku\InternalAuditMinku\InternalAudit\InternalAudit\Views\Institutions\InstitutionsDelete.cshtml"
                                                                   ;
}
















#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<InternalAudit.Models.TblMasterInstitutions> Html { get; private set; }
    }
}
#pragma warning restore 1591
