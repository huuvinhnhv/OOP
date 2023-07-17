using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyCuaHang_21880159.Entities
{
    public class ResponseData
    {
        public string Message { get; set; }
        public bool Status { get; set; }

        public ResponseData()
        {
            Message = string.Empty;
            Status = false;
        }
    }
}
