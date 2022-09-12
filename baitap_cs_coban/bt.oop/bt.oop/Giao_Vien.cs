using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bt.oop
{
    internal static class Giao_Vien
    {
        static private string hoTen, bangCap, chuyenNganh;
        static private int tuoi;
        static private float bacLuong;
        static Giao_Vien()
        {
            hoTen = "DANG THANH HAI";
            tuoi = 20;
            bangCap = "GIOI";
            chuyenNganh = "CNTT";
            bacLuong = 3.5f;
        }
        public static void InPut()
        {
            Console.Write("\n - Nhap vao ho ten giao vien : "); hoTen = Console.ReadLine();
            Console.Write("\n - Nhap vao tuoi giao vien : "); tuoi = int.Parse(Console.ReadLine());
            Console.Write("\n - Nhap vao bang cap giao vien : "); bangCap = Console.ReadLine();
            Console.Write("\n - Nhap vao chuyen nganh giao vien : "); chuyenNganh = Console.ReadLine();
            Console.Write("\n - Nhap vao bac luong giao vien : "); bacLuong = float.Parse(Console.ReadLine());
        }
        static double TienLuong()
        {
            return bacLuong * 1490;
        }
        public static void OutPut()
        {
            Console.WriteLine("\n - Ho Ten : {0}\n - Tuoi : {1}\n - Bang Cap : {2}\n - Chuyen Nganh : {3}\n - Bac Luong : {4}\n - Tien Luong : {5}"
                , hoTen, tuoi, bacLuong, chuyenNganh, bacLuong, Math.Round(TienLuong(), 3));
        }
        static void Main()
        {
            Giao_Vien.InPut();
            Console.WriteLine("\t GIAO VIEN VUA NHAP VAO LA ");
            Giao_Vien.OutPut();
        }
    }
}
