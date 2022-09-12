using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vonglap_for
{
    internal class continue_break
    {
        static void Main()
        {
            /* break : dừng vong lặp 
             * thường hay để trong 1 điều kiện nào đó 
             */
            for(int i = 0; i < 10; i++)
            {
                Console.Write("\t" + i);
                if (i == 6)
                {
                    break;// khi vòng lặp chạy đến 6 thì dừng vì gặp break; 
                }
            }
            /* continue : là bỏ qua khối lệnh sau nó và tiếp tục chaỵ lại vong lặp 
             * thường hay để trong 1 điều kiện nào đó
             * nên đặt ở đầu lệnh mà bạn cần bỏ qua trong vòng lặp
             * */
            for(int i = 0; i < 10; i++)
            {
                if (i == 4)
                {
                    continue;// điều kiện này sẽ giúp không thực hiện câu lệnh tiếp theo
                             // quay trở lại vòng lặp để tiếp tục chạy chương trình 
                }
                Console.WriteLine("\t" + i);

            }
        }
    }
}
