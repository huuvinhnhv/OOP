using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using QuanLyCuaHang_21880159.DAL;
using QuanLyCuaHang_21880159.Entities;

namespace QuanLyCuaHang_21880159.Service
{
    public class XuLyHoaDonNhapHang
    {
        public static string TaoHoaDon(List<SanPhamHoaDon> dssp)
        {
            XuLySanPham XuLySanPham = new XuLySanPham();
            List<HoaDonNhapHang> dshd = LuuTruHoaDonNhapHang.DocDSHoaDon();
            HoaDonNhapHang hd = new HoaDonNhapHang();
            hd.MaHoaDon = "HDNH" + (dshd.Count);
            hd.NgayLap = DateTime.Now;
            hd.DSSP = dssp;
            hd.TongTien = LayTongTienHoaDon(dssp);
            LuuTruHoaDonNhapHang.LuuHoaDon(hd);
            XuLySanPham.CapNhatSoLuongNhapHang(dssp);
            return "Tạo hóa đơn thành công!";
        }
        public static int LayTongTienHoaDon(List<SanPhamHoaDon> dssp)
        {
            int tong = 0;
            foreach (var item in dssp)
            {
                tong += item.ThanhTien;
            }
            return tong;
        }

        public static List<HoaDonNhapHang> TimKiem(string Keyword)
        {
            List<HoaDonNhapHang> dshd = LuuTruHoaDonNhapHang.DocDSHoaDon();
            List<HoaDonNhapHang> kq = new List<HoaDonNhapHang>();
            if (string.IsNullOrEmpty(Keyword))
            {
                return dshd;
            }
            foreach (var hd in dshd)
            {
                if (hd.MaHoaDon.Equals(Keyword))
                {
                    kq.Add(hd);
                    break;
                }
            }
            return kq;
        }


        internal static bool XoaSanPham(string maHoaDon, int sTT)
        {
            HoaDonNhapHang? hd = LuuTruHoaDonNhapHang.DocHoaDon(maHoaDon);
            HoaDonNhapHang hd2;
            if (hd != null)
            {
                hd2 = hd.Value;
                for (int i = 0; i < hd2.DSSP.Count; i++)
                {
                    if (hd2.DSSP[i].STT == sTT)
                    {
                        hd2.DSSP.RemoveAt(i);
                    }
                }
                for (int i = 0; i < hd2.DSSP.Count; i++)
                {
                    SanPhamHoaDon sp = hd2.DSSP[i];
                    sp.STT = i;
                    hd2.DSSP[i] = sp;
                }
                List<HoaDonNhapHang> dshd = LuuTruHoaDonNhapHang.DocDSHoaDon();
                for (int i = 0; i < dshd.Count; i++)
                {
                    if (dshd[i].MaHoaDon.Equals(maHoaDon))
                    {
                        dshd.Remove(dshd[i]);
                    }
                }
                LuuTruHoaDonNhapHang.LuuDSHoaDon(dshd);
                return LuuTruHoaDonNhapHang.LuuHoaDon(hd2);
            }
            return false;
        }

        public static bool SuaNgayHoaDon(string newDate, string maHoaDon)
        {
            DateTime date;
            try
            {
                date = DateTime.Parse(newDate);
                HoaDonNhapHang? hd = LuuTruHoaDonNhapHang.DocHoaDon(maHoaDon);
                HoaDonNhapHang hd2;
                if (hd != null)
                {
                    hd2 = hd.Value;
                    hd2.NgayLap = date;
                    List<HoaDonNhapHang> dshd = LuuTruHoaDonNhapHang.DocDSHoaDon();
                    for (int i = 0; i < dshd.Count; i++)
                    {
                        if (dshd[i].MaHoaDon.Equals(maHoaDon))
                        {
                            dshd.Remove(dshd[i]);
                        }
                    }
                    LuuTruHoaDonNhapHang.LuuDSHoaDon(dshd);
                    return LuuTruHoaDonNhapHang.LuuHoaDon(hd2);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return false;
        }

        internal static bool XoaHD(string maHoaDon)
        {
            List<HoaDonNhapHang> dshd = LuuTruHoaDonNhapHang.DocDSHoaDon();
            for (int i = 0; i < dshd.Count; i++)
            {
                if (dshd[i].MaHoaDon.Equals(maHoaDon))
                {
                    dshd.Remove(dshd[i]);
                    break;
                }
            }
            return LuuTruHoaDonNhapHang.LuuDSHoaDon(dshd);
        }
    }
}
