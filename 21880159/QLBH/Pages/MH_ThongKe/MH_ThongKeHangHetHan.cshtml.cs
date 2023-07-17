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
    public class MH_ThongKeHangHetHanModel : PageModel
    {
        public List<SanPham> dssp;
        public void OnGet()
        {
            dssp = XuLyThongKe.ThongKeSanPhamHetHang();
        }
    }
}
