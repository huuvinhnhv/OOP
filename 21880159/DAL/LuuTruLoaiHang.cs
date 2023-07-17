using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

using Newtonsoft.Json;

using QuanLyCuaHang_21880159.Entities;

namespace QuanLyCuaHang_21880159.DAL
{
    public class LuuTruLoaiHang
    {
        public static bool LuuLoaiHang(LoaiHang lh)
        {
            List<LoaiHang> dslh = DocDSLoaiHang();
            dslh.Add(lh);
            return LuuDSLoaiHang(dslh);
        }
        public static List<LoaiHang> DocDSLoaiHang()
        {
            StreamReader reader = new StreamReader("danhsachloaihang.json");
            List<LoaiHang> dslh = new List<LoaiHang>();
            try
            {
                string stringJson = reader.ReadToEnd();
                dslh = JsonConvert.DeserializeObject<List<LoaiHang>>(stringJson);
            }
            catch (Exception e)
            {

                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                reader.Close();
            }
            return dslh;
        }
        public static bool LuuDSLoaiHang(List<LoaiHang> dslh)
        {
            StreamWriter writer = new StreamWriter("danhsachloaihang.json");
            try
            {
                string stringJson = JsonConvert.SerializeObject(dslh);
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
