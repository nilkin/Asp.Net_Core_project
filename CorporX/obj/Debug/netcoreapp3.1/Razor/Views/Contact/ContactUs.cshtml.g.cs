#pragma checksum "C:\Users\n_ilkin\source\repos\CorporX\Views\Contact\ContactUs.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3b518e460e3ea87fb098c63713503c8f91c38247"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contact_ContactUs), @"mvc.1.0.view", @"/Views/Contact/ContactUs.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3b518e460e3ea87fb098c63713503c8f91c38247", @"/Views/Contact/ContactUs.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b98fae0065ae1d09f21ea58ac0c6917e022e9cc4", @"/Views/_ViewImports.cshtml")]
    public class Views_Contact_ContactUs : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ContactViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_Header", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ReContact", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\n_ilkin\source\repos\CorporX\Views\Contact\ContactUs.cshtml"
  
    ViewData["Title"] = "ContactUs";
    Layout = "~/Views/Shared/_LayoutSecond.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!--body content wrap start-->\r\n<div class=\"main\">\r\n\r\n    <!--header section start-->\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3b518e460e3ea87fb098c63713503c8f91c382474345", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 11 "C:\Users\n_ilkin\source\repos\CorporX\Views\Contact\ContactUs.cshtml"
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
    <!--contact us promo start-->
    <section class=""contact-us-promo pt-100"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-3 col-md-6 col-sm-6"">
                    <div class=""card single-promo-card single-promo-hover text-center shadow-sm"">
                        <div class=""card-body py-5"">
                            <div class=""pb-2"">
                                <span class=""ti-mobile icon-sm color-secondary""></span>
                            </div>
                            <div>
                                <h5 class=""mb-0"">Call Us</h5>
                                <p class=""text-muted mb-0"">");
#nullable restore
#line 25 "C:\Users\n_ilkin\source\repos\CorporX\Views\Contact\ContactUs.cshtml"
                                                      Write(Model.Sett.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""col-lg-3 col-md-6 col-sm-6"">
                    <div class=""card single-promo-card single-promo-hover text-center shadow-sm"">
                        <div class=""card-body py-5"">
                            <div class=""pb-2"">
                                <span class=""ti-location-pin icon-sm color-secondary""></span>
                            </div>
                            <div>
                                <h5 class=""mb-0"">Visit Us</h5>
                                <p class=""text-muted mb-0"">");
#nullable restore
#line 38 "C:\Users\n_ilkin\source\repos\CorporX\Views\Contact\ContactUs.cshtml"
                                                      Write(Model.Sett.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""col-lg-3 col-md-6 col-sm-6"">
                    <div class=""card single-promo-card single-promo-hover text-center shadow-sm"">
                        <div class=""card-body py-5"">
                            <div class=""pb-2"">
                                <span class=""ti-email icon-sm color-secondary""></span>
                            </div>
                            <div>
                                <h5 class=""mb-0"">Mail Us</h5>
                                <p class=""text-muted mb-0"">");
#nullable restore
#line 51 "C:\Users\n_ilkin\source\repos\CorporX\Views\Contact\ContactUs.cshtml"
                                                      Write(Model.Sett.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""col-lg-3 col-md-6 col-sm-6"">
                    <div class=""card single-promo-card single-promo-hover text-center shadow-sm"">
                        <div class=""card-body py-5"">
                            <div class=""pb-2"">
                                <span class=""ti-headphone-alt icon-sm color-secondary""></span>
                            </div>
                            <div>
                                <h5 class=""mb-0"">Live Chat</h5>
                                <p class=""text-muted mb-0"">Chat with Us 24/7</p>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <!--contact us promo end-->
    <!--contact us section start-->
    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3b518e460e3ea87fb098c63713503c8f91c382479764", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    <!--contact us section end-->
    <!--google map block start-->
    <div class=""google-map"">
        <iframe src=""https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3151.83543450937!2d144.953735315922!3d-37.817323442021234!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x6ad65d4c2b349649%3A0xb6899234e561db11!2sEnvato!5e0!3m2!1sen!2sbd!4v1571030260624!5m2!1sen!2sbd"" height=""450"" style=""border:0;""");
            BeginWriteAttribute("allowfullscreen", " allowfullscreen=\"", 3768, "\"", 3786, 0);
            EndWriteAttribute();
            WriteLiteral("></iframe>\r\n    </div>\r\n    <!--google map block end-->\r\n\r\n\r\n</div>\r\n<!--body content wrap end-->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ContactViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
