using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vonglap_for
{
    internal class vonglap_while_do
    {
        static void Main()
        {
            /*vòng lặp while :
             * while(điều kiện dừng lặp)
             * {
             * ..........
             * }
             *  nếu điều kiện dừng là sai thì vòng lặp sẽ không lặp
             *  nếu điều kiện dừng là true thì vòng lặp sẽ lặp vô hạn */
            float diemTB, diemTB2;
            Console.Write(" - Nhap vao diem trung binh : ");diemTB  =float.Parse(Console.ReadLine());
            while(diemTB < 0 || diemTB > 10)
            {
                Console.Write(" - Nhap lai diem trung binh : "); diemTB = float.Parse(Console.ReadLine());
            }


            Console.Write(" - Nhap vao diem trung binh 2 : ");
            do
            {
                diemTB2 = float.Parse(Console.ReadLine());
                if (diemTB2 < 0 || diemTB2 > 10)
                {
                    Console.Write(" - Nhap lai diem trung binh 2 : ");
                }
            } while (diemTB2 < 0 || diemTB2 > 10);
            
            
            
        }
    }
}
