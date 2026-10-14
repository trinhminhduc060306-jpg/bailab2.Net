using System;
using System.Collections.Generic;
using System.Text;

namespace Lab02_OOPBasics
{
    internal class SinhVien
    {
        private string maSV;
        private string hoTen;
        private DateTime ngaySinh;
        private double diemTB;

        public string MaSV
        {
            get { return maSV; }
            set { maSV = value; }
        }

        public string HoTen
        {
            get { return hoTen; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Ho ten khong duoc rong!");
                }
                hoTen = value;
            }
        }

        public DateTime NgaySinh
        {
            get { return ngaySinh; }
            set { ngaySinh = value; }
        }

        public double DiemTB
        {
            get { return diemTB; }
            set
            {
                if (value < 0 || value > 10)
                {
                    throw new ArgumentOutOfRangeException(
                        nameof(DiemTB),
                        "Diem phai tu 0 den 10!");
                }
                diemTB = value;
            }
        }

        // Constructor mặc định
        public SinhVien()
        {
            maSV = "Chưa có";
            hoTen = "Chưa có";
            ngaySinh = DateTime.Today;
            diemTB = 0;
        }

        // Constructor có tham số
        public SinhVien(string maSV, string hoTen, DateTime ngaySinh, double diemTB)
        {
            MaSV = maSV;
            HoTen = hoTen;
            NgaySinh = ngaySinh;
            DiemTB = diemTB;
        }

        public void HienThi()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Ma sinh vien: " + MaSV);
            Console.WriteLine("Ho ten: " + HoTen);
            Console.WriteLine("Ngay sinh: " + NgaySinh.ToString("dd/MM/yyyy"));
            Console.WriteLine("Diem trung binh: " + DiemTB.ToString("N2"));
        }

        public int TinhTuoi()
        {
            DateTime today = DateTime.Today;
            int tuoi = today.Year - NgaySinh.Year;

            if (NgaySinh.Date > today.AddYears(-tuoi))
            {
                tuoi--;
            }

            return tuoi;
        }

        public string XepLoai()
        {
            if (DiemTB >= 9)
                return "Xuat sac";
            else if (DiemTB >= 8)
                return "Gioi";
            else if (DiemTB >= 6.5)
                return "Kha";
            else if (DiemTB >= 5)
                return "Trung Binh";
            else
                return "Yeu";
        }
    }
}
