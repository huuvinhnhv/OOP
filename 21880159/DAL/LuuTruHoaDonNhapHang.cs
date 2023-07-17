using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

using Newtonsoft.Json;

using QuanLyCuaHang_21880159.Entities;

namespace QuanLyCuaHang_21880159.DAL
{
    public class LuuTruHoaDonNhapHang
    {
        public static bool LuuSPNhapHang(SanPhamHoaDon sp)
        {
            List<SanPhamHoaDon> dssp = DocDSSPNhapHang();
            dssp.Add(sp);
            return LuuDSSPNhapHang(dssp);
        }

        public static List<SanPhamHoaDon> DocDSSPNhapHang()
        {
            StreamReader reader = new StreamReader("danhsachsanphamnhaphangtemp.json");
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

        public static bool LuuDSSPNhapHang(List<SanPhamHoaDon> dssp)
        {
            StreamWriter writer = new StreamWriter("danhsachsanphamnhaphangtemp.json");
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

        public static bool LuuHoaDon(HoaDonNhapHang hd)
        {
            List<HoaDonNhapHang> dshd = DocDSHoaDon();
            dshd.Add(hd);
            return LuuDSHoaDon(dshd);
        }

        public static bool LuuDSHoaDon(List<HoaDonNhapHang> dshd)
        {
            StreamWriter writer = new StreamWriter("danhsachhoadonnhaphang.json");
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

        public static bool XoaDanhSachSPNhapHang()
        {
            StreamWriter writer = new StreamWriter("danhsachsanphamnhaphangtemp.json");
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

        public static HoaDonNhapHang? DocHoaDon(string id)
        {
            List<HoaDonNhapHang> dshd = DocDSHoaDon();
            foreach (var hd in dshd)
            {
                if (hd.MaHoaDon.Equals(id))
                {
                    return hd;
                }
            }
            return null;
        }

        public static List<HoaDonNhapHang> DocDSHoaDon()
        {
            StreamReader reader = new StreamReader("danhsachhoadonnhaphang.json");
            List<HoaDonNhapHang> dshd = new List<HoaDonNhapHang>();
            try
            {
                string stringJson = reader.ReadToEnd();
                dshd = JsonConvert.DeserializeObject<List<HoaDonNhapHang>>(stringJson);
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
