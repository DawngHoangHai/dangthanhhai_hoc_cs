using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonKeThua
{
    internal class Program_1
    {
        class benhNhan
        {
            protected string hoTen, queQuan;
            protected int namSinh;
            public void InPut()
            {
                Console.Write("\n\t - Nhập vào tên : "); hoTen = Console.ReadLine();
                Console.Write("\n\t - Nhập vào quê quán : "); queQuan = Console.ReadLine();
                Console.Write("\n\t - Nhập vào năm sinh : "); namSinh = System.Int32.Parse(Console.ReadLine());
            }
            public void OutPut()
            {
                Console.Write("\t|{0,25}  |{1,25}  |{2,15}  |", hoTen, queQuan, namSinh);
            }
        }
        class benhAn : benhNhan
        {
            protected string tenBenhAn;
            protected double tienBenhAn;
            public double TienBenhAn
            {
                get => tienBenhAn;
                set => tienBenhAn = value;
            }

            public new void InPut()
            {
                base.InPut();
                Console.Write("\n\t - Nhập vào tên bệnh án : "); tenBenhAn = Console.ReadLine();
                Console.Write("\n\t - Nhập vào tiền bệnh án : "); TienBenhAn = System.Int32.Parse(Console.ReadLine());
            }
            public int tinhTuoi()
            {
                return DateTime.Today.Year - namSinh;
            }
            public new void OutPut()
            {
                base.OutPut();
                Console.WriteLine("{0,25}  |{1,15}đ  |{2,10}  |" +
                    "\n\t+-------------------------------------------------------------------------------------------------------------------------------------+"
                    , tenBenhAn, TienBenhAn, tinhTuoi());
            }
        }
        static void Nhap(benhAn[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\n - Nhập vào Bệnh Án thứ {i + 1} :");
                a[i] = new benhAn();
                a[i].InPut();
            }
        }
        static void Tieude()
        {
            Console.WriteLine("\n\t+-------------------------------------------------------------------------------------------------------------------------------------+" +
                "\n\t|{0,25}  |{1,25}  |{2,15}  |{3,25}  |{4,15}   |{5,10}  |" +
                "\n\t+-------------------------------------------------------------------------------------------------------------------------------------+"
                , "TÊN BỆNH NHÂN", "QUÊ QUÁN", "NĂM SINH", "TÊN BỆNH ÁN", "TIỀN", "TUỔI");
        }
        static void Xuat(benhAn[] a, int n)
        {
            Tieude();
            for (int i = 0; i < n; i++)
            {
                a[i].OutPut();
            }
        }
        static void SapXep(benhAn[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (a[i].tinhTuoi() < a[j].tinhTuoi())
                    {
                        benhAn tim = a[i];
                        a[i] = a[j];
                        a[j] = tim;
                    }
                }
            }
            Console.WriteLine("\n\t\t\t\t\t\t! DANH SÁCH SẮP XẾP TĂNG DẦN THEO TUỔI LÀ !");
            Xuat(a, n);
        }
        static void timKiem(benhAn[] a, int n, bool kiemTra = false)
        {
            Console.WriteLine("\n\t\t\t\t\t\t! DANH SÁCH BỆNH NHÂN CÓ ĐỘ TUỔI TRÊN 50 LÀ !");
            Tieude();
            for (int i = 0; i < n; i++)
            {
                if (a[i].tinhTuoi() >= 50)
                {
                    kiemTra = true;
                    a[i].OutPut();
                }
            }
            if (kiemTra == false)
            {
                Console.WriteLine("\n\t\t\t\t\t---->> ! DANH SÁCH KHÔNG CÓ BỆNH NHÂN TRÊN 50 TUỔI !");
            }
        }
        static void timMax(benhAn[] a, int n)
        {
            benhAn max = a[0];
            for (int i = 0; i < n; i++)
            {
                if (max.TienBenhAn < a[i].TienBenhAn)
                {
                    max = a[i];
                }
            }
            Console.WriteLine("\n\t\t\t\t\t\t!  BỆNH NHÂN CÓ TIỀN VIỆN PHÍ ĐẮT NHẤT LÀ !"); Tieude();
            max.OutPut();
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.Write(" - > Nhập vào số lượng : "); int n = int.Parse(Console.ReadLine());
            benhAn[] a = new benhAn[n];
            Nhap(a, n);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n\t\t\t\t\t\t! DANH SÁCH BỆNH NHÂN VÀ BỆNH ÁN VỪA LƯU LÀ !");
            Xuat(a, n);
            SapXep(a, n);
            timKiem(a, n);
            timMax(a, n);
            Console.ReadLine();
        }
    }
}
