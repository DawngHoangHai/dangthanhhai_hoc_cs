using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cautruc_struct
{
    internal class st_sanpham
    {
        struct sanPham
        {
            public string maSP, tenSP;
            public double donGia;
        }
        static void Nhap(ref sanPham[] sp, int n)
        {
            Console.WriteLine("\n\t- NHAP VAO DANH SACH SAN PHAM -");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\n [+] Nhap vao san pham thu [{i}] : ");
                Console.Write("\n\t - Nhap vao ma san pham : "); sp[i].maSP = Console.ReadLine();
                Console.Write("\n\t - Nhap vao ten san pham : "); sp[i].tenSP = Console.ReadLine();
                Console.Write("\n\t - Nhap vao don gia san pham : "); sp[i].donGia = double.Parse(Console.ReadLine());
            }
        }
        static void NOTE()
        {
            Console.WriteLine("\t+--------------------------------------------------------------+");
            Console.WriteLine("\t| {0,10} | {1,25} | {2,15} vnd |", "MA SP", "TEN SP", "DON GIA");
            Console.WriteLine("\t+--------------------------------------------------------------+");
        }
        static void Xuat(ref sanPham[] sp, int n)
        {
            Console.WriteLine("\n\t DANH SACH SAN PHAM VUA NHAP VAO LA \n");
            NOTE();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("\t| {0,10} | {1,25} | {2,15} vnd |" +
                    " \n\t+--------------------------------------------------------------+"
                    , sp[i].maSP.ToUpper(), sp[i].tenSP.ToUpper(), sp[i].donGia);
            }
        }
        static void TimKiem(ref sanPham[] sp, int n)
        {
            Console.WriteLine("\n\t DANH SACH SAN PHAM COS DON GIA LON HON 20000 \n");
            NOTE();
            for (int i = 0; i < n; i++)
            {
                if (sp[i].donGia >= 20000)
                {
                    Console.WriteLine("\t| {0,10} | {1,25} | {2,15} vnd |" +
                    " \n\t+--------------------------------------------------------------+"
                    , sp[i].maSP.ToUpper(), sp[i].tenSP.ToUpper(), sp[i].donGia);
                }
            }
        }
        static void Main(string[] args)
        {
            uint soLg;
            Console.Write(" - Nhap vao so luong san pham : "); soLg = uint.Parse(Console.ReadLine());
            sanPham[] Sp = new sanPham[soLg];
            Nhap(ref Sp, (int)soLg);
            Console.Clear(); // lệnh xóa màn hình 
            Xuat(ref Sp, (int)soLg);
            TimKiem(ref Sp, (int)soLg);
        }
    }
}
