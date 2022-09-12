using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hamtrongCS
{
    internal class bien_toancuc_cucbo
    {
        /* biến cục cộ được phép trùng tên và ưu tiên biến nào gần hơn 
         * biến cực bộ được ưu tiên sử dụng hơn
         * 
         * biến cục bộ chỉ sự dụng được ở trong {} mà nó khai báo 
         */
        static int bienToanCuc = 6;
        static void inBien()
        {
            int bienToanCuc = 100;
            Console.WriteLine(bienToanCuc); // ưu tiên sử dụng cái biến gần nó nhất 
        }
        static void Main()
        {
            Console.WriteLine(bienToanCuc);// in ra 6 
            inBien();   // in ra 100
        }
        
    }
}
