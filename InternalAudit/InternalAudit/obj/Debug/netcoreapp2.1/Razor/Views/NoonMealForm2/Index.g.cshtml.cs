#pragma checksum "D:\Minku's Internal Audit Project\InternalAuditMinku\InternalAuditMinku\InternalAudit\InternalAudit\Views\NoonMealForm2\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e02d5727b948b3a52c958f14bead092d65436894"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_NoonMealForm2_Index), @"mvc.1.0.view", @"/Views/NoonMealForm2/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/NoonMealForm2/Index.cshtml", typeof(AspNetCore.Views_NoonMealForm2_Index))]
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
#line 2 "D:\Minku's Internal Audit Project\InternalAuditMinku\InternalAuditMinku\InternalAudit\InternalAudit\Views\NoonMealForm2\Index.cshtml"
using InternalAudit.Common;

#line default
#line hidden
#line 3 "D:\Minku's Internal Audit Project\InternalAuditMinku\InternalAuditMinku\InternalAudit\InternalAudit\Views\NoonMealForm2\Index.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e02d5727b948b3a52c958f14bead092d65436894", @"/Views/NoonMealForm2/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"843a2c94a12d37d6f224245557ffb217a35f7bcc", @"/Views/_ViewImports.cshtml")]
    public class Views_NoonMealForm2_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<InternalAudit.Models.NoonMealPdlForm2>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/dataTables.jqueryui.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/jquery.dataTables.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "NoonMealForm2", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Edit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "D:\Minku's Internal Audit Project\InternalAuditMinku\InternalAuditMinku\InternalAudit\InternalAudit\Views\NoonMealForm2\Index.cshtml"
   int rowNo = 0; 

#line default
#line hidden
#line 5 "D:\Minku's Internal Audit Project\InternalAuditMinku\InternalAuditMinku\InternalAudit\InternalAudit\Views\NoonMealForm2\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/Internal.cshtml";

#line default
#line hidden
            BeginContext(224, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 10 "D:\Minku's Internal Audit Project\InternalAuditMinku\InternalAuditMinku\InternalAudit\InternalAudit\Views\NoonMealForm2\Index.cshtml"
 if (ViewData["Msg"] != null)
{
    InternalAudit.DTO.MessageDTO msg = ViewData["Msg"] as InternalAudit.DTO.MessageDTO;
    

#line default
#line hidden
            BeginContext(354, 62, false);
#line 13 "D:\Minku's Internal Audit Project\InternalAuditMinku\InternalAuditMinku\InternalAudit\InternalAudit\Views\NoonMealForm2\Index.cshtml"
Write(await Html.PartialAsync("~/Views/Shared/_ShowMsg.cshtml", msg));

#line default
#line hidden
            EndContext();
#line 13 "D:\Minku's Internal Audit Project\InternalAuditMinku\InternalAuditMinku\InternalAudit\InternalAudit\Views\NoonMealForm2\Index.cshtml"
                                                                   ;
}

#line default
#line hidden
            BeginContext(422, 96, true);
            WriteLiteral("\r\n<link rel=\"stylesheet\" href=\"https://code.jquery.com/ui/1.12.1/themes/base/jquery-ui.css\" />\r\n");
            EndContext();
            BeginContext(590, 66, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e4e30be8e9254ba18843e30e4c709b3e", async() => {
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
            BeginContext(656, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(658, 64, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ec6afcf9714245ee83c5d6c2fe04318e", async() => {
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
            BeginContext(722, 454, true);
            WriteLiteral(@"
<div class=""content"">
    <div class=""container-fluid"">
        <div class=""row"">
            <div class=""col-md-12"">
                <div class=""card"">
                    <div class=""card-header card-header-primary"">
                        <h4 class=""card-title"">Noon Meal Pdl Form 2</h4>
                        <p class=""card-category"">Status of Audit in respect of Corporation School Centers ……….(Month/Year) </p>
                        ");
            EndContext();
            BeginContext(1177, 132, false);
#line 28 "D:\Minku's Internal Audit Project\InternalAuditMinku\InternalAuditMinku\InternalAudit\InternalAudit\Views\NoonMealForm2\Index.cshtml"
                   Write(Html.ActionLink("ADD", "Create", "NoonMealForm2", null, new { @class = "btn btn-default pull-right", style = "margin-top: -49px;" }));

#line default
#line hidden
            EndContext();
            BeginContext(1309, 985, true);
            WriteLiteral(@"
                    </div>
                    <div class=""card-body"">
                        <div class=""table-responsive"">
                            <table id=""mytable"" width=""100%"" class=""a display table table-bordered  text-center"">
                                <thead class=""thead-light"">
                                    <tr>

                                        <th>Sr.No</th>
                                        <th>InstitutionsName</th>
                                        <th>TotalCenter</th>
                                        <th>Completed</th>
                                        <th>Pending</th>
                                        <th>FinancialYear</th>
                                        <th>PeriodCategory</th>
                                        <th>Period</th>
                                        <th>Operation</th>
                                    </tr>
                                </thead>
");
            EndContext();
#line 47 "D:\Minku's Internal Audit Project\InternalAuditMinku\InternalAuditMinku\InternalAudit\InternalAudit\Views\NoonMealForm2\Index.cshtml"
                                 foreach (var item in @Model)
                                {

#line default
#line hidden
            BeginContext(2392, 132, true);
            WriteLiteral("                                    <tr>\r\n                                        <th>\r\n                                            ");
            EndContext();
            BeginContext(2526, 10, false);
#line 51 "D:\Minku's Internal Audit Project\InternalAuditMinku\InternalAuditMinku\InternalAudit\InternalAudit\Views\NoonMealForm2\Index.cshtml"
                                        Write(rowNo += 1);

#line default
#line hidden
            EndContext();
            BeginContext(2537, 93, true);
            WriteLiteral("\r\n                                        </th>\r\n                                        <td>");
            EndContext();
            BeginContext(2631, 20, false);
#line 53 "D:\Minku's Internal Audit Project\InternalAuditMinku\InternalAuditMinku\InternalAudit\InternalAudit\Views\NoonMealForm2\Index.cshtml"
                                       Write(item.InstitutionName);

#line default
#line hidden
            EndContext();
            BeginContext(2651, 51, true);
            WriteLiteral("</td>\r\n                                        <td>");
            EndContext();
            BeginContext(2703, 16, false);
#line 54 "D:\Minku's Internal Audit Project\InternalAuditMinku\InternalAuditMinku\InternalAudit\InternalAudit\Views\NoonMealForm2\Index.cshtml"
                                       Write(item.TotalCenter);

#line default
#line hidden
            EndContext();
            BeginContext(2719, 51, true);
            WriteLiteral("</td>\r\n                                        <td>");
            EndContext();
            BeginContext(2771, 14, false);
#line 55 "D:\Minku's Internal Audit Project\InternalAuditMinku\InternalAuditMinku\InternalAudit\InternalAudit\Views\NoonMealForm2\Index.cshtml"
                                       Write(item.Completed);

#line default
#line hidden
            EndContext();
            BeginContext(2785, 51, true);
            WriteLiteral("</td>\r\n                                        <td>");
            EndContext();
            BeginContext(2837, 12, false);
#line 56 "D:\Minku's Internal Audit Project\InternalAuditMinku\InternalAuditMinku\InternalAudit\InternalAudit\Views\NoonMealForm2\Index.cshtml"
                                       Write(item.Pending);

#line default
#line hidden
            EndContext();
            BeginContext(2849, 51, true);
            WriteLiteral("</td>\r\n                                        <td>");
            EndContext();
            BeginContext(2901, 22, false);
#line 57 "D:\Minku's Internal Audit Project\InternalAuditMinku\InternalAuditMinku\InternalAudit\InternalAudit\Views\NoonMealForm2\Index.cshtml"
                                       Write(item.FinancialYearName);

#line default
#line hidden
            EndContext();
            BeginContext(2923, 51, true);
            WriteLiteral("</td>\r\n                                        <td>");
            EndContext();
            BeginContext(2975, 23, false);
#line 58 "D:\Minku's Internal Audit Project\InternalAuditMinku\InternalAuditMinku\InternalAudit\InternalAudit\Views\NoonMealForm2\Index.cshtml"
                                       Write(item.PeriodCategoryName);

#line default
#line hidden
            EndContext();
            BeginContext(2998, 51, true);
            WriteLiteral("</td>\r\n                                        <td>");
            EndContext();
            BeginContext(3050, 15, false);
#line 59 "D:\Minku's Internal Audit Project\InternalAuditMinku\InternalAuditMinku\InternalAudit\InternalAudit\Views\NoonMealForm2\Index.cshtml"
                                       Write(item.PeriodName);

#line default
#line hidden
            EndContext();
            BeginContext(3065, 101, true);
            WriteLiteral("</td>\r\n                                        <td>\r\n                                                ");
            EndContext();
            BeginContext(3166, 139, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9df6707bb3674456a8cbfec20fdbfeef", async() => {
                BeginContext(3266, 35, true);
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
#line 61 "D:\Minku's Internal Audit Project\InternalAuditMinku\InternalAuditMinku\InternalAudit\InternalAudit\Views\NoonMealForm2\Index.cshtml"
                                                                                                      WriteLiteral(item.NoonMealRecNo);

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
            BeginContext(3305, 50, true);
            WriteLiteral("\r\n                                                ");
            EndContext();
            BeginContext(3355, 144, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d2eb41f51abe45f4a3e55fd53d59d3bd", async() => {
                BeginContext(3459, 36, true);
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
#line 62 "D:\Minku's Internal Audit Project\InternalAuditMinku\InternalAuditMinku\InternalAudit\InternalAudit\Views\NoonMealForm2\Index.cshtml"
                                                                                                        WriteLiteral(item.NoonMealRecNo);

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
            BeginContext(3499, 190, true);
            WriteLiteral("\r\n                                            </td>\r\n                                         <td>\r\n                                        </td>\r\n                                    </tr>\r\n");
            EndContext();
#line 67 "D:\Minku's Internal Audit Project\InternalAuditMinku\InternalAuditMinku\InternalAudit\InternalAudit\Views\NoonMealForm2\Index.cshtml"
                                }

#line default
#line hidden
            BeginContext(3724, 220, true);
            WriteLiteral("                                </tbody>\r\n                            </table>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
            EndContext();
            BeginContext(3944, 42, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0609414027b8402988b8493e40ece11a", async() => {
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
            BeginContext(3986, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(4049, 51, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "64f1ab8c8fa84053951877b6a54d0ddc", async() => {
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
            BeginContext(4100, 119, true);
            WriteLiteral("\r\n<script>\r\n    $(document).ready(function () {\r\n        $(\'.a\').DataTable();\r\n\r\n    });\r\n</script>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<InternalAudit.Models.NoonMealPdlForm2>> Html { get; private set; }
    }
}
#pragma warning restore 1591
