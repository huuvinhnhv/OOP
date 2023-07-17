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
    public class MH_CTHDXuatHangModel : PageModel
    {
        public HoaDonXuatHang hd;
        public bool CoHD;
        public string Chuoi;
        [BindProperty(SupportsGet = true)]
        public string id { get; set; }
        public void OnGet()
        {
            Chuoi = string.Empty;
            List<HoaDonXuatHang> dshd = LuuTruHoaDonXuatHang.DocDSHoaDon();
            hd = dshd[dshd.Count - 1];
            CoHD = true;
            if (!string.IsNullOrEmpty(id))
            {
                HoaDonXuatHang? hd2 = LuuTruHoaDonXuatHang.DocHoaDon(id);
                if (hd2 != null)
                {
                    hd = hd2.Value;
                }
                CoHD = hd2 != null;
                if (!CoHD)
                {
                    Chuoi = "Không tồn tại hóa đơn!";
                }
            }
        }
        public void OnPost()
        {
        }
    }
}
