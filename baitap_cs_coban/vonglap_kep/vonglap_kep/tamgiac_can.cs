using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vonglap_kep
{
    internal class tamgiac_can
    {
        static void Main()
        {
            int h = 7;
            for (int i = 1; i <= h; i++)
            {
                for (int j = 1; j < 2 * h; j++)
                {
                    if (Math.Abs(h - j) < i)
                    {
                        Console.Write(" * ");
                    }
                    else
                    {
                        Console.Write("   ");
                    }
                }
                Console.WriteLine("\n");
            }
            Console.WriteLine();
            for (int i = 1; i <= h; i++)
            {
                for (int j = 1; j < 2 * h; j++)
                {
                    if (Math.Abs(h - j) == i - 1 || i == h)
                    {
                        Console.Write(" * ");
                    }
                    else
                    {
                        Console.Write("   ");
                    }
                }
                Console.WriteLine("\n");
            }
            Console.WriteLine("\n\n");
            for (int i = 1; i < 7; i++)
            {
                for (int j = 1; j <= 7; j++)
                {
                    if ((i == 1 && (j == 1 || j == 4 || j == 7)) || (i == 4 && (j == 1 || j == 7))
                        || (i == 5 && (j <= 2 || j >= 6)) || (i == 6 && j != 4))
                    {
                        Console.Write("   ");
                    }
                    else
                    {
                        Console.Write(" * ");
                    }
                }
                Console.WriteLine("\n");
            }
        }
    }
}
