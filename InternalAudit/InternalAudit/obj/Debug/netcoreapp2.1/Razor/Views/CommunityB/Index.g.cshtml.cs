#pragma checksum "D:\Minku's Internal Audit Project\InternalAuditMinku\InternalAuditMinku\InternalAudit\InternalAudit\Views\CommunityB\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e82800afcc9f9e66e977cf4dafb5b31b67fd566d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CommunityB_Index), @"mvc.1.0.view", @"/Views/CommunityB/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/CommunityB/Index.cshtml", typeof(AspNetCore.Views_CommunityB_Index))]
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
#line 2 "D:\Minku's Internal Audit Project\InternalAuditMinku\InternalAuditMinku\InternalAudit\InternalAudit\Views\CommunityB\Index.cshtml"
using InternalAudit.Common;

#line default
#line hidden
#line 3 "D:\Minku's Internal Audit Project\InternalAuditMinku\InternalAuditMinku\InternalAudit\InternalAudit\Views\CommunityB\Index.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e82800afcc9f9e66e977cf4dafb5b31b67fd566d", @"/Views/CommunityB/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"843a2c94a12d37d6f224245557ffb217a35f7bcc", @"/Views/_ViewImports.cshtml")]
    public class Views_CommunityB_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<InternalAudit.Models.CommunityFormB>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/dataTables.jqueryui.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/jquery.dataTables.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "CommunityB", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Edit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Delete"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/dataTables.jqueryui.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 4 "D:\Minku's Internal Audit Project\InternalAuditMinku\InternalAuditMinku\InternalAudit\InternalAudit\Views\CommunityB\Index.cshtml"
   int rowNo = 0; 

#line default
#line hidden
#line 5 "D:\Minku's Internal Audit Project\InternalAuditMinku\InternalAuditMinku\InternalAudit\InternalAudit\Views\CommunityB\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/Internal.cshtml";

#line default
#line hidden
            BeginContext(222, 100, true);
            WriteLiteral("\r\n\r\n\r\n<link rel=\"stylesheet\" href=\"https://code.jquery.com/ui/1.12.1/themes/base/jquery-ui.css\" />\r\n");
            EndContext();
            BeginContext(394, 66, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f0744581eee246ac8e015644d4d11e7b", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(460, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(462, 64, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c4957bbb45c14060bee9f34807473428", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(526, 428, true);
            WriteLiteral(@"
<div class=""content"">
    <div class=""container-fluid"">
        <div class=""row"">
            <div class=""col-md-12"">
                <div class=""card"">
                    <div class=""card-header card-header-primary"">
                        <h4 class=""card-title"">Communial FORM-B </h4>
                        <p class=""card-category"">Community wise Officers / Staffs Name details as on</p>
                        ");
            EndContext();
            BeginContext(955, 129, false);
#line 24 "D:\Minku's Internal Audit Project\InternalAuditMinku\InternalAuditMinku\InternalAudit\InternalAudit\Views\CommunityB\Index.cshtml"
                   Write(Html.ActionLink("ADD", "Create", "CommunityB", null, new { @class = "btn btn-default pull-right", style = "margin-top: -49px;" }));

#line default
#line hidden
            EndContext();
            BeginContext(1084, 1064, true);
            WriteLiteral(@"
                    </div>
                    <div class=""card-body"">
                        <div class=""table-responsive"">
                            <table id=""mytable"" width=""100%"" class=""a display table table-bordered  text-center"">
                                <thead class=""thead-light"">
                                    <tr>

                                        <th>Sr.No</th>
                                        <th>District Office</th>
                                        <th>Officer Personnels Name(Thiru/Tmt/Selvi))</th>
                                        <th>Post Name</th>
                                        <th>Grade</th>
                                        <th>Joining Date</th>
                                        <th>Gender</th>
                                        <th>Religion</th>
                                        <th>Category</th>
                                        <th>Operation</th>
                                    </tr>
  ");
            WriteLiteral("                              </thead>\r\n");
            EndContext();
#line 44 "D:\Minku's Internal Audit Project\InternalAuditMinku\InternalAuditMinku\InternalAudit\InternalAudit\Views\CommunityB\Index.cshtml"
                                 foreach (var item in @Model)
                                {

#line default
#line hidden
            BeginContext(2246, 132, true);
            WriteLiteral("                                    <tr>\r\n                                        <th>\r\n                                            ");
            EndContext();
            BeginContext(2380, 10, false);
#line 48 "D:\Minku's Internal Audit Project\InternalAuditMinku\InternalAuditMinku\InternalAudit\InternalAudit\Views\CommunityB\Index.cshtml"
                                        Write(rowNo += 1);

#line default
#line hidden
            EndContext();
            BeginContext(2391, 93, true);
            WriteLiteral("\r\n                                        </th>\r\n                                        <td>");
            EndContext();
            BeginContext(2485, 19, false);
#line 50 "D:\Minku's Internal Audit Project\InternalAuditMinku\InternalAuditMinku\InternalAudit\InternalAudit\Views\CommunityB\Index.cshtml"
                                       Write(item.DistrictOffice);

#line default
#line hidden
            EndContext();
            BeginContext(2504, 51, true);
            WriteLiteral("</td>\r\n                                        <td>");
            EndContext();
            BeginContext(2556, 26, false);
#line 51 "D:\Minku's Internal Audit Project\InternalAuditMinku\InternalAuditMinku\InternalAudit\InternalAudit\Views\CommunityB\Index.cshtml"
                                       Write(item.OfficerPersonnelsName);

#line default
#line hidden
            EndContext();
            BeginContext(2582, 51, true);
            WriteLiteral("</td>\r\n                                        <td>");
            EndContext();
            BeginContext(2634, 13, false);
#line 52 "D:\Minku's Internal Audit Project\InternalAuditMinku\InternalAuditMinku\InternalAudit\InternalAudit\Views\CommunityB\Index.cshtml"
                                       Write(item.PostName);

#line default
#line hidden
            EndContext();
            BeginContext(2647, 51, true);
            WriteLiteral("</td>\r\n                                        <td>");
            EndContext();
            BeginContext(2699, 10, false);
#line 53 "D:\Minku's Internal Audit Project\InternalAuditMinku\InternalAuditMinku\InternalAudit\InternalAudit\Views\CommunityB\Index.cshtml"
                                       Write(item.Grade);

#line default
#line hidden
            EndContext();
            BeginContext(2709, 51, true);
            WriteLiteral("</td>\r\n                                        <td>");
            EndContext();
            BeginContext(2761, 60, false);
#line 54 "D:\Minku's Internal Audit Project\InternalAuditMinku\InternalAuditMinku\InternalAudit\InternalAudit\Views\CommunityB\Index.cshtml"
                                       Write(Convert.ToDateTime(item.JoiningDate).ToString("dd-MMM-yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(2821, 51, true);
            WriteLiteral("</td>\r\n                                        <td>");
            EndContext();
            BeginContext(2873, 11, false);
#line 55 "D:\Minku's Internal Audit Project\InternalAuditMinku\InternalAuditMinku\InternalAudit\InternalAudit\Views\CommunityB\Index.cshtml"
                                       Write(item.Gender);

#line default
#line hidden
            EndContext();
            BeginContext(2884, 51, true);
            WriteLiteral("</td>\r\n                                        <td>");
            EndContext();
            BeginContext(2936, 13, false);
#line 56 "D:\Minku's Internal Audit Project\InternalAuditMinku\InternalAuditMinku\InternalAudit\InternalAudit\Views\CommunityB\Index.cshtml"
                                       Write(item.Religion);

#line default
#line hidden
            EndContext();
            BeginContext(2949, 51, true);
            WriteLiteral("</td>\r\n                                        <td>");
            EndContext();
            BeginContext(3001, 13, false);
#line 57 "D:\Minku's Internal Audit Project\InternalAuditMinku\InternalAuditMinku\InternalAudit\InternalAudit\Views\CommunityB\Index.cshtml"
                                       Write(item.Category);

#line default
#line hidden
            EndContext();
            BeginContext(3014, 97, true);
            WriteLiteral("</td>\r\n                                        <td>\r\n                                            ");
            EndContext();
            BeginContext(3111, 142, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "de08b4792cfc4958a328ab6f54821fbf", async() => {
                BeginContext(3214, 35, true);
                WriteLiteral("<i class=\"material-icons\">build</i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 59 "D:\Minku's Internal Audit Project\InternalAuditMinku\InternalAuditMinku\InternalAudit\InternalAudit\Views\CommunityB\Index.cshtml"
                                                                                               WriteLiteral(item.CommunityFormBrecNo);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3253, 46, true);
            WriteLiteral("\r\n                                            ");
            EndContext();
            BeginContext(3299, 147, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b198ca0697b84f73977a9ca60b851d4d", async() => {
                BeginContext(3406, 36, true);
                WriteLiteral("<i class=\"material-icons\">delete</i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 60 "D:\Minku's Internal Audit Project\InternalAuditMinku\InternalAuditMinku\InternalAudit\InternalAudit\Views\CommunityB\Index.cshtml"
                                                                                                 WriteLiteral(item.CommunityFormBrecNo);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3446, 185, true);
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                        </td>\r\n                                    </tr>\r\n");
            EndContext();
#line 65 "D:\Minku's Internal Audit Project\InternalAuditMinku\InternalAuditMinku\InternalAudit\InternalAudit\Views\CommunityB\Index.cshtml"
                                }

#line default
#line hidden
            BeginContext(3666, 222, true);
            WriteLiteral("                                </tbody>\r\n                            </table>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
#line 76 "D:\Minku's Internal Audit Project\InternalAuditMinku\InternalAuditMinku\InternalAudit\InternalAudit\Views\CommunityB\Index.cshtml"
 if (ViewData["Msg"] != null)
{
    InternalAudit.DTO.MessageDTO msg = ViewData["Msg"] as InternalAudit.DTO.MessageDTO;
    

#line default
#line hidden
            BeginContext(4016, 62, false);
#line 79 "D:\Minku's Internal Audit Project\InternalAuditMinku\InternalAuditMinku\InternalAudit\InternalAudit\Views\CommunityB\Index.cshtml"
Write(await Html.PartialAsync("~/Views/Shared/_ShowMsg.cshtml", msg));

#line default
#line hidden
            EndContext();
#line 79 "D:\Minku's Internal Audit Project\InternalAuditMinku\InternalAuditMinku\InternalAudit\InternalAudit\Views\CommunityB\Index.cshtml"
                                                                   ;
}

#line default
#line hidden
            BeginContext(4084, 42, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3b89b68c912b4720bbc46af22fed2879", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4126, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(4189, 51, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e7326360bace486c925cb379c1f302f8", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4240, 99, true);
            WriteLiteral("\r\n<script>\r\n    $(document).ready(function () {\r\n        $(\'.a\').DataTable();\r\n\r\n    });\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<InternalAudit.Models.CommunityFormB>> Html { get; private set; }
    }
}
#pragma warning restore 1591
