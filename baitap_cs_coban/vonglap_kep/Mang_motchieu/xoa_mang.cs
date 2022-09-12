using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mang_motchieu
{
    internal class xoa_mang
    {
        public static void Nhap(int[] numbers, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(" \n\t - Nhap vao phan tu thu [{0}] : ", i + 1);
                numbers[i] = int.Parse(Console.ReadLine());
            }
        }
        public static void Xuat(int[] numbers, int n)
        {
            Console.Write("\n Cac Phan Tu Co Trong Mang : ");
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0,5}", numbers[i]);
            }
        }
        public static void Xoa(int[] numbers, int n)// xoa 1.
        {
            bool kiemTra = false;
            for (int i = 0; i < n; i++)
            {
                if (numbers[i] == 3)
                {
                    numbers[i] = numbers[i + 1];
                    kiemTra = true;
                    n--;
                }
            }
            if (kiemTra == true)
            {
                Xuat(numbers, n);
            }
            else
            {
                Console.WriteLine(" \n -> 3 khong co trong mang !!!");
            }
        }
        public static void XOA(int[] numbers, int n, int pos)
        {
            int i = 0;
            while (i != pos - 1)
                i++;
            /*vi tri i trong mang se duoc thay the boi gia tri ben phai cua no */
            while (i < n)
            {
                numbers[i] = numbers[i + 1];
                i++;
            }
            n--;
            Console.Write("\nIn mang sau khi da xoa phan tu: ");
            Xuat(numbers, n);
        }
        public static void Main()
        {
            int n, k;
            int[] numbers = new int[10];
            Console.Write("\n - Nhap vao so phan tu trong mang : "); n = int.Parse(Console.ReadLine());
            Nhap(numbers, n);
            Xuat(numbers, n);
            //Xoa(numbers, n);
            Console.Write("\n - Nhap vao vi tri ban can xoa : "); k = int.Parse(Console.ReadLine());
            XOA(numbers, n, k);
            Console.ReadLine();
        }

    }
}
