using System;
using System.Collections.Generic;
using System.Text;

namespace Lab02_OOPBasics
{
    internal class TaiKhoanNganHang
    {
        public string SoTaiKhoan { get; set; }
        public string TenChuTaiKhoan { get; set; }

        private decimal soDu;

        public decimal SoDu
        {
            get { return soDu; }
            private set { soDu = value; }
        }

        // Constructor
        public TaiKhoanNganHang(
            string soTaiKhoan,
            string tenChuTaiKhoan,
            decimal soDuBanDau)
        {
            if (soDuBanDau < 0)
                throw new ArgumentException(
                    "So du ban dau khong duoc am!");

            SoTaiKhoan = soTaiKhoan;
            TenChuTaiKhoan = tenChuTaiKhoan;
            SoDu = soDuBanDau;
        }

        // Nap tien
        public void NapTien(decimal soTien)
        {
            if (soTien <= 0)
            {
                Console.WriteLine(
                    "So tien nap phai lon hon 0!");
                return;
            }

            SoDu += soTien;
            Console.WriteLine("Nap tien thanh cong!");
        }

        // Rut tien
        public void RutTien(decimal soTien)
        {
            if (soTien <= 0)
            {
                Console.WriteLine(
                    "So tien rut phai lon hon 0!");
            }
            else if (soTien > SoDu)
            {
                Console.WriteLine("So du khong du!");
            }
            else
            {
                SoDu -= soTien;
                Console.WriteLine("Rut tien thanh cong!");
            }
        }

        // Kiem tra so du
        public void KiemTraSoDu()
        {
            Console.WriteLine(
                $"So du hien tai: {SoDu:N0} VND");
        }

        // Hien thi thong tin
        public void HienThi()
        {
            Console.WriteLine("So tai khoan: " + SoTaiKhoan);
            Console.WriteLine("Chu tai khoan: " + TenChuTaiKhoan);
            KiemTraSoDu();
        }
    }
}
