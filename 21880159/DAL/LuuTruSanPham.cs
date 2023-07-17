using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

using Newtonsoft.Json;

using QuanLyCuaHang_21880159.Entities;

namespace QuanLyCuaHang_21880159.DAL
{
    public class LuuTruSanPham
    {
        public static bool LuuSanPham(SanPham s)
        {
            List<SanPham> dssp = DocDSSanPham();
            dssp.Add(s);
            return LuuDSSanPham(dssp);
        }
        public static List<SanPham> DocDSSanPham()
        {
            StreamReader reader = new StreamReader("danhsachsanpham.json");
            List<SanPham> dssp = new List<SanPham>();
            try
            {
                string stringJson = reader.ReadToEnd();
                dssp = JsonConvert.DeserializeObject<List<SanPham>>(stringJson);
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
        public static bool LuuDSSanPham(List<SanPham> dssp)
        {
            StreamWriter writer = new StreamWriter("danhsachsanpham.json");
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
    }
}
