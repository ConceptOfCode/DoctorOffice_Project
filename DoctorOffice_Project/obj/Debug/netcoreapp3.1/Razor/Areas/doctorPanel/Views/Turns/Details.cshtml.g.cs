#pragma checksum "C:\Users\HamidS\source\repos\DoctorOffice_Project\DoctorOffice_Project\Areas\doctorPanel\Views\Turns\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d5f7a91c714c80a3982212ae3a2701cb27db1329"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_doctorPanel_Views_Turns_Details), @"mvc.1.0.view", @"/Areas/doctorPanel/Views/Turns/Details.cshtml")]
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
#line 1 "C:\Users\HamidS\source\repos\DoctorOffice_Project\DoctorOffice_Project\Areas\doctorPanel\Views\_ViewImports.cshtml"
using DoctorOffice_Project;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HamidS\source\repos\DoctorOffice_Project\DoctorOffice_Project\Areas\doctorPanel\Views\_ViewImports.cshtml"
using DoctorOffice.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\HamidS\source\repos\DoctorOffice_Project\DoctorOffice_Project\Areas\doctorPanel\Views\_ViewImports.cshtml"
using DoctorOffice.DataLayer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\HamidS\source\repos\DoctorOffice_Project\DoctorOffice_Project\Areas\doctorPanel\Views\_ViewImports.cshtml"
using DoctorOffice.Domains;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\HamidS\source\repos\DoctorOffice_Project\DoctorOffice_Project\Areas\doctorPanel\Views\_ViewImports.cshtml"
using DoctorOffice.Enums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\HamidS\source\repos\DoctorOffice_Project\DoctorOffice_Project\Areas\doctorPanel\Views\_ViewImports.cshtml"
using DoctorOffice.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\HamidS\source\repos\DoctorOffice_Project\DoctorOffice_Project\Areas\doctorPanel\Views\_ViewImports.cshtml"
using DoctorOffice.ExtensionMethods;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\HamidS\source\repos\DoctorOffice_Project\DoctorOffice_Project\Areas\doctorPanel\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d5f7a91c714c80a3982212ae3a2701cb27db1329", @"/Areas/doctorPanel/Views/Turns/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f75b17eb66ee8477b8a2b4e04fb51d1706d51b85", @"/Areas/doctorPanel/Views/_ViewImports.cshtml")]
    public class Areas_doctorPanel_Views_Turns_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SecretaryreserveDetails_ViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Turns", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "doctorPanel", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\HamidS\source\repos\DoctorOffice_Project\DoctorOffice_Project\Areas\doctorPanel\Views\Turns\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Areas/doctorPanel/Views/Shared/_doctorLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""jumbotron jumbotron-fluid"">
    <div class=""container text-right"">
        <div class=""alert alert-primary"">
            <h1 class=""display-4 "">جزییات لیست رزرو کننده گان</h1>
        </div>
        <label class=""text-primary"" dir=""rtl"">نام و نام خانوادگی : </label> <label dir=""rtl"">");
#nullable restore
#line 14 "C:\Users\HamidS\source\repos\DoctorOffice_Project\DoctorOffice_Project\Areas\doctorPanel\Views\Turns\Details.cshtml"
                                                                                        Write(Model.fullNamePatient);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label><br>\r\n        <label class=\"text-primary\" dir=\"rtl\">شماره شناسنامه : </label> <label dir=\"rtl\">");
#nullable restore
#line 15 "C:\Users\HamidS\source\repos\DoctorOffice_Project\DoctorOffice_Project\Areas\doctorPanel\Views\Turns\Details.cshtml"
                                                                                    Write(Model.nationalNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label><br>\r\n        <label class=\"text-primary\" dir=\"rtl\">نام پدر : </label> <label dir=\"rtl\">");
#nullable restore
#line 16 "C:\Users\HamidS\source\repos\DoctorOffice_Project\DoctorOffice_Project\Areas\doctorPanel\Views\Turns\Details.cshtml"
                                                                             Write(Model.fatherName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label><br>\r\n        <label class=\"text-primary\" dir=\"rtl\">تاریخ تولد : </label> <label dir=\"rtl\">");
#nullable restore
#line 17 "C:\Users\HamidS\source\repos\DoctorOffice_Project\DoctorOffice_Project\Areas\doctorPanel\Views\Turns\Details.cshtml"
                                                                                Write(Model.birthDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label><br>\r\n        <label class=\"text-primary\" dir=\"rtl\">شماره تلفن : </label> <label dir=\"rtl\">");
#nullable restore
#line 18 "C:\Users\HamidS\source\repos\DoctorOffice_Project\DoctorOffice_Project\Areas\doctorPanel\Views\Turns\Details.cshtml"
                                                                                Write(Model.phoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label><br>\r\n        <label class=\"text-primary\" dir=\"rtl\">پست الکترونیک : </label> <label dir=\"rtl\">");
#nullable restore
#line 19 "C:\Users\HamidS\source\repos\DoctorOffice_Project\DoctorOffice_Project\Areas\doctorPanel\Views\Turns\Details.cshtml"
                                                                                   Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label><br>\r\n        <label class=\"text-primary\" dir=\"rtl\">تاریخ رزرو : </label> <label dir=\"rtl\">");
#nullable restore
#line 20 "C:\Users\HamidS\source\repos\DoctorOffice_Project\DoctorOffice_Project\Areas\doctorPanel\Views\Turns\Details.cshtml"
                                                                                Write(Model.reserveDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label><br>\r\n        <label class=\"text-primary\" dir=\"rtl\">تاریخ امروز : </label> <label dir=\"rtl\">");
#nullable restore
#line 21 "C:\Users\HamidS\source\repos\DoctorOffice_Project\DoctorOffice_Project\Areas\doctorPanel\Views\Turns\Details.cshtml"
                                                                                 Write(Model.currentDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label><br>\r\n    </div>\r\n\r\n    <div class=\"row\" dir=\"ltr\" id=\"reserveDetailsButtons\">\r\n        <div class=\"col-md-6 offset-5\">\r\n            <div class=\"col-md-6\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d5f7a91c714c80a3982212ae3a2701cb27db132910278", async() => {
                WriteLiteral("تایید و بازگشت");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SecretaryreserveDetails_ViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591