using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLyCuaHang_21880159.Entities
{
    public struct HoaDonXuatHang
    {
        public string MaHoaDon;
        public List<SanPhamHoaDon> DSSP;
        public DateTime NgayLap;
        public int TongTien;
    }
}
