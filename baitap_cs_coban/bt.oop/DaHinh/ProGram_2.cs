using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaHinh
{
    internal class ProGram_2
    {
        public const double PI = 3.1415926535897931;
        abstract class Shape
        {
            public abstract void Nhap();
            public abstract void Xuat();
            public abstract double chuVu();
            public abstract double dienTich();
        }
        class Round : Shape
        {
            protected float r;
            public override void Nhap()
            {
                Console.Write("\n\t - Nhập Vào Bán Kính : "); r = float.Parse(Console.ReadLine());
            }
            public override double chuVu()
            {
                return 2 * r * PI;
            }
            public override double dienTich()
            {
                return PI * r * r;
            }
            public override void Xuat()
            {
                Console.WriteLine("\n\t[+] Hình Tròn !!!");
                Console.WriteLine("\n\t -> Bán Kính : {0}\n\t -> Chu Vi : {1}\n\t -> Diện Tích : {2}"
                    , r, Math.Round(chuVu(), 2), Math.Round(dienTich(), 2));
            }
        }
        class Rec : Shape
        {
            protected int dai, rong;
            public override void Nhap()
            {
                Console.Write("\n\t - Nhập Vào Chiều Dài : "); dai = int.Parse(Console.ReadLine());
                Console.Write("\n\t - Nhập Vào Chiều Rộng : "); rong = int.Parse(Console.ReadLine());
            }
            public override double chuVu()
            {
                return (dai + rong) * 2;
            }
            public override double dienTich()
            {
                return dai * rong;
            }
            public override void Xuat()
            {
                Console.WriteLine("\n\t[+] Hình Chữ Nhật !!!");
                Console.WriteLine("\n\t -> Chiều Dài : {0}\n\t -> Chiều Rộng : {1}\n\t -> Chu Vi : {2}\n\t -> Diện Tích : {3}"
                    , dai, rong, chuVu(), dienTich());
            }
        }
        class Tri : Shape
        {
            protected int a, b, c;
            public override void Nhap()
            {
                Console.WriteLine("\n\t - Nhập vào Ba Cạnh Của Tam Giác : ");
                do
                {
                    a = int.Parse(Console.ReadLine());
                    b = int.Parse(Console.ReadLine());
                    c = int.Parse(Console.ReadLine());
                    if (a < 0 && b < 0 && c < 0 && a + b > c && a + c < b & b + c < a)
                    {
                        Console.WriteLine("\n\t - Nhập Lại Ba Cạnh Của Tam Giác : ");
                    }
                } while (a < 0 && b < 0 && c < 0 && a + b > c && a + c < b & b + c < a);
            }
            public override double chuVu()
            {
                return a + b + c;
            }
            public override double dienTich()
            {
                float C = (a + b + c) / 2;
                return Math.Sqrt(C * (C - a) * (C - b) * (C - c));
            }
            public override void Xuat()
            {
                Console.WriteLine("\n\t[+] Hình Tam Giác !!!");
                Console.WriteLine("\n\t -> Ba Cạnh Của Tam Giác Là : {0,2},{1,2},{2,2}\n\t -> Chu Vi : {3}\n\t -> Diện Tích : {4}"
                    , a, b, c, chuVu(), Math.Round(dienTich(), 2));
            }
        }
        class QuanLyShape
        {
            Shape[] a = new Shape[10];
            int n;
            public void InPut()
            {
                int i = 0, luaChon;
                for (i = 0; ; i++)
                {
                    Console.WriteLine("\n\t 1. Hình Tròn , 2.Hình Chữ Nhật , 3.Hình Tam Giác , 4.Dừng Nhập !!");
                    Console.Write("\t - Mời Nhập Vào Lựa Chọn Của Bạn : ");
                    do
                    {
                        luaChon = int.Parse(Console.ReadLine());
                        if (luaChon > 4 || luaChon < 1)
                        {
                            Console.Write("\t - Mời Nhập Lại Lựa Chọn Của Bạn : ");
                        }
                    } while (luaChon > 4 || luaChon < 1);
                    if (luaChon == 1)
                    {
                        Console.WriteLine($"\n - Nhập Vào Hình Tròn [{i + 1}] : ");
                        a[i] = new Round();
                    }
                    if (luaChon == 2)
                    {
                        Console.WriteLine($"\n - Nhập Vào Hình Chữ Nhật [{i + 1}] : ");
                        a[i] = new Rec();
                    }
                    if (luaChon == 3)
                    {
                        Console.WriteLine($"\n - Nhập Vào Hình Tam Giác [{i + 1}] : ");
                        a[i] = new Tri();
                    }
                    if (luaChon == 4)
                    {
                        Console.WriteLine($"\n\t ------------- Dừng Nhập ------------------");
                        break;
                    }
                    a[i].Nhap();
                    n = i;
                }
            }
            public void OutPut()
            {
                Console.WriteLine("\n\t========= DANH SÁCH CÁC HÌNH VỪA LƯU VÀO LÀ ===========");
                for (int i = 0; i < n; i++)
                {
                    a[i].Xuat();
                }
            }
            public void TongChuVi_DienTich()
            {
                double Sum1 = 0, Sum2 = 0;
                for (int i = 0; i < n; i++)
                {
                    Sum1 += a[i].chuVu();
                    Sum2 += a[i].dienTich();
                }
                Console.WriteLine("\n\t -->> Tổng Chu Vi Các Hình Vừa Nhập Là : " + Math.Round(Sum1, 2));
                Console.WriteLine("\n\t -->> Tổng Diện Tích Các Hình Vừa Nhập Là : " + Math.Round(Sum2, 2));
            }
        }
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            QuanLyShape a = new QuanLyShape();
            a.InPut();
            a.OutPut();
            a.TongChuVi_DienTich();
            Console.ReadLine();
        }
    }
}
