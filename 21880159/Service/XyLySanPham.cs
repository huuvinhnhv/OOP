using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using QuanLyCuaHang_21880159.Entities;
using QuanLyCuaHang_21880159.DAL;

namespace QuanLyCuaHang_21880159.Service
{
    public class XuLySanPham:IXuLySanPham
    {
        private static List<SanPham> dssp = new List<SanPham>();
        private static List<LoaiHang> dslh = new List<LoaiHang>();
        public string TaoSanPham(SanPham s)
        {
            dssp = LuuTruSanPham.DocDSSanPham();
            dslh = LuuTruLoaiHang.DocDSLoaiHang();
            if (string.IsNullOrWhiteSpace(s.MaSanPham) ||
            string.IsNullOrWhiteSpace(s.TenSanPham) ||
            string.IsNullOrWhiteSpace(s.CtySanXuat) ||
            string.IsNullOrWhiteSpace(s.MaLoaiHang) ||
            string.IsNullOrWhiteSpace(s.MaLoaiHang))
            {
                return "Không được đễ trống trường nào!";
            }
            if (KiemTraTonTaiMaSanPham(s.MaSanPham))
            {
                return $"Mã sản phẩm {s.MaSanPham} đã tồn tại!";
            }
            if (s.NgaySanXuat.CompareTo(DateTime.Now) > 0 ? true : false)
            {
                return $"Ngày sản xuất không thể lớn hơn ngày hiện tại!";
            }
            if (s.HanSuDung <= 0)
            {
                return $"Hạn sử dụng không thể âm!";
            }

            if (!KiemTraTonTaiLoaiHang(s.MaLoaiHang))
            {
                return $"Mã loại hàng {s.MaLoaiHang} không tồn tại!";
            }
            if (s.GiaSanPham <= 0)
            {
                return $"Giá sản phẩm không thể âm!";
            }
            if (LuuTruSanPham.LuuSanPham(s))
            {
                return "Tạo sản phẩm thành công!";
            }
            return "Tạo sản phẩm không thành công!";
        }

        public void CapNhatSoLuongNhapHang(List<SanPhamHoaDon> dssp)
        {
            List<SanPham> dssp2 = LuuTruSanPham.DocDSSanPham();
            foreach (var sp in dssp)
            {
                for (int i = 0; i < dssp2.Count; i++)
                {
                    if (sp.MaSanPham.Equals(dssp2[i].MaSanPham))
                    {
                        SanPham sp2 = dssp2[i];
                        sp2.SoLuong = sp.SoLuong;
                        dssp2[i] = sp2;
                    }
                }
            }
            LuuTruSanPham.LuuDSSanPham(dssp2);
        }
        public void CapNhatSoLuongXuatHang(List<SanPhamHoaDon> dssp)
        {
            List<SanPham> dssp2 = LuuTruSanPham.DocDSSanPham();
            foreach (var sp in dssp)
            {
                for (int i = 0; i < dssp2.Count; i++)
                {
                    if (sp.MaSanPham.Equals(dssp2[i].MaSanPham))
                    {
                        SanPham sp2 = dssp2[i];
                        sp2.SoLuong = sp2.SoLuong - sp.SoLuong;
                        dssp2[i] = sp2;
                    }
                }
            }
            LuuTruSanPham.LuuDSSanPham(dssp2);
        }
        public string XoaSanPham(string id)
        {
            dssp = LuuTruSanPham.DocDSSanPham();
            for (int i = 0; i < dssp.Count; i++)
            {
                if (dssp[i].MaSanPham.Equals(id))
                {
                    dssp.Remove(dssp[i]);
                    break;
                }
            }
            if (LuuTruSanPham.LuuDSSanPham(dssp))
            {
                return "Xóa sản phẩm thành công!";
            }
            return "Xóa sản phẩm không thành công!";
        }

        public string SuaSanPham(SanPham s)
        {
            if (string.IsNullOrWhiteSpace(s.MaSanPham) ||
            string.IsNullOrWhiteSpace(s.TenSanPham) ||
            string.IsNullOrWhiteSpace(s.CtySanXuat) ||
            string.IsNullOrWhiteSpace(s.MaLoaiHang) ||
            string.IsNullOrWhiteSpace(s.MaLoaiHang))
            {
                return "Không được đễ trống trường nào!";
            }

            if (s.NgaySanXuat.CompareTo(DateTime.Now) > 0 ? true : false)
            {
                return $"Ngày sản xuất không thể lớn hơn ngày hiện tại!";
            }
            if (s.HanSuDung <= 0)
            {
                return $"Hạn sử dụng không thể âm!";
            }
            if (s.GiaSanPham <= 0)
            {
                return $"Giá sản phẩm không thể âm!";
            }


            dssp = LuuTruSanPham.DocDSSanPham();
            for (int i = 0; i < dssp.Count; i++)
            {
                if (dssp[i].MaSanPham.Equals(s.MaSanPham))
                {
                    dssp[i] = s;
                    break;
                }
            }

            if (LuuTruSanPham.LuuDSSanPham(dssp))
            {
                return "Sửa sản phẩm thành công!";
            }
            return "Sửa sản phẩm không thành công!";
        }

        public SanPham DocSanPham(string id)
        {
            dssp = LuuTruSanPham.DocDSSanPham();

            if (string.IsNullOrEmpty(id))
            {
                return null;
            }
            foreach (var item in dssp)
            {
                if (item.MaSanPham.Equals(id))
                {
                    return item;
                }
            }
            return null;
        }

        public bool KiemTraTonTaiMaSanPham(string masp)
        {
            foreach (var item in dssp)
            {
                if (item.MaSanPham.Equals(masp))
                {
                    return true;
                }
            }
            return false;
        }
        public List<SanPham> TimKiem(int searchOptions, string keyword)
        {
            dssp = LuuTruSanPham.DocDSSanPham();
            List<SanPham> kq = new List<SanPham>();
            if (string.IsNullOrEmpty(keyword))
            {
                return dssp;
            }
            switch (searchOptions)
            {
                //tim theo ma san pham
                case 1:
                    for (int i = 0; i < dssp.Count; i++)
                    {
                        if (dssp[i].MaSanPham.Equals(keyword))
                        {
                            kq.Add(dssp[i]);
                            break;
                        }
                    }
                    break;
                case 2:
                    for (int i = 0; i < dssp.Count; i++)
                    {
                        if (dssp[i].TenSanPham.ToLower().Contains(keyword.ToLower()))
                        {
                            kq.Add(dssp[i]);
                        }
                    }
                    break;
            }
            return kq;
        }
        private static bool KiemTraTonTaiLoaiHang(string malh)
        {
            foreach (var item in dslh)
            {
                if (item.MaLoaiHang.Equals(malh))
                {
                    Console.WriteLine(item.MaLoaiHang);
                    return true;
                }
            }
            return false;
        }
    }
}
