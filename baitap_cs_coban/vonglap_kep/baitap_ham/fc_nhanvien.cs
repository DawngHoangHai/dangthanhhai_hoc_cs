using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitap_ham
{
    internal class fc_nhanvien
    {
        public static string hoTen;
        public static double luongCoBan, heSoLuong;
        static void Nhap()
        {
            Console.Write(" - Nhập Vào Họ Tên Của Nhân Viên : "); hoTen = Console.ReadLine();
            Console.Write(" - Nhập vào lương cơ bản của Nhân viên :"); luongCoBan = double.Parse(Console.ReadLine());
            Console.Write(" - Nhập vào hệ số lương của Nhân viên :"); heSoLuong = double.Parse(Console.ReadLine());
        }
        static double tinhLuong()
        {
            return luongCoBan * heSoLuong;
        }
        static double tinhPhuCap()
        {
            return (luongCoBan * heSoLuong) * 0.25;
        }

        static void Xuat()
        {
            Console.WriteLine("\n\t\t\t\t\t BẢNG CÔNG NHÂN VIÊN ");
            Console.WriteLine("\n\t +---------------------------------------------------------------------------------------------------------+" +
                "\n\t | {0,25} | {1,20} | {2,11} | {3,20} | {4,15} |" +
                "\n\t +---------------------------------------------------------------------------------------------------------+",
                "HO TEN", "LUONG CO BAN", "HE SO LUONG", "LUONG", "PHU CAP");
            Console.WriteLine("\t | {0,25} | {1,20} | {2,11} | {3,20} | {4,15} |" +
                "\n\t +---------------------------------------------------------------------------------------------------------+",
                hoTen.ToLower(), luongCoBan, heSoLuong, tinhLuong(), tinhPhuCap());
        }
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Nhap();
            Xuat();
        }
    }
}
