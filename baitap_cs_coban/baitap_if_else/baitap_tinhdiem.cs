using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitap_cs_coban
{
    internal class baitap_tinhdiem
    {
        static void Main()
        {
            float diemKt, diemGki, diemCki ,diemTB;
            Console.WriteLine(" - MOI NHAP VAO DIEM CUA BAN - ");
            Console.Write(" \n - Nhap vao diem kiem tra :");diemKt = float.Parse(Console.ReadLine());
            Console.Write(" \n - Nhap vao diem giua ki :"); diemGki = float.Parse(Console.ReadLine());
            Console.Write(" \n - Nhap vao diem cuoi ki :"); diemCki = float.Parse(Console.ReadLine());
            diemTB = (diemKt + diemGki + diemCki) / 3;
            if(diemTB >= 9.0f)
            {
                Console.WriteLine($" DIEM TRUNG BINH LA : { Math.Round(diemTB, 2)}\n -> HOC SINH DAT HANG   A !" );
            }else if(diemTB >= 7.0f && diemTB < 9.0f)
            {
                Console.WriteLine($" DIEM TRUNG BINH LA : {Math.Round(diemTB, 2)}\n -> HOC SINH DAT HANG   B !");
            }else if(diemTB >= 5.0f && diemTB < 7.0f)
            {
                Console.WriteLine($" DIEM TRUNG BINH LA : {Math.Round(diemTB, 2)}\n -> HOC SINH DAT HANG  C !");
            }else
            {
                Console.WriteLine($" DIEM TRUNG BINH LA : {Math.Round(diemTB, 2)}\n -> HOC SINH HOC LAI DI !!!");
            }
            Console.ReadKey();
        }
    }
}
