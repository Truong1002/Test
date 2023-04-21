using SinhVien;
using System;

class program
{
    static List<SinhVienA> dsSinhVien = new List<SinhVienA>();
    static void Nhap()
    {
        SinhVienA sinhVien = new SinhVienA();
        sinhVien.Nhap();
        dsSinhVien.Add(sinhVien);
    }
    static void HienThi()
    {
        SinhVienA.inTieuDe();
        foreach(SinhVienA sv in dsSinhVien)
        {
            sv.inDL();
        }
    }
    static void HienThiTheoTongDiem()
    {
        Console.Write("Nhập Điểm: ");
        double diem = double.Parse(Console.ReadLine());
        SinhVienA.inTieuDe();
        foreach(SinhVienA sv in dsSinhVien)
        {
            if(diem <= sv.TongDiem)
            {
                sv.inDL();
            }
        }
    }
    static void HienThiTheoDiaChi()
    {
        Console.Write("Nhập Địa Chỉ: ");
        string diachi = Console.ReadLine();
        SinhVienA.inTieuDe();
        foreach (SinhVienA sv in dsSinhVien)
        {
            if (diachi == sv.DiaChi)
            {
                sv.inDL();
            }
        }
    }
    static void TimKiemTheoSBD()
    {
        Console.Write("Nhập SBD: ");
        string sbd = Console.ReadLine();
        SinhVienA.inTieuDe();
        foreach (SinhVienA sv in dsSinhVien)
        {
            if (sbd == sv.SBD)
            {
                sv.inDL();
            }
        }
    }
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        int chon;
        do
        {
            Console.WriteLine("MENU");
            Console.WriteLine("1. Nhập thông tin 1 thí sinh");
            Console.WriteLine("2. Hiển thị danh sách các thí sinh");
            Console.WriteLine("3. Hiển thị các sinh viên theo tổng điểm");
            Console.WriteLine("4. Hiển thị các sinh viên theo địa chỉ");
            Console.WriteLine("5. Tìm Kiếm theo số báo danh");
            Console.WriteLine("6. Kết thúc chương trình");
            Console.WriteLine("7. Truyền file");
            Console.WriteLine("Nhập lựa chọn: ");
            chon = int.Parse(Console.ReadLine());
            switch (chon)
            {
                case 1:
                    Nhap();
                    break;
                case 2:
                    HienThi();
                    break;
                case 3:
                    HienThiTheoTongDiem();
                    break;
                case 4:
                    HienThiTheoDiaChi();
                    break;
                case 5:
                    TimKiemTheoSBD();
                    break;
                case 6:
                    Console.WriteLine("Chương trình kết thúc.");
                    break;
                case 7:
                    string filePath= "SinhVien.txt";
                    using (StreamWriter writer = new StreamWriter(filePath))
                    {
                        writer.WriteLine("{0, -15}{1, -15}{2, -15}{3, -15}{4, -15}{5, -15}{6, -15}{7, -15}", "SBD", "Họ Tên", "Địa Chỉ", "Toán", "Lý", "Hóa", "Điểm ƯT", "Tổng Điểm");
                        foreach(SinhVienA sv in dsSinhVien)
                        {
                            writer.WriteLine("{0, -15}{1, -15}{2, -15}{3, -15}{4, -15}{5, -15}{6, -15}{7, -15}", sv.SBD, sv.HoTen, sv.DiaChi, sv.Toan, sv.Ly, sv.Hoa, sv.DiemUT, sv.TongDiem);
                        }
                    }

                    break;
                default:
                    Console.WriteLine("Lụa Chọn Không Hợp Lệ");
                    break;
            }
        } while (chon != 6);
    }
}