using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitap_ham
{
    internal class fc_sohoanhao
    {
        static int check(int n)
        {
            int sum = 0;
            for (int i = 1; i < n; i++)
            {
                if (n % i == 0)
                {
                    sum += i;
                }
            }
            if (sum == n)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        static void kiemTra(int n)
        {
            if (check(n) == 1)
            {
                Console.WriteLine($" -> {n} la so hoan hao ");
            }
            else
            {
                Console.WriteLine($" -> {n} khong la so hoan hao ");
            }
        }
        static void inSoHoanHao(int n)
        {
            Console.Write(" -> Cac so hoan hao la :");
            for (int i = 1; i <= n; i++)
            {
                if (check(i) == 1)
                {
                    Console.Write("\t" + i);
                }
            }
        }
        static void Main()
        {
            int n;
            Console.Write(" - Nhap vao 1 so de kiem tra : "); n = int.Parse(Console.ReadLine());
            kiemTra(n);
            Console.Write(" - Nhap vao 1 so : "); n = int.Parse(Console.ReadLine());
            inSoHoanHao(n);
        }
    }
}
