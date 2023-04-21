using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinhVien
{
    class SinhVienA
    {
        public String SBD { get; set; }
        public String HoTen { get; set; }
        public String DiaChi { get; set; }
        public double Toan { get; set; }
        public double Ly { get; set; }
        public double Hoa { get; set; }
        public double DiemUT { get; set; }
        public double TongDiem
        {
            get { return Toan + Ly + Hoa + DiemUT; }
        }
        public SinhVienA() { }
        public SinhVienA(string sBD, string hoTen, string diaChi, double toan, double ly, double hoa, double diemUT)
        {
            SBD = sBD;
            HoTen = hoTen;
            DiaChi = diaChi;
            Toan = toan;
            Ly = ly;
            Hoa = hoa;
            DiemUT = diemUT;
        }
        public void Nhap()
        {
            Console.Write("Số Báo Danh: ");
            SBD = Console.ReadLine();
            Console.Write("Họ Tên: ");
            HoTen = Console.ReadLine();
            Console.Write("Địa Chỉ: ");
            DiaChi = Console.ReadLine();
            Console.Write("Điểm Toán: ");
            Toan = double.Parse(Console.ReadLine());
            Console.Write("Điểm Lý: ");
            Ly = double.Parse(Console.ReadLine());
            Console.Write("Điểm Hóa: ");
            Hoa = double.Parse(Console.ReadLine());
            Console.Write("Điểm ưu Tiên: ");
            DiemUT = double.Parse(Console.ReadLine());
        }
        public static void inTieuDe()
        {
            Console.WriteLine("{0, -15}{1, -15}{2, -15}{3, -15}{4, -15}{5, -15}{6, -15}{7, -15}", "SBD", "Họ Tên", "Địa Chỉ", "Toán", "Lý","Hóa", "Điểm ƯT", "Tổng Điểm");
        }
        public void inDL()
        {
            Console.WriteLine("{0, -15}{1, -15}{2, -15}{3, -15}{4, -15}{5, -15}{6, -15}{7, -15}", SBD,HoTen, DiaChi,Toan, Ly, Hoa, DiemUT, TongDiem ) ;
        }
    }

}
