using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cautruc_struct.cs
{
    class st_nhanvien
    {
        struct NhanVien
        {
            public string maNv, tenNv, PhongBan, QueQuan, SDT;
            public int NamSinh, NamVao, NamThoi;
            public double heso, luong;
        }
        static void InPut(ref NhanVien[] nv, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("\n (+)Nhập vào Nhân Viên thứ [{0}] : ", i + 1);
                Console.Write("\n\t[+]Nhập vào Mã Nhân Viên : "); nv[i].maNv = Console.ReadLine();
                Console.Write("\n\t[+]Nhập vào Tên Nhân Viên : "); nv[i].tenNv = Console.ReadLine();
                Console.Write("\n\t[+]Nhập vào Phòng Ban Nhân Viên : "); nv[i].PhongBan = Console.ReadLine();
                Console.Write("\n\t[+]Nhập vào Năm Sinh Nhân Viên : ");
                do
                {
                    nv[i].NamSinh = int.Parse(Console.ReadLine());
                    if (nv[i].NamSinh < 1000)
                    {
                        Console.Write("\n\t[+]Nhập lại Năm Sinh Nhân Viên : ");
                    }
                } while (nv[i].NamSinh < 1000);
                Console.Write("\n\t[+]Nhập vào Quê Quán Nhân Viên : "); nv[i].QueQuan = Console.ReadLine();
                Console.Write("\n\t[+]Nhập vào SDT Nhân Viên : "); nv[i].SDT = Console.ReadLine();
                Console.Write("\n\t[+]Nhập vào Năm Vào công ty : "); nv[i].NamVao = int.Parse(Console.ReadLine());
                Console.Write("\n\t[+]Nhập vào Năm Nghỉ : ");
                do
                {
                    nv[i].NamThoi = int.Parse(Console.ReadLine());
                    if (nv[i].NamThoi < nv[i].NamVao)
                    {
                        Console.Write("\n\t[+]Nhập lại Năm Nghỉ : ");
                    }
                } while (nv[i].NamThoi < nv[i].NamVao);

                if ((nv[i].NamThoi - nv[i].NamVao) > 0 && (nv[i].NamThoi - nv[i].NamVao) <= 5)
                {
                    nv[i].heso = 1.5;
                }
                else if ((nv[i].NamThoi - nv[i].NamVao) > 5 && (nv[i].NamThoi - nv[i].NamVao) <= 10)
                {
                    nv[i].heso = 3;
                }
                else
                {
                    nv[i].heso = 5;
                }

                nv[i].luong = nv[i].heso * 10000;
            }
        }
        static void TieuDe()
        {
            Console.WriteLine("\n +===================================================================================================================================================================+");
            Console.WriteLine(" | {0,10}| {1,25}| {2,20}| {3,10}| {4,21}| {5,15}| {6,10}| {7,10}| {8,7}| {9,15}$|" +
                    "\n +===================================================================================================================================================================+"
               , "MÃ NV", "HỌ VÀ TÊN", "PHÒNG BAN", "NĂM SINH", "QUÊ QUÁN", "SDT", "NĂM VÀO", "NĂM NGHỈ", "HỆ SỐ", "TỔNG LƯƠNG");

        }
        static void OutPut(ref NhanVien[] nv, int n)
        {
            TieuDe();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(" | {0,10}| {1,25}| {2,20}| {3,10}| {4,21}| {5,15}| {6,10}| {7,10}| {8,7}| {9,15}$|" +
                    "\n +===================================================================================================================================================================+"
               , nv[i].maNv, nv[i].tenNv, nv[i].PhongBan, nv[i].NamSinh, nv[i].QueQuan, nv[i].SDT, nv[i].NamVao, nv[i].NamThoi, nv[i].heso, nv[i].luong);

            }
        }
        static void SapXep(ref NhanVien[] nv, int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (nv[i].luong > nv[j].luong)
                    {
                        NhanVien tm = nv[i];
                        nv[i] = nv[j];
                        nv[j] = tm;
                    }
                }
            }
            Console.WriteLine("\n\t\t\t\t\t\t!! DANH SÁCH NHÂN VIÊN LƯƠNG TĂNG DẦN LÀ !!");
            OutPut(ref nv, n);
        }
        static void TimKiem(ref NhanVien[] nv, int n)
        {
        GO_ON:
            string MATK;
            Console.Write("\n\t[+]Nhập vào Mã Nhân viên Để kiểm tra : "); MATK = Console.ReadLine();
            bool check = false;
            Console.WriteLine("\n\t\t\t\t\t\t!! MÃ  NHÂN VIÊN VỪA NHẬP VÀO LÀ !! ");
            TieuDe();
            for (int i = 0; i < n; i++)
            {
                if (nv[i].maNv.Trim().ToUpper() == MATK.Trim().ToUpper())
                {
                    check = true;
                    Console.WriteLine(" | {0,10}| {1,25}| {2,20}| {3,10}| {4,21}| {5,15}| {6,10}| {7,10}| {8,7}| {9,15}$|" +
                   "\n +===================================================================================================================================================================+"
                    , nv[i].maNv, nv[i].tenNv, nv[i].PhongBan, nv[i].NamSinh, nv[i].QueQuan, nv[i].SDT, nv[i].NamVao, nv[i].NamThoi, nv[i].heso, nv[i].luong);
                }
            }
            if (check == false)
            {
                Console.WriteLine("\n\t\t\t================> KHÔNG CÓ MÃ NHÂN VIÊN VỪA NHẬP !!! ");
                goto GO_ON;
            }
        }
        static void Main()
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.Write("\n - Nhập vào số lượng nhân viên : "); uint n = uint.Parse(Console.ReadLine());
            NhanVien[] nv = new NhanVien[n];
            InPut(ref nv, (int)n);
            Console.Clear();
            Console.WriteLine("\n\t\t\t\t\t\t!! DANH SÁCH NHÂN VIÊN VỪA NHẬP VÀO LÀ !! ");
            OutPut(ref nv, (int)n);
            SapXep(ref nv, (int)n);
            //TimKiem(ref nv, (int)n);
            Console.ReadLine();
        }
    }
}
