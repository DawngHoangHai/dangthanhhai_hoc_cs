using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mang_cs
{
    internal class mang_motchieu
    {
        static void Main(string[] args)
        {
            //  khai báo khởi tạo mảng
            // khai báo mảng <kiểu dữ liệu> <[]> <tên mảng>

            // khai bao  va truyen vao phan tu trong mang 
            //int[] mang = { 1, 2, 3, 4, 5 };
            int[] mang = new int[] { 11, 25, 3, 4, 5 };

            //mang[2] = 10;// thay doi du lieu trong mang o vitri so 2 
            Console.WriteLine(mang[2] + "\n");// in ra vi tri so 2 trong mang 
                                              //int[]mang  = new int[10]; // khai bao mang co 10 phan tu 

            // dung vong for de dieu tung phan tu trong mang
            for (int i = 0; i < mang.Length; i++)// mang.Length : độ dài trong trong mảng 
            {
                Console.WriteLine(mang[i]);
            }
            Console.WriteLine();

            // co the dung vong foreach de hien thi ra du lieu trong mang 
            /*foreach (var item in collection)
            {

            }*/
            foreach (var i in mang)
            {
                Console.WriteLine(i);
            }
            // để lấy độ dài của mảng ta dùng <tên mạng.Length>
            int n;
            Console.Write(" - Nhap vao so luong phan tu trong mang :"); n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write(" + Nhap vao phan tu thu [{0}] : ", i + 1);
                a[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("\n -> Phan tu co trong mang la : ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(" {0,5} ", a[i]);
            }
            Console.Write("\n ->sap xep mang tang dan : ");
            Array.Sort(a);// ham sapw xeps tang dan 
            foreach (var i in a)// (var <giá trị mình đặt> in <tên mảng>
            {
                Console.Write(" {0,5} ", i);
            }
            Console.Write("\nnhap ");
        }
    }
}
