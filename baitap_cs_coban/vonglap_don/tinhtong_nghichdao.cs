using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vonglap_don
{
    internal class tinhtong_nghichdao
    {
        static void Main(string[] args)
        {
            uint n;
            float sum = default;
            Console.Write(" - Nhap vao so tu nhien :");n = uint.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                sum = sum + (float)1 / i;
            }
            Console.WriteLine($" Ket qua cua 1 + 1/2 + 1/3 + ... +1/{n} = {Math.Round( sum,3)}");
        }
    }
}
