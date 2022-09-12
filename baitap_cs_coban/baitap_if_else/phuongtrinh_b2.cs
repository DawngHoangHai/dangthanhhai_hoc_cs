using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitap_cs_coban
{
    internal class phuongtrinh_b2
    {
        static void Main()
        {
            int a, b, c;
            float deta, x1, x2;
            Console.Write(" - Nhap vao a : ");a = int .Parse(Console.ReadLine());
            Console.Write(" - Nhap vao b : "); b = int.Parse(Console.ReadLine());
            Console.Write(" - Nhap vao c : "); c = int.Parse(Console.ReadLine());
            //Console.Clear(); giong system("cls")c++
            if(a == 0)
            {
                float X = default;
                if(b == 0)
                {
                    if(c == 0)
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
                    X = (float)-c / b;
                    Console.WriteLine($" -> Phuong tinh co nghiem duy nhat la = {Math.Round(X,2)} \n");
                }
            }else
            {
                deta = b * b - 4 * a * c;
                if(deta > 0)
                {
                    x1 = (float)(-b + Math.Sqrt(deta)) / (2 * a);
                    x2 = (float)(-b - Math.Sqrt(deta)) / (2 * a);
                    Console.WriteLine($" -> Phuong Trinh co 2 nghiem phan biet x1 = {x1} , x2 = {x2} \n");
                }
                else if(deta == 0)
                {
                    Console.WriteLine($" -> Phuong trinh co 2 nghiem kep x1 = x2 = {(float)-b/2*a} \n");
                }else
                {
                    Console.WriteLine(" -> Phuong trinh vo nghiem !!!! \n");
                }
            }
            Console.ReadKey();
        }
    }
}
