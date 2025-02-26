using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuong2_Bai3
{
    enum CapBacNhanVien
    {
        Intern = 1,
        Junior = 2,
        Mid = 3,
        Senior = 4,
        Lead = 5
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            NhanVien nv1 = new NhanVien("Nguyễn Hữu Quân", CapBacNhanVien.Mid, 2000);
            NhanVien nv2 = new NhanVien("Lê Thị Diệu Nhi", CapBacNhanVien.Senior, 4000);

            nv1.HienThiThongTin();
            nv2.HienThiThongTin();

            Console.WriteLine($"Lương của {nv1.Ten}: {nv1.TinhLuong()} USD");

            Console.WriteLine($"Lương của {nv2.Ten} (hệ số thưởng 1.2): {nv2.TinhLuong(1.2)} USD");
            Console.ReadKey();
        }
    }
}
