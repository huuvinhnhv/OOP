using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using QuanLyCuaHang_21880159.DAL;
using QuanLyCuaHang_21880159.Entities;

namespace QuanLyCuaHang_21880159.Service
{
    public class XuLyThongKe
    {
        public static List<SanPham> ThongKeSanPhamHetHang()
        {
            List<SanPham> kq = new List<SanPham>();

            List<SanPham> dssp = LuuTruSanPham.DocDSSanPham();
            foreach (var sp in dssp)
            {
                DateTime ngayhethan = sp.NgaySanXuat.AddMonths(sp.HanSuDung);
                int kqss = DateTime.Compare(ngayhethan, DateTime.Now);
                if (kqss < 0)
                {
                    kq.Add(sp);
                }
            }
            return kq;
        }
        public static Dictionary<LoaiHang, int> ThongKeTheoLoai(string keyword)
        {
            Dictionary<LoaiHang, int> kq = new Dictionary<LoaiHang, int>();
            List<SanPham> dssp = LuuTruSanPham.DocDSSanPham();
            List<LoaiHang> dslh = LuuTruLoaiHang.DocDSLoaiHang();
            foreach (var lh in dslh)
            {
                kq.Add(lh, 0);
            }

            foreach (var item in kq.ToList())
            {
                int tong = 0;
                foreach (var sp in dssp)
                {
                    if (item.Key.MaLoaiHang == sp.MaLoaiHang)
                    {
                        tong += sp.SoLuong;
                    }
                }
                kq[item.Key] = tong;
            }
            if (string.IsNullOrEmpty(keyword))
            {
                return kq;
            }
            Dictionary<LoaiHang, int> kq2 = new Dictionary<LoaiHang, int>();
            foreach (var k in kq)
            {
                if (k.Key.Equals(keyword))
                {
                    kq2.Add(k.Key, k.Value);
                    break;
                }
            }
            return kq2;
        }
    }
}
