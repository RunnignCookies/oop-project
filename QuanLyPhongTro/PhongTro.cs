using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongTro
{
    public class PhongTro
    {
        protected Double dienTich;
        protected String dacDiem;
        protected NoiThat noiThat;
        protected String soPhong;
        protected int soLuongNguoiMax;
        protected Double giaCa;
        public PhongTro() { }

        public PhongTro(double dienTich, string dacDiem, NoiThat noiThat, string soPhong, int soLuongNguoiMax, double giaCa)
        {
            this.dienTich = dienTich;
            this.dacDiem = dacDiem;
            this.noiThat = noiThat;
            this.soPhong = soPhong;
            this.soLuongNguoiMax = soLuongNguoiMax;
            this.giaCa = giaCa;
        }
        public Double GiaCa() { return giaCa; }
    }
    public class NoiThat
    {
        protected List<String> noiThat;
        public NoiThat(List<String> noiThat) 
        {
            this.noiThat = noiThat;
        }
    }
}
