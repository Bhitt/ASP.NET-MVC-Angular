#pragma checksum "C:\Users\bhitt\Desktop\ASP.NET-MVC-Angular\Example ASP.NET app\DutchTreat\Views\BinAttributeClearance\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "db8985a40f511919f6b26d9feba812544a72e6e6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BinAttributeClearance_Index), @"mvc.1.0.view", @"/Views/BinAttributeClearance/Index.cshtml")]
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
#nullable restore
#line 1 "C:\Users\bhitt\Desktop\ASP.NET-MVC-Angular\Example ASP.NET app\DutchTreat\Views\_ViewImports.cshtml"
using DutchTreat.Controllers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\bhitt\Desktop\ASP.NET-MVC-Angular\Example ASP.NET app\DutchTreat\Views\_ViewImports.cshtml"
using DutchTreat.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\bhitt\Desktop\ASP.NET-MVC-Angular\Example ASP.NET app\DutchTreat\Views\_ViewImports.cshtml"
using DutchTreat.Data.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db8985a40f511919f6b26d9feba812544a72e6e6", @"/Views/BinAttributeClearance/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"402ff29ed5304f90d7247425045b59e26db665d3", @"/Views/_ViewImports.cshtml")]
    public class Views_BinAttributeClearance_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("13"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/content/images/enter.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/ViewScripts/CommanScript.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/ViewScripts/ReprintScript.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\bhitt\Desktop\ASP.NET-MVC-Angular\Example ASP.NET app\DutchTreat\Views\BinAttributeClearance\Index.cshtml"
   
    ViewBag.Title = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-xs-12 col-md-12 col-lg-12"">
        <div class=""panel panel-default"" style=""padding:0px;"">
            <h4 class=""MainTitle"" id=""title"">REPRINT</h4>
            <div class=""panel-body form-horizontal validateform"" style=""padding:0px;"">
                <div class=""col-xs-12 col-md-12 col-lg-12"">
                    <div");
            BeginWriteAttribute("class", " class=\"", 451, "\"", 459, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        <div class=""row"">
                            <div class=""panel-body form-horizontal"">
                                <div class=""row"">
                                    <div class=""col-sm-4"">
                                        <div class=""form-group"">
                                            ");
#nullable restore
#line 18 "C:\Users\bhitt\Desktop\ASP.NET-MVC-Angular\Example ASP.NET app\DutchTreat\Views\BinAttributeClearance\Index.cshtml"
                                       Write(Html.LabelFor(x => x.BENCH_ID, new { @class = "col-sm-4 control-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            <div class=\"col-sm-8\">\r\n                                                <div class=\"input-group\">\r\n                                                    ");
#nullable restore
#line 21 "C:\Users\bhitt\Desktop\ASP.NET-MVC-Angular\Example ASP.NET app\DutchTreat\Views\BinAttributeClearance\Index.cshtml"
                                               Write(Html.TextBoxFor(x => x.BENCH_ID, new
                                               {
                                                   @class = "form-control transform",
                                                   placeholder = "BENCH_ID"
                                               }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                    <span class=\"input-group-addon\">\r\n                                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "db8985a40f511919f6b26d9feba812544a72e6e67693", async() => {
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
            WriteLiteral(@"
                                                    </span>
                                                </div>
                                            </div>
                                        </div>
                                        <div class=""form-group"">
                                            ");
#nullable restore
#line 33 "C:\Users\bhitt\Desktop\ASP.NET-MVC-Angular\Example ASP.NET app\DutchTreat\Views\BinAttributeClearance\Index.cshtml"
                                       Write(Html.LabelFor(s => s.LABEL_TYPE, new { @class = "col-sm-4 control-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            <div class=\"col-sm-8\">\r\n                                                ");
#nullable restore
#line 35 "C:\Users\bhitt\Desktop\ASP.NET-MVC-Angular\Example ASP.NET app\DutchTreat\Views\BinAttributeClearance\Index.cshtml"
                                           Write(Html.DropDownListFor(s => s.LABEL_TYPE, Model.LabelListType, new { @class = "form-control disabled", @readonly = true }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                            </div>
                                        </div>
                                        <div id=""divitemtype"">
                                            <div class=""form-group"">
                                                ");
#nullable restore
#line 40 "C:\Users\bhitt\Desktop\ASP.NET-MVC-Angular\Example ASP.NET app\DutchTreat\Views\BinAttributeClearance\Index.cshtml"
                                           Write(Html.LabelFor(s => s.ITEM_TYPE, new { @class = "col-sm-4 control-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                <div class=\"col-sm-8\">\r\n                                                    ");
#nullable restore
#line 42 "C:\Users\bhitt\Desktop\ASP.NET-MVC-Angular\Example ASP.NET app\DutchTreat\Views\BinAttributeClearance\Index.cshtml"
                                               Write(Html.DropDownListFor(s => s.ITEM_TYPE, Model.InvItemTypeList, "--SELECT--", new { @class = "form-control disabled", @readonly = true }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                                </div>
                                            </div>
                                        </div>
                                        <div class=""form-group"">
                                            ");
#nullable restore
#line 47 "C:\Users\bhitt\Desktop\ASP.NET-MVC-Angular\Example ASP.NET app\DutchTreat\Views\BinAttributeClearance\Index.cshtml"
                                       Write(Html.LabelFor(x => x.LABEL_VALUE, new { @class = "col-sm-4 control-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            <div class=\"col-sm-8\">\r\n                                                <div class=\"input-group\">\r\n                                                    ");
#nullable restore
#line 50 "C:\Users\bhitt\Desktop\ASP.NET-MVC-Angular\Example ASP.NET app\DutchTreat\Views\BinAttributeClearance\Index.cshtml"
                                               Write(Html.TextBoxFor(x => x.LABEL_VALUE, null, new
                                                   {
                                                       @class = "form-control",
                                                   }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                    <span class=\"input-group-addon\">\r\n                                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "db8985a40f511919f6b26d9feba812544a72e6e612703", async() => {
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
            WriteLiteral(@"
                                                    </span>
                                                </div>
                                            </div>
                                        </div>
                                        <div class=""form-group"">
                                            <label class=""col-xs-5 col-sm-4 control-label""");
            BeginWriteAttribute("for", " for=\"", 4174, "\"", 4180, 0);
            EndWriteAttribute();
            WriteLiteral(@"></label>
                                            <div class=""col-xs-7 col-sm-8"">
                                                <div class=""input-group"" style=""display: block;"">
                                                    <button class=""btn btn-primary btn-md pull-right ResetButtonFontSize"" type=""button"" onclick=""FnReset();"">Reset</button>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

");
            DefineSection("script", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "db8985a40f511919f6b26d9feba812544a72e6e615220", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "db8985a40f511919f6b26d9feba812544a72e6e616407", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591