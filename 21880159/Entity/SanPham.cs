using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLyCuaHang_21880159.Entities
{
    public class SanPham
    {
        public string TenSanPham { get; set; }
        public string MaSanPham { get; set; }
        public int HanSuDung { get; set; }
        public string CtySanXuat { get; set; }
        public DateTime NgaySanXuat { get; set; }
        public string MaLoaiHang { get; set; }
        public int GiaSanPham { get; set; }
        public int SoLuong { get; set; }
        public SanPham() { }
        public SanPham(string tenSanPham, string maSanPham, int hanSuDung, string ctySanXuat, DateTime ngaySanXuat, string maLoaiHang, int giaSanPham, int soLuong)
        {
            TenSanPham = tenSanPham;
            MaSanPham = maSanPham;
            HanSuDung = hanSuDung;
            CtySanXuat = ctySanXuat;
            NgaySanXuat = ngaySanXuat;
            MaLoaiHang = maLoaiHang;
            GiaSanPham = giaSanPham;
            SoLuong = soLuong;
        }
    }
}
