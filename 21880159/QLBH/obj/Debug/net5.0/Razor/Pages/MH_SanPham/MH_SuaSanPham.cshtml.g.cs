#pragma checksum "D:\HUS\KyThuatLapTrinh\Demo\Demo2\Demo2\Pages\MH_SanPham\MH_SuaSanPham.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "867eab3d1a3e59c1286d176730249fee25ac4e5e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(QuanLyCuaHang_21880159.Pages.MH_SanPham.Pages_MH_SanPham_MH_SuaSanPham), @"mvc.1.0.razor-page", @"/Pages/MH_SanPham/MH_SuaSanPham.cshtml")]
namespace QuanLyCuaHang_21880159.Pages.MH_SanPham
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
#line 1 "D:\HUS\KyThuatLapTrinh\Demo\Demo2\Demo2\Pages\_ViewImports.cshtml"
using QuanLyCuaHang_21880159;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"867eab3d1a3e59c1286d176730249fee25ac4e5e", @"/Pages/MH_SanPham/MH_SuaSanPham.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"50f5cb9ad2c6abe0325b08f92dbad601c6c3ba01", @"/Pages/_ViewImports.cshtml")]
    public class Pages_MH_SanPham_MH_SuaSanPham : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 5 "D:\HUS\KyThuatLapTrinh\Demo\Demo2\Demo2\Pages\MH_SanPham\MH_SuaSanPham.cshtml"
 if (Model.CoSanPham)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "867eab3d1a3e59c1286d176730249fee25ac4e5e3613", async() => {
                WriteLiteral("\r\n        <label>Nhập tên phẩm:</label><br>\r\n        <input type=\"text\" name=\"TenSanPham\"");
                BeginWriteAttribute("value", " value=\"", 220, "\"", 253, 1);
#nullable restore
#line 9 "D:\HUS\KyThuatLapTrinh\Demo\Demo2\Demo2\Pages\MH_SanPham\MH_SuaSanPham.cshtml"
WriteAttributeValue("", 228, Model.SanPham.TenSanPham, 228, 25, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /><br>\r\n        <label>Nhập hạn sử dụng (tháng):</label><br>\r\n        <input type=\"text\" name=\"HanSuDung\"");
                BeginWriteAttribute("value", " value=\"", 360, "\"", 392, 1);
#nullable restore
#line 11 "D:\HUS\KyThuatLapTrinh\Demo\Demo2\Demo2\Pages\MH_SanPham\MH_SuaSanPham.cshtml"
WriteAttributeValue("", 368, Model.SanPham.HanSuDung, 368, 24, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /><br>\r\n        <label>Nhập công ty sản xuất:</label><br>\r\n        <input type=\"text\" name=\"CtySanXuat\"");
                BeginWriteAttribute("value", " value=\"", 497, "\"", 530, 1);
#nullable restore
#line 13 "D:\HUS\KyThuatLapTrinh\Demo\Demo2\Demo2\Pages\MH_SanPham\MH_SuaSanPham.cshtml"
WriteAttributeValue("", 505, Model.SanPham.CtySanXuat, 505, 25, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /><br>\r\n        <label>Nhập ngày sản xuất:</label><br>\r\n        <input type=\"text\" name=\"NgaySanXuat\"");
                BeginWriteAttribute("value", " value=\"", 633, "\"", 667, 1);
#nullable restore
#line 15 "D:\HUS\KyThuatLapTrinh\Demo\Demo2\Demo2\Pages\MH_SanPham\MH_SuaSanPham.cshtml"
WriteAttributeValue("", 641, Model.SanPham.NgaySanXuat, 641, 26, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /><br>\r\n        <label>Nhập mã loại hàng:</label><br>\r\n        <input type=\"text\" name=\"MaLoaiHang\"");
                BeginWriteAttribute("value", " value=\"", 768, "\"", 801, 1);
#nullable restore
#line 17 "D:\HUS\KyThuatLapTrinh\Demo\Demo2\Demo2\Pages\MH_SanPham\MH_SuaSanPham.cshtml"
WriteAttributeValue("", 776, Model.SanPham.MaLoaiHang, 776, 25, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /><br>\r\n        <label>Nhập giá phẩm:</label><br>\r\n        <input type=\"text\" name=\"GiaSanPham\"");
                BeginWriteAttribute("value", " value=\"", 898, "\"", 931, 1);
#nullable restore
#line 19 "D:\HUS\KyThuatLapTrinh\Demo\Demo2\Demo2\Pages\MH_SanPham\MH_SuaSanPham.cshtml"
WriteAttributeValue("", 906, Model.SanPham.GiaSanPham, 906, 25, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /><br><br>\r\n        <input type=\"submit\" value=\"Sửa Sản Phẩm\" />\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 22 "D:\HUS\KyThuatLapTrinh\Demo\Demo2\Demo2\Pages\MH_SanPham\MH_SuaSanPham.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "D:\HUS\KyThuatLapTrinh\Demo\Demo2\Demo2\Pages\MH_SanPham\MH_SuaSanPham.cshtml"
Write(Model.Chuoi);

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<QuanLyCuaHang_21880159.Pages.MH_SanPham.MH_SuaSanPhamModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<QuanLyCuaHang_21880159.Pages.MH_SanPham.MH_SuaSanPhamModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<QuanLyCuaHang_21880159.Pages.MH_SanPham.MH_SuaSanPhamModel>)PageContext?.ViewData;
        public QuanLyCuaHang_21880159.Pages.MH_SanPham.MH_SuaSanPhamModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
