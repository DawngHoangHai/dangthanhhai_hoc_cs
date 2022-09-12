using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bt_2oop
{
    internal class Thi_Sinh
    {
        private string name;
        private float diemToan, diemLy, diemHoa;
        public Thi_Sinh()
        {
            Name = "DANG THANH HAI";
            diemToan = 9;
            diemLy = 9;
            diemHoa = 9;
        }
        public Thi_Sinh(string name, float diemToan, float diemLy, float diemHoa)
        {
            this.Name = name;
            this.diemToan = diemToan;
            this.diemLy = diemLy;
            this.diemHoa = diemHoa;
        }

        public string Name { get => name; set => name = value; }//ham lay va set

        public void InPut()
        {
            Console.Write("\n\t - Nhap Vao Ten Thi Sinh : "); Name = Console.ReadLine();
            Console.Write("\n\t - Nhap Vao Diem Toan : "); diemToan = float.Parse(Console.ReadLine());
            Console.Write("\n\t - Nhap Vao Diem Ly : "); diemLy = float.Parse(Console.ReadLine());
            Console.Write("\n\t - Nhap Vao Diem Hoa : "); diemHoa = float.Parse(Console.ReadLine());
        }
        public void OutPut()
        {
            Console.WriteLine("\t| {0,25} | {1,10}d | {2,10}d | {3,10}d |" +
                "\n\t+=====================================================================+"
                , Name.Trim().ToUpper(), diemToan, diemLy, diemHoa);
        }

    }
    class Progam
    {
        static void NHAP(ref Thi_Sinh[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\n - Nhap Vao Thi Sinh Thu [{i + 1}] !! :");
                a[i] = new Thi_Sinh();// khởi tạo 1 đối tượng mới 
                a[i].InPut();
            }
        }
        static void TIti()
        {
            Console.WriteLine("\n\t+=====================================================================+");
            Console.WriteLine("\t| {0,25} | {1,10}  | {2,10}  | {3,10}  |" +
                "\n\t+=====================================================================+"
                , "HO TEN", "DIEM TOAN", "DIEM LY", "DIEM LY");
        }
        static void XUAT(ref Thi_Sinh[] a, int n)
        {
            TIti();
            for (int i = 0; i < n; i++)
            {
                a[i].OutPut();
            }
        }
        static void TimKiem(ref Thi_Sinh[] a, int n, bool kiemtra)
        {
            string tentk; tieptuc:
            Console.Write("\n\t - Nhap vao Ten Thi Sinh De XOA : "); tentk = Console.ReadLine();
            for (int i = 0; i < n; i++)
            {
                if (tentk.Trim().ToUpper() == a[i].Name.ToUpper())
                {
                    kiemtra = true;
                    a[i] = a[i + 1];
                    n--;
                }
            }
            if (kiemtra == true)
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = i; j < n; j++)
                    {
                        if (a[i].Name.Length < a[j].Name.Length)
                        {
                            Thi_Sinh tg = a[i];
                            a[i] = a[j];
                            a[j] = tg;
                        }
                    }
                }
                Console.Write("\n\t\t\t DANH SACH THI SINH SAP XEP SAU KHI XOA ");
                XUAT(ref a, n);
            }
            else
            {
                Console.WriteLine("\n\t\t\t ----> KHONG CO TEN THI SINH TRONG DANH SACH !!!!");
                goto tieptuc;
            }
        }
        static void Main()
        {
            Thi_Sinh[] a = new Thi_Sinh[3];
            NHAP(ref a, 3);
            Console.Write("\n\t\t\t DANH SACH THI SINH VUA NHAP ");
            XUAT(ref a, 3);
            bool kiemtra = false;
            TimKiem(ref a, 3, kiemtra);

        }
    }
}
