using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitapmang
{
    internal class tim_min2_max2
    {
        static void nhap(int[] a, int n)
        {
            Console.WriteLine(" - NHAP VAO MANG ");
            for (int i = 0; i < n; i++)
            {
                Console.Write("\n\t - Nhap vao phan tu thu [{0}] : ", i + 1);
                a[i] = int.Parse(Console.ReadLine());
            }
        }
        static void Xuat(int[] a, int n)
        {
            Console.Write(" \n - > CAC PHAN TU TRONG MANG LA : ");
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0,5}", a[i]);
            }
        }
        static void Timkiem(int[] numbers, int n)
        {
            int min = numbers[0];
            int max = numbers[0];
            int max2, min2;
            // tim max, min
            for (int i = 1; i < n; i++)
            {
                if (max < numbers[i])
                {
                    max = numbers[i];
                }
                if (min > numbers[i])
                {
                    min = numbers[i];
                }
            }

            max2 = min;
            min2 = max;
            // tim max2, min2
            for (int i = 0; i < n; i++)
            {
                if (max2 < numbers[i] && numbers[i] != max)
                {
                    max2 = numbers[i];
                }
                if (min2 > numbers[i] && numbers[i] != min)
                {
                    min2 = numbers[i];
                }
            }
            if (min2 == min)
            {
                Console.WriteLine("\n - Khong co gia tri nho thu hai");
            }
            else
            {
                Console.WriteLine("\n - Gia tri nho thu hai: " + min2);
            }

            if (max2 == max)
            {
                Console.WriteLine("\n - Khong co gia tri lon thu hai");
            }
            else
            {
                Console.WriteLine("\n - Gia tri lon thu hai la: " + max2);
            }
        }
        static void Main(string[] args)
        {
            int n;
            Console.Write(" - Nhap vao so luong phan tu trong mang : "); n = System.Int32.Parse(Console.ReadLine());
            int[] a = new int[n];
            nhap(a, n);
            Xuat(a, n);
            Timkiem(a, n);
            Console.WriteLine();
        }
    }
}
