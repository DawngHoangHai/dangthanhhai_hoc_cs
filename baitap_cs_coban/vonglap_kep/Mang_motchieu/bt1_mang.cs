using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mang_motchieu
{
    internal class bt1_mang
    {
        static void Nhap(int[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write("\n - Nhap vao phan tu thu [{0}] : ", i + 1);
                a[i] = int.Parse(Console.ReadLine());
            }
        }
        static void Xuat(int[] a, int n)
        {
            Console.Write("\n -> Cac phan tu trong mang la : ");
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0,5}", a[i]);
            }
        }
        static void Swap(int[] a, int n)
        {
            Console.Write("\n -> Cac phan tu sap xep tang dan la : ");
            Array.Sort(a);
            foreach (var i in a)
            {
                Console.Write("{0,5}", i);
            }
            Array.Reverse(a);
            Console.Write("\n -> Cac phan tu sap xep giam dan la : ");
            foreach (var i in a)
            {
                Console.Write("{0,5}", i);
            }
        }
        static void KiemTra(int[] a, int n)
        {
        nhaplai:
            int x;
            Console.Write(" \n - Nhap vao 1 so de kiem tra : "); x = int.Parse(Console.ReadLine());
            int kiemTra = Array.IndexOf(a, x);
            if (kiemTra > -1)
            {
                Console.WriteLine("\n -> {0} co trong mang !!", x);
            }
            else
            {
                Console.WriteLine("\n -> {0} Khong co trong mang !!", x);
                goto nhaplai;
            }

        }
        static void timMax(int[] a, int n)
        {
            int max = a[0];
            for (int i = 0; i < n; i++)
            {
                if (max < a[i])
                {
                    max = a[i];
                }
            }
            Console.WriteLine("\n -> Phan tu lon nhat trong mang la :{0}", max);
        }
        static void Chen(int[] arr1, int n, int x, int k)
        {
            int kiemTra = 0;
            for (int i = 0; i < n; i++)
            {
                if (arr1[i] == x)
                {
                    Console.WriteLine(" -> Phan tu {0} da co trong mang !!", x);
                    kiemTra++;
                    break;
                }
            }
            if (kiemTra == 0)
            {
                n++;
                // dich sang phai 1 phan tu 
                for (int i = n; i >= k; i--)
                    arr1[i] = arr1[i - 1];
                /* chen gia tri vao vi tri da cho */
                arr1[k - 1] = x;
                Console.Write("\n\nSau khi chen phan tu, mang co dang:\n");
                Xuat(arr1, n);
            }
        }
        static void Main(string[] args)
        {
            int n, x, k;
            int[] number = new int[10];
            Console.Write(" - Nhap vao so phan tu trong mang : "); n = int.Parse(Console.ReadLine());
            Nhap(number, n);
            Xuat(number, n);
            Swap(number, n);
            KiemTra(number, n);
            Console.Write("\n - Nhap vao phan tu chen : "); x = int.Parse(Console.ReadLine());
            Console.Write("\n - Nhap vao vi tri chen : "); k = int.Parse(Console.ReadLine());
            Chen(number, n, x, k);
            timMax(number, n);
        }
    }
}
