using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitapmang
{
    internal class matran_chuyenvi
    {
        static void Nhap(int[,] arr, int m, int n)
        {
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("\n\t Nhap vao Hang:[{0}] , Cot:[{1}] : ", i + 1, j + 1);
                    arr[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }
        static void Xuat(int[,] arr, int m, int n)
        {
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(" {0,2} ", arr[i, j]);
                }
                Console.WriteLine();
            }
        }
        static void ChuyenVi(int[,] arr, int[,] brr, int m, int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    brr[i, j] = arr[j, i];
                }
            }
            Console.WriteLine(" : MA TRAN CHUYEN VI LA :");
            Xuat(brr, n, m);
        }
        static void Main()
        {
            int m, n;
            Console.Write(" - Nhap vao so hang : "); m = int.Parse(Console.ReadLine());
            Console.Write(" - Nhap vao so cot : "); n = int.Parse(Console.ReadLine());
            int[,] arr = new int[m, n];
            int[,] brr = new int[n, m];
            Nhap(arr, m, n);
            Console.WriteLine(" : MA TRAN VUA NHAP VAO LA :");
            Xuat(arr, m, n);
            ChuyenVi(arr, brr, m, n);
        }
    }
}
