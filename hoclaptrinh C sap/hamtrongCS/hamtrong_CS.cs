using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hamtrongCS
{
    internal class hamtrong_CS
    {
        /* cấu trúc 1 hàm. 
         * < từ khóa 1, 2, 3 > < kiểu trả về > <tên hàm > (tham số truyền vào)
         * {....... }
         * từ khóa 1, 2, 3 : public, static, readonly, private,.........
         * kiểu trả về : int, long, void, kiểu dữ liệu .......
         * tên hàm : tự đặt 
         * ->> không thể khai báo 1 hàm cho 1 hàm khác 
         * có thể gọi hàm trong hàm 
         * hàm main viết trên môi trường console của  c# phải có static mới chạy 
         * vì thế nên các hàm phải có static
         */
        public static void tinhtoan(float a, float b) // tạo một hàm để tính toán 
        {
            Console.WriteLine($" Tong cua {a} + {b} = {a + b} ");
            Console.WriteLine($" Hieu cua {a} - {b} = {a - b} ");
            Console.WriteLine($" Tich cua {a} * {b} = {a * b} ");
            Console.WriteLine($" Thuong cua {a} / {b} = {Math.Round((float)a / b, 3)} ");
        }

        static void Main()
        {
            float a, b;
            a = 10.5f; b = 5.5f;
            tinhtoan(a, b);// gọi lại hàm tính toán 
        }
    }
}
