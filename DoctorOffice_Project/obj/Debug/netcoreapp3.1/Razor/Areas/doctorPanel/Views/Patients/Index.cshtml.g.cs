#pragma checksum "C:\Users\HamidS\source\repos\DoctorOffice_Project\DoctorOffice_Project\Areas\doctorPanel\Views\Patients\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b84a718455d88551db14a83dc0819be9e5bc9d9b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_doctorPanel_Views_Patients_Index), @"mvc.1.0.view", @"/Areas/doctorPanel/Views/Patients/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b84a718455d88551db14a83dc0819be9e5bc9d9b", @"/Areas/doctorPanel/Views/Patients/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f75b17eb66ee8477b8a2b4e04fb51d1706d51b85", @"/Areas/doctorPanel/Views/_ViewImports.cshtml")]
    public class Areas_doctorPanel_Views_Patients_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<patients>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Patients", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "insertData", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "doctorPanel", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("عکس موجود نیست"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("عکس مریض"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-responsive img-thumbnail"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("max-width:5em !important; max-height:60px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "updateData", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/patientsScripts.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\HamidS\source\repos\DoctorOffice_Project\DoctorOffice_Project\Areas\doctorPanel\Views\Patients\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/doctorPanel/Views/Shared/_doctorLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row"" id=""searchField"">
    <section class=""col-lg-4 col-md-4 col-sm-4 col-xl-4"">
        <section class=""row"">
            <section class=""col-lg-6 col-md-6 col-sm-6 col-xl-6"">
                <label>شماره ملی بیمار :</label>
            </section>
        </section>
    </section>
    <section class=""col-lg-4 col-md-4 col-sm-4 col-xl-4 text-center"">
        <input type=""text"" class=""form-control"" id=""searchContent"" placeholder=""شماره ملی بیمار را وارد کنید ..."">
    </section>
    <section class=""col-lg-4 col-md-4 col-sm-4 col-xl-4 text-right"">
        <a id=""searchButton"" class=""btn btn-success"">جست و جو</a>
    </section>
</div>

<div class=""alert alert-warning text-right"">
    <h4>برای دیدن جزییات دقیق میتوانید رو دکمه ویرایش کلیک کنید</h4>
</div>

<div class=""alert alert-success text-right"">
    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b84a718455d88551db14a83dc0819be9e5bc9d9b9831", async() => {
                WriteLiteral("تشکیل پرونده جدید");
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
            WriteLiteral(@"
</div>

<table id=""reserveList"" class=""table table-hover table-bordered"">
    <thead class=""thead-dark"">
    <th>کد شناسایی</th>
    <th>تصویر</th>
    <th>شماره ملی</th>
    <th>نام و نام خانوادگی</th>
    <th>نام پدر</th>
    <th>تاریخ تولد</th>
    <th>عملیات</th>
    </thead>
    <tbody>
");
#nullable restore
#line 44 "C:\Users\HamidS\source\repos\DoctorOffice_Project\DoctorOffice_Project\Areas\doctorPanel\Views\Patients\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 47 "C:\Users\HamidS\source\repos\DoctorOffice_Project\DoctorOffice_Project\Areas\doctorPanel\Views\Patients\Index.cshtml"
               Write(item.patientsID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b84a718455d88551db14a83dc0819be9e5bc9d9b12413", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1562, "~/uploadImages/", 1562, 15, true);
#nullable restore
#line 48 "C:\Users\HamidS\source\repos\DoctorOffice_Project\DoctorOffice_Project\Areas\doctorPanel\Views\Patients\Index.cshtml"
AddHtmlAttributeValue("", 1577, item.imageName, 1577, 15, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 49 "C:\Users\HamidS\source\repos\DoctorOffice_Project\DoctorOffice_Project\Areas\doctorPanel\Views\Patients\Index.cshtml"
               Write(item.nationalNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 50 "C:\Users\HamidS\source\repos\DoctorOffice_Project\DoctorOffice_Project\Areas\doctorPanel\Views\Patients\Index.cshtml"
               Write(item.firstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 50 "C:\Users\HamidS\source\repos\DoctorOffice_Project\DoctorOffice_Project\Areas\doctorPanel\Views\Patients\Index.cshtml"
                               Write(item.lastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 51 "C:\Users\HamidS\source\repos\DoctorOffice_Project\DoctorOffice_Project\Areas\doctorPanel\Views\Patients\Index.cshtml"
               Write(item.fatherName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 52 "C:\Users\HamidS\source\repos\DoctorOffice_Project\DoctorOffice_Project\Areas\doctorPanel\Views\Patients\Index.cshtml"
               Write(item.birthDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b84a718455d88551db14a83dc0819be9e5bc9d9b15800", async() => {
                WriteLiteral("ویرایش");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 54 "C:\Users\HamidS\source\repos\DoctorOffice_Project\DoctorOffice_Project\Areas\doctorPanel\Views\Patients\Index.cshtml"
                                                                                                  WriteLiteral(item.patientsID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    <a");
            BeginWriteAttribute("onclick", " onclick=\"", 2137, "\"", 2179, 3);
            WriteAttributeValue("", 2147, "deletePatients(", 2147, 15, true);
#nullable restore
#line 55 "C:\Users\HamidS\source\repos\DoctorOffice_Project\DoctorOffice_Project\Areas\doctorPanel\Views\Patients\Index.cshtml"
WriteAttributeValue("", 2162, item.patientsID, 2162, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2178, ")", 2178, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-sm btn btn-danger\" id=\"deletePatients\">حذف</a>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 58 "C:\Users\HamidS\source\repos\DoctorOffice_Project\DoctorOffice_Project\Areas\doctorPanel\Views\Patients\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </tbody>
</table>

<div class=""modal"" tabindex=""-1"" role=""dialog"" id=""Modal"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"" id=""headerModal"">
                <h5 class=""modal-title"" id=""ModalTitle"">Modal title</h5>
");
            WriteLiteral(@"            </div>
            <div class=""modal-body text-right"" id=""ModalBody"">

            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-success"" id=""AcceptDelete"">بله</button>
                <button type=""button"" class=""btn btn-danger"" data-dismiss=""modal"">خیر</button>
            </div>
        </div>
    </div>
</div>

");
            DefineSection("ScriptsOnViews", async() => {
                WriteLiteral(" \r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b84a718455d88551db14a83dc0819be9e5bc9d9b20349", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<patients>> Html { get; private set; }
    }
}
#pragma warning restore 1591
