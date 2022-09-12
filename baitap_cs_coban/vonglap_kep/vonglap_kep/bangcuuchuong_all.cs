using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vonglap_kep
{
    internal class bangcuuchuong_all
    {
        static void Main()
        {
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 2; j <= 10; j++)
                {
                    Console.Write($" {j} x {i} = {i * j} \t");
                }
                Console.WriteLine();
            }
        }
    }
}
