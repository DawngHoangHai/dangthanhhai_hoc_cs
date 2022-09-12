using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitapmang
{
    internal class tinhtrungbinhcong
    {
        public static void Main()
        {
            uint n;
            Console.Write(" - Nhap vao so phan tu trong mang : "); n = uint.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"\n\t - Nhap vao phan tu thu [{i + 1}] : ");
                numbers[i] = int.Parse(Console.ReadLine());
            }
            int dem1 = 0, dem2 = 0;
            int sum1 = 0, sum2 = 0;
            for (int i = 0; i < n; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    sum1 += numbers[i];
                    dem1++;
                }
                else
                {
                    sum2 += numbers[i];
                    dem2++;
                }
            }
            Console.WriteLine(" - > Trung Binh Cong Cac So Chan La : " + (float)sum1 / dem1);
            Console.WriteLine(" - > Trung Binh Cong Cac So Le La : " + (float)sum2 / dem2);
        }
    }
}
