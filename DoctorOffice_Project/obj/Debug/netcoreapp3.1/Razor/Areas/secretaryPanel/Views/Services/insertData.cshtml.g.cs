#pragma checksum "C:\Users\HamidS\source\repos\DoctorOffice_Project\DoctorOffice_Project\Areas\secretaryPanel\Views\Services\insertData.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4d86a72b2240eddb83d2c3a000d249cc1cca1eb1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_secretaryPanel_Views_Services_insertData), @"mvc.1.0.view", @"/Areas/secretaryPanel/Views/Services/insertData.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d86a72b2240eddb83d2c3a000d249cc1cca1eb1", @"/Areas/secretaryPanel/Views/Services/insertData.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f75b17eb66ee8477b8a2b4e04fb51d1706d51b85", @"/Areas/secretaryPanel/Views/_ViewImports.cshtml")]
    public class Areas_secretaryPanel_Views_Services_insertData : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/SservicesInsertData"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onsubmit", new global::Microsoft.AspNetCore.Html.HtmlString("return Accepted"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("insertServices"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\HamidS\source\repos\DoctorOffice_Project\DoctorOffice_Project\Areas\secretaryPanel\Views\Services\insertData.cshtml"
  
    ViewData["Title"] = "insertData";
    Layout = "~/Areas/secretaryPanel/Views/Shared/_secretaryLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"jumbotron jumbotron-fluid\">\r\n    <div class=\"container text-right\">\r\n        <div class=\"alert alert-primary\">\r\n            <h3 class=\"text-muted\">درج خدمات مطب</h3>\r\n        </div>\r\n        <hr>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4d86a72b2240eddb83d2c3a000d249cc1cca1eb16838", async() => {
                WriteLiteral("\r\n            <div class=\"row\">\r\n                <div class=\"col-xl-12\">\r\n                    <div class=\"col-xl-6 col-lg-6 col-md-6 col-sm-6\">\r\n\r\n                        <input type=\"text\" name=\"ServicesID\" id=\"ServicesID\"");
                BeginWriteAttribute("value", " value=\"", 666, "\"", 674, 0);
                EndWriteAttribute();
                WriteLiteral(@" hidden>

                        <label>عنوان خدمت : </label> <input type=""text"" name=""Title"" id=""Title"" class=""form-control"">
                        <p></p>
                    </div>
                </div>
            </div>
            <div class=""row"">
                <div class=""col-xl-12"">
                    <div class=""col-xl-10 col-lg-10 col-md-10 col-sm-10"">

                        <section class=""alert alert-warning"" id=""infoType"">
                            <h5>توجه داشته باشید شما فقط میتوانید 160 کاراکتر تایپ کنید</h5>
                        </section>

                        <label>متن کامل خدمت : </label>
                        <textarea name=""fullTextServices"" maxlength=""160"" id=""fullTextServices"" cols=""30"" rows=""5""
                                  class=""form-control""></textarea>
                    </div>
                </div>
            </div>
            <div class=""row"">
                <div class=""col-xl-6 col-lg-6 col-md-6 col-sm-6"">
                   ");
                WriteLiteral(@" <div class=""col-xl-6 col-lg-6 col-md-6 col-sm-6"">
                        <label>در سایت نمایش داده شود؟ </label>
                        <input type=""checkbox"" name=""showInPage"" id=""showInPage"" value=""true"">
                    </div>
                </div>
            </div>
            <div class=""row"">
                <div class=""col-xl-6 col-lg-6 col-md-6 col-sm-6"">
                    <div class=""col-xl-6 col-lg-6 col-md-6 col-sm-6"">
                        <label>ترتیب : </label>
                        <input type=""text"" name=""Order"" id=""Order"" class=""form-control"">
                    </div>
                </div>
            </div>
            <section class=""container"" id=""medicineButtons"">
                <input type=""submit"" id=""SaveService"" value=""ذخیره"" class=""btn btn-success btn-sm"">
                <a id=""Cancel"" class=""btn btn-danger btn-sm"">انصراف</a>
            </section>
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



<div class=""modal"" tabindex=""-1"" role=""dialog"" id=""Modal"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"" id=""headerModal"">
                <h5 class=""modal-title"" id=""ModalTitle"">Modal title</h5>
");
            WriteLiteral(@"            </div>
            <div class=""modal-body"" id=""ModalBody"">

            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-primary"" id=""Accept"">می پذیرم</button>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591