using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cautruc_struct.cs
{
    internal class st_hinhtron
    {
        public const double PI = 3.1415926535897931;
        struct HinhTron
        {
            public float r, s, cv;
        }
        static void inPut(ref HinhTron[] a, uint n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\n - Nhap vao hinh tron thu [{i + 1}] : ");
                Console.Write("\n - Nhap vao ban kinh : "); a[i].r = float.Parse(Console.ReadLine());
                Console.WriteLine($" ----> Nhap xong hinh tron thu [{i + 1}] !! \n");
                a[i].cv = (float)PI * a[i].r * 2;
                a[i].s = (float)PI * a[i].r * a[i].r;
            }
        }
        static void outPut(ref HinhTron[] a, uint n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\n HINH TRON THU [{i + 1}] : \n");
                Console.Write($" - Ban Kinh Hinh Tron : {a[i].r} \n");
                Console.Write($" - Chu Vi Hinh Tron : {Math.Round(a[i].cv, 2)} \n");
                Console.Write($" - Dien Tich Hinh Tron : {Math.Round(a[i].cv, 2)} \n");
            }
        }
        static void Swap(HinhTron h1, HinhTron h2)
        {
            HinhTron X;
            X = h1;
            h1 = h2;
            h2 = X;
        }
        static void tangDienTich(ref HinhTron[] a, uint n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (a[i].s > a[j].s)
                    {
                        HinhTron X = a[i];
                        a[i] = a[j];
                        a[j] = X;
                    }
                }
            }
            Console.WriteLine("\n------------------ DIEN TICH TANG DAN LA ---------------------");
            outPut(ref a, n);
        }
        static void Main()
        {
            Console.Write("\n - Nhap vao so luong hinh tron : "); uint n = uint.Parse(Console.ReadLine());
            HinhTron[] a = new HinhTron[n];
            inPut(ref a, n);
            outPut(ref a, n);
            tangDienTich(ref a, n);
        }
    }
}
