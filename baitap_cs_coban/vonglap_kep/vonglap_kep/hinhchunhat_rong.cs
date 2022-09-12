using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vonglap_kep
{
    internal class hinhchunhat_rong
    {
        static void Main()
        {
            uint m, n;
            Console.Write(" Nhap vao chieu dai :"); m = uint.Parse(Console.ReadLine());
            Console.Write(" Nhap vao chieu rong :"); n = uint.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= m; j++)
                {
                    if (i == 1 || i == n || j == 1 || j == m)
                    {
                        Console.Write(" * ");
                    }
                    else
                    {
                        Console.Write("   ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
