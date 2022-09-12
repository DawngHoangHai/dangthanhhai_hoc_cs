
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vonglap_don
{
    internal class songuyento
    {
        static void Main()
        {
            /*int n,count = 0;
            Console.Write("Nhap vao so nguyen :");n= int.Parse(Console.ReadLine());
            for (int i = 2; i < Math.Sqrt(n); i++)
            {
                if (n%1==0)
                {
                    count++;
                }
            }
            if(count == 0)
            {
                Console.WriteLine($" -> {n} La so nguyen to !!");
            }
            else
            {
                Console.WriteLine($" -> {n} Khong La so nguyen to !!");
            }*/
            int n, count = 0;
            Console.Write("Nhap vao so nguyen :"); n = int.Parse(Console.ReadLine());
            for (int i = 2; i < n; i++)
            {
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        break;
                    }
                    else if (i == j + 1)
                    {
                        Console.Write("\t" + i);
                    }
                }
            }
        }
    }
}
