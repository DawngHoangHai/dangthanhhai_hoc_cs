using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cautruc_struct.cs
{
    internal class st_giangvien
    {
        struct giangVien
        {
            public string MaGV, HoTenGv;
            public uint soMonDay, hocKi;
        }
        static void InPut(giangVien[] gv, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\n - [+] Nhập vào giảng viên thu [{i + 1}] : ");
                Console.Write("\n\t - Nhập vào mã giảng viên : "); gv[i].MaGV = Console.ReadLine();
                Console.Write("\n\t - Nhập vào tên giảng viên : "); gv[i].HoTenGv = Console.ReadLine();
                Console.Write("\n\t - Nhập vào số môn dạy : "); gv[i].soMonDay = uint.Parse(Console.ReadLine());
                Console.Write("\n\t - Nhập vào số học kì : "); gv[i].hocKi = uint.Parse(Console.ReadLine());
            }
        }
        static void TieuDe()
        {
            Console.WriteLine("\n\t\t+====================================================================+");
            Console.WriteLine("\t\t| {0,10}  |  {1,20}  |  {2,10}  |  {3,10}  |" +
                    "\n\t\t+====================================================================+",
                    "MÃ GV", "TÊN GV", "SỐ M DẠY", "HỌC KỲ");
        }
        static void OutPut(giangVien[] gv, int n)
        {
            Console.WriteLine("\n\t\t CÁC GIẢNG VIÊN VỪA LƯU VÀO LÀ ");
            TieuDe();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("\t\t| {0,10}  |  {1,20}  |  {2,10}  |  {3,10}  |" +
                    "\n\t\t+====================================================================+",
                    gv[i].MaGV, gv[i].HoTenGv, gv[i].soMonDay, gv[i].hocKi);
            }
        }
        static void TimKiem(giangVien[] gv, int n)
        {
            Console.WriteLine("\n\t\t GIẢNG VIÊN CÓ SỐ MÔN DẠY LÀ 5 VÀ 2 HỌC KÌ LÀ ");
            TieuDe();
            for (int i = 0; i < n; i++)
            {
                if (gv[i].soMonDay >= 5 && gv[i].hocKi == 2)
                {
                    Console.WriteLine("\t\t| {0,10}  |  {1,20}  |  {2,10}  |  {3,10}  |" +
                    "\n\t\t+====================================================================+",
                    gv[i].MaGV, gv[i].HoTenGv, gv[i].soMonDay, gv[i].hocKi);
                }
            }
        }
        static void Main()
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.Write(" - Nhập vào số lượng giảng viên : "); uint n = uint.Parse(Console.ReadLine());
            giangVien[] gv = new giangVien[n];
            InPut(gv, (int)n);
            Console.Clear();
            OutPut(gv, (int)n);
            TimKiem(gv, (int)n);
            Console.ReadLine();
        }
    }
}
