#pragma checksum "C:\Users\HamidS\source\repos\DoctorOffice_Project\DoctorOffice_Project\Views\Home\Components\ServicesComponent\services.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c68b0a905a6f47965af36fe9b2b9f3c4d02f38ad"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Components_ServicesComponent_services), @"mvc.1.0.view", @"/Views/Home/Components/ServicesComponent/services.cshtml")]
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
#line 1 "C:\Users\HamidS\source\repos\DoctorOffice_Project\DoctorOffice_Project\Views\_ViewImports.cshtml"
using DoctorOffice_Project;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HamidS\source\repos\DoctorOffice_Project\DoctorOffice_Project\Views\_ViewImports.cshtml"
using DoctorOffice.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\HamidS\source\repos\DoctorOffice_Project\DoctorOffice_Project\Views\_ViewImports.cshtml"
using DoctorOffice.DataLayer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\HamidS\source\repos\DoctorOffice_Project\DoctorOffice_Project\Views\_ViewImports.cshtml"
using DoctorOffice.Domains;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\HamidS\source\repos\DoctorOffice_Project\DoctorOffice_Project\Views\_ViewImports.cshtml"
using DoctorOffice.Enums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\HamidS\source\repos\DoctorOffice_Project\DoctorOffice_Project\Views\_ViewImports.cshtml"
using DoctorOffice.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\HamidS\source\repos\DoctorOffice_Project\DoctorOffice_Project\Views\_ViewImports.cshtml"
using DoctorOffice.ExtensionMethods;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c68b0a905a6f47965af36fe9b2b9f3c4d02f38ad", @"/Views/Home/Components/ServicesComponent/services.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c22f121c9ee0c20df6ad0d8cb7f8d8851cda9d8", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Components_ServicesComponent_services : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Services>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<section class=\"services-section spad\" id=\"clinicServices\">\r\n    <div class=\"container\">\r\n        <div class=\"section-title text-center\">\r\n            <h2>خدمات ما</h2>\r\n        </div>\r\n        <div class=\"row text-right\" dir=\"rtl\">\r\n");
#nullable restore
#line 10 "C:\Users\HamidS\source\repos\DoctorOffice_Project\DoctorOffice_Project\Views\Home\Components\ServicesComponent\services.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-lg-4 col-md-6 service text-right\" dir=\"rtl\">\r\n                    <div class=\"service-content\">\r\n                        <h4>");
#nullable restore
#line 14 "C:\Users\HamidS\source\repos\DoctorOffice_Project\DoctorOffice_Project\Views\Home\Components\ServicesComponent\services.cshtml"
                       Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                        <p>\r\n                            ");
#nullable restore
#line 16 "C:\Users\HamidS\source\repos\DoctorOffice_Project\DoctorOffice_Project\Views\Home\Components\ServicesComponent\services.cshtml"
                       Write(item.fullTextServices);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </p>\r\n                    </div>\r\n                    <div class=\"service-icon text-right\" dir=\"rtl\">\r\n                        <i class=\"flaticon-020-decay\"></i>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 23 "C:\Users\HamidS\source\repos\DoctorOffice_Project\DoctorOffice_Project\Views\Home\Components\ServicesComponent\services.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Services>> Html { get; private set; }
    }
}
#pragma warning restore 1591