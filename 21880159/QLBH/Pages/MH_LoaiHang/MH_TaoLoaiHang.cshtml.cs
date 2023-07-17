using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using QuanLyCuaHang_21880159.Entities;
using QuanLyCuaHang_21880159.Service;

namespace QuanLyCuaHang_21880159.Pages.MH_LoaiHang
{
    public class MH_TaoLoaiHangModel : PageModel
    {
        public string Chuoi;
        [BindProperty]
        public string MaLoaiHang { get; set; }
        [BindProperty]
        public string TenLoaiHang { get; set; }
        public void OnGet()
        {
            Chuoi = string.Empty;
        }
        public void OnPost()
        {
            //LoaiHang lh;
            //lh.MaLoaiHang = MaLoaiHang;
            //lh.TenLoaiHang = TenLoaiHang;
            //Chuoi = XuLyLoaiHang.TaoLoaiHang(lh);
        }
    }
}
