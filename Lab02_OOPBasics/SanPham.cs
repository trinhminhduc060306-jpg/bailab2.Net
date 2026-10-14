using System;
using System.Collections.Generic;
using System.Text;

namespace Lab02_OOPBasics
{
    internal class SanPham
    {
        public string MaSP { get; set; }
        public string TenSP { get; set; }

        private double donGia;
        public double DonGia
        {
            get { return donGia; }
            set
            {
                if (value < 0)
                    throw new ArgumentException(
                        "Don gia khong duoc am!");
                donGia = value;
            }
        }

        private int soLuong;
        public int SoLuong
        {
            get { return soLuong; }
            set
            {
                if (value < 0)
                    throw new ArgumentException(
                        "So luong khong duoc am!");
                soLuong = value;
            }
        }

        // Constructor
        public SanPham(string maSP, string tenSP,
                       double donGia, int soLuong)
        {
            MaSP = maSP;
            TenSP = tenSP;
            DonGia = donGia;
            SoLuong = soLuong;
        }

        // Tinh thanh tien
        public double ThanhTien()
        {
            return DonGia * SoLuong;
        }

        // Hien thi thong tin
        public void HienThi()
        {
            Console.WriteLine("Ma SP: " + MaSP);
            Console.WriteLine("Ten SP: " + TenSP);
            Console.WriteLine("Don gia: " + DonGia.ToString("N2"));
            Console.WriteLine("So luong: " + SoLuong);
            Console.WriteLine("Thanh tien: " + ThanhTien().ToString("N2"));
        }
    }


}
