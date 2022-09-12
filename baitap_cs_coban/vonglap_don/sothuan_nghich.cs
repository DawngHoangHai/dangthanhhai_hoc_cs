
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vonglap_don
{
    internal class sothuan_nghich
    {
        static void Main()
        {
            Console.Write(" - Nhap vao 1 so nguyen bat ki :");
            uint n = uint.Parse(Console.ReadLine());
            int m = (int)n, dao = 0;
            while (m > 0)
            {
                dao = dao * 10 + m % 10;
                m /= 10;
            }
            if (n == dao)
            {
                Console.WriteLine($" -> {n} la so thuan nghich !!");
            }
            else
            {
                Console.WriteLine("$ -> {n} khong la so thuan nghich !!");
            }
        }
    }
}
