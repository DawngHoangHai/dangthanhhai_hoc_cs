using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace input_output
{
    internal class string_chuoi
    {
        static void Main()
        {
            string hoten;
            Console.Write(" - Nhap vao chuoi ki tu bat ki : "); hoten = Console.ReadLine();
            Console.WriteLine($" + ki tu vua nhap vao la : {hoten}\n");

            Console.WriteLine($" + so luong ki tu co vua nhap la : {hoten.Length}\n");
            // hoten.Length() : xem so luong ki tu vua nhap 
            Console.WriteLine($" + Ki tu vua nhap chuyen thanh in hoa la : {hoten.ToUpper()}\n");
            // hoten.ToUpper() : chuyen ki tu thanh in HOA 
            Console.WriteLine($" + Ki tu vua nhap chuyen thanh in thuong la : {hoten.ToLower()}\n");
            // hoten.ToLower() :chuyen ki tu thanh chu thuong
            Console.WriteLine($" + Ki tu in ra k co khoang trang tu dau va o cuoi : {hoten.Trim()}\n");
            // hoten.Trim() : xoa khoang trang dau va cuoi ki tu 
            Console.WriteLine($" + Ki tu in ra k co khoang trang tu dau va o cuoi va in thuong: {hoten.Trim().ToLower()} \n");
            // hoten.Trim().ToLower() : xoa khoang trang dau va cuoi ki tu va in thuong

            // kiem tra co ki tu ..o.. ben trong chuoi nhap vao  khong : hoten.Contains("o");
            // ket qua la true or false
            Console.WriteLine($" + Ki tu 'o' dem tu dau vao la thu bao nhieu : {hoten.IndexOf("o")} \n");
            // kiem tra xem ki tu o la ki tu thu bao nhieu tinh tu dau chuoi vao :hoten.IndexOf("o")
            Console.WriteLine($" + Ki tu 'o' dem tu dau vao la thu bao nhieu : {hoten.LastIndexOf("o")} \n");
            // kiem tra xem ki tu o la ki tu thu bao nhieu tinh tu cuoi chuoi vao :hoten.LastIndexOf("o")

            // cách kiểm tra xem có chuỗi kí tự trong đó không 
            if (hoten.ToUpper().CompareTo("DANG HOANG HAI") == 0)// string.Compare(hoten,"DANG HOANG HAI")
            {
                Console.WriteLine(" trung ten nhau ");
            }
            else
            {
                Console.WriteLine(" hkobng trung ten nhau");
            }
            





        }
    }
}
