using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitap_cs_coban
{
    internal class tinhtamgiac
    {
        static void Main()
        {
            int canh1,canh2, canh3;
            Console.WriteLine(" Nhap vao  ba canh cua tam giac :");
            canh1 = int.Parse(Console.ReadLine());
            canh2 = int.Parse(Console.ReadLine());
            canh3 = int.Parse(Console.ReadLine());
            double C = 0, S = 0 ,X = 0;
            C = canh1 + canh2 + canh3;
            X = (canh1 + canh2 + canh3) / 2;
            S = Math.Sqrt((X * (X - canh1) * (X - canh2) * (X - canh3)));
            Console.WriteLine($" CHU VI hinh tam giac vua nhap la : {C}");
            Console.WriteLine($" DIEN TICH hinh tam giac la : {Math.Round(S, 3)}");
        }
    }
}
