using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitapmang
{
    internal class timmax_trenhang
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
            Console.WriteLine(" : MA TRAN VUA NHAP VAO LA :");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(" {0,2} ", arr[i, j]);
                }
                Console.WriteLine();
            }
        }
        static void Max_hang(int[,] arr, int m, int n)
        {
            for (int i = 0; i < m; i++)
            {
                int max = arr[i, 0];
                for (int j = 0; j < n; j++)
                {
                    if (arr[i, j] > max)
                    {
                        max = arr[i, j];
                    }
                }
                Console.Write("\n - > MAX CUA HANG {0} LA {1}: ", i + 1, max);
            }
        }
        static void Tim_Max(int[,] arr, int m, int n)
        {
            int max = arr[0, 0];
            int min = arr[0, 0];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (arr[i, j] > max)
                    {
                        max = arr[i, j];
                    }
                    if (arr[i, j] < min)
                    {
                        min = arr[i, j];
                    }

                }
            }
            Console.WriteLine("\n - > Phan tu lon nhat trong ma tran la : " + max);
            Console.WriteLine("\n - > Phan tu nho nhat trong ma tran la : " + min);
        }
        static void Main()
        {
            int m, n;
            Console.Write(" - Nhap vao so hang : "); m = int.Parse(Console.ReadLine());
            Console.Write(" - Nhap vao so cot : "); n = int.Parse(Console.ReadLine());
            int[,] arr = new int[m, n];
            Nhap(arr, m, n);
            Xuat(arr, m, n);
            Max_hang(arr, m, n);
            Tim_Max(arr, m, n);
        }
    }
}
