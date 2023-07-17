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
    public class MH_XoaHoaDonModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public string id { get; set; }
        public string MaHoaDon;
        public bool CoHoaDon;
        public string Chuoi;
        public void OnGet()
        {
            Chuoi = string.Empty;
            HoaDonXuatHang? hd = LuuTruHoaDonXuatHang.DocHoaDon(id);
            CoHoaDon = hd != null;
            if (!CoHoaDon)
            {
                Chuoi = "Không tồn tại mã hóa đơn!";
            }
        }
        public void OnPost()
        {
            //bool kq = XuLyHoaDonXuatHang.XoaHD(id);
            //if (kq)
            //{
            //    Chuoi = "Xóa thành công!";
            //}
            //else
            //{
            //    Chuoi = "Xóa không thành công!";
            //}
        }
    }
}
