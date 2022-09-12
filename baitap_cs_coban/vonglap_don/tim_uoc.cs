
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vonglap_don
{
    internal class tim_uoc
    {
        static void Main()
        {
            uint n, count = default;
            Console.Write(" - Nhap vao so tu nhien :"); n = uint.Parse(Console.ReadLine());
            Console.WriteLine($" Uoc cua {n} la :");
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    Console.Write($"  {i}");
                    count++;
                }
            }
            Console.WriteLine($"\n Tong cac uoc cua {n} la : {count}");
        }
    }
}
