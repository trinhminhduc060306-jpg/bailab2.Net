
using Lab02_OOPBasics;
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("1. Thong tin sinh vien");
            Console.WriteLine("2. Constructor");
            Console.WriteLine("3. Dong goi va kiem tra du lieu");
            
            Console.WriteLine("5. Danh sach sinh vien");
            Console.WriteLine("6. Quan ly san pham");
            Console.WriteLine("7. Tai khoan ngan hang");
            Console.WriteLine("8. Quan ly nhan vien");
            Console.WriteLine("9. Hinh chu nhat");
            Console.WriteLine("10. Quan ly sinh vien");
            Console.WriteLine("0. Thoat");
            Console.Write("Chon bai: ");

            string chon = Console.ReadLine();

            switch (chon)
            {
                case "1":
                    Cau1();
                    break;
                case "2":
                    Cau2();
                    break;
                case "3":
                    Cau3();
                    break;
               
                case "5":
                    Cau5();
                    break;
                case "6":
                    Cau6();
                    break;
                case "7":
                    Cau7();
                    break;
                case "8":
                    Cau8();
                    break;
                case "9":
                    Cau9();
                    break;
                case "10":
                    Cau10();
                    break;
                case "0":
                    return;
                default:
                    Console.WriteLine("Lua chon khong hop le!");
                    break;
            }

            Console.WriteLine("\nNhan phim bat ky de tiep tuc...");
            Console.ReadKey();
            Console.Clear();
        }
    }

    // CAU 1: Thong tin sinh vien
    static void Cau1()
    {
        SinhVien sv = new SinhVien();
        sv.MaSV = "SV01";
        sv.HoTen = "Nguyen Van An";
        sv.NgaySinh = DateTime.Parse("01/01/2005");
        sv.DiemTB = 8.5;

        sv.HienThi();
    }

    // CAU 2: Constructor
    static void Cau2()
    {
        SinhVien sv1 = new SinhVien();
        SinhVien sv2 = new SinhVien(
            "SV02", "Tran Van Binh", DateTime.Parse("02/02/2005"), 7.5
        );

        Console.WriteLine("Sinh vien 1:");
        sv1.HienThi();

        Console.WriteLine("\nSinh vien 2:");
        sv2.HienThi();
    }

    // CAU 3: Dong goi va kiem tra du lieu
    static void Cau3()
    {
        try
        {
            SinhVien sv = new SinhVien(
                "SV03", "Le Minh Anh", DateTime.Parse("03/03/2005"), 9.0
            );

            sv.HienThi();
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("Loi: " + ex.Message);
        }
    }

    // CAU 5: Danh sach sinh vien
    static void Cau5()
    {
        List<SinhVien> danhSach = new List<SinhVien>();

        danhSach.Add(new SinhVien(
            "SV01", "Nguyen Van An", DateTime.Parse("01/01/2005"), 8.5
        ));
        danhSach.Add(new SinhVien(
            "SV02", "Tran Van Binh", DateTime.Parse("02/02/2005"), 7.5
        ));
        danhSach.Add(new SinhVien(
            "SV03", "Le Minh Anh", DateTime.Parse("03/03/2005"), 9.0
        ));

        Console.WriteLine("Danh sach sinh vien:");
        foreach (SinhVien sv in danhSach)
        {
            sv.HienThi();
            Console.WriteLine("--------------------");
        }

        Console.Write("Nhap ma sinh vien can tim: ");
        string ma = Console.ReadLine();

        SinhVien timThay = danhSach.Find(
            sv => sv.MaSV == ma
        );

        if (timThay != null)
        {
            Console.WriteLine("Tim thay sinh vien:");
            timThay.HienThi();
        }
        else
        {
            Console.WriteLine("Khong tim thay sinh vien!");
        }
    }

    // CAU 6: San pham
    static void Cau6()
    {
        SanPham sp = new SanPham(
            "SP01", "Ban phim", 350000.0, 2
        );

        sp.HienThi();
    }

    // CAU 7: Tai khoan ngan hang
    static void Cau7()
    {
        TaiKhoanNganHang tk = new TaiKhoanNganHang(
            "123456789", "Nguyen Van An", 1000000m
        );

        tk.HienThi();

        Console.Write("\nNhap so tien can nap: ");
        if (decimal.TryParse(Console.ReadLine(), out decimal tienNap))
        {
            tk.NapTien(tienNap);
        }
        else
        {
            Console.WriteLine("So tien khong hop le!");
        }

        Console.Write("\nNhap so tien can rut: ");
        if (decimal.TryParse(Console.ReadLine(), out decimal tienRut))
        {
            tk.RutTien(tienRut);
        }
        else
        {
            Console.WriteLine("So tien khong hop le!");
        }

        tk.KiemTraSoDu();
    }

    // CAU 8: Nhan vien
    static void Cau8()
    {
        NhanVien nv = new NhanVien(
            "NV01", "Nguyen Van An", 5000000m, 2.5m
        );

        nv.HienThi();
    }

    // CAU 9: Hinh chu nhat
    static void Cau9()
    {
        HinhChuNhat hcn = new HinhChuNhat(10, 5);
        hcn.HienThi();
    }

    // CAU 10: Quan ly sinh vien don gian
    static void Cau10()
    {
        List<SinhVien> danhSach = new List<SinhVien>();
        bool tiepTuc = true;

        while (tiepTuc)
        {
            Console.WriteLine("\n--- QUAN LY SINH VIEN ---");
            Console.WriteLine("1. Them sinh vien");
            Console.WriteLine("2. Hien thi danh sach");
            Console.WriteLine("3. Tim sinh vien theo ma");
            Console.WriteLine("0. Quay lai menu chinh");
            Console.Write("Chon: ");

            string luaChon = Console.ReadLine();

            switch (luaChon)
            {
                case "1":
                    Console.Write("Ma sinh vien: ");
                    string ma = Console.ReadLine();

                    Console.Write("Ho ten: ");
                    string ten = Console.ReadLine();

                    Console.Write("Ngay sinh: ");
                    string ngaySinh = Console.ReadLine();

                    Console.Write("Diem trung binh: ");
                    if (double.TryParse(
                        Console.ReadLine(), out double diem))
                    {
                        try
                        {
                            danhSach.Add(new SinhVien(
                                ma, ten, DateTime.Parse(ngaySinh), diem
                            ));
                            Console.WriteLine("Them thanh cong!");
                        }
                        catch (ArgumentException ex)
                        {
                            Console.WriteLine("Loi: " + ex.Message);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Diem khong hop le!");
                    }
                    break;

                case "2":
                    if (danhSach.Count == 0)
                    {
                        Console.WriteLine("Danh sach dang rong.");
                    }
                    else
                    {
                        foreach (SinhVien sv in danhSach)
                        {
                            sv.HienThi();
                            Console.WriteLine("--------------------");
                        }
                    }
                    break;

                case "3":
                    Console.Write("Nhap ma can tim: ");
                    string maTim = Console.ReadLine();

                    SinhVien svTim = danhSach.Find(
                        sv => sv.MaSV == maTim
                    );

                    if (svTim != null)
                        svTim.HienThi();
                    else
                        Console.WriteLine("Khong tim thay!");
                    break;

                case "0":
                    tiepTuc = false;
                    break;

                default:
                    Console.WriteLine("Lua chon khong hop le!");
                    break;
            }
        }
    }
}
