using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

using Newtonsoft.Json;

using QuanLyCuaHang_21880159.Entities;

namespace QuanLyCuaHang_21880159.DAL
{
    public class LuuTruHoaDonXuatHang
    {
        public static bool LuuSPXuatHang(SanPhamHoaDon sp)
        {
            List<SanPhamHoaDon> dssp = DocDSSPXuatHang();
            dssp.Add(sp);
            return LuuDSSPXuatHang(dssp);
        }

        public static List<SanPhamHoaDon> DocDSSPXuatHang()
        {
            StreamReader reader = new StreamReader("danhsachsanphamxuathangtemp.json");
            List<SanPhamHoaDon> dssp = new List<SanPhamHoaDon>();
            try
            {
                string stringJson = reader.ReadToEnd();
                dssp = JsonConvert.DeserializeObject<List<SanPhamHoaDon>>(stringJson);
            }
            catch (Exception e)
            {

                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                reader.Close();
            }
            return dssp;
        }

        public static bool LuuDSSPXuatHang(List<SanPhamHoaDon> dssp)
        {
            StreamWriter writer = new StreamWriter("danhsachsanphamxuathangtemp.json");
            try
            {
                string stringJson = JsonConvert.SerializeObject(dssp);
                writer.Write(stringJson);
                return true;
            }
            catch (Exception e)
            {

                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                writer.Close();

            }
            return false;
        }

        public static bool LuuHoaDon(HoaDonXuatHang hd)
        {
            List<HoaDonXuatHang> dshd = DocDSHoaDon();
            dshd.Add(hd);
            return LuuDSHoaDon(dshd);
        }

        public static bool LuuDSHoaDon(List<HoaDonXuatHang> dshd)
        {
            StreamWriter writer = new StreamWriter("danhsachhoadonxuathang.json");
            try
            {
                string stringJson = JsonConvert.SerializeObject(dshd);
                writer.Write(stringJson);
                return true;
            }
            catch (Exception e)
            {

                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                writer.Close();

            }
            return false;
        }

        public static bool XoaDanhSachSPXuatHang()
        {
            StreamWriter writer = new StreamWriter("danhsachsanphamxuathangtemp.json");
            try
            {
                string stringJson = "[]";
                writer.WriteLine(stringJson);
                return true;
            }
            catch (Exception e)
            {

                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                writer.Close();

            }
            return false;
        }

        public static HoaDonXuatHang? DocHoaDon(string id)
        {
            List<HoaDonXuatHang> dshd = DocDSHoaDon();
            foreach (var hd in dshd)
            {
                if (hd.MaHoaDon.Equals(id))
                {
                    return hd;
                }
            }
            return null;
        }

        public static List<HoaDonXuatHang> DocDSHoaDon()
        {
            StreamReader reader = new StreamReader("danhsachhoadonxuathang.json");
            List<HoaDonXuatHang> dshd = new List<HoaDonXuatHang>();
            try
            {
                string stringJson = reader.ReadToEnd();
                dshd = JsonConvert.DeserializeObject<List<HoaDonXuatHang>>(stringJson);
            }
            catch (Exception e)
            {

                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                reader.Close();
            }
            return dshd;
        }
    }
}
