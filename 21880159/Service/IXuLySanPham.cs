using QuanLyCuaHang_21880159.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyCuaHang_21880159.Service
{
    public interface IXuLySanPham
    {
        public string TaoSanPham(SanPham s);
        public void CapNhatSoLuongNhapHang(List<SanPhamHoaDon> dssp);
        public  void CapNhatSoLuongXuatHang(List<SanPhamHoaDon> dssp);
        public string XoaSanPham(string id);
        public  string SuaSanPham(SanPham s);
        public SanPham DocSanPham(string id);
        public  bool KiemTraTonTaiMaSanPham(string masp);
        public List<SanPham> TimKiem(int searchOptions, string keyword);
    }
}
