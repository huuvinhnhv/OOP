#pragma checksum "D:\HUS\KyThuatLapTrinh\Demo\Demo2\Demo2\Pages\MH_SanPham\MH_TimKiemSanPham.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "30f5e7c0ab0ab127805f39e7d813d66cccdbad8e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(QuanLyCuaHang_21880159.Pages.MH_SanPham.Pages_MH_SanPham_MH_TimKiemSanPham), @"mvc.1.0.razor-page", @"/Pages/MH_SanPham/MH_TimKiemSanPham.cshtml")]
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
#nullable restore
#line 3 "D:\HUS\KyThuatLapTrinh\Demo\Demo2\Demo2\Pages\MH_SanPham\MH_TimKiemSanPham.cshtml"
using QuanLyCuaHang_21880159.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"30f5e7c0ab0ab127805f39e7d813d66cccdbad8e", @"/Pages/MH_SanPham/MH_TimKiemSanPham.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"50f5cb9ad2c6abe0325b08f92dbad601c6c3ba01", @"/Pages/_ViewImports.cshtml")]
    public class Pages_MH_SanPham_MH_TimKiemSanPham : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "2", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "30f5e7c0ab0ab127805f39e7d813d66cccdbad8e4330", async() => {
                WriteLiteral("\r\n    <label for=\"searchOptions\">Tìm kiếm sản phẩm theo:</label><br />\r\n    <select name=\"SearchOptions\">\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "30f5e7c0ab0ab127805f39e7d813d66cccdbad8e4709", async() => {
                    WriteLiteral("Mã sản phẩm");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "30f5e7c0ab0ab127805f39e7d813d66cccdbad8e5945", async() => {
                    WriteLiteral("Tên sản phẩm");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    </select><br />\r\n    <label>Nhập thông tin tìm kiếm:</label><br>\r\n    <input type=\"text\" name=\"Keyword\"");
                BeginWriteAttribute("value", " value=\"", 456, "\"", 464, 0);
                EndWriteAttribute();
                WriteLiteral(" /><br>\r\n    <input type=\"submit\" value=\"Tìm kiếm\" />\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

<table>
    <tr>
        <th>Mã sản phẩm</th>
        <th>Tên sản phẩm</th>
        <th>Công ty sản xuât</th>
        <th>Hạn sử dụng</th>
        <th>Ngày sản xuất</th>
        <th>Giá</th>
        <th>Mã Loại hàng</th>
        <th>Xóa/Sửa</th>
        <th>Nhập hàng</th>
        <th>Xuất hàng</th>
    </tr>
");
#nullable restore
#line 30 "D:\HUS\KyThuatLapTrinh\Demo\Demo2\Demo2\Pages\MH_SanPham\MH_TimKiemSanPham.cshtml"
     foreach (SanPham s in Model.dssp)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 33 "D:\HUS\KyThuatLapTrinh\Demo\Demo2\Demo2\Pages\MH_SanPham\MH_TimKiemSanPham.cshtml"
           Write(s.MaSanPham);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 34 "D:\HUS\KyThuatLapTrinh\Demo\Demo2\Demo2\Pages\MH_SanPham\MH_TimKiemSanPham.cshtml"
           Write(s.TenSanPham);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 35 "D:\HUS\KyThuatLapTrinh\Demo\Demo2\Demo2\Pages\MH_SanPham\MH_TimKiemSanPham.cshtml"
           Write(s.MaLoaiHang);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 36 "D:\HUS\KyThuatLapTrinh\Demo\Demo2\Demo2\Pages\MH_SanPham\MH_TimKiemSanPham.cshtml"
           Write(s.HanSuDung);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 37 "D:\HUS\KyThuatLapTrinh\Demo\Demo2\Demo2\Pages\MH_SanPham\MH_TimKiemSanPham.cshtml"
           Write(s.NgaySanXuat);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 38 "D:\HUS\KyThuatLapTrinh\Demo\Demo2\Demo2\Pages\MH_SanPham\MH_TimKiemSanPham.cshtml"
           Write(s.GiaSanPham);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 39 "D:\HUS\KyThuatLapTrinh\Demo\Demo2\Demo2\Pages\MH_SanPham\MH_TimKiemSanPham.cshtml"
           Write(s.MaLoaiHang);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 1202, "\"", 1238, 2);
            WriteAttributeValue("", 1209, "MH_XoaSanPham?id=", 1209, 17, true);
#nullable restore
#line 41 "D:\HUS\KyThuatLapTrinh\Demo\Demo2\Demo2\Pages\MH_SanPham\MH_TimKiemSanPham.cshtml"
WriteAttributeValue("", 1226, s.MaSanPham, 1226, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Xóa</a>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 1267, "\"", 1303, 2);
            WriteAttributeValue("", 1274, "MH_SuaSanPham?id=", 1274, 17, true);
#nullable restore
#line 42 "D:\HUS\KyThuatLapTrinh\Demo\Demo2\Demo2\Pages\MH_SanPham\MH_TimKiemSanPham.cshtml"
WriteAttributeValue("", 1291, s.MaSanPham, 1291, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Sửa</a>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 45 "D:\HUS\KyThuatLapTrinh\Demo\Demo2\Demo2\Pages\MH_SanPham\MH_TimKiemSanPham.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<QuanLyCuaHang_21880159.Pages.MH_SanPham.MH_TimKiemSanPhamModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<QuanLyCuaHang_21880159.Pages.MH_SanPham.MH_TimKiemSanPhamModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<QuanLyCuaHang_21880159.Pages.MH_SanPham.MH_TimKiemSanPhamModel>)PageContext?.ViewData;
        public QuanLyCuaHang_21880159.Pages.MH_SanPham.MH_TimKiemSanPhamModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
