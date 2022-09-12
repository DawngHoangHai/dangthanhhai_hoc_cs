using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vonglap_kep
{
    internal class tamgiac_1
    {
        static void Main()
        {
            int n = 7;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n\n");
            for (int i = n; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n\n");
            for (int i = 0; i <= n; i++)
            {
                for (int j = 0; j <= n; j++)
                {
                    if (j <= n - i)
                    {
                        global::System.Console.Write("  ");
                    }
                    else
                    {
                        global::System.Console.Write("* ");
                    }
                }
                global::System.Console.WriteLine();
            }
            Console.WriteLine("\n\n");
            for (int i = n; i >= 1; i--)
            {
                for (int j = 0; j <= n; j++)
                {
                    if (j <= n - i)
                    {
                        global::System.Console.Write("  ");
                    }
                    else
                    {
                        global::System.Console.Write("* ");
                    }
                }
                global::System.Console.WriteLine();
            }
        }
    }
}
