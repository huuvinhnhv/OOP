#pragma checksum "D:\HUS\HK2\LapTrinhHuongDoiTuong\Nop DA - 1\21880159\QLBH\Pages\MH_XuatHang\MH_CTHDXuatHang.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "28faba7427a1d8b277e47b5d71ca25e7804466b5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(QuanLyCuaHang_21880159.Pages.MH_XuatHang.Pages_MH_XuatHang_MH_CTHDXuatHang), @"mvc.1.0.razor-page", @"/Pages/MH_XuatHang/MH_CTHDXuatHang.cshtml")]
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
#line 3 "D:\HUS\HK2\LapTrinhHuongDoiTuong\Nop DA - 1\21880159\QLBH\Pages\MH_XuatHang\MH_CTHDXuatHang.cshtml"
using QuanLyCuaHang_21880159.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"28faba7427a1d8b277e47b5d71ca25e7804466b5", @"/Pages/MH_XuatHang/MH_CTHDXuatHang.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"50f5cb9ad2c6abe0325b08f92dbad601c6c3ba01", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_MH_XuatHang_MH_CTHDXuatHang : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 7 "D:\HUS\HK2\LapTrinhHuongDoiTuong\Nop DA - 1\21880159\QLBH\Pages\MH_XuatHang\MH_CTHDXuatHang.cshtml"
 if (Model.CoHD)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h3 style=\"text-align:center\">Chi Tiết Hóa Đơn Xuất Hàng</h3>\r\n    <br />\r\n    <br />\r\n");
            WriteLiteral("    <p>Mã hóa đơn: ");
#nullable restore
#line 13 "D:\HUS\HK2\LapTrinhHuongDoiTuong\Nop DA - 1\21880159\QLBH\Pages\MH_XuatHang\MH_CTHDXuatHang.cshtml"
              Write(Model.hd.MaHoaDon);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n    <br />\r\n    <p>Ngày lập hóa đơn: ");
#nullable restore
#line 15 "D:\HUS\HK2\LapTrinhHuongDoiTuong\Nop DA - 1\21880159\QLBH\Pages\MH_XuatHang\MH_CTHDXuatHang.cshtml"
                    Write(Model.hd.NgayLap);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </p>
    <br />
    <table class=""table table-bordered table-hover"">
        <tr>
            <th>STT</th>
            <th>Tên Sản Phẩm</th>
            <th>Số lượng</th>
            <th>Giá sản phẩm</th>
            <th>Thành tiền</th>
        </tr>
");
#nullable restore
#line 25 "D:\HUS\HK2\LapTrinhHuongDoiTuong\Nop DA - 1\21880159\QLBH\Pages\MH_XuatHang\MH_CTHDXuatHang.cshtml"
         foreach (var sp in Model.hd.DSSP)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 28 "D:\HUS\HK2\LapTrinhHuongDoiTuong\Nop DA - 1\21880159\QLBH\Pages\MH_XuatHang\MH_CTHDXuatHang.cshtml"
               Write(sp.STT);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 29 "D:\HUS\HK2\LapTrinhHuongDoiTuong\Nop DA - 1\21880159\QLBH\Pages\MH_XuatHang\MH_CTHDXuatHang.cshtml"
               Write(sp.TenSanPham);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 30 "D:\HUS\HK2\LapTrinhHuongDoiTuong\Nop DA - 1\21880159\QLBH\Pages\MH_XuatHang\MH_CTHDXuatHang.cshtml"
               Write(sp.SoLuong);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 31 "D:\HUS\HK2\LapTrinhHuongDoiTuong\Nop DA - 1\21880159\QLBH\Pages\MH_XuatHang\MH_CTHDXuatHang.cshtml"
               Write(sp.GiaSanPham);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 32 "D:\HUS\HK2\LapTrinhHuongDoiTuong\Nop DA - 1\21880159\QLBH\Pages\MH_XuatHang\MH_CTHDXuatHang.cshtml"
               Write(sp.ThanhTien);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 34 "D:\HUS\HK2\LapTrinhHuongDoiTuong\Nop DA - 1\21880159\QLBH\Pages\MH_XuatHang\MH_CTHDXuatHang.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </table>\r\n    <p><b>Tổng tiền: ");
#nullable restore
#line 37 "D:\HUS\HK2\LapTrinhHuongDoiTuong\Nop DA - 1\21880159\QLBH\Pages\MH_XuatHang\MH_CTHDXuatHang.cshtml"
                Write(Model.hd.TongTien);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </b></p>\r\n");
#nullable restore
#line 38 "D:\HUS\HK2\LapTrinhHuongDoiTuong\Nop DA - 1\21880159\QLBH\Pages\MH_XuatHang\MH_CTHDXuatHang.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "D:\HUS\HK2\LapTrinhHuongDoiTuong\Nop DA - 1\21880159\QLBH\Pages\MH_XuatHang\MH_CTHDXuatHang.cshtml"
Write(Model.Chuoi);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n<a class=\"btn btn-info\" href=\"/MH_XuatHang/MH_TaoHoaDonXuatHang\">Tạo thêm hóa đơn</a>\r\n<a class=\"btn btn-info\" href=\"/MH_XuatHang/MH_TimKiem\">Quay về tìm kiếm</a>\r\n\r\n<br />\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<QuanLyCuaHang_21880159.Pages.MH_XuatHang.MH_CTHDXuatHangModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<QuanLyCuaHang_21880159.Pages.MH_XuatHang.MH_CTHDXuatHangModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<QuanLyCuaHang_21880159.Pages.MH_XuatHang.MH_CTHDXuatHangModel>)PageContext?.ViewData;
        public QuanLyCuaHang_21880159.Pages.MH_XuatHang.MH_CTHDXuatHangModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591