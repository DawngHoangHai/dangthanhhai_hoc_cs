using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Da_Hinh
{
    /*interface : là 1 tập các thành phàn chỉ khai báo mà không có phần định nghĩa(giống như phương thức thuần ảo)
     * bên trong thành phần interface chỉ có phương thức, propety,event
     * 
     * đặc điểm : 
     * - chỉ chứa khai báo, không chứa định nghĩa, không cần từ khóa abstract
     * - ghi đè  thành phần trong interface không cần từ override
     * - các thành phần mặc định của interface là public
     * - không có contructer và detructor
     * - Coi như là đa kế thừa 
     */
    internal class @interface
    {
        interface ISpeak
        {
            void Speak();
        }
        class Animal : ISpeak
        {
            public void Speak()
            {
                Console.WriteLine("\n Animal Speak : .............");
            }
        }
        static void Main()
        {
            var speak = new Animal();
            speak.Speak();
        }
    }
}
