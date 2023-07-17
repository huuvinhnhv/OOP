using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using QuanLyCuaHang_21880159.Entities;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using QuanLyCuaHang_21880159.Service;
using QuanLyCuaHang_21880159.DAL;

namespace QuanLyCuaHang_21880159.Pages.MH_SanPham
{

    public class MH_TaoSanPhamModel : PageModel
    {
        public List<LoaiHang> dslh;
        public string Chuoi;
        [BindProperty]
        public string MaSanPham { get; set; }
        [BindProperty]
        public string TenSanPham { get; set; }
        [BindProperty]
        public int HanSuDung { get; set; }
        [BindProperty]
        public string CtySanXuat { get; set; }
        [BindProperty]
        public DateTime NgaySanXuat { get; set; }
        [BindProperty]
        public string MaLoaiHang { get; set; }
        [BindProperty]
        public int GiaSanPham { get; set; }
        public void OnGet()
        {
            Chuoi = string.Empty;
            dslh = LuuTruLoaiHang.DocDSLoaiHang();
        }
        public void OnPost()
        {
            //dslh = LuuTruLoaiHang.DocDSLoaiHang();
            //SanPham s;
            //s.MaSanPham = MaSanPham;
            //s.TenSanPham = TenSanPham;
            //s.HanSuDung = HanSuDung;
            //s.CtySanXuat = CtySanXuat;
            //s.NgaySanXuat = NgaySanXuat;
            //s.MaLoaiHang = MaLoaiHang;
            //s.GiaSanPham = GiaSanPham;
            //s.SoLuong = 0;
            //Chuoi = XuLySanPham.TaoSanPham(s);
        }
    }
}
