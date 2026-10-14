using System;
using System.Collections.Generic;
using System.Text;

namespace Lab02_OOPBasics
{
    internal class NhanVien
    {
        public string MaNV { get; set; }
        public string HoTen { get; set; }
        public decimal LuongCoBan { get; set; }
        public decimal HeSoLuong { get; set; }

        public NhanVien(string maNV, string hoTen,
                        decimal luongCoBan, decimal heSoLuong)
        {
            MaNV = maNV;
            HoTen = hoTen;
            LuongCoBan = luongCoBan;
            HeSoLuong = heSoLuong;
        }

        public decimal TinhLuong()
        {
            return LuongCoBan * HeSoLuong;
        }

        public void HienThi()
        {
            Console.WriteLine("Ma nhan vien: " + MaNV);
            Console.WriteLine("Ho ten: " + HoTen);
            Console.WriteLine("Luong co ban: " + LuongCoBan);
            Console.WriteLine("He so luong: " + HeSoLuong);
            Console.WriteLine("Luong thuc nhan: " + TinhLuong());
        }
    }
}
