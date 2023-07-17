using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using QuanLyCuaHang_21880159.DAL;
using QuanLyCuaHang_21880159.Entities;

namespace QuanLyCuaHang_21880159.Service
{
    public class XuLyHoaDonXuatHang
    {
        public static string TaoHoaDon(List<SanPhamHoaDon> dssp)
        {
            XuLySanPham XuLySanPham = new XuLySanPham();
            List<HoaDonXuatHang> dshd = LuuTruHoaDonXuatHang.DocDSHoaDon();
            HoaDonXuatHang hd = new HoaDonXuatHang();
            hd.MaHoaDon = "HDXH" + (dshd.Count);
            hd.NgayLap = DateTime.Now;
            hd.DSSP = dssp;
            hd.TongTien = LayTongTienHoaDon(dssp);
            LuuTruHoaDonXuatHang.LuuHoaDon(hd);
            XuLySanPham.CapNhatSoLuongXuatHang(dssp);
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

        public static List<HoaDonXuatHang> TimKiem(string Keyword)
        {
            List<HoaDonXuatHang> dshd = LuuTruHoaDonXuatHang.DocDSHoaDon();
            List<HoaDonXuatHang> kq = new List<HoaDonXuatHang>();
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


        public static bool XoaSanPham(string maHoaDon, int sTT)
        {
            HoaDonXuatHang? hd = LuuTruHoaDonXuatHang.DocHoaDon(maHoaDon);
            HoaDonXuatHang hd2;
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
                List<HoaDonXuatHang> dshd = LuuTruHoaDonXuatHang.DocDSHoaDon();
                for (int i = 0; i < dshd.Count; i++)
                {
                    if (dshd[i].MaHoaDon.Equals(maHoaDon))
                    {
                        dshd.Remove(dshd[i]);
                    }
                }
                LuuTruHoaDonXuatHang.LuuDSHoaDon(dshd);
                return LuuTruHoaDonXuatHang.LuuHoaDon(hd2);
            }
            return false;
        }

        public static bool SuaNgayHoaDon(string newDate, string maHoaDon)
        {
            DateTime date;
            try
            {
                date = DateTime.Parse(newDate);
                HoaDonXuatHang? hd = LuuTruHoaDonXuatHang.DocHoaDon(maHoaDon);
                HoaDonXuatHang hd2;
                if (hd != null)
                {
                    hd2 = hd.Value;
                    hd2.NgayLap = date;
                    List<HoaDonXuatHang> dshd = LuuTruHoaDonXuatHang.DocDSHoaDon();
                    for (int i = 0; i < dshd.Count; i++)
                    {
                        if (dshd[i].MaHoaDon.Equals(maHoaDon))
                        {
                            dshd.Remove(dshd[i]);
                        }
                    }
                    LuuTruHoaDonXuatHang.LuuDSHoaDon(dshd);
                    return LuuTruHoaDonXuatHang.LuuHoaDon(hd2);
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
            List<HoaDonXuatHang> dshd = LuuTruHoaDonXuatHang.DocDSHoaDon();
            for (int i = 0; i < dshd.Count; i++)
            {
                if (dshd[i].MaHoaDon.Equals(maHoaDon))
                {
                    dshd.Remove(dshd[i]);
                    break;
                }
            }
            return LuuTruHoaDonXuatHang.LuuDSHoaDon(dshd);
        }
    }
}
