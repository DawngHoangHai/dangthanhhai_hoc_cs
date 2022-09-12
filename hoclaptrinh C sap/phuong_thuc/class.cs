using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phuong_thuc
{
    /* - hướng đối tượng : là phương pháp lập trình dựa ttreen mô hình hóa
         đưa cái đối tưởng từ thế giới ngoài vào trong lập trinh thể hiện qua các lớp
         - lớp :  là kiểu dữ liệu do ngưới dùng tự định nghĩa ra để mô hình hóa đối tượng 
         {
            gồm có dữ liệu , phương thức 
         }.
         - đối tượng : là đối tượng thực tế : máy tính ,con vật....., đối tượng trừu tượng: đơn hàng ,tiển ảo......
         --> là sản phẩm của các lớp trong ngôn ngữ lập trình 
         1 đối tượng khi được tạo ra phải sử dụng new vd: CAT meo = new CAT();
         */
    class Con_Meo
    {
        public string Ten, MauSac;
        public int tuoi, canNang;
        public void Thongtin()
        {
            Console.WriteLine("\n - TEN MEO : {0}\n - MAU SAC : {1} \n - TUOI : {2}\n - CAN NANG : {3}"
                , Ten, MauSac, tuoi, canNang);
        }
    }
    class Con_Nguoi
    {
        public string Name, queQuan;
        public int tuoi;
        public void Infor()
        {
            Console.WriteLine("\n - TEN : {0}\n - QUE QUAN: {1} \n - TUOI : {2}", Name, queQuan, tuoi);
        }
    }
    class program
    {
        static void Main()
        {
            Con_Meo con = new Con_Meo();
            con.Ten = "petss"; con.MauSac = "black"; con.tuoi = 10; con.canNang = 5;
            con.Thongtin();
            Con_Nguoi con2 = new Con_Nguoi();
            con2.Name = " dang thanh hai "; con2.queQuan = "thai binh"; con2.tuoi = 30;
            con2.Infor();
        }
    }
    /* class : là kiểu tham chiếu nên k cần dùng ref và out vì dữ liệu đến đầu lưu vào đến đó 
     * stuct : là kiểm tham trị cần dùng ref và out vì nó sẽ lưu ra vùng nhớ khác xong cóp lại 
     *..................../
}
