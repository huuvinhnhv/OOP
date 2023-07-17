using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using QuanLyCuaHang_21880159.DAL;
using QuanLyCuaHang_21880159.Entities;

namespace QuanLyCuaHang_21880159.Service
{
    public class XuLyLoaiHang
    {
        private static List<LoaiHang> dslh = new List<LoaiHang>();
        public static string TaoLoaiHang(LoaiHang lh)
        {
            dslh = LuuTruLoaiHang.DocDSLoaiHang();
            if (string.IsNullOrWhiteSpace(lh.MaLoaiHang) ||
                string.IsNullOrWhiteSpace(lh.TenLoaiHang))
            {
                return "Không được đễ trống trường nào!";
            }
            if (KiemTraTonTaiLoaiHang(lh.MaLoaiHang))
            {
                Console.WriteLine(lh.MaLoaiHang);
                return $"Mã loại hàng {lh.MaLoaiHang} đã tồn tại!";
            }
            if (LuuTruLoaiHang.LuuLoaiHang(lh))
            {
                return "Tạo sản phẩm thành công!";
            }
            return "Tạo sản phẩm không thành công!";
        }

        public static string XoaLoaiHang(string id)
        {
            dslh = LuuTruLoaiHang.DocDSLoaiHang();
            for (int i = 0; i < dslh.Count; i++)
            {
                if (dslh[i].MaLoaiHang.Equals(id))
                {
                    dslh.Remove(dslh[i]);
                    break;
                }
            }
            List<SanPham> dssp = LuuTruSanPham.DocDSSanPham();
            for (int i = 0; i < dssp.Count; i++)
            {
                if (dssp[i].MaLoaiHang.Equals(id))
                {
                    dssp.Remove(dssp[i]);
                }
            }

            if (LuuTruLoaiHang.LuuDSLoaiHang(dslh) &&
                LuuTruSanPham.LuuDSSanPham(dssp))
            {
                return "Xóa loại hàng thành công!";
            }
            return "Xóa loại hàng không thành công!";
        }

        public static LoaiHang DocLoaiHang(string id)
        {
            dslh = LuuTruLoaiHang.DocDSLoaiHang();

            if (string.IsNullOrEmpty(id))
            {
                return null;
            }
            foreach (var item in dslh)
            {
                if (item.MaLoaiHang.Equals(id))
                {
                    return item;
                }
            }
            return null;
        }

        internal static string SuaLoaiHang(LoaiHang lh)
        {
            if (string.IsNullOrWhiteSpace(lh.MaLoaiHang) ||
                string.IsNullOrWhiteSpace(lh.TenLoaiHang))
            {
                return "Không được đễ trống trường nào!";
            }

            dslh = LuuTruLoaiHang.DocDSLoaiHang();
            for (int i = 0; i < dslh.Count; i++)
            {
                if (dslh[i].MaLoaiHang.Equals(lh.MaLoaiHang))
                {
                    dslh[i] = lh;
                    break;
                }
            }

            if (LuuTruLoaiHang.LuuDSLoaiHang(dslh))
            {
                return "Sửa sản phẩm thành công!";
            }
            return "Sửa sản phẩm không thành công!";

        }

        internal static List<LoaiHang> TimKiem(int searchOptions, string keyword)
        {
            dslh = LuuTruLoaiHang.DocDSLoaiHang();
            List<LoaiHang> kq = new List<LoaiHang>();
            if (string.IsNullOrEmpty(keyword))
            {
                return dslh;
            }
            switch (searchOptions)
            {
                //tim theo ma loai hang
                case 1:
                    for (int i = 0; i < dslh.Count; i++)
                    {
                        if (dslh[i].MaLoaiHang.Equals(keyword))
                        {
                            kq.Add(dslh[i]);
                            break;
                        }
                    }
                    break;
                case 2:
                    for (int i = 0; i < dslh.Count; i++)
                    {
                        if (dslh[i].TenLoaiHang.ToLower().Contains(keyword.ToLower()))
                        {
                            kq.Add(dslh[i]);
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
