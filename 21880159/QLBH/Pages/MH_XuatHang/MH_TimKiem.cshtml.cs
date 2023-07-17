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
    public class MH_TimKiemModel : PageModel
    {
        public HoaDonXuatHang hd2;
        public List<HoaDonXuatHang> dshd;
        [BindProperty]
        public string Keyword { get; set; }
        [BindProperty]
        public int GiaTienNhap { get; set; }
        [BindProperty]
        public int SoLuong { get; set; }
        public void OnGet()
        {
            dshd = LuuTruHoaDonXuatHang.DocDSHoaDon();
        }
        public void OnPost()
        {
            dshd = XuLyHoaDonXuatHang.TimKiem(Keyword);
        }
    }
}
