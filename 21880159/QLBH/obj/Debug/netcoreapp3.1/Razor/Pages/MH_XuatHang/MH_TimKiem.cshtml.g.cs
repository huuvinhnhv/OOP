#pragma checksum "D:\HUS\HK2\LapTrinhHuongDoiTuong\Nop DA - 1\21880159\QLBH\Pages\MH_XuatHang\MH_TimKiem.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dc0ace2bb444c83f3ca119ab13fab1faf656e918"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(QuanLyCuaHang_21880159.Pages.MH_XuatHang.Pages_MH_XuatHang_MH_TimKiem), @"mvc.1.0.razor-page", @"/Pages/MH_XuatHang/MH_TimKiem.cshtml")]
namespace QuanLyCuaHang_21880159.Pages.MH_XuatHang
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
#line 1 "D:\HUS\HK2\LapTrinhHuongDoiTuong\Nop DA - 1\21880159\QLBH\Pages\_ViewImports.cshtml"
using QuanLyCuaHang_21880159;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\HUS\HK2\LapTrinhHuongDoiTuong\Nop DA - 1\21880159\QLBH\Pages\MH_XuatHang\MH_TimKiem.cshtml"
using QuanLyCuaHang_21880159.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dc0ace2bb444c83f3ca119ab13fab1faf656e918", @"/Pages/MH_XuatHang/MH_TimKiem.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"50f5cb9ad2c6abe0325b08f92dbad601c6c3ba01", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_MH_XuatHang_MH_TimKiem : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dc0ace2bb444c83f3ca119ab13fab1faf656e9183717", async() => {
                WriteLiteral("\r\n    <label>Nhập mã hóa đơn:</label><br />\r\n    <input type=\"text\" name=\"Keyword\"");
                BeginWriteAttribute("value", " value=\"", 224, "\"", 232, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\" class=\"form-control\" /><br>\r\n    <input type=\"submit\" value=\"Tìm kiếm\" class=\"btn btn-info\" />\r\n");
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
            WriteLiteral(@"
<h3 style=""text-align:center"">Danh sách hóa đơn</h3>
<a href=""/MH_XuatHang/MH_TaoHoaDonXuatHang"" class=""btn btn-outline-info"">Tạo hóa đơn</a>
<br />
<br />
<table class=""table table-bordered table-hover"">
    <tr>
        <th style=""text-align:center"">Mã hóa đơn</th>
        <th style=""text-align:center"">Ngày lập</th>
        <th style=""text-align:center"">Tổng tiền</th>
        <th style=""text-align:center"">Hành động</th>
    </tr>
");
#nullable restore
#line 23 "D:\HUS\HK2\LapTrinhHuongDoiTuong\Nop DA - 1\21880159\QLBH\Pages\MH_XuatHang\MH_TimKiem.cshtml"
     foreach (var hd in Model.dshd)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 26 "D:\HUS\HK2\LapTrinhHuongDoiTuong\Nop DA - 1\21880159\QLBH\Pages\MH_XuatHang\MH_TimKiem.cshtml"
           Write(hd.MaHoaDon);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 27 "D:\HUS\HK2\LapTrinhHuongDoiTuong\Nop DA - 1\21880159\QLBH\Pages\MH_XuatHang\MH_TimKiem.cshtml"
           Write(hd.NgayLap);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 28 "D:\HUS\HK2\LapTrinhHuongDoiTuong\Nop DA - 1\21880159\QLBH\Pages\MH_XuatHang\MH_TimKiem.cshtml"
           Write(hd.TongTien);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td style=\"text-align:center\">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 1031, "\"", 1082, 2);
            WriteAttributeValue("", 1038, "/MH_XuatHang/MH_CTHDXuatHang?id=", 1038, 32, true);
#nullable restore
#line 30 "D:\HUS\HK2\LapTrinhHuongDoiTuong\Nop DA - 1\21880159\QLBH\Pages\MH_XuatHang\MH_TimKiem.cshtml"
WriteAttributeValue("", 1070, hd.MaHoaDon, 1070, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Xem Chi Tiêt</a>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 1120, "\"", 1168, 2);
            WriteAttributeValue("", 1127, "/MH_XuatHang/MH_SuaHoaDon?id=", 1127, 29, true);
#nullable restore
#line 31 "D:\HUS\HK2\LapTrinhHuongDoiTuong\Nop DA - 1\21880159\QLBH\Pages\MH_XuatHang\MH_TimKiem.cshtml"
WriteAttributeValue("", 1156, hd.MaHoaDon, 1156, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Sửa</a>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 1197, "\"", 1245, 2);
            WriteAttributeValue("", 1204, "/MH_XuatHang/MH_XoaHoaDon?id=", 1204, 29, true);
#nullable restore
#line 32 "D:\HUS\HK2\LapTrinhHuongDoiTuong\Nop DA - 1\21880159\QLBH\Pages\MH_XuatHang\MH_TimKiem.cshtml"
WriteAttributeValue("", 1233, hd.MaHoaDon, 1233, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Xóa</a>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 35 "D:\HUS\HK2\LapTrinhHuongDoiTuong\Nop DA - 1\21880159\QLBH\Pages\MH_XuatHang\MH_TimKiem.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<QuanLyCuaHang_21880159.Pages.MH_XuatHang.MH_TimKiemModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<QuanLyCuaHang_21880159.Pages.MH_XuatHang.MH_TimKiemModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<QuanLyCuaHang_21880159.Pages.MH_XuatHang.MH_TimKiemModel>)PageContext?.ViewData;
        public QuanLyCuaHang_21880159.Pages.MH_XuatHang.MH_TimKiemModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
