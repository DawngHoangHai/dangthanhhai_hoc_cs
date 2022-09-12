using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vonglap_don
{
    internal class tinhtonggiaithua
    {
        static void Main()
        {
            uint n;
            Console.Write(" - Nhap vao n bat ki :"); n = uint.Parse(Console.ReadLine());
            long giathua = 1, sum = 0;
            for (int i = 1; i <= n; i++)
            {
                giathua *= i;
                sum += giathua;
            }
            Console.WriteLine($" Tong 1! + 2! + 3! + {n}! = {sum}");
        }
    }
}
