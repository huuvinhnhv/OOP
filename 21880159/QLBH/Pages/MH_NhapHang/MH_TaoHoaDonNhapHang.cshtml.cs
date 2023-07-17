using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using QuanLyCuaHang_21880159.DAL;
using QuanLyCuaHang_21880159.Entities;
using QuanLyCuaHang_21880159.Service;

namespace QuanLyCuaHang_21880159.Pages.MH_NhapHang
{
    public class MH_TaoHoaDonNhapHangModel : PageModel
    {
        public string Chuoi;
        public string Chuoi2;
        public bool CoSanPham;
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
            //dssp = LuuTruSanPham.DocDSSanPham();
            //dsspThem = LuuTruHoaDonNhapHang.DocDSSPNhapHang();
            //SanPham? sp3 = XuLySanPham.DocSanPham(MaSanPham);
            //if (sp3 != null)
            //{
            //    SanPham sp4 = sp3.Value;
            //    sp4.SoLuong = SoLuong;
            //    sphd.MaSanPham = sp4.MaSanPham;
            //    sphd.TenSanPham = sp4.TenSanPham;
            //    sphd.HanSuDung = sp4.HanSuDung;
            //    sphd.CtySanXuat = sp4.CtySanXuat;
            //    sphd.MaLoaiHang = sp4.MaLoaiHang;
            //    sphd.GiaSanPham = sp4.GiaSanPham;
            //    sphd.SoLuong = sp4.SoLuong;
            //    sphd.ThanhTien = SoLuong * sp4.GiaSanPham;
            //    LuuTruHoaDonNhapHang.LuuSPNhapHang(sphd);
            //}
            //List<SanPhamHoaDon> tsdsspHoaDon = LuuTruHoaDonNhapHang.DocDSSPNhapHang();
            //for (int i = 0; i < tsdsspHoaDon.Count; i++)
            //{
            //    SanPhamHoaDon sphd2 = tsdsspHoaDon[i];
            //    sphd2.STT = i + 1;
            //    tsdsspHoaDon[i] = sphd2;
            //}
            //LuuTruHoaDonNhapHang.LuuDSSPNhapHang(tsdsspHoaDon);
            //dsspThem = tsdsspHoaDon;
        }
        public void OnPostCreate()
        {
            Chuoi2 = string.Empty;
            dssp = LuuTruSanPham.DocDSSanPham();
            dsspThem = LuuTruHoaDonNhapHang.DocDSSPNhapHang();
            bool kq = LuuTruHoaDonNhapHang.XoaDanhSachSPNhapHang();
            if (dsspThem.Count == 0)
            {
                Chuoi2 = "Hóa đơn không có sản phẩm!";
            }
            else
            {
                string hd = XuLyHoaDonNhapHang.TaoHoaDon(dsspThem);
                Response.Redirect("/MH_NhapHang/MH_CTHDNhapHang");
            }
        }
    }
}
