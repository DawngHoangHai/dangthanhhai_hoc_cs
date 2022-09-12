using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ke_Thua
{
    internal class ke_thua
    {
        /*Kế Thừa :
         * class<lớp con> : <lớp cha>{ }
         * -> trong C# không hỗ trợ đa kế thừa (1 lớp kế thừa từ nhiều lớp)
         * 
         * --> thành phần của lớp cha có được kế thừa hay không nhờ vào phạm vi truy cập 
         * (privated là không;protected,public là có)
         * 
         * phương thức khởi tạo vào hủy  là không được kế thừa 
         */
        class Annimal
        {
            protected float chieuCao, canNang, kichThuoc;
            public Annimal()
            {
                chieuCao = 5;
                canNang = 10;
                kichThuoc = 5.5f;
            }
            public Annimal(float chieuCao, float canNang, float kichThuoc) // phải gọi phương thức khởi tạo của thằng con trước
            {
                this.chieuCao = chieuCao;
                this.canNang = canNang;
                this.kichThuoc = kichThuoc;
            }

            public void Infor()
            {
                Console.WriteLine("Chieu Cao = {0}\nCan Nang = {1}\nKich Thươc = {2}", chieuCao, canNang, kichThuoc);
            }
        }
        class Cat : Annimal// khi ta kế thừa thì thuộc tính của cha con dùng được mà k cần khai báo 
        {
            protected float soLuong;
            public Cat()
            {
                chieuCao = 5;
                canNang = 10;
                kichThuoc = 5.5f;
                soLuong = 10;
            }
            // nếu gọi đến hàm khởi tạo của lớp kế thừa thì phải có base
            public Cat(float chieuCao, float canNang, float kichThuoc, float soLuong) : base(chieuCao, canNang, kichThuoc)
            {
                this.soLuong = soLuong;
            }
            public new void Infor() // muấn dùng phương thức trùng tên với lớp con thì nên dùng từ khóa new để đánh dấu
            {
                base.Infor();// gọi lại phương thức của thằng cha =  base.<tên mà mình muấn gọi>
                Console.WriteLine("so luong = " + soLuong);
            }
        }
        static void Main(string[] args)
        {
            Cat meo = new Cat(5, 5, 5, 10);
            meo.Infor();
        }
    }
}
