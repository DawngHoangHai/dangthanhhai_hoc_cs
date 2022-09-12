
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vonglap_don
{
    internal class phantichsonguyen
    {
        static void Main()
        {
            Console.Write(" - Nhap vao 1 so nguyen bat ki :");
            int i =2 ,n = int.Parse(Console.ReadLine());
            Console.Write($" So {n} duoc phan tich ra la : ");
            while (n>1)
            {
                if (n%i==0)
                {
                    Console.Write(i);
                    if (n!=i)
                    {
                        Console.Write(" x ");
                    }
                    n /= i;
                }
                else
                {
                    i++;
                }
            }
            Console.WriteLine();
        }
    }
}
