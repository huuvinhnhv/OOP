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
    public class MH_SuaLoaiHangModel : PageModel
    {
        public string Chuoi;
        public bool CoLoaiHang;
        public LoaiHang LoaiHang;
        [BindProperty(SupportsGet = true)]
        public string Id { get; set; }

        public string MaLoaiHang { get; set; }
        [BindProperty]
        public string TenLoaiHang { get; set; }

        public void OnGet()
        {
            //Chuoi = string.Empty;
            //LoaiHang? lh = XuLyLoaiHang.DocLoaiHang(Id);
            //if (lh != null)
            //{
            //    LoaiHang = lh.Value;
            //}
            //else
            //{
            //    Chuoi = "Không tìm thấy loại hàng!";
            //}
            //CoLoaiHang = lh != null;
        }
        public void OnPost()
        {
            //LoaiHang lh;
            //lh.MaLoaiHang = Id;
            //lh.TenLoaiHang = TenLoaiHang;
            //Chuoi = XuLyLoaiHang.SuaLoaiHang(lh);
            //Response.Redirect("/MH_LoaiHang/MH_TimKiemLoaiHang");
        }
    }
}
