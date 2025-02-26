using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuong2_Bai3
{
    internal class NhanVien
    {
        public string Ten { get; set; }
        public CapBacNhanVien CapBac { get; set; }
        public double LuongCoBan { get; set; }

        public NhanVien(string ten, CapBacNhanVien capBac, double luongCoBan)
        {
            Ten = ten;
            CapBac = capBac;
            LuongCoBan = luongCoBan;
        }

        public double TinhLuong(double heSoThuong = 1.0)
        {
            return LuongCoBan * heSoThuong;
        }

        public void HienThiThongTin()
        {
            Console.WriteLine($"Tên: {Ten}, Cấp bậc: {CapBac}, Lương cơ bản: {LuongCoBan} USD");
        }
    }
}
