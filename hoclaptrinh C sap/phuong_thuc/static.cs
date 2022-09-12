using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phuong_thuc
{
    internal class @static
    {
        /* 
         * thành phần static : lớp tiện ích 
         * 
         *  + hàm khởi tạo static contructor :
         *  
         *  - chỉ có 1 static contructor trong 1 lớp
         *  
         *  - không nhận tham số nào , không chứa phạm vi truy cập 
         *  
         *  - chỉ được gọi 1 lần duy nhất và trước tất cả 
         *  
         *  +  lớp static static class :
         *  - chỉ chứa thành phần static
         */
        static class MEO
        {
            public static int tuoi = 10;
            public static int age;

            public static void infor()
            {
                Console.WriteLine(" thông tin meo la !! ");
                Console.WriteLine(" mèo mèo mèo ");
            }
        }
        static class tinhToan
        {
            public static int add(int a, int b)
            {
                return a + b;
            }
            public static int sub(int a, int b)
            {
                return a - b;
            }
            public static int mu(int a, int b)
            {
                return a * b;
            }
            public static float chia(int a, int b)
            {
                return (float)a / b;
            }
        }
        static void Main()
        {
            // MEO a = new MEO();// không thể tạo biến và đối tượng
            MEO.infor(); // không cần phải khởi tạo đối tượng
            int a = 10, b = 50;
            Console.WriteLine(" -> {0} + {1} = {2}", a, b, tinhToan.add(a, b)); // gọi thẳng trực tiếp đến static class đó
            Console.WriteLine(" -> {0} - {1} = {2}", a, b, tinhToan.sub(a, b));
            Console.WriteLine(" -> {0} x {1} = {2}", a, b, tinhToan.mu(a, b));
            Console.WriteLine(" -> {0} / {1} = {2}", a, b, tinhToan.chia(a, b));

        }
    }
}
