using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phuong_thuc
{
    internal class phamvitruycap
    {
        /*
         * public : nội bộ 
         * private : chỉ nội bộ bên trong lớp 
         * protected :  chỉ nội bộ bên trong lớp và lớp nó dẫn xuất 
         * internal : chỉ được truy cập trong cùng 1 project thuộc tính này thường dùng trong class 
         * protected internal : tương tự internal và thêm lớp dẫn xuất 
         * LƯU Ý :
         * - nếu khai báo lớp mà không ghi j đằng trước thì là internal
         * - nếu khai báo thành phần bên trong lớp không ghi j thì là private 
         * 
         * --> thuộc tính lên để private để bảo mật 
         * --> phương thức(hàm)để là public  
         */

        class nguoi
        {
            private string name, address;
            private int tuoi;

            public int Tuoi { get => tuoi; set => tuoi = value; } // hàm get set ngắn gọn ctrl + R + E

            public nguoi(int tuoi)
            {
                this.name = "dang thanh hai";
                this.address = "thai binh";
                if (tuoi > 0 && tuoi <= 150)// hàm khởi tạo điều kiện với tuổi
                {
                    this.Tuoi = tuoi;
                }
                else
                {
                    Console.WriteLine(" tuoi nhap vao khong hop le : ");
                }
            }

            public void SetTuoi(int tuoi) // hàm set mà người dùng tự đặt 
            {
                if (tuoi < 0 && tuoi > 150)
                {
                    Console.WriteLine(" tuoi nhap vao khong hop le : ");
                }
                else
                {
                    this.Tuoi = tuoi;
                }
            }
            public int GetTuoi()
            {
                return this.Tuoi;
            }
            public void inFor()
            {
                Console.WriteLine(" ten  = {0}\n dia chi = {1}\n tuoi = {2}", name, address, Tuoi);
            }
        }
        static void Main()
        {
            nguoi a = new nguoi(10);
            a.SetTuoi(200);
            a.inFor();


        }

    }
}
