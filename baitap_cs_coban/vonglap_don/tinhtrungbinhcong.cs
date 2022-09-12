using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vonglap_don
{
    internal class tinhtrungbinhcong
    {
        static void Main()
        {
            uint n;
            Console.Write(" - Nhap vao so tu nhien :"); n = uint.Parse(Console.ReadLine());
            long sum1, sum2, sum3;
            sum1 = sum2 = sum3 = default;
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    sum1 = sum1 + i;
                }
                else if (i % 2 == 1)
                {
                    sum2 += i;
                }
                sum3 += i;


            }
            Console.WriteLine($" Tong cac so tu 1 den {n} la : {sum3}\n Tong cac so le tu 1 den {n} la : {sum2} \n Tong cac so chan tu 1 den {n} la : {sum1}");
        }
    }
}
