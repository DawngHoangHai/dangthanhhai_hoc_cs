using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mang_2chieu
{
    internal class class1
    {
        public static void Nhap(int[,] a, int m, int n)
        {
            Console.WriteLine("\n [+] Nhap vao MA TRAN [+] ");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"\n - NHAP VAO PHAN TU SO DONG [{i + 1}] ,SO COT [{j + 1}] : ");
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }
        public static void Xuat(int[,] a, int m, int n)
        {
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0,5}", a[i, j]);
                }
                Console.WriteLine();
            }
        }
        static void Tong(int[,] a, int m, int n)
        {
            long sum = default;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    sum += a[i, j];
                }

            }
            Console.WriteLine("\n - > Tong Cac phan tu trong mang la : " + sum);
        }
        static void Main()
        {
            int m, n;
            Console.Write(" - Nhap vao so dong : "); m = int.Parse(Console.ReadLine());
            Console.Write(" - Nhap vao so cot : "); n = int.Parse(Console.ReadLine());
            int[,] a = new int[m, n];
            Nhap(a, m, n);
            Xuat(a, m, n);
            Tong(a, m, n);
        }
    }
}
