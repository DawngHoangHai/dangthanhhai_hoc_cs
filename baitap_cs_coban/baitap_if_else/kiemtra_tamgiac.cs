using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitap_cs_coban
{
    internal class kiemtra_tamgiac
    {
        static void Main()
        {
            int a, b, c;
            Console.WriteLine(" Nhap vao  ba canh cua tam giac :");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            if(a > 0 && b > 0 && c > 0 && a + b > c && a + c > b & b + c > a)
            {
                if(a == b  && b == c)
                {
                    Console.WriteLine($" BA CANH {a} ,{b} ,{c} tao thanh tam giac DEU !!!");
                }else if(a == c || b == c || a == c)
                {
                    if(a * a == b * b + c * c || b * b == a * a + c * c || c * c == b * b + a * a)
                    {
                        Console.WriteLine($" BA CANH {a} ,{b} ,{c}  tao thanh tam giac VUONG CAN !!!");
                    }
                    else
                    {
                        Console.WriteLine($" BA CANH {a} ,{b} ,{c}  tao thanh tam giac CAN !!!");
                    }
                }else if(a * a == b * b + c * c || b * b == a * a + c * c || c * c == b * b + a * a)
                {
                    Console.WriteLine($" BA CANH {a} ,{b} ,{c}  tao thanh tam giac VUONG !!!");
                }
                else
                {
                    Console.WriteLine($" BA CANH {a} ,{b} ,{c}  tao thanh tam giac THUONG !!!");
                }
            }
            else
            {
                Console.WriteLine($" BA CANH {a} ,{b} ,{c} K TAO THANH TAM GIAC !!!");
            }

        }
    }
}
