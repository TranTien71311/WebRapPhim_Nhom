#pragma checksum "D:\HK5\LTWASP\DoAn\CinemaBookingTicket\CinemaBookingTicket\WebAppCinemaBooking\Areas\Admin\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c91e0d8824ef0d1455f36e060da796763cd97009"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Shared__Layout), @"mvc.1.0.view", @"/Areas/Admin/Views/Shared/_Layout.cshtml")]
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
#line 2 "D:\HK5\LTWASP\DoAn\CinemaBookingTicket\CinemaBookingTicket\WebAppCinemaBooking\Areas\Admin\Views\_ViewImports.cshtml"
using WebAppCinemaBooking;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\HK5\LTWASP\DoAn\CinemaBookingTicket\CinemaBookingTicket\WebAppCinemaBooking\Areas\Admin\Views\_ViewImports.cshtml"
using WebAppCinemaBooking.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c91e0d8824ef0d1455f36e060da796763cd97009", @"/Areas/Admin/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5bbbb203f2bff78945c9ccb00f3bc85aac0ce020", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c91e0d8824ef0d1455f36e060da796763cd970093459", async() => {
                WriteLiteral("\r\n    ");
#nullable restore
#line 5 "D:\HK5\LTWASP\DoAn\CinemaBookingTicket\CinemaBookingTicket\WebAppCinemaBooking\Areas\Admin\Views\Shared\_Layout.cshtml"
Write(await Html.PartialAsync("_HeadPartial.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c91e0d8824ef0d1455f36e060da796763cd970094723", async() => {
                WriteLiteral(@"
    <div class=""preloader"">
        <div class=""lds-ripple"">
            <div class=""lds-pos""></div>
            <div class=""lds-pos""></div>
        </div>
    </div>
    <div id=""main-wrapper"" data-layout=""vertical"" data-navbarbg=""skin6"" data-sidebartype=""full"" data-sidebar position=""absolute"" data-header-position=""absolute"" data-boxed-layout=""full"">
        ");
#nullable restore
#line 15 "D:\HK5\LTWASP\DoAn\CinemaBookingTicket\CinemaBookingTicket\WebAppCinemaBooking\Areas\Admin\Views\Shared\_Layout.cshtml"
   Write(await Html.PartialAsync("_HeaderPartial.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        ");
#nullable restore
#line 16 "D:\HK5\LTWASP\DoAn\CinemaBookingTicket\CinemaBookingTicket\WebAppCinemaBooking\Areas\Admin\Views\Shared\_Layout.cshtml"
   Write(await Html.PartialAsync("_SideBarPartial.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        <div class=\"page-wrapper\">\r\n            <div class=\"container-fluid\">\r\n                <div class=\"card\">\r\n                    <div class=\"container-fluid\">\r\n                        ");
#nullable restore
#line 21 "D:\HK5\LTWASP\DoAn\CinemaBookingTicket\CinemaBookingTicket\WebAppCinemaBooking\Areas\Admin\Views\Shared\_Layout.cshtml"
                   Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n            ");
#nullable restore
#line 25 "D:\HK5\LTWASP\DoAn\CinemaBookingTicket\CinemaBookingTicket\WebAppCinemaBooking\Areas\Admin\Views\Shared\_Layout.cshtml"
       Write(await Html.PartialAsync("_FooterPartial.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </div>\r\n    </div>\r\n    ");
#nullable restore
#line 28 "D:\HK5\LTWASP\DoAn\CinemaBookingTicket\CinemaBookingTicket\WebAppCinemaBooking\Areas\Admin\Views\Shared\_Layout.cshtml"
Write(await Html.PartialAsync("_ScriptPartial.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 30 "D:\HK5\LTWASP\DoAn\CinemaBookingTicket\CinemaBookingTicket\WebAppCinemaBooking\Areas\Admin\Views\Shared\_Layout.cshtml"
Write(RenderSection("Scripts", required: false));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</html>\r\n");
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
