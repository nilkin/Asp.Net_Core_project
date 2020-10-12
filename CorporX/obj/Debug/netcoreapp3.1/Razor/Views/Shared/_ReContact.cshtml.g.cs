#pragma checksum "C:\Users\n_ilkin\source\repos\CorporX\Views\Shared\_ReContact.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "006497903ce2d3ab7044692abfae234c2bf3dd0d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__ReContact), @"mvc.1.0.view", @"/Views/Shared/_ReContact.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"006497903ce2d3ab7044692abfae234c2bf3dd0d", @"/Views/Shared/_ReContact.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b98fae0065ae1d09f21ea58ac0c6917e022e9cc4", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__ReContact : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("contactForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("contact-us-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<section class=""contact-us-section ptb-100"">
    <div class=""container contact"">
        <div class=""col-12 pb-3 message-box d-none"">
            <div class=""alert alert-danger""></div>
        </div>
        <div class=""row justify-content-around"">
            <div class=""col-md-6"">
                <div class=""contact-us-form gray-light-bg rounded p-5"">
                    <h4>Ready to get started?</h4>
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "006497903ce2d3ab7044692abfae234c2bf3dd0d5331", async() => {
                WriteLiteral(@"
                        <div class=""form-row"">
                            <div class=""col-12"">
                                <div class=""form-group"">
                                    <input type=""text"" class=""form-control"" name=""name"" placeholder=""Enter name"" required=""required"">
                                </div>
                            </div>
                            <div class=""col-12"">
                                <div class=""form-group"">
                                    <input type=""email"" class=""form-control"" name=""email"" placeholder=""Enter email"" required=""required"">
                                </div>
                            </div>
                            <div class=""col-12"">
                                <div class=""form-group"">
                                    <textarea name=""message"" id=""message"" class=""form-control"" rows=""7"" cols=""25"" placeholder=""Message""></textarea>
                                </div>
                            </div>
");
                WriteLiteral(@"                            <div class=""col-sm-12 mt-3"">
                                <button type=""submit"" class=""btn secondary-solid-btn"" id=""btnContactUs"">
                                    Send Message
                                </button>
                            </div>
                        </div>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </div>
            </div>
            <div class=""col-md-5"">
                <div class=""contact-us-content"">
                    <h2>Looking for a excellent Business idea?</h2>
                    <p class=""lead"">Seamlessly deliver pandemic e-services and next-generation initiatives.</p>

                    <a href=""#"" class=""btn outline-btn align-items-center"">Get Directions <span class=""ti-arrow-right pl-2""></span></a>

                    <hr class=""my-5"">

                    <h5>Our Headquarters</h5>
                    <address>
                        ");
#nullable restore
#line 47 "C:\Users\n_ilkin\source\repos\CorporX\Views\Shared\_ReContact.cshtml"
                   Write(Model.Setting.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </address>\r\n                    <br>\r\n                    <span>Phone: ");
#nullable restore
#line 50 "C:\Users\n_ilkin\source\repos\CorporX\Views\Shared\_ReContact.cshtml"
                            Write(Model.Setting.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> <br>\r\n                    <span>Email: <a");
            BeginWriteAttribute("href", " href=\"", 2666, "\"", 2701, 2);
            WriteAttributeValue("", 2673, "mailto:", 2673, 7, true);
#nullable restore
#line 51 "C:\Users\n_ilkin\source\repos\CorporX\Views\Shared\_ReContact.cshtml"
WriteAttributeValue(" ", 2680, Model.Setting.Email, 2681, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"link-color\">");
#nullable restore
#line 51 "C:\Users\n_ilkin\source\repos\CorporX\Views\Shared\_ReContact.cshtml"
                                                                                      Write(Model.Setting.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></span>\r\n\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n");
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
