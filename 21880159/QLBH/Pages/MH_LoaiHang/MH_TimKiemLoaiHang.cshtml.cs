using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using QuanLyCuaHang_21880159.DAL;
using QuanLyCuaHang_21880159.Entities;
using QuanLyCuaHang_21880159.Service;

namespace QuanLyCuaHang_21880159.Pages.MH_LoaiHang
{
    public class MH_TimKiemLoaiHangModel : PageModel
    {
        public List<LoaiHang> dslh;
        [BindProperty]
        public int SearchOptions { get; set; }
        [BindProperty]
        public string Keyword { get; set; }
        public void OnGet()
        {
            dslh = LuuTruLoaiHang.DocDSLoaiHang();
        }
        public void OnPost()
        {
            //dslh = XuLyLoaiHang.TimKiem(SearchOptions, Keyword);
        }
    }
}
