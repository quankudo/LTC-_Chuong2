using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuong2_Bai1
{
    internal class Program
    {
        static int TinhTong(int a, int b = 10)
        {
            return a + b;
        }

        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Tổng của 5 và 7: " + TinhTong(5, 7));

            Console.WriteLine("Tổng của 5 và giá trị mặc định 10: " + TinhTong(5));
            Console.ReadKey();
        }
    }
}
