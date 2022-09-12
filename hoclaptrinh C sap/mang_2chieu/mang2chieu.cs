using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mang_2chieu
{
    internal class mang2chieu
    {
        static void Main(string[] args)
        {
            //khai báo khởi tạo mảng 2 chiều vuông [số dòng,số cột]
            int[,] mang2chieu = new int[3, 3];// Tạo ra mảng có 6 hàng và 6 cột -- (luôn là nguyên dương)

            int row = mang2chieu.GetLength(0); // cách xem mảng có ba nhiêu hàng GetLength(0)
            int col = mang2chieu.GetLength(1); // cách xem mảng có ba nhiêu cột GetLength(1)
            Console.WriteLine("\nSo hang {0} va So Cot {1} ", row, col);
            for (int i = 0; i < mang2chieu.GetLength(0); i++)
            {
                for (int j = 0; j < mang2chieu.GetLength(1); j++)
                {
                    Console.Write(" \n - Nhap vao Cot [{0}] , Hang [{1}] : ", j + 1, i + 1);
                    mang2chieu[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < mang2chieu.GetLength(0); i++)
            {
                for (int j = 0; j < mang2chieu.GetLength(1); j++)
                {
                    Console.Write(mang2chieu[i, j] + " ");
                }
                Console.WriteLine();
            }


            //khai báo khởi tạo mảng 2 chiều zigzac
            /*int[][] mang2chieu_zigzac = new int[3][];
            for (int i = 0; i < mang2chieu_zigzac.Length; i++)
            {
                mang2chieu_zigzac[i] = new int[1 + i];// khởi tạo lên số cột tùy ý mình
            }
            for (int i = 0; i < mang2chieu_zigzac.Length; i++)
            {
                for (int j = 0; j < mang2chieu_zigzac[i].Length; j++)
                {
                    Console.Write(" - Nhap vao hang [{0}] Cot [{1}] :", i +1, j+1);
                    mang2chieu_zigzac[i][j] = int .Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < mang2chieu_zigzac.Length; i++)
            {
                for (int j = 0; j < mang2chieu_zigzac[i].Length; j++)
                 // mang2chieu_zigzac[i].Length : là số cột trên từng hàng ma trận
                {
                    Console.Write(mang2chieu_zigzac[i][j]+"  ");
                }
                Console.WriteLine();
            }*/

        }
    }
}
