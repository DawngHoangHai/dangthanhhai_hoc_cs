using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bt_2oop
{
    internal class NGUOI
    {
        private string hoTen, ngheNghiep, quocTich;
        private int tuoi;
        public NGUOI()
        {
            hoTen = "DANG THANH HAI";
            tuoi = 20;
            ngheNghiep = "CNTT";
            quocTich = "VIET NAM";
        }
        public NGUOI(string hoTen, string ngheNghiep, string quocTich, int tuoi)
        {
            this.hoTen = hoTen;
            this.ngheNghiep = ngheNghiep;
            this.quocTich = quocTich;
            this.tuoi = tuoi;
        }
        ~NGUOI() { }
        public void InPut()
        {
            Console.Write("\n\t - Nhập vào họ tên : "); hoTen = Console.ReadLine();
            Console.Write("\n\t - Nhập vào tuổi : "); tuoi = int.Parse(Console.ReadLine());
            Console.Write("\n\t - Nhập vào quốc tịch : "); quocTich = Console.ReadLine();
            Console.Write("\n\t - Nhập vào nghề nghiệp : "); ngheNghiep = Console.ReadLine();
        }
        public void OutPut()
        {
            Console.WriteLine("\t| {0,25}  |  {1,10}  | {2,25}  | {3,25}  |" +
                "\n\t+=====================================================================================================+"
                , hoTen.ToUpper().Trim(), tuoi, quocTich.ToUpper().Trim(), ngheNghiep.ToUpper().Trim());
        }
        static void TieuDe()
        {
            Console.WriteLine("\t+=====================================================================================================+" +
                "\n\t| {0,25}  |  {1,10}  | {2,25}  | {3,25}  |" +
                "\n\t+=====================================================================================================+"
                , "HỌ TÊN", "TUỔI", "QUỐC TỊCH", "NGHỀ NGHIỆP");
        }
        static void Nhap(NGUOI[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\n [+]Nhập vào người thứ [{i + 1}] : ");
                a[i] = new NGUOI();
                a[i].InPut();
            }
        }
        static void Xuat(NGUOI[] a, int n)
        {
            TieuDe();
            for (int i = 0; i < n; i++)
            {
                a[i].OutPut();
            }
        }
        static void SapXepTangDan(NGUOI[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (a[i].hoTen.Length > a[j].hoTen.Length)
                    {
                        NGUOI tm = a[i];
                        a[i] = a[j];
                        a[j] = tm;
                    }
                }
            }
            Console.WriteLine("\n\t\t\t\tDANH SÁCH HỌ TÊN SẮP XẾP TĂNG DẦN LÀ !!");
            Xuat(a, n);
        }
        static void TimKiem(NGUOI[] a, int n, bool kiemTra = false)
        {
            Console.WriteLine("\n\t\t\t\tDANH SÁCH CÓ NGƯỜI LÀM NGHỀ BÁC SĨ LÀ !!");
            TieuDe();
            for (int i = 0; i < n; i++)
            {
                if (a[i].ngheNghiep.ToUpper().Trim() == "BAC SI")
                {
                    kiemTra = true;
                    a[i].OutPut();
                }
            }
            if (kiemTra == false)
            {
                Console.WriteLine("\n\t\t\t\t--> DANH SÁCH KHÔNG CÓ AI LÀM NGHỀ BÁC SĨ À !!");
            }
        }
        static void Xoa(NGUOI[] a, int n, bool kiemTra = false)
        {
            for (int i = 0; i < n; i++)
            {
                if (a[i].quocTich.ToUpper().Trim() == "CAMPUCHIA")
                {
                    n--;
                    a[i] = a[i + 1];
                    kiemTra = true;
                }
            }
            if (kiemTra == true)
            {
                Console.WriteLine("\n\t\t\t\tDANH SÁCH SAU KHI XÓA NGƯỜI Ở CAMPUCHIA LÀ !!");
                Xuat(a, n);
            }
            else
            {
                Console.WriteLine("\n\t\t\t\t--> DANH SÁCH KHÔNG CÓ AI SỐNG Ở CAMPUCHIA À !!");
            }
        }
        static void TimTuoi(NGUOI[] a, int n, bool kiemTra = false)
        {
            NGUOI max = a[0], min = a[0];
            for (int i = 0; i < n; i++)
            {
                if (max.tuoi < a[i].tuoi)
                {
                    max = a[i];
                }
                if (min.tuoi > a[i].tuoi)
                {
                    min = a[i];
                }
            }
            Console.WriteLine("\n\t\t\t\tNGƯỜI CÓ ĐỘ TUỔI LỚN NHẤT LÀ !!"); TieuDe(); max.OutPut();
            Console.WriteLine("\n\t\t\t\tNGƯỜI CÓ ĐỘ TUỔI NHỎ NHẤT LÀ !!"); TieuDe(); min.OutPut();
        }
        static void Chen(NGUOI[] a, int n, bool kiemTra = false)
        {
            int viTri;
            NGUOI tenChen = new NGUOI();
            for (int i = 0; i < n; i++)
            {
                if (a[i].hoTen.ToUpper().Trim() == "LE DAI NGHIA")
                {
                    kiemTra = true;
                }
            }
            if (kiemTra == true)
            {
                Console.WriteLine("\n\t\t\t\t---->> DANH SÁCH ĐÃ CÓ NGƯỜI TÊN LÊ ĐẠI NGHĨA RỒI  !!");
            }
            else
            {
                Console.WriteLine("\n\t\t\t\tDANH SÁCH CHƯA CÓ NGƯỜI TÊN LÊ ĐẠI NGHĨA !!");
                n++;
                Console.WriteLine("\n - Nhập vào người có tên là Lê Đại NGhĩa !!! ");
                do
                {
                    tenChen.InPut();
                    if (tenChen.hoTen.ToUpper().Trim() != "LE DAI NGHIA")
                    {
                        Console.WriteLine("\n -- > MỜI NHẬP LẠI !!! ");
                    }
                } while (tenChen.hoTen.ToUpper().Trim() != "LE DAI NGHIA");
                Console.Write("\n - Nhập vào vị trí mà bạn muấn chèn : "); viTri = int.Parse(Console.ReadLine());
                for (int i = n; i >= viTri; i--)
                {
                    a[i] = a[i - 1];
                }
                a[viTri - 1] = tenChen;
                Console.WriteLine("\n\n\n");
                Xuat(a, n);
            }
        }
        static void Main()
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.Write(" - [+] Nhập Vào Số Lượng Con Người : "); int n = int.Parse(Console.ReadLine());
            NGUOI[] a = new NGUOI[5];
            Nhap(a, n);
            Console.WriteLine("\n\t\t\t\tDANH SÁCH VỪA NGƯỜI VỪA NHẬP VÀO LÀ !!");
            Xuat(a, n);
            SapXepTangDan(a, n);
            TimKiem(a, n);
            Xoa(a, n);
            TimTuoi(a, n);
            Chen(a, n);
            Console.ReadLine();
        }
    }
}
