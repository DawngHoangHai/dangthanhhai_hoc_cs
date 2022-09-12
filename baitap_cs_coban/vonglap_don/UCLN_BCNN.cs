using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vonglap_don
{
    internal class UCLN_BCNN
    {
        static void Main()
        {
            int a, b;
            Console.Write(" - Nhap vao a , b ");a= int.Parse(Console.ReadLine());b = int.Parse(Console.ReadLine());
            if(a >= 0 && b >= 0)
            {
                if(a == 0 && b == 0)
                {
                    Console.WriteLine(" -> Khong co BCNN VA UCLN !!");

                }else if(a == 0 || b == 0)
                {
                    Console.WriteLine(" -> Khong co BCNN !!");
                    Console.WriteLine(" -> UCLN la : "+ (a==0 ? b: a));
                }
                else
                {
                    int boi = a * b;
                    while (a!=b)
                    {
                        if (a > b)
                        {
                            a -= b;
                        }
                        else
                        {
                            b -= a;
                        }
                    }
                    Console.WriteLine($" -> UCLN la :{a}");
                    Console.WriteLine($" -> BCNN la :{boi/a}");
                }
            }
        }
    }
}
