#pragma checksum "C:\Users\n_ilkin\source\repos\CorporX\Views\Pages\Fag.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f7ca2d31b479dd49725fc725aa8a6fbb2737a618"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pages_Fag), @"mvc.1.0.view", @"/Views/Pages/Fag.cshtml")]
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
#line 1 "C:\Users\n_ilkin\source\repos\CorporX\Views\_ViewImports.cshtml"
using CorporX;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\n_ilkin\source\repos\CorporX\Views\_ViewImports.cshtml"
using CorporX.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\n_ilkin\source\repos\CorporX\Views\_ViewImports.cshtml"
using CorporX.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\n_ilkin\source\repos\CorporX\Views\_ViewImports.cshtml"
using CorporX.Data.Models.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f7ca2d31b479dd49725fc725aa8a6fbb2737a618", @"/Views/Pages/Fag.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b98fae0065ae1d09f21ea58ac0c6917e022e9cc4", @"/Views/_ViewImports.cshtml")]
    public class Views_Pages_Fag : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FaqViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_Header", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\n_ilkin\source\repos\CorporX\Views\Pages\Fag.cshtml"
  
    ViewData["Title"] = "Fag";
    Layout = "~/Views/Shared/_LayoutSecond.cshtml";
    int count = 1;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!--body content wrap start-->\r\n<div class=\"main\">\r\n\r\n    <!--header section start-->\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f7ca2d31b479dd49725fc725aa8a6fbb2737a6184008", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 12 "C:\Users\n_ilkin\source\repos\CorporX\Views\Pages\Fag.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = Model.Breadcrumb;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    <!--header section end-->
    <!--promo section start-->
    <section class=""promo-section ptb-100"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-8 col-md-9"">
                    <div class=""section-heading mb-5"">
                        <h2>Frequently Asked Questions</h2>
                        <p class=""lead"">
                            Quickly morph client-centric results through performance based applications. Proactively facilitate professional human capital for cutting-edge.
                        </p>
                    </div>
                </div>
            </div>
            <!--pricing faq start-->
            <div class=""row"">
                <div class=""col-lg-6"">
                    <div id=""accordion-1"" class=""accordion accordion-faq"">
");
#nullable restore
#line 31 "C:\Users\n_ilkin\source\repos\CorporX\Views\Pages\Fag.cshtml"
                         foreach (var faq in Model.Fags.Take(3))
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <!-- Accordion card ");
#nullable restore
#line 33 "C:\Users\n_ilkin\source\repos\CorporX\Views\Pages\Fag.cshtml"
                                           Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral(" -->\r\n                            <div class=\"card\">\r\n                                <div class=\"card-header py-4\"");
            BeginWriteAttribute("id", " id=\"", 1383, "\"", 1404, 2);
            WriteAttributeValue("", 1388, "heading-1-", 1388, 10, true);
#nullable restore
#line 35 "C:\Users\n_ilkin\source\repos\CorporX\Views\Pages\Fag.cshtml"
WriteAttributeValue("", 1398, count, 1398, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-toggle=\"collapse\" role=\"button\"\r\n                                     data-target=\"#collapse-1-");
#nullable restore
#line 36 "C:\Users\n_ilkin\source\repos\CorporX\Views\Pages\Fag.cshtml"
                                                         Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" aria-expanded=\"false\"");
            BeginWriteAttribute("aria-controls", " aria-controls=\"", 1535, "\"", 1568, 2);
            WriteAttributeValue("", 1551, "collapse-1-", 1551, 11, true);
#nullable restore
#line 36 "C:\Users\n_ilkin\source\repos\CorporX\Views\Pages\Fag.cshtml"
WriteAttributeValue("", 1562, count, 1562, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    <h6 class=\"mb-0\"><span");
            BeginWriteAttribute("class", " class=\"", 1630, "\"", 1652, 2);
#nullable restore
#line 37 "C:\Users\n_ilkin\source\repos\CorporX\Views\Pages\Fag.cshtml"
WriteAttributeValue("", 1638, faq.Icon, 1638, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 1647, "mr-3", 1648, 5, true);
            EndWriteAttribute();
            WriteLiteral("></span> ");
#nullable restore
#line 37 "C:\Users\n_ilkin\source\repos\CorporX\Views\Pages\Fag.cshtml"
                                                                                     Write(faq.Question);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                                </div>\r\n                                <div");
            BeginWriteAttribute("id", " id=\"", 1758, "\"", 1780, 2);
            WriteAttributeValue("", 1763, "collapse-1-", 1763, 11, true);
#nullable restore
#line 39 "C:\Users\n_ilkin\source\repos\CorporX\Views\Pages\Fag.cshtml"
WriteAttributeValue("", 1774, count, 1774, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"collapse\"");
            BeginWriteAttribute("aria-labelledby", " aria-labelledby=\"", 1798, "\"", 1832, 2);
            WriteAttributeValue("", 1816, "heading-1-", 1816, 10, true);
#nullable restore
#line 39 "C:\Users\n_ilkin\source\repos\CorporX\Views\Pages\Fag.cshtml"
WriteAttributeValue("", 1826, count, 1826, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("\r\n                                     data-parent=\"#accordion-1\">\r\n                                    <div class=\"card-body\">\r\n                                        <p>");
#nullable restore
#line 42 "C:\Users\n_ilkin\source\repos\CorporX\Views\Pages\Fag.cshtml"
                                      Write(faq.Ask);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n");
            WriteLiteral("                            <p class=\"d-none\">");
#nullable restore
#line 47 "C:\Users\n_ilkin\source\repos\CorporX\Views\Pages\Fag.cshtml"
                                          Write(count++);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 48 "C:\Users\n_ilkin\source\repos\CorporX\Views\Pages\Fag.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-lg-6\">\r\n                    <div id=\"accordion-2\" class=\"accordion accordion-faq\">\r\n");
#nullable restore
#line 55 "C:\Users\n_ilkin\source\repos\CorporX\Views\Pages\Fag.cshtml"
                         foreach (var faq in Model.Fags.Skip(3).Take(3))
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <!-- Accordion card ");
#nullable restore
#line 57 "C:\Users\n_ilkin\source\repos\CorporX\Views\Pages\Fag.cshtml"
                                           Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral(" -->\r\n                            <div class=\"card\">\r\n                                <div class=\"card-header py-4\"");
            BeginWriteAttribute("id", " id=\"", 2672, "\"", 2693, 2);
            WriteAttributeValue("", 2677, "heading-2-", 2677, 10, true);
#nullable restore
#line 59 "C:\Users\n_ilkin\source\repos\CorporX\Views\Pages\Fag.cshtml"
WriteAttributeValue("", 2687, count, 2687, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-toggle=\"collapse\" role=\"button\"\r\n                                     data-target=\"#collapse-2-");
#nullable restore
#line 60 "C:\Users\n_ilkin\source\repos\CorporX\Views\Pages\Fag.cshtml"
                                                         Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" aria-expanded=\"false\"");
            BeginWriteAttribute("aria-controls", " aria-controls=\"", 2824, "\"", 2857, 2);
            WriteAttributeValue("", 2840, "collapse-2-", 2840, 11, true);
#nullable restore
#line 60 "C:\Users\n_ilkin\source\repos\CorporX\Views\Pages\Fag.cshtml"
WriteAttributeValue("", 2851, count, 2851, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    <h6 class=\"mb-0\"><span");
            BeginWriteAttribute("class", " class=\"", 2919, "\"", 2941, 2);
#nullable restore
#line 61 "C:\Users\n_ilkin\source\repos\CorporX\Views\Pages\Fag.cshtml"
WriteAttributeValue("", 2927, faq.Icon, 2927, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 2936, "mr-3", 2937, 5, true);
            EndWriteAttribute();
            WriteLiteral("></span> ");
#nullable restore
#line 61 "C:\Users\n_ilkin\source\repos\CorporX\Views\Pages\Fag.cshtml"
                                                                                     Write(faq.Question);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                                </div>\r\n                                <div");
            BeginWriteAttribute("id", " id=\"", 3047, "\"", 3069, 2);
            WriteAttributeValue("", 3052, "collapse-2-", 3052, 11, true);
#nullable restore
#line 63 "C:\Users\n_ilkin\source\repos\CorporX\Views\Pages\Fag.cshtml"
WriteAttributeValue("", 3063, count, 3063, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"collapse\"");
            BeginWriteAttribute("aria-labelledby", " aria-labelledby=\"", 3087, "\"", 3121, 2);
            WriteAttributeValue("", 3105, "heading-2-", 3105, 10, true);
#nullable restore
#line 63 "C:\Users\n_ilkin\source\repos\CorporX\Views\Pages\Fag.cshtml"
WriteAttributeValue("", 3115, count, 3115, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("\r\n                                     data-parent=\"#accordion-1\">\r\n                                    <div class=\"card-body\">\r\n                                        <p>");
#nullable restore
#line 66 "C:\Users\n_ilkin\source\repos\CorporX\Views\Pages\Fag.cshtml"
                                      Write(faq.Ask);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n                            <p class=\"d-none\">");
#nullable restore
#line 70 "C:\Users\n_ilkin\source\repos\CorporX\Views\Pages\Fag.cshtml"
                                          Write(count++);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 71 "C:\Users\n_ilkin\source\repos\CorporX\Views\Pages\Fag.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </div>
                </div>
            </div>
            <!--pricing faq end-->
        </div>
    </section>
    <!--promo section end-->

    <section class=""gray-light-bg ptb-100"">
        <div class=""container"">
            <div class=""row justify-content-center"">
                <div class=""col-md-9 col-lg-8"">
                    <div class=""section-heading mb-3 text-center"">
                        <h2>Frequently Asked Questions</h2>
                        <p class=""lead"">
                            Quickly morph client-centric results through performance based applications. Proactively facilitate professional human capital for cutting-edge.
                        </p>
                    </div>
                </div>
            </div>
            <div class=""row"">
");
#nullable restore
#line 93 "C:\Users\n_ilkin\source\repos\CorporX\Views\Pages\Fag.cshtml"
                 foreach (var faq in Model.Fags.Skip(6))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-md-6\">\r\n                        <div class=\"single-faq mt-4\">\r\n                            <h5>");
#nullable restore
#line 97 "C:\Users\n_ilkin\source\repos\CorporX\Views\Pages\Fag.cshtml"
                           Write(faq.Question);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                            <p>\r\n                               ");
#nullable restore
#line 99 "C:\Users\n_ilkin\source\repos\CorporX\Views\Pages\Fag.cshtml"
                          Write(faq.Ask);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 102 "C:\Users\n_ilkin\source\repos\CorporX\Views\Pages\Fag.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </section>\r\n\r\n\r\n</div>\r\n<!--body content wrap end-->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FaqViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
