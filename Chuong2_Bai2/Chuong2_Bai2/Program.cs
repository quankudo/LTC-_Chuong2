using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuong2_Bai2
{
    internal class Program
    {
        enum CapBacNhanVien
        {
            Intern = 1,  
            Junior = 2, 
            Mid = 3,    
            Senior = 4, 
            Lead = 5   
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Danh sách cấp bậc nhân viên:");
            foreach (CapBacNhanVien capBac in Enum.GetValues(typeof(CapBacNhanVien)))
            {
                Console.WriteLine($"{(int)capBac} - {capBac}");
            }

            Console.Write("\nNhập số cấp bậc (1-5): ");
            if (int.TryParse(Console.ReadLine(), out int soNhap))
            {
                if (Enum.IsDefined(typeof(CapBacNhanVien), soNhap))
                {
                    CapBacNhanVien capBacTimThay = (CapBacNhanVien)soNhap;
                    Console.WriteLine($"Cấp bậc tương ứng: {capBacTimThay}");
                }
                else
                {
                    Console.WriteLine("Không có cấp bậc nào phù hợp!");
                }
            }
            else
            {
                Console.WriteLine("Vui lòng nhập một số hợp lệ!");
            }

            Console.Write("\nNhập tên cấp bậc (Intern, Junior, Mid, Senior, Lead): ");
            string chuoiNhap = Console.ReadLine();

            if (Enum.TryParse(chuoiNhap, true, out CapBacNhanVien capBacTuChuoi))
            {
                Console.WriteLine($"Chuỗi \"{chuoiNhap}\" tương ứng với cấp bậc: {capBacTuChuoi} ({(int)capBacTuChuoi})");
            }
            else
            {
                Console.WriteLine("Tên cấp bậc không hợp lệ!");
            }
            Console.ReadKey();
        }
    }
}
