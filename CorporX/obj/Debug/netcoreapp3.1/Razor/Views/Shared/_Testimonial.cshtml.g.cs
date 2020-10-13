#pragma checksum "C:\Users\n_ilkin\Desktop\my Code\Asp.Net_Core_project\CorporX\Views\Shared\_Testimonial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "688e172c03282c31eb53e10ea200fe7b9e69b376"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Testimonial), @"mvc.1.0.view", @"/Views/Shared/_Testimonial.cshtml")]
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
#line 1 "C:\Users\n_ilkin\Desktop\my Code\Asp.Net_Core_project\CorporX\Views\_ViewImports.cshtml"
using CorporX;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\n_ilkin\Desktop\my Code\Asp.Net_Core_project\CorporX\Views\_ViewImports.cshtml"
using CorporX.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\n_ilkin\Desktop\my Code\Asp.Net_Core_project\CorporX\Views\_ViewImports.cshtml"
using CorporX.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\n_ilkin\Desktop\my Code\Asp.Net_Core_project\CorporX\Views\_ViewImports.cshtml"
using CorporX.Data.Models.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\n_ilkin\Desktop\my Code\Asp.Net_Core_project\CorporX\Views\_ViewImports.cshtml"
using ReflectionIT.Mvc.Paging;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"688e172c03282c31eb53e10ea200fe7b9e69b376", @"/Views/Shared/_Testimonial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"87dc0700a9fdc35c3637b59456fdd67cc70ae19b", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Testimonial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Client>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("client"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("50"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid rounded-circle shadow-sm mr-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"<section class=""testimonial-section ptb-100"">
    <div class=""container"">
        <div class=""row justify-content-center"">
            <div class=""col-md-9 col-lg-8"">
                <div class=""section-heading mb-5 text-center"">
                    <h2>Testimonials What Clients Say</h2>
                    <p class=""lead"">
                        Rapidiously morph transparent internal or ""organic"" sources whereas resource sucking
                        e-business. Conveniently innovate compelling internal.
                    </p>
                </div>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-md-12 col-lg-12"">
                <div class=""owl-carousel owl-theme client-testimonial custom-arrow custom-arrow-bottom-center mb-5"">
");
#nullable restore
#line 18 "C:\Users\n_ilkin\Desktop\my Code\Asp.Net_Core_project\CorporX\Views\Shared\_Testimonial.cshtml"
                     foreach (var clt in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"item\">\r\n                            <div class=\"testimonial-single shadow-sm gray-light-bg rounded p-4\">\r\n                                <blockquote>\r\n                                    ");
#nullable restore
#line 23 "C:\Users\n_ilkin\Desktop\my Code\Asp.Net_Core_project\CorporX\Views\Shared\_Testimonial.cshtml"
                               Write(clt.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </blockquote>
                                <div class=""client-img d-flex align-items-center justify-content-between pt-4"">
                                    <div class=""d-flex align-items-center"">
                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "688e172c03282c31eb53e10ea200fe7b9e69b3766694", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1419, "~/Assets/img/", 1419, 13, true);
#nullable restore
#line 27 "C:\Users\n_ilkin\Desktop\my Code\Asp.Net_Core_project\CorporX\Views\Shared\_Testimonial.cshtml"
AddHtmlAttributeValue("", 1432, clt.Photo, 1432, 10, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        <div class=\"client-info\">\r\n                                            <h5 class=\"mb-0\">");
#nullable restore
#line 29 "C:\Users\n_ilkin\Desktop\my Code\Asp.Net_Core_project\CorporX\Views\Shared\_Testimonial.cshtml"
                                                        Write(clt.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                            <small class=\"mb-0\">");
#nullable restore
#line 30 "C:\Users\n_ilkin\Desktop\my Code\Asp.Net_Core_project\CorporX\Views\Shared\_Testimonial.cshtml"
                                                           Write(clt.Position);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n                                        </div>\r\n                                    </div>\r\n                                    <div class=\"client-ratting\">\r\n                                        <ul class=\"list-inline client-ratting-list\">\r\n");
#nullable restore
#line 35 "C:\Users\n_ilkin\Desktop\my Code\Asp.Net_Core_project\CorporX\Views\Shared\_Testimonial.cshtml"
                                             for (int i = 0; i < @clt.Star; i++)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <li class=\"list-inline-item\"><span class=\"fas fa-star ratting-color\"></span></li>\r\n");
#nullable restore
#line 38 "C:\Users\n_ilkin\Desktop\my Code\Asp.Net_Core_project\CorporX\Views\Shared\_Testimonial.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                        </ul>
                                        <span class=""font-weight-bold"">5.0 <small class=""font-weight-lighter"">Out of 5</small></span>
                                    </div>
                                </div>
                            </div>
                        </div>
");
#nullable restore
#line 45 "C:\Users\n_ilkin\Desktop\my Code\Asp.Net_Core_project\CorporX\Views\Shared\_Testimonial.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Client>> Html { get; private set; }
    }
}
#pragma warning restore 1591
