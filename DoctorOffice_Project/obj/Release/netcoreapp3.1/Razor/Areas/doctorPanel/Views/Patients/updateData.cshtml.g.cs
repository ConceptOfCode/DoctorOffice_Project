#pragma checksum "C:\Users\HamidS\source\repos\DoctorOffice_Project\DoctorOffice_Project\Areas\doctorPanel\Views\Patients\updateData.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "97b73158667a0329c35521a91245d9c50f6b2a7c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_doctorPanel_Views_Patients_updateData), @"mvc.1.0.view", @"/Areas/doctorPanel/Views/Patients/updateData.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"97b73158667a0329c35521a91245d9c50f6b2a7c", @"/Areas/doctorPanel/Views/Patients/updateData.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f75b17eb66ee8477b8a2b4e04fb51d1706d51b85", @"/Areas/doctorPanel/Views/_ViewImports.cshtml")]
    public class Areas_doctorPanel_Views_Patients_updateData : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<patients>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("عکسی موجد نیست"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("max-height: 8em; margin-top: 10px; border-radius:15px; border:3px solid black;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Patients", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "doctorPanel", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/DoctorPanel/UpdatePatients"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("UpdatePatients"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onsubmit", new global::Microsoft.AspNetCore.Html.HtmlString("return isSuccess"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\HamidS\source\repos\DoctorOffice_Project\DoctorOffice_Project\Areas\doctorPanel\Views\Patients\updateData.cshtml"
  
    ViewData["Title"] = "updateData";
    Layout = "~/Areas/doctorPanel/Views/Shared/_doctorLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"jumbotron jumbotron-fluid container\">\r\n\r\n    <div class=\"alert alert-primary text-center container\">\r\n        <h4>تشکیل پرونده بیماران مطب</h4>\r\n    </div>\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "97b73158667a0329c35521a91245d9c50f6b2a7c9809", async() => {
                WriteLiteral("\r\n        <input type=\"text\" name=\"patientsID\" id=\"patientsID\"");
                BeginWriteAttribute("value", " value=\"", 512, "\"", 537, 1);
#nullable restore
#line 16 "C:\Users\HamidS\source\repos\DoctorOffice_Project\DoctorOffice_Project\Areas\doctorPanel\Views\Patients\updateData.cshtml"
WriteAttributeValue("", 520, Model.patientsID, 520, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" hidden />
        <div class=""alert alert-warning text-center"">
            <h4>لطفا اطلاعات زیر را با دقت پر کنید</h4>
        </div>
        <div class=""row "" id=""folderPatients"">
            <div class=""col-xl-12"">
                <div class=""col-xl-6 float-left offset-xl-3 text-right"" id=""folderContent"">
                    <section class=""col-xl-3 offset-xl-12 text-center"">
                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "97b73158667a0329c35521a91245d9c50f6b2a7c10983", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 963, "~/uploadImages/", 963, 15, true);
#nullable restore
#line 24 "C:\Users\HamidS\source\repos\DoctorOffice_Project\DoctorOffice_Project\Areas\doctorPanel\Views\Patients\updateData.cshtml"
AddHtmlAttributeValue("", 978, Model.imageName, 978, 16, false);

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
                WriteLiteral("<br>\r\n                    </section>\r\n                    <label>نام : </label>\r\n                    <input type=\"text\" name=\"firstName\"");
                BeginWriteAttribute("id", " id=\"", 1249, "\"", 1254, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\" placeholder=\"نام بیمار...\"");
                BeginWriteAttribute("value", " value=\"", 1303, "\"", 1327, 1);
#nullable restore
#line 27 "C:\Users\HamidS\source\repos\DoctorOffice_Project\DoctorOffice_Project\Areas\doctorPanel\Views\Patients\updateData.cshtml"
WriteAttributeValue("", 1311, Model.firstName, 1311, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                    <label>نام خانوادگی : </label>\r\n                    <input type=\"text\" name=\"lastName\"");
                BeginWriteAttribute("id", " id=\"", 1437, "\"", 1442, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\" placeholder=\"نام خانوادگی بیمار...\"");
                BeginWriteAttribute("value", " value=\"", 1500, "\"", 1523, 1);
#nullable restore
#line 29 "C:\Users\HamidS\source\repos\DoctorOffice_Project\DoctorOffice_Project\Areas\doctorPanel\Views\Patients\updateData.cshtml"
WriteAttributeValue("", 1508, Model.lastName, 1508, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                    <label>نام پدر : </label>\r\n                    <input type=\"text\" name=\"fatherName\"");
                BeginWriteAttribute("id", " id=\"", 1630, "\"", 1635, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\" placeholder=\"نام پدر بیمار...\"");
                BeginWriteAttribute("value", " value=\"", 1688, "\"", 1713, 1);
#nullable restore
#line 31 "C:\Users\HamidS\source\repos\DoctorOffice_Project\DoctorOffice_Project\Areas\doctorPanel\Views\Patients\updateData.cshtml"
WriteAttributeValue("", 1696, Model.fatherName, 1696, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                    <label>شماره ملی : </label>\r\n                    <input type=\"text\" name=\"nationalNumber\" id=\"nationalNumber\" class=\"form-control\" placeholder=\"شماره ملی بیمار...\"");
                BeginWriteAttribute("value", " value=\"", 1900, "\"", 1929, 1);
#nullable restore
#line 33 "C:\Users\HamidS\source\repos\DoctorOffice_Project\DoctorOffice_Project\Areas\doctorPanel\Views\Patients\updateData.cshtml"
WriteAttributeValue("", 1908, Model.nationalNumber, 1908, 21, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                    <label>تاریخ تولد : </label>\r\n                    <input type=\"text\" name=\"birthDate\"");
                BeginWriteAttribute("id", " id=\"", 2038, "\"", 2043, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\" placeholder=\"تاریخ تولد بیمار...\"");
                BeginWriteAttribute("value", " value=\"", 2099, "\"", 2123, 1);
#nullable restore
#line 35 "C:\Users\HamidS\source\repos\DoctorOffice_Project\DoctorOffice_Project\Areas\doctorPanel\Views\Patients\updateData.cshtml"
WriteAttributeValue("", 2107, Model.birthDate, 2107, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                    <label>تصویر : </label>\r\n                    <input type=\"file\" name=\"imgUp\"");
                BeginWriteAttribute("id", " id=\"", 2223, "\"", 2228, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\" placeholder=\"عکس بیمار این قسمت اختیاری است...\"");
                BeginWriteAttribute("value", " value=\"", 2298, "\"", 2322, 1);
#nullable restore
#line 37 "C:\Users\HamidS\source\repos\DoctorOffice_Project\DoctorOffice_Project\Areas\doctorPanel\Views\Patients\updateData.cshtml"
WriteAttributeValue("", 2306, Model.imageName, 2306, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                    <label>شماره تلفن : </label>\r\n                    <input type=\"number\" name=\"phoneNumber\"");
                BeginWriteAttribute("id", " id=\"", 2435, "\"", 2440, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\" placeholder=\"شماره تلفن بیمار...\"");
                BeginWriteAttribute("value", " value=\"", 2496, "\"", 2522, 1);
#nullable restore
#line 39 "C:\Users\HamidS\source\repos\DoctorOffice_Project\DoctorOffice_Project\Areas\doctorPanel\Views\Patients\updateData.cshtml"
WriteAttributeValue("", 2504, Model.phoneNumber, 2504, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                    <label>پست الکترونیک : </label>\r\n                    <input type=\"email\" name=\"Email\"");
                BeginWriteAttribute("id", " id=\"", 2631, "\"", 2636, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\" placeholder=\"پست الکترونیک بیمار...\"");
                BeginWriteAttribute("value", " value=\"", 2695, "\"", 2715, 1);
#nullable restore
#line 41 "C:\Users\HamidS\source\repos\DoctorOffice_Project\DoctorOffice_Project\Areas\doctorPanel\Views\Patients\updateData.cshtml"
WriteAttributeValue("", 2703, Model.Email, 2703, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n\r\n                    <div id=\"folderBtn\" class=\"text-center\">\r\n                        <input type=\"submit\" value=\"ذخیره\" class=\"btn btn-success\" id=\"patientsEdit\">\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "97b73158667a0329c35521a91245d9c50f6b2a7c18930", async() => {
                    WriteLiteral("انصراف");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    </div>\r\n                </div>\r\n\r\n\r\n            </div>\r\n        </div>\r\n\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

</div>




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
</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<patients> Html { get; private set; }
    }
}
#pragma warning restore 1591
