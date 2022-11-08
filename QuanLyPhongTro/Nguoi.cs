using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongTro
{
    public class Nguoi
    {
        protected String ten;
        protected String id;
        protected DateOnly ns;
        protected String diaChi;
        protected String ngheNghiep;
        protected String gioiTinh;
        protected String sdt;
        public Nguoi() { }

        public Nguoi(string ten, string id, DateOnly ns, string diaChi, string ngheNghiep, string gioiTinh, string sdt)
        {
            this.ten = ten;
            this.id = id;
            this.ns = ns;
            this.diaChi = diaChi;
            this.ngheNghiep = ngheNghiep;
            this.gioiTinh = gioiTinh;
            this.sdt = sdt;
        }

        public virtual void XuatThongTin(){ }

    }

    public class NguoiThue:Nguoi
    {
        public NguoiThue() { }

        public NguoiThue(string ten, string id, DateOnly ns, string diaChi, string ngheNghiep, string gioiTinh, string sdt) : base(ten, id, ns, diaChi, ngheNghiep, gioiTinh, sdt)
        {
        }


    }

    public class NguoiChoThue:Nguoi
    {
        public NguoiChoThue() { }

        public NguoiChoThue(string ten, string id, DateOnly ns, string diaChi, string ngheNghiep, string gioiTinh, string sdt) : base(ten, id, ns, diaChi, ngheNghiep, gioiTinh, sdt)
        {
        }

    }
    public class NguoiMoiGioi : Nguoi
    {
        public NguoiMoiGioi()
        {
        }
        public NguoiMoiGioi(string ten, string id, DateOnly ns, string diaChi, string gioiTinh, string sdt) : base(ten, id, ns, diaChi, "nguoi moi gioi", gioiTinh, sdt)
        {
        }
    }
}
