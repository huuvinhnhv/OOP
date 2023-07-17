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
    public class MH_XoaSanPhamModel : PageModel
    {
        public string Chuoi;
        public bool CoSanPham;
        public SanPham SanPham;

        [BindProperty(SupportsGet = true)]
        public string Id { get; set; }

        public void OnGet()
        {
        //    SanPham? sp = XuLySanPham.DocSanPham(Id);
        //    if (sp != null)
        //    {
        //        SanPham = sp.Value;
        //    }
        //    else
        //    {
        //        Chuoi = "Không tim thấy sản phẩm!";
        //    }
        //    CoSanPham = sp != null;
        //}
        //public void OnPost()
        //{
        //    Chuoi = XuLySanPham.XoaSanPham(Id);
        //    Response.Redirect("/MH_SanPham/MH_TimKiemSanPham");
        }
    }
}
