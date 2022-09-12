using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phuong_thuc
{
    /* cách sử dụng từ khóa this :
     * từ khóa this là để phân biệt các biến trong class có trùng tên với tham số truyền vào. */
    internal class contructor
    {
        // khi ta không khai báo hàm khởi tạo hàm hủy thì trình biên dịch tự tạo ra cho chúng ta với dữ liệu là 0 và " "
        class Cat
        {
            public float CanNang, ChieuCao;
            public int Tuoi;
            public Cat() // hàm khởi tạo không tham số
            {
                CanNang = 5.5f;
                ChieuCao = 10f;
                Tuoi = 10;
            }

            //ta dùng tổ hợp phím cto tab tab là tạo contructor cto + tab + tab

             public Cat(float canNang, float chieuCao, int tuoi)// hàm khởi tạo có tham số 
            {
                CanNang = canNang;
                ChieuCao = chieuCao;
                Tuoi = tuoi;
            }


            //public Cat(float kg = 5.5f,float h = 10f,int old = 6) 
            //    // khi ta tạo hàm khởi tạo tham số ngầm thì k cần phải tạo hàm không tham số và có tham số 
            //{
            //    CanNang = kg;
            //    ChieuCao = h;
            //    Tuoi = old;
            //}


            ~  Cat()// hàm hủy ta chỉ cần thêm dấu ~ và k có phạm vi truy cập 
            {
                Console.WriteLine(" HUY DƯ LIEU ");
            }
            public void Infor()
            {
                Console.WriteLine(" Can Nang = {0}\n Chieu Cao  = {1}\n Tuoi = {2}", CanNang, ChieuCao, Tuoi);
            }
        }
        static void Main()
        // hàm khởi tạo sẽ gọi hàm phụ hợp và đủ nhất để biên dịch 
        // tao có thể tạo nhiều hàm khởi tạo nhưng phải khác nhau (kiểu dữ kiệu ,tên ,.....)
        {
            Cat meoDen = new Cat();// khi mình tạo hàm khởi tạo với giá trị cho trước thì in ra gia trị đó
            meoDen.Infor();
            Cat meoTrang = new Cat(5f,5f,5);// khi mình khởi tạo giá trị truyền vào tham số thì phải truyền vào đủ và đúng thứ tự 
            meoTrang.Infor();



            //Cat meoDien = new Cat(kg:5,h:10,old:11) khi ta dùng khởi tạo ngầm định 
        }

    }
}
