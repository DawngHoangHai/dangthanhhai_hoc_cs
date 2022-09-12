using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mang_motchieu
{
    internal class chen_mang
    {
        static void Nhap(int[] a, int n)
        {
            Console.Write("Nhap {0} phan tu vao trong mang:\n", n);
            for (int i = 0; i < n; i++)
            {
                Console.Write("Phan tu - {0} : ", i + 1);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        public static void Xuat(int[] a, int n)
        {
            Console.Write("In mang ban dau:\n");
            for (int i = 0; i < n; i++)
                Console.Write("{0} ", a[i]);
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
        public static void Main()
        {
            int n, k, x;
            int[] arr1 = new int[10];
            Console.Write("\nChen phan tu vao mang trong C#: \n");
            Console.Write("--------------------------------\n");
            Console.Write("\nNhap kich co mang: "); n = Convert.ToInt32(Console.ReadLine());
            Nhap(arr1, n);
            /* nhap cac phan tu vao trong mang*/
            Xuat(arr1, n);
            Console.Write("\nNhap gia tri phan tu moi can chen: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nNhap vi tri can chen phan tu moi nay: ");
            k = Convert.ToInt32(Console.ReadLine());
            Chen(arr1, n, x, k);
            Console.Write("\n\n");

            Console.ReadKey();
        }
    }
}
