using System;
using System.Collections.Generic;
using System.Text;

namespace Lab02_OOPBasics
{
    internal class HinhChuNhat
    {
        public double ChieuDai { get; set; }
        public double ChieuRong { get; set; }

        public HinhChuNhat(double chieuDai, double chieuRong)
        {
            if (chieuDai <= 0 || chieuRong <= 0)
            {
                throw new ArgumentException(
                    "Chieu dai va chieu rong phai lon hon 0!"
                );
            }

            ChieuDai = chieuDai;
            ChieuRong = chieuRong;
        }

        public double TinhChuVi()
        {
            return (ChieuDai + ChieuRong) * 2;
        }

        public double TinhDienTich()
        {
            return ChieuDai * ChieuRong;
        }

        public void HienThi()
        {
            Console.WriteLine("Chieu dai: " + ChieuDai);
            Console.WriteLine("Chieu rong: " + ChieuRong);
            Console.WriteLine("Chu vi: " + TinhChuVi());
            Console.WriteLine("Dien tich: " + TinhDienTich());
        }
    }
}
