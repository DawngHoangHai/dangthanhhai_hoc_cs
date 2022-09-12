using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bt.oop
{
    internal class Program
    {
        class HCN
        {
            private int chieudai, chieurong;
            public HCN()
            {
                this.chieudai = 10;
                this.chieurong = 9;
            }
            public HCN(int chieudai, int chieurong)
            {
                this.chieudai = chieudai;
                this.chieurong = chieurong;
            }
            public float chuVi()
            {
                return (float)(this.chieudai + this.chieurong) * 2;
            }
            public float dienTich()
            {
                return this.chieudai * this.chieurong;
            }
            public void outPut()
            {
                Console.WriteLine(" - Chieu Dai = {0}\n - Chieu Rong = {1}\n - Chu Vi = {2}\n - Dien Tich = {3}"
                    , chieudai, chieurong, chuVi(), dienTich());
            }
        }
        static void Main(string[] args)
        {
            HCN hcn = new HCN(5, 2);// truyền tham số vào đây đỡ tạo hàm nhập 
            hcn.outPut();
            DA_THUC []a = new DA_THUC[5];
            a[0].InPut();
        }
    }
}
