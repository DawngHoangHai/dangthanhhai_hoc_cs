using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_math.cs
{
    internal class class_math
    {
        static void Main(string[] args)
        {
            // sử dụng lớp tinhsh toán .
            int a, b;
            Console.Write(" - NHap vao a = ");a = System.Int32.Parse(Console.ReadLine());
            Console.Write(" - NHap vao b = "); b = System.Int32.Parse(Console.ReadLine());
            //Console.Write(" - NHap vao c = "); c = System.Int32.Parse(Console.ReadLine());
            int max = Math.Max(a, b );
            Console.WriteLine($" MAX ({a} ,{b}) = {max}");
            Console.WriteLine($" PI  =  {Math.PI}");

        }
    }
}
