using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vonglap_don
{
    internal class sochinhphuong
    {
        static void Main()
        {
            /*uint n;
            Console.Write(" - Nap vao so nguyen de kiem tra :");n = uint.Parse(Console.ReadLine());
            int soCP = (int)Math.Sqrt(n);
            if (soCP * soCP == n)
            {
                Console.WriteLine($" -> {n } la so chinh  phuong !!");
            }
            else
            {
                Console.WriteLine($" -> {n} khong la so chinh phuong !!");
            }*/
            uint n;
            Console.Write(" - Nap vao so nguyen bat ki :"); n = uint.Parse(Console.ReadLine());
            Console.Write($" So chinh phuong tu 1 den {n} la :");
            for (int i = 1; i <= n; i++)
            {
                int soCP = (int)Math.Sqrt(i);
                if (soCP * soCP == i)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
