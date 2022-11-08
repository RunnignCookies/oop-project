using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongTro
{
    public class HopDong
    {
        protected DateOnly ngayBatDau;
        protected DateOnly ngayHetHan;
        protected int thoiHanThue;
        protected String donViThue;
        protected String donVi;
        protected NguoiChoThue chu;
        protected NguoiThue khach;
        protected NguoiMoiGioi nhanvien;
        protected PhongTro phongTro;
        protected double tienDatCoc;
        
        public HopDong()
        {
        }
        public void NgayHetHan(DateOnly ngayBatDau, int thoiHanThue,String donVi)
        {
            int[] thang = {0,31,28,31,30,31,30,31,31,30,31,30,31};
            int d = ngayBatDau.Day;
            int m = ngayBatDau.Month;
            int y = ngayBatDau.Year + thoiHanThue;
            if (donVi.Equals("nam"))
            {
                
                if (m < 3 && NamNhuan(ngayBatDau.Year)) d--;
                if (m > 3 && NamNhuan(y)) d--;
                for (int i = ngayBatDau.Year+1; i <= y; i++)
                {
                    if (NamNhuan(i)) d--;
                }
                if (d <= 0)
                {
                    m--;
                    if (m <= 0)
                    {
                        y--;
                        m = 12;
                        d = thang[m]+d;
                    }
                    d = thang[m] + d;
                }
                
            }
            DateOnly ngayHetHan = new DateOnly(y, m, d);
        }
        public void DangKyHopDong(NguoiChoThue chu,NguoiThue khach,NguoiMoiGioi nhanvien,DateOnly ngatBatDau,String donViThue,int thoiHanThue)
        {
            this.chu = chu;
            this.khach = khach;
            this.nhanvien = nhanvien;
            this.ngayBatDau = ngayBatDau;
            this.donViThue = donViThue;
            this.thoiHanThue = thoiHanThue;
        }
        public void Huyhopdong(bool benHuy,bool nguoiThayThe,DateOnly now)
        {
            if (benHuy == true)
            {
                if (DenHan(now) == true)
                    Console.WriteLine("khong boi thuong");
                else
                {
                    Console.WriteLine("Boi thuong" + tienDatCoc);
                    //Review();
                }

            }
            else
            {
                if (DenHan(now) == true)
                    Console.WriteLine("Khong boi thuong");
                else
                {
                    if (nguoiThayThe == true)
                        Console.WriteLine("Khong boi thuong");
                    else
                    {
                        Console.WriteLine("Boi thuong" + phongTro.GiaCa() * 0.7);
                       // Baocao();
                    }
                }

            }
        }
        public bool DenHan(DateOnly now)
        {
            if (now < ngayHetHan) return true;
            return false;
        }
        public bool NamNhuan(int nam)
        {
            if((nam%4==0 && nam%100!=0) || nam%400==0)
            {
                return true;
            }
            return false;
        }
        
    
    }
}
