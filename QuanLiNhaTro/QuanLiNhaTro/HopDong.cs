using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiNhaTro
{
    class HopDong
    {
            public Nguoichothue chutro;
            public Nguoithue nguoithuetro;
            public Phongtro phongtro;
            public double tiendatcoc;
            public double tienboithuong;
            public int khoangthoigian;
            public DateTime batdau;
            public DateTime hethan;
            public Mondo mondo;

            public HopDong()
            {

            }

            public HopDong(Nguoichothue chutro, Nguoithue nguoithuetro, Phongtro phongtro, Mondo mondo, double tienboithuong, double tiendatcoc)
            {
                this.mondo = mondo;
                this.tienboithuong = tienboithuong;
                this.chutro = chutro;
                this.nguoithuetro = nguoithuetro;
                this.phongtro = phongtro;
                this.tiendatcoc = phongtro.giaphong * 0.3;
            }
            public void ngayhethanhopdong()
            {
                if (khoangthoigian+ batdau.Month>12)
                {
                    hethan = batdau;
                    hethan.Month = hethan.Month + khoangthoigian - 12;
                    hethan.Year++;
                    Console.WriteLine("Ngay het han la: " + hethan.ToString("dd/mm/yyyy"));

                }
            }

            public void thoihanhopdong()
            {
                Console.WriteLine("Thoi han bat dau tu" + batdau + "den ngay" + hethan);
            }
            public bool nguoithay;
            public DateTime now;
            public bool benhuy; // true : chu, false: nguoi thue
            public void Huyhopdong()
            {
                if (benhuy == true)
                {
                    if (dadenhan() == true)
                        Console.WriteLine("khong boi thuong");
                    else
                    {
                        Console.WriteLine("Boi thuong" + tiendatcoc);
                        Review();
                    }

                }
                else
                {
                    if (dadenhan() == true)
                        Console.WriteLine("Khong boi thuong");
                    else
                    {
                        if (nguoithay != true)
                            Console.WriteLine("Khong boi thuong");
                        else
                        {
                            Console.WriteLine("Boi thuong" + phongtro.giaphong * 0.7);
                            Baocao();
                        }
                    }

                }
            }
            public bool dadenhan()
            {
                if (now.Year - hethan.Year > 0)
                    return false;
                else
                {
                    if (now.Month - hethan.Month > 0)
                        return false;
                    else
                        if (now.Day - hethan.Day > 0)
                        return false;

                }
                return true;

            }
            public void Review()
            {
                Console.WriteLine("Nha Tro Khong uy tin ");
            }
            public void Baocao()
            {
                Console.WriteLine("Khach huy hop dong phai boi thuong");
            }
            public void huhong()
            {
                if (mondo.cua == false)
                        tienboithuong += mondo.giacua;
                if (mondo.bep == false)
                        tienboithuong += mondo.giabep;
                if (mondo.rem == false)
                        tienboithuong += mondo.giarem;
                if (mondo.maylanh == false)
                        tienboithuong += mondo.giamaylanh;
            }
            public void Traphong()
            {
                if (dadenhan())
                    Console.WriteLine("ket thuc hop dong");
                else
                    Console.WriteLine("Tra tien phong theo hop dong: " + phongtro.giaphong);
            }
    }
    class Mondo
    {
            public bool cua;
            public double giacua;
            public bool bep;
            public double giabep;
            public bool rem;
            public double giarem;
            public bool maylanh;
            public double giamaylanh;
            public Mondo()
            {

            }

            public Mondo(bool cua, double giacua, bool bep, double giabep, bool rem, double giarem, bool maylanh, double giamaylanh)
            {
                this.cua = cua;
                this.giacua = giacua;
                this.bep = bep;
                this.giabep = giabep;
                this.rem = rem;
                this.giarem = giarem;
                this.maylanh = maylanh;
                this.giamaylanh = giamaylanh;
            }
    }
}
