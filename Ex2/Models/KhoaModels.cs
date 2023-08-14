using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ex2.Models
{
    public class KhoaModels
    {
        public string TenKhoa { get; set; }
        public int NamThanhLap { get; set; }
        public string Message { get; set; }

        public KhoaModels()
        {
            TenKhoa = "Khoa Công Nghệ Thông Tin";
            NamThanhLap = 2003;
            Message = "Chào Mừng các bạn tới với FIT-HUIT";
        }

    }
}
