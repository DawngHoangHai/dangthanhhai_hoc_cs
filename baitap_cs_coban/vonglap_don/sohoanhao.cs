using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vonglap_don
{
    internal class sohoanhao
    {
        static void Main()
        {
            uint n;
            Console.Write(" Nhap vao so bat ki :"); n = uint.Parse(Console.ReadLine());
            int sum = default;
            for (int i = 1; i < n; i++)
            {
                if (n % i == 0)
                {
                    sum += i;
                }
            }
            if (sum == n)
            {
                Console.WriteLine($" -> {n} la so hoan hao !!!");
            }
            else
            {
                Console.WriteLine($" -> {n} khong la so hoan hao !!!");
            }
        }
    }
}
