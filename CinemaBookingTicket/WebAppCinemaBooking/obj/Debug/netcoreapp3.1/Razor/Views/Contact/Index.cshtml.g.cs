#pragma checksum "C:\Users\VK Be\Desktop\Cinema\CinemaBookingTicket\CinemaBookingTicket\WebAppCinemaBooking\Views\Contact\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c816dd639aef0bd1affc252ceeb1f731fd425fee"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contact_Index), @"mvc.1.0.view", @"/Views/Contact/Index.cshtml")]
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
#line 2 "C:\Users\VK Be\Desktop\Cinema\CinemaBookingTicket\CinemaBookingTicket\WebAppCinemaBooking\Views\_ViewImports.cshtml"
using WebAppCinemaBooking;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\VK Be\Desktop\Cinema\CinemaBookingTicket\CinemaBookingTicket\WebAppCinemaBooking\Views\_ViewImports.cshtml"
using WebAppCinemaBooking.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c816dd639aef0bd1affc252ceeb1f731fd425fee", @"/Views/Contact/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5bbbb203f2bff78945c9ccb00f3bc85aac0ce020", @"/Views/_ViewImports.cshtml")]
    public class Views_Contact_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("https://sendmail.w3layouts.com/submitForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("formhny-sec"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"<div class=""w3l-breadcrumbs"">
    <nav id=""breadcrumbs"" class=""breadcrumbs"">
        <div class=""container page-wrapper"">
            <a href=""index.html"">Home</a> » <span class=""breadcrumb_last"" aria-current=""page"">Contact</span>
        </div>
    </nav>
</div>

<section class=""w3l-contact-1"">
    <div class=""contacts-9 py-5"">
        <div class=""container py-lg-4"">
            <div class=""headerhny-title text-center"">
                <h4 class=""sub-title text-center"">Contact us</h4>
                <h3 class=""hny-title mb-0"">Leave a Message</h3>
                <p class=""hny-title mb-lg-5 mb-4"">If you have a question regarding our services, feel free to contact us using the form below.</p>
            </div>
            <div class=""contact-view mt-lg-5 mt-4"">
                <div class=""conhny-form-section"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c816dd639aef0bd1affc252ceeb1f731fd425fee5282", async() => {
                WriteLiteral("\r\n                        <div class=\"form-grids\">\r\n                            <div class=\"form-input\">\r\n                                <input type=\"text\" name=\"w3lName\" id=\"w3lName\" placeholder=\"Enter your name *\"");
                BeginWriteAttribute("required", " required=\"", 1168, "\"", 1179, 0);
                EndWriteAttribute();
                WriteLiteral(@" />
                            </div>
                            <div class=""form-input"">
                                <input type=""text"" name=""w3lSubject"" id=""w3lSubject"" placeholder=""Enter subject "" required />
                            </div>
                            <div class=""form-input"">
                                <input type=""email"" name=""w3lSender"" id=""w3lSender"" placeholder=""Enter your email *""
                                       required />
                            </div>
                            <div class=""form-input"">
                                <input type=""text"" name=""w3lPhone"" id=""w3lPhone"" placeholder=""Enter your Phone Number *""
                                       required />
                            </div>
                        </div>
                        <div class=""form-input mt-4"">
                            <textarea name=""w3lMessage"" id=""w3lMessage"" placeholder=""Type your query here""");
                BeginWriteAttribute("required", "\r\n                                      required=\"", 2155, "\"", 2205, 0);
                EndWriteAttribute();
                WriteLiteral("></textarea>\r\n                        </div>\r\n                        <div class=\"submithny text-right mt-4\">\r\n                            <button class=\"btn read-button\">Submit Message</button>\r\n                        </div>\r\n                    ");
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
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </div>

                <div class=""d-grid contact-addres-inf mt-5 pt-lg-4"">
                    <div class=""contact-info-left d-grid"">
                        <div class=""contact-info"">
                            <div class=""icon"">
                                <span class=""fa fa-location-arrow"" aria-hidden=""true""></span>
                            </div>
                            <div class=""contact-details"">
                                <h4>Address:</h4>
                                <p>Lorem dolor sit, New York, USA</p>
                            </div>
                        </div>
                        <div class=""contact-info"">
                            <div class=""icon"">
                                <span class=""fa fa-phone"" aria-hidden=""true""></span>
                            </div>
                            <div class=""contact-details"">
                                <h4>Phone:</h4>
                                <p><a href=""tel:+598-658");
            WriteLiteral(@"-456"">+598-658-346</a></p>
                                <p><a href=""tel:+598-658-457"">+598-658-436</a></p>
                            </div>
                        </div>
                        <div class=""contact-info"">
                            <div class=""icon"">
                                <span class=""fa fa-envelope-open-o"" aria-hidden=""true""></span>
                            </div>
                            <div class=""contact-details"">
                                <h4>Mail:</h4>
                                <p><a href=""mailto:mail@example.com"" class=""email"">info@proshowz.com</a></p>
                                <p><a href=""mailto:mail@example.com"" class=""email"">proshowz@support.com</a></p>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""contact-map"">
        <iframe src=""https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d387193.3");
            WriteLiteral("05935303!2d-74.25986548248684!3d40.69714941932609!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x89c24fa5d33f083b%3A0xc80b8f06e177fe62!2sNew+York%2C+NY%2C+USA!5e0!3m2!1sen!2sin!4v1563262564932!5m2!1sen!2sin\" style=\"border:0\"");
            BeginWriteAttribute("allowfullscreen", " allowfullscreen=\"", 4738, "\"", 4756, 0);
            EndWriteAttribute();
            WriteLiteral("></iframe>\r\n    </div>\r\n</section>");
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
