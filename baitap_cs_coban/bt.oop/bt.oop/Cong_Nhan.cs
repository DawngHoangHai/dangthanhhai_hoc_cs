using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bt.oop
{
    internal class Cong_Nhan
    {
        private string hoTen, queQuan;
        private int tuoi;
        private float bacLuong;

        public float BacLuong { get => bacLuong; set => bacLuong = value; } // tạo ra hàm get set để lấy dữ liệu đóng gói.

        public Cong_Nhan(string hoTen = "Dang Thanh Hai", string queQuan = "Thai Binh", int tuoi = 20, float bacLuong = 2.0f)
        {
            this.hoTen = hoTen;
            this.queQuan = queQuan;
            this.tuoi = tuoi;
            this.BacLuong = bacLuong;
        }
        public float tienLuong()
        {
            return BacLuong * 2500 + (BacLuong * 2500 * 0.2f);
        }
        public void outPut()
        {
            Console.WriteLine("\n - Ten  : {0}\n - Que Quan  : {1}\n - Tuoi  : {2}\n - Bac Luong  : {3}\n - Luong  : {4}"
                , hoTen, queQuan, tuoi, BacLuong, tienLuong());
        }

    }
    class MAIN
    {
        static void Main()
        {
            Cong_Nhan cn = new Cong_Nhan();
            cn.BacLuong = 3.1f;
            cn.outPut();
        }
    }
}
