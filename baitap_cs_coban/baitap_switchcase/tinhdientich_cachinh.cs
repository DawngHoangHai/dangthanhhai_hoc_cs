using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitap_switchcase
{
    internal class tinhdientich_cachinh
    {
        static void Main()
        {
            int luaChon;
            Console.WriteLine(" \t!! TINH DIEN TICH !!\n \n\t 1.HINH CHU NHAT \n\t 2.HINH VUONG \n\t 3.HINH BINH HANH \n\t 4.HINH THANG \n");
            Console.Write(" - Nhap vao lua chon cua ban :");luaChon =  int.Parse(Console.ReadLine());
            switch(luaChon)
            {
                case 1:
                    {
                        Console.WriteLine("\tBAN CHON HINH CHU NHAT !!");
                        int dai, rong ,S = default;
                        Console.WriteLine(" - Nhap vao chieu dai , rong :"); 
                        dai = int.Parse(Console.ReadLine());
                        rong = int.Parse(Console.ReadLine());
                        S = dai * rong;
                        Console.WriteLine($"\t-> DIEN TICH HINH CHU NHAT LA : {S} cm");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("\tBAN CHON HINH VUONG !!");
                        int canh, S = default;
                        Console.Write(" - Nhap vao canh :");
                        canh = int.Parse(Console.ReadLine());
                        S = canh * canh;
                        Console.WriteLine($"\t-> DIEN TICH HINH VUONG LA : {S} cm");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("\tBAN CHON HINH BINH HANH !!");
                        int day,cao, S = default;
                        Console.WriteLine(" - Nhap vao canh day ,chieu cao :");
                        day = int.Parse(Console.ReadLine());
                        cao = int.Parse(Console.ReadLine());
                        S = day*cao;
                        Console.WriteLine($"\t-> DIEN TICH BINH HANH LA : {S} cm");
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("\tBAN CHON HINH THANG THUONG !!");
                        int dayLon, dayBe, cao;float S = default;
                        Console.WriteLine(" - Nhap vao canh day lon ,day be :");
                        dayLon = int.Parse(Console.ReadLine());
                        dayBe = int.Parse(Console.ReadLine());
                        Console.Write(" - Nhap vao chieu cao :");
                        cao = int.Parse(Console.ReadLine());
                        S = (float)((dayLon + dayBe) * cao)/2;
                        Console.WriteLine($"\t-> DIEN TICH BINH HANH LA : {S} cm");
                        break;
                    }
                    default:
                    Console.WriteLine("\t BAN CHUA CHO CHUC NANG NAO !!!");
                    break;
            }
        }
    }
}
