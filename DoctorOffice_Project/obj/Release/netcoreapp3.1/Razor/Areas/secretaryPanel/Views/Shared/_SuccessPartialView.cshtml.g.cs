#pragma checksum "C:\Users\HamidS\source\repos\DoctorOffice_Project\DoctorOffice_Project\Areas\secretaryPanel\Views\Shared\_SuccessPartialView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c938bcb548da0048976c534f2ece00cbbf946a83"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_secretaryPanel_Views_Shared__SuccessPartialView), @"mvc.1.0.view", @"/Areas/secretaryPanel/Views/Shared/_SuccessPartialView.cshtml")]
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
#line 1 "C:\Users\HamidS\source\repos\DoctorOffice_Project\DoctorOffice_Project\Areas\secretaryPanel\Views\_ViewImports.cshtml"
using DoctorOffice_Project;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HamidS\source\repos\DoctorOffice_Project\DoctorOffice_Project\Areas\secretaryPanel\Views\_ViewImports.cshtml"
using DoctorOffice.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\HamidS\source\repos\DoctorOffice_Project\DoctorOffice_Project\Areas\secretaryPanel\Views\_ViewImports.cshtml"
using DoctorOffice.DataLayer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\HamidS\source\repos\DoctorOffice_Project\DoctorOffice_Project\Areas\secretaryPanel\Views\_ViewImports.cshtml"
using DoctorOffice.Domains;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\HamidS\source\repos\DoctorOffice_Project\DoctorOffice_Project\Areas\secretaryPanel\Views\_ViewImports.cshtml"
using DoctorOffice.Enums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\HamidS\source\repos\DoctorOffice_Project\DoctorOffice_Project\Areas\secretaryPanel\Views\_ViewImports.cshtml"
using DoctorOffice.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\HamidS\source\repos\DoctorOffice_Project\DoctorOffice_Project\Areas\secretaryPanel\Views\_ViewImports.cshtml"
using DoctorOffice.ExtensionMethods;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\HamidS\source\repos\DoctorOffice_Project\DoctorOffice_Project\Areas\secretaryPanel\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c938bcb548da0048976c534f2ece00cbbf946a83", @"/Areas/secretaryPanel/Views/Shared/_SuccessPartialView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f75b17eb66ee8477b8a2b4e04fb51d1706d51b85", @"/Areas/secretaryPanel/Views/_ViewImports.cshtml")]
    public class Areas_secretaryPanel_Views_Shared__SuccessPartialView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""modal"" tabindex=""-1"" role=""dialog"" id=""Modal"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header text-right"" id=""headerModal"" dir=""rtl"">
                <h5 class=""modal-title"" id=""ModalTitle"">Modal title</h5>
");
            WriteLiteral(@"            </div>
            <div class=""modal-body text-right"" id=""ModalBody"">

            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">بستن</button>
            </div>
        </div>
    </div>
</div>");
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
