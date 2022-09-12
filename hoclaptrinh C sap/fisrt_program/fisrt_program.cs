using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; // thư viện của c#

namespace hoclaptrinh_C_sap
{

    internal class fisrt_program
    {

        static void Main(string[] args)
        {
            // cho phép người dùng in ra tiếng việt.
            Console.OutputEncoding = Encoding.Unicode;
            // Console.BackgroundColor = ConsoleColor.Gray;// in ra backgroud màu mà mình muấn in
            Console.Title = " Day La Truong Trinh Dau Tien Cua Toi !!!! "; // đặt tên co file chạy

            Console.Write("\tdang thanh hai\n");
            // in ra thông tin có trong " "
                                               
            // Console.ForegroundColor = ConsoleColor.Blue;// in ra chữ mau ma minh muan in 
            Console.WriteLine("\tTran Van Anh \n");

            string hoTen = " Đăng Thanh Hai", email = "danghoanghai@gmail.com";
            Console.WriteLine(hoTen);
            Console.WriteLine("email cua toi la  : " + email);
            int a = 50, b = 30;
            int sum = a + b;
            float div = (float)a / b;
            Console.WriteLine(" a + b = " + sum);
            Console.WriteLine(" a / b = " + div);

        }
    }
}
