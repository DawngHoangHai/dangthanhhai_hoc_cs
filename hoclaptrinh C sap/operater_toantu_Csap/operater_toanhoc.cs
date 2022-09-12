using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operater_toantu_Csap
{
    internal class operater_toantu
    {
        static void Main(string[] args)
        {
            // toán tử toán học : + , - ,* , / , % , ++ , -- ;
            string hello = "hello dang thanh hai";
            int a = 100;
            float b = 300.35f; // :kiểu floast phải thêm chữ f cuối cùng

            int sum = a + (int)b;// a + (int)b :ép kiểu 1 số  ||  (int)(a+b) :ép kiểu  nhiều số  
            string SUM = hello +( a+ b); // phép tính này là nối lại với nhau tính toán trước
            //  string SUM = hello + a + b : chỉ nối lại với nhau 
            Console.WriteLine("ket qua cua a + b = " + sum);
            Console.WriteLine( SUM);

            int   x = 1, y = 2 ;
            Console.WriteLine((float)x/y);// ép kiểu
            ++x; --y; // == x++ , y++;
            Console.WriteLine(" X = " + x + " , y = " +y );
        }
    }
}
