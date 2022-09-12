using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operater_toantu_Csap
{
    internal class operater_sosanh_logic
    {
        static void Main()
        {
            Console.Title = " Toan TU So Sanh va Logic !!! ";
            Console.WriteLine(" DANG THANH HAI ");
            int a = 100, b = 200;
            bool soSanh = a > b;
            Console.WriteLine(soSanh);
            bool ss = b % 2 == 1;
            Console.WriteLine(ss);
            //toan tu ! có thể để trước kết quả Console.WriteLine(!ss);
        }

    }
}
