using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLyCuaHang_21880159.Entities
{
    public class LoaiHang
    {
        public string MaLoaiHang { get; set; }
        public string TenLoaiHang { get; set; }

        public LoaiHang(string maLoaiHang, string tenLoaiHang)
        {
            MaLoaiHang = maLoaiHang;
            TenLoaiHang = tenLoaiHang;
        }
    }
}
