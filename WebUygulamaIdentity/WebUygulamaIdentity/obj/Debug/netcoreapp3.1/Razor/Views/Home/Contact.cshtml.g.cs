#pragma checksum "C:\Users\rabii\OneDrive\Masaüstü\WebProgramlama\WebProgramlama\WebUygulamaIdentity\WebUygulamaIdentity\Views\Home\Contact.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "203e2b7021100591a57ff1ca3df941ea49c6507f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Contact), @"mvc.1.0.view", @"/Views/Home/Contact.cshtml")]
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
#line 1 "C:\Users\rabii\OneDrive\Masaüstü\WebProgramlama\WebProgramlama\WebUygulamaIdentity\WebUygulamaIdentity\Views\_ViewImports.cshtml"
using WebUygulamaIdentity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\rabii\OneDrive\Masaüstü\WebProgramlama\WebProgramlama\WebUygulamaIdentity\WebUygulamaIdentity\Views\_ViewImports.cshtml"
using WebUygulamaIdentity.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"203e2b7021100591a57ff1ca3df941ea49c6507f", @"/Views/Home/Contact.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c0a7fe860fe7f0bb15817ee945e0ffd8be97d3d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Contact : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("contact-form "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("contact.php "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
            WriteLiteral(@"

    <!-- =====================================
        ==== Start Contact -->

    <section id=""contact "" data-scroll-index=""6"" class=""page-contact section-padding"" style=""background-image: url(img/pattern.png)"">
        <div class=""container"">
            <div class=""section-head text-center"">
                <h5>Contact Us</h5>
                <h3>KEEP IN TOUCH</h3>
            </div>

            <div class=""cont"">
                <div class=""row no-gutters"">
                    <div class=""col-lg-4 "">
                        <div class=""l-side"">
                            <div class=""item"">
                                <span class=""icon col-2 col-sm-2 ""><i class=""fas fa-map-marker-alt ""></i></span>
                                <div class=""content col-10 col-sm-10 "">
                                    <h3>Our Location</h3>
                                    <p>2659 King Autostrad Street, Toronto, ON L6H 6X5 Canada</p>
                                </div>
                 ");
            WriteLiteral(@"           </div>

                            <div class=""item"">
                                <span class=""icon col-2 col-sm-2 ""><i class=""fas fa-mobile-alt ""></i></span>
                                <div class=""content col-10 col-sm-10 "">
                                    <h3>Let's Talk</h3>
                                    <p>Phone : +12 3 1462 2249, 2248</p>
                                    <p>Fax : +12 9 1462 2238, 2248</p>
                                </div>
                            </div>

                            <div class=""item"">
                                <span class=""icon col-2 col-sm-2 ""><i class=""far fa-envelope ""></i></span>
                                <div class=""content col-10 col-sm-10 "">
                                    <h3>E-mail Us</h3>
                                    <p>Support : info@company.com</p>
                                    <p>Sales : info@example.com</p>
                                </div>
                          ");
            WriteLiteral(@"  </div>
                            <div class=""social-icons text-center"">
                                <a href=""#0""><i class=""fab fa-facebook-f""></i></a>
                                <a href=""#0""><i class=""fab fa-twitter""></i></a>
                                <a href=""#0""><i class=""fab fa-linkedin-in""></i></a>
                                <a href=""#0""><i class=""fab fa-instagram""></i></a>
                            </div>
                        </div>
                    </div>
                    <div class=""col-lg-8 "">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "203e2b7021100591a57ff1ca3df941ea49c6507f7548", async() => {
                WriteLiteral(@"

                            <div class=""messages ""></div>

                            <div class=""controls "">

                                <div class=""row "">
                                    <div class=""col-md-6 "">
                                        <div class=""form-group "">
                                            <i class=""far fa-user ""></i>
                                            <input id=""form_name "" type=""text"" name=""name "" placeholder=""your Name... "" required=""required"" data-error=""Firstname is required. "">
                                            <div class=""help-block with-errors ""></div>
                                        </div>
                                    </div>
                                    <div class=""col-md-6 "">
                                        <div class=""form-group "">
                                            <i class=""fas fa-mobile-alt ""></i>
                                            <input id=""form_email "" type=""text"" na");
                WriteLiteral(@"me=""phone "" placeholder=""Cell phone... "" required=""required"" data-error=""Valid email is required. "">
                                            <div class=""help-block with-errors ""></div>
                                        </div>
                                    </div>
                                    <div class=""col-md-6 "">
                                        <div class=""form-group "">
                                            <i class=""far fa-envelope ""></i>
                                            <input id=""form_subject "" type=""email"" name=""email "" placeholder=""Email Adress... "">
                                        </div>
                                    </div>
                                    <div class=""col-md-6 "">
                                        <div class=""form-group "">
                                            <i class=""far fa-comment-dots ""></i>
                                            <input id=""form_subject "" type=""text"" name=""subject "" place");
                WriteLiteral(@"holder=""Subject... "">
                                        </div>
                                    </div>
                                    <div class=""col-md-12 "">
                                        <div class=""form-group "">
                                            <i class=""far fa-comment ""></i>
                                            <textarea id=""form_message "" name=""message "" placeholder=""Your Message "" rows=""4 "" required=""required"" data-error=""Your message is required. ""></textarea>
                                            <div class=""help-block with-errors ""></div>
                                        </div>
                                    </div>

                                    <div class=""col-md-12 "">
                                        <button type=""submit"" class=""butn butn-bord""><span>Send Message</span></button>
                                    </div>

                                </div>
                            </div>
               ");
                WriteLiteral("         ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </section>\r\n\r\n    <!-- End Contact ====\r\n        ======================================= -->");
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
