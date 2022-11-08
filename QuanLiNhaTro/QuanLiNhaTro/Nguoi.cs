using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiNhaTro
{
    class Nguoi
    {
        public string ten;
        public DateTime ngaysinh;
        public string id;
        public bool gioitinh;
        public string nghenghiep;
        public string hokhau;
        public string sdt;
        public bool ykien;
        public Nguoi()
        {

        }
        public Nguoi(string hokhau, string ten, string id, string sdt, DateTime ngaysinh, string nghenghiep, bool gioitinh, bool ykien)
        {
            this.hokhau = hokhau;
            this.ten = ten;
            this.id = id;
            this.ngaysinh = ngaysinh;
            this.sdt = sdt;
            this.nghenghiep = nghenghiep;
            this.gioitinh = gioitinh;
            this.ykien = ykien;
        }
    }
    class Nguoichothue : Nguoi
    {
        public Nguoichothue()
        {

        }

        public Nguoichothue(string hokhau, string ten, string id, string sdt, DateTime ngaysinh, string nghenghiep,bool  gioitinh, bool ykien) : base(hokhau, ten, id, sdt, ngaysinh, nghenghiep, gioitinh, ykien)
        {
        }


    }
    class Nguoithue:Nguoi
    {
        public Nguoithue()
        {

        }

        public Nguoithue(string hokhau, string ten, string id, string sdt, DateTime ngaysinh, string nghenghiep, bool gioitinh, bool ykien) : base(hokhau, ten, id, sdt, ngaysinh, nghenghiep, gioitinh, ykien)
        {
        }

    }
    class Nguoimoigioi:Nguoi
    {
        public CongTyMoiGioi congty;
        public Nguoimoigioi()
        {

        }
        public Nguoimoigioi(string hokhau, string ten, string id, string sdt, DateTime ngaysinh, string nghenghiep, bool gioitinh, bool ykien, CongTyMoiGioi congty) : base(hokhau, ten, id, sdt, ngaysinh, nghenghiep, gioitinh, ykien)
        {
                this.congty = congty;
        }
    }
}
