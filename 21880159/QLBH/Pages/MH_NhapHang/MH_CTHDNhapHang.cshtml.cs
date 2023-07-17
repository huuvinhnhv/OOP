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
    public class MH_CTHDNhapHangModel : PageModel
    {
        public HoaDonNhapHang hd;
        public bool CoHD;
        public string Chuoi;
        [BindProperty(SupportsGet = true)]
        public string id { get; set; }
        public void OnGet()
        {
            Chuoi = string.Empty;
            List<HoaDonNhapHang> dshd = LuuTruHoaDonNhapHang.DocDSHoaDon();
            hd = dshd[dshd.Count - 1];
            CoHD = true;
            if (!string.IsNullOrEmpty(id))
            {
                HoaDonNhapHang? hd2 = LuuTruHoaDonNhapHang.DocHoaDon(id);
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
