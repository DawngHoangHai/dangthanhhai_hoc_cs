using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vonglap_for
{
    internal class vonglap_goto_for
    {
        static void Main(string[] args)
        {
            /* vòng lặp goto 
             * giống với vong lặp trong c++ 
             * 
             * cách 1 :
             * tiepTuc:
             * ........ sẽ lặp lại các  dòng code từ tiepTuc -> goto tiepTuc;
             * ........
             * ........
             * goto tiepTuc;
             * 
             * cách 2:
             * goto tiepTuc;
             * ......    sẽ bỏ qua các dòng code sau goto tiepTuc ;
             * ......    chạy đến dong code sau tiepTuc:
             * ......
             * tiepTuc:
             *........*/

            // vong lặp for
            /* - khai báo : 
             * chỉ có 1 khởi tạo để vào và điều kiện đó đi đến hết chương trình 
             * - ở điều kiện lặp :
             * viết false chương trình k chạy lặp || viết true chương trình chạy vô hạn 
             * có thể thêm nhiều điều kiện lặp vào cùng liên kết vơi nhau bằng toán tử logic 
             * lần  lặp :
             * có thể thêm nhiều câu lệnh về lặp cách nhau 1 dấu ,
             * có thể thêm Console.Write(Line)("") 
             */
            Console.OutputEncoding = Encoding.UTF8;
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("đặng thanh hải");
                
            }
            // vòng lặp lồng nhau thì vòng lặp đầu tiên sẽ là sô cột, vòng lặp tiếp theo là số hàng ngang

        }
    }
}
