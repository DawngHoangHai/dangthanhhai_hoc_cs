using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cautruc_struct.cs
{
    internal class st_hocsinh
    {
        struct hocSinh
        {
            public string maHS, TenHs;
            public float diemLT, diemTH;
        }
        static void InPut(hocSinh[] hs, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\n - [+] Nhập vào học sinh thứ [{i + 1}] : ");
                Console.Write("\n\t - Nhập vào mã học sinh : "); hs[i].maHS = Console.ReadLine();
                Console.Write("\n\t - Nhập vào họ tên học sinh : "); hs[i].TenHs = Console.ReadLine();
                Console.Write("\n\t - Nhập vào điểm lý thuyết học sinh : "); hs[i].diemLT = int.Parse(Console.ReadLine());
                Console.Write("\n\t - Nhập vào điểm thực hành học sinh : "); hs[i].diemTH = int.Parse(Console.ReadLine());
            }
        }
        static void hai()
        {
            Console.WriteLine("\n\t\t +===================================================================================+");
            Console.WriteLine("\t\t |  {0,15}  |  {1,25}  |  {2,11}   |  {3,11}   |" +
                    "\n\t\t +===================================================================================+"
                    , "MÃ HS", "HỌ VÀ TÊN", "ĐIỂM LT", "ĐIỂM TH");
        }
        static void OutPut(hocSinh[] hs, int n)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n\t\t\t\t! DANH SÁCH HỌC SINH VỪA LƯU VÀO LÀ !");
            hai();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("\t\t |  {0,15}  |  {1,25}  |  {2,10} đ  |  {3,10} đ  |" +
                    "\n\t\t +===================================================================================+"
                    , hs[i].maHS, hs[i].TenHs, hs[i].diemLT, hs[i].diemTH);
            }
        }
        static void TimKiem(hocSinh[] hs, int n)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            bool check = false;
            Console.WriteLine("\n\t\t\t\t! HỌC SINH THI TRƯỢT TRONG ĐỢT THI NÀY LÀ !");
            hai();
            for (int i = 0; i < n; i++)
            {
                if (hs[i].diemLT < 5 || hs[i].diemTH < 5)
                {
                    Console.WriteLine("\t\t |  {0,15}  |  {1,25}  |  {2,10} đ  |  {3,10} đ  |" +
                    "\n\t\t +===================================================================================+"
                    , hs[i].maHS, hs[i].TenHs, hs[i].diemLT, hs[i].diemTH);
                    check = true;
                }
            }
            if (check == false)
            {
                Console.WriteLine("\n\t\t\t ->> KHÔNG CÓ SINH VIÊN NÀO DƯỚI THI TRƯỢT ! ");
            }
        }
        static void Main()
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.Write("\n - NHẬP VÀO SỐ LƯỢNG HỌC SINH : "); uint n = uint.Parse(Console.ReadLine());
            hocSinh[] Hs = new hocSinh[n];
            InPut(Hs, (int)n);
            Console.Clear();
            OutPut(Hs, (int)n);
            TimKiem(Hs, (int)n);
        }
    }
}
