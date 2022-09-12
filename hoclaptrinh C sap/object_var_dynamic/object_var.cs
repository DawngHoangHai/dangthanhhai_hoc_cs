using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace object_var_dynamic
{
    internal class object_var
    {
        static void Main(string[] args)
        {

            // var bắt buộc phải gán giá trị khi vừa khai bao .

            var a = " ";
            // object : là kiểu dữ liệu cơ bản trong c# 

            // dynamic : kiểu dữ liệu dynamic 

            // toán tử ba ngôi :
            // cách làm toán tử 3 ngôi 
            int n = 3;
            string s = default;
            s = (n % 2 == 0) ? "so chan " : " so le";
            Console.WriteLine(s);
        

         }
    }
}
