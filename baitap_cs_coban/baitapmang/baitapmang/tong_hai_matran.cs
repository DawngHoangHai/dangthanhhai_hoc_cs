using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitapmang
{
    internal class tong_hai_matran
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
            Console.WriteLine(" \t -> Nhap xong Ma Tran !! ");
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
        static void Tong(int[,] a, int[,] b, int m, int n)
        {
            int[,] sum = new int[m, n];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    sum[i, j] = a[i, j] + b[i, j];
                }
            }
            Console.WriteLine("\n : TONG HAI MA TRAN LA : ");
            Xuat(sum, m, n);
        }
        static void Main()
        {
            int m, n;
            Console.Write(" - Nhap vao so hang : "); m = int.Parse(Console.ReadLine());
            Console.Write(" - Nhap vao so cot : "); n = int.Parse(Console.ReadLine());
            int[,] arr = new int[m, n];
            int[,] brr = new int[m, n];
            Nhap(arr, m, n);
            Nhap(brr, m, n);
            Console.WriteLine(" : MA TRAN VUA NHAP VAO LA :");
            Xuat(arr, m, n);
            Console.WriteLine(" : MA TRAN VUA NHAP VAO LA :");
            Xuat(brr, m, n);
            Tong(arr, brr, m, n);

        }
    }
}
