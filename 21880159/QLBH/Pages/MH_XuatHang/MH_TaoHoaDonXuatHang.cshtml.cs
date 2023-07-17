using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using QuanLyCuaHang_21880159.DAL;
using QuanLyCuaHang_21880159.Entities;
using QuanLyCuaHang_21880159.Service;

namespace QuanLyCuaHang_21880159.Pages.MH_XuatHang
{
    public class MH_TaoHoaDonXuatHangModel : PageModel
    {
        public string Chuoi;
        public string Chuoi2;
        public string Chuoi3;
        public bool CoSanPham;
        public bool CheckSoLuong;
        public SanPham? sp;
        public SanPham sp2;

        public List<SanPham> dssp;
        [BindProperty]
        public int SearchOptions { get; set; }
        [BindProperty]
        public string Keyword { get; set; }
        [BindProperty(SupportsGet = true)]
        public string id { get; set; }
        [BindProperty]
        public int SoLuong { get; set; }
        [BindProperty]
        public string MaSanPham { get; set; }
        public List<SanPhamHoaDon> dsspThem;
        public SanPhamHoaDon sphd;
        public void OnGet()
        {

            //Chuoi2 = string.Empty;
            //Chuoi = string.Empty;
            //dssp = LuuTruSanPham.DocDSSanPham();
            //sp = XuLySanPham.DocSanPham(id);
            //if (sp != null)
            //{
            //    sp2 = sp.Value;
            //}
            //else
            //{
            //    Chuoi = "Không tìm thấy sản phẩm!";
            //}
            //CoSanPham = sp != null;

        }
        public void OnPostSearch()
        {
            //dssp = XuLySanPham.TimKiem(SearchOptions, Keyword);
        }
        public void OnPostAdd()
        {
            dssp = LuuTruSanPham.DocDSSanPham();
            //dsspThem = LuuTruHoaDonXuatHang.DocDSSPXuatHang();
            //SanPham? sp3 = XuLySanPham.DocSanPham(MaSanPham);
            //if (sp3 != null)
            //{
            //    SanPham sp4 = sp3.Value;
            //    Console.WriteLine(sp4.SoLuong);
            //    if (SoLuong > sp4.SoLuong)
            //    {
            //        Chuoi3 = "Số lượng xuất không thể lớn hiện số lượng hiện có!";
            //        return;
            //    }
            //    sp4.SoLuong = SoLuong;
            //    sphd.MaSanPham = sp4.MaSanPham;
            //    sphd.TenSanPham = sp4.TenSanPham;
            //    sphd.HanSuDung = sp4.HanSuDung;
            //    sphd.CtySanXuat = sp4.CtySanXuat;
            //    sphd.MaLoaiHang = sp4.MaLoaiHang;
            //    sphd.GiaSanPham = sp4.GiaSanPham;
            //    sphd.SoLuong = sp4.SoLuong;
            //    sphd.ThanhTien = SoLuong * sp4.GiaSanPham;
            //    LuuTruHoaDonXuatHang.LuuSPXuatHang(sphd);
            //}
            //List<SanPhamHoaDon> tsdsspHoaDon = LuuTruHoaDonXuatHang.DocDSSPXuatHang();
            //for (int i = 0; i < tsdsspHoaDon.Count; i++)
            //{
            //    SanPhamHoaDon sphd2 = tsdsspHoaDon[i];
            //    sphd2.STT = i + 1;
            //    tsdsspHoaDon[i] = sphd2;
            //}
            //LuuTruHoaDonXuatHang.LuuDSSPXuatHang(tsdsspHoaDon);
            //dsspThem = tsdsspHoaDon;
        }
        public void OnPostCreate()
        {
            Chuoi2 = string.Empty;
            dssp = LuuTruSanPham.DocDSSanPham();
            dsspThem = LuuTruHoaDonXuatHang.DocDSSPXuatHang();
            bool kq = LuuTruHoaDonXuatHang.XoaDanhSachSPXuatHang();
            if (dsspThem.Count == 0)
            {
                Chuoi2 = "Hóa đơn không có sản phẩm!";
            }
            else
            {
                string hd = XuLyHoaDonXuatHang.TaoHoaDon(dsspThem);
                Response.Redirect("/MH_XuatHang/MH_CTHDXuatHang");
            }
        }
    }
}
