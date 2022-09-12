using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_else_switch_case
{
    internal class tinhtoancoban
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.Write(" Nhap vao so nguyen a = ");a= int.Parse(Console.ReadLine());
            Console.Write(" Nhap vao so nguyen b = "); b = int.Parse(Console.ReadLine());
            int sum, hieu;
            float tich, thuong;
            sum = a + b;
            hieu = a - b; 
            tich = a * b;
            thuong = (float)a / b;
            Console.WriteLine($" Tong {a} + {b} = {sum}\n Hieu {a} - {b} = {hieu} \n Tich {a} x {b} = {tich} \n Thuong {a}/{b} = {thuong}");
            
            
        }
    }
}
