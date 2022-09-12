using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitap_switchcase
{
    internal class tinhtoans
    {
        static void Main()
        {
            int a, b, c,luachon;
            Console.WriteLine(" Nhap vao  a b c : ");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            Console.WriteLine($" MOI BAN CHON CHC NANG \n 1 : {a} + {b} + {c} \n 2 : {a} * {b} * {c} \n 3 : {a}x + {b} = {0} \n ");
            Console.Write(" Nhap vao mong muan cua ban :");luachon = int.Parse(Console.ReadLine());
            switch (luachon)
            {
                case 1:
                    {
                        Console.WriteLine($" KET QUA {a} + {b} + {c} = {a + b + c}");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine($" KET QUA {a} * {b} * {c} = {a * b * c}");
                        break;
                    }
                case 3:
                    {
                        float X = default;
                        if (a == 0)
                        {
                            if (b == 0)
                            {
                                Console.WriteLine(" -> Phuong tinh vo so nghiem !!!\n");
                            }
                            else
                            {
                                Console.WriteLine(" -> Phuong tinh vo nghiem !!!\n");
                            }
                        }
                        else
                        {
                            X = (float)-b / a;
                            Console.WriteLine($" -> Phuong tinh co nghiem duy nhat la = {Math.Round(X, 2)} \n");
                        }
                        break;
                    }
            }
        }
    }
}
