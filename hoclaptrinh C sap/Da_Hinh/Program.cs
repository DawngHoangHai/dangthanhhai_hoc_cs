using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Da_Hinh
{
    /* Đa Hình là đa dạng phong phú ,nhiều kiểu ,nhiều hình thái.
     * Virtual : dùng để khái báo 1 phương thức ảo (có thể ghi đè được )
     * 
     * Override : dùng để đánh dấu phường thức ghi đè của lớp cha 
     * 
     * --> chỉ có thể ghi đè lên phương thức Virtual hoặc Abstract
     * 
     * 
     * lớp trừu tượng và phương thức thuần ảo 
     * Phương thức ảo : là phương thức ảo và không có định nghĩa bên trong 
     * Lớp trừu tượng : là lớp chứa phương thức  thuần ảo 
     * 
     * abstract : là từ khóa để khai báo phương thức thuần ảo hoặc lớp trừu tượng
     * phương thức thuần ảo abstract bắt buộc phải override lại để đảm bảo chương trình luôn đúng
     */
    internal class Program
    {
        abstract class Animal
        {
            public abstract void Speak();

        }
        class Cat : Animal
        {
            public override void Speak()// phương thức ghi đè của phương thức cha
            {
                Console.WriteLine("Cat Speak : .....");
            }
        }
        class Dog : Animal
        {
            public override void Speak()
            {
                Console.WriteLine("Dog Speak : .....");
            }
        }
        static void Main(string[] args)
        {
            Animal cat = new Cat();
            Animal dog = new Dog();
            cat.Speak();
            dog.Speak();
        }
    }
}
