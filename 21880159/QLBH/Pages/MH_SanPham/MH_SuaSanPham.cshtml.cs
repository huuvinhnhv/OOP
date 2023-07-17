using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using QuanLyCuaHang_21880159.Entities;
using QuanLyCuaHang_21880159.Service;

namespace QuanLyCuaHang_21880159.Pages.MH_SanPham
{
    public class MH_SuaSanPhamModel : PageModel
    {
        public string Chuoi;
        public bool CoSanPham;
        public SanPham SanPham;
        [BindProperty(SupportsGet = true)]
        public string Id { get; set; }

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
            //Chuoi = string.Empty;
            //SanPham? sp = XuLySanPham.DocSanPham(Id);
            //if (sp != null)
            //{
            //    SanPham = sp.Value;
            //}
            //else
            //{
            //    Chuoi = "Không tìm thấy sản phẩm!";
            //}
            //CoSanPham = sp != null;
        }
        public void OnPost()
        {
            //SanPham s;
            //s.MaSanPham = Id;
            //s.TenSanPham = TenSanPham;
            //s.HanSuDung = HanSuDung;
            //s.CtySanXuat = CtySanXuat;
            //s.NgaySanXuat = NgaySanXuat;
            //s.MaLoaiHang = MaLoaiHang;
            //s.GiaSanPham = GiaSanPham;
            //s.SoLuong = 0;
            //Chuoi = XuLySanPham.SuaSanPham(s);
            //Response.Redirect("/MH_SanPham/MH_TimKiemSanPham");
        }
    }
}
