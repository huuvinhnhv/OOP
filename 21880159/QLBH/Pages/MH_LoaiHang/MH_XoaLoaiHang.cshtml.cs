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
    public class MH_XoaLoaiHangModel : PageModel
    {
        public string Chuoi;
        public bool CoLoaiHang;
        public LoaiHang LoaiHang;

        [BindProperty(SupportsGet = true)]
        public string Id { get; set; }

        public void OnGet()
        {
            //LoaiHang? lh = XuLyLoaiHang.DocLoaiHang(Id);
            //if (lh != null)
            //{
            //    LoaiHang = lh.Value;
            //}
            //else
            //{
            //    Chuoi = "Không tim thấy loại hàng!";
            //}
            //CoLoaiHang = lh != null;
        }
        public void OnPost()
        {
            Chuoi = XuLyLoaiHang.XoaLoaiHang(Id);
            Response.Redirect("/MH_LoaiHang/MH_TimKiemLoaiHang");
        }
    }
}
