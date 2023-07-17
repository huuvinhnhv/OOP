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
    public class MH_SuaHoaDonModel : PageModel
    {
        public bool CoHoaDon;
        [BindProperty]
        public string MaHoaDon { get; set; }
        [BindProperty]
        public int STT { get; set; }
        [BindProperty]
        public int SoLuong { get; set; }
        public string Chuoi;
        public string Chuoi2;
        public string Chuoi3;
        public string Chuoi4;
        [BindProperty(SupportsGet = true)]
        public string id { get; set; }
        public HoaDonNhapHang hd;
        [BindProperty]
        public string NewDate { get; set; }
        public void OnGet()
        {
            Chuoi = string.Empty;
            HoaDonNhapHang? hd2 = LuuTruHoaDonNhapHang.DocHoaDon(id);
            if (hd2 != null)
            {
                hd = hd2.Value;
            }
            CoHoaDon = hd2 != null;
            if (!CoHoaDon)
            {
                Chuoi = "Không tìm thấy hóa đơn!";
            }
        }

        public void OnPostRemove()
        {
            //bool kq = XuLyHoaDonNhapHang.XoaSanPham(MaHoaDon, STT);
            //if (kq)
            //{
            //    Chuoi2 = "Xóa sản phẩm thành công!";
            //}
            //else
            //{
            //    Chuoi2 = "Xóa sản phẩm không thành công!";
            //}
            //HoaDonNhapHang? hd2 = LuuTruHoaDonNhapHang.DocHoaDon(MaHoaDon);
            //if (hd2 != null)
            //{
            //    hd = hd2.Value;
            //}
            //CoHoaDon = hd2 != null;
            //if (!CoHoaDon)
            //{
            //    Chuoi2 = "Không tìm thấy hóa đơn!";
            //}
        }
        public void OnPostDateEdit()
        {
            bool kq = XuLyHoaDonNhapHang.SuaNgayHoaDon(NewDate, MaHoaDon);
            if (kq)
            {
                Chuoi3 = "Sửa ngày thành công!";
            }
            else
            {
                Chuoi3 = "Sửa ngày không thành công!";
            }
            HoaDonNhapHang? hd2 = LuuTruHoaDonNhapHang.DocHoaDon(MaHoaDon);
            if (hd2 != null)
            {
                hd = hd2.Value;
            }
            CoHoaDon = hd2 != null;
            if (!CoHoaDon)
            {
                Chuoi3 = "Không tìm thấy hóa đơn!";
            }
        }
    }
}
