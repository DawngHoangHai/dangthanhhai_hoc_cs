using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitap_ham
{
    internal class fc_max_min
    {
        static void soLonNhat(int a, int b, int c, int d)
        {
            int max = a;
            if (a < b)
            {
                max = b;
            }
            if (a < c)
            {
                max = c;
            }
            if (a < d)
            {
                max = d;
            }
            Console.WriteLine($" MAX ({a},{b},{c},{d}) = {max}");
        }
        static void soBeNhat(int a, int b, int c, int d)
        {
            int min = a;
            if (a > b)
            {
                min = b;
            }
            if (a > c)
            {
                min = c;
            }
            if (a > d)
            {
                min = d;
            }
            Console.WriteLine($" MIN ({a},{b},{c},{d}) = {min}");
        }
        static void Main(string[] args)
        {
            int a = 9, b = 5, c = 1, d = 11;
            soLonNhat(a, b, c, d);
            soBeNhat(a, b, c, d);
        }
    }
}
