using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using QuanLyCuaHang_21880159.Entities;
using QuanLyCuaHang_21880159.Service;

namespace QuanLyCuaHang_21880159.Pages.MH_ThongKe
{
    public class MH_ThongKeLoaiHangModel : PageModel
    {

        public Dictionary<LoaiHang, int> dstk;
        [BindProperty]
        public string Keyword { get; set; }
        public void OnGet()
        {
            dstk = XuLyThongKe.ThongKeTheoLoai("");
        }
        public void OnPost()
        {
            dstk = XuLyThongKe.ThongKeTheoLoai(Keyword);
        }
    }
}
