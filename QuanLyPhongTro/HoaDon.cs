using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace QuanLyPhongTro
{
    public class HoaDon
    {
        protected double soTienPT;
        protected NguoiChoThue nguoiThanhToan;
        protected String Mucdichsd;
        protected int soHosd;
        protected DateOnly hanThanhToan;
        protected String maKH;
        protected String kyHD;
        protected CongToDien congTo;
        public HoaDon() { }
        public HoaDon(double soTienPT, NguoiChoThue nguoiThanhToan, string Mucdichsd, int soHosd, DateOnly hanThanhToan, string maKH, string kyHD, CongToDien congTo)
        {
            this.soTienPT = soTienPT;
            this.nguoiThanhToan = nguoiThanhToan;
            this.Mucdichsd = Mucdichsd;
            this.soHosd = soHosd;
            this.hanThanhToan = hanThanhToan;
            this.maKH = maKH;
            this.kyHD = kyHD;
            this.congTo = congTo;
        }
    }
    public class HoaDonDien : HoaDon
    {
        public HoaDonDien(double soTienPT, NguoiChoThue nguoiThanhToan, string Mucdichsd, int soHosd, DateOnly hanThanhToan, string maKH, string kyHD, CongToDien congTo) : base(soTienPT, nguoiThanhToan, Mucdichsd, soHosd, hanThanhToan, maKH, kyHD, congTo)
        {
        }
    }
    public class HoaDonNuoc : HoaDon
    {
        public HoaDonNuoc(double soTienPT, NguoiChoThue nguoiThanhToan, string Mucdichsd, int soHosd, DateOnly hanThanhToan, string maKH, string kyHD, CongToDien congTo) : base(soTienPT, nguoiThanhToan, Mucdichsd, soHosd, hanThanhToan, maKH, kyHD, congTo)
        {
        }
    }
    public class CongTo
    {
        protected String congToDoDem;
        private double luongTieuThu;

        public CongTo(string congToDoDem)
        {
            this.congToDoDem = congToDoDem;
        }
        public double getLuongTieuThu() { return luongTieuThu; }
        public void setLuongTieuThu(double luongTieuThu) { this.luongTieuThu = luongTieuThu; }
    }
    public class CongToDien:CongTo
    {
        protected KGBinhThuong bt;
        protected KGCaoDiem cd;
        protected KGThapDiem td;
        public CongToDien(string congToDoDem, KGBinhThuong bt, KGCaoDiem cd, KGThapDiem td):base(congToDoDem)
        {
            this.congToDoDem = congToDoDem;
            this.bt = bt;
            this.cd = cd;
            this.td = td;
            setLuongTieuThu(bt.getDienTieuThu() + cd.getDienTieuThu() + td.getDienTieuThu());   
        }
    }
    public class KhungGio
    {
        protected int heSoNhan;
        protected double chiSoMoi;
        protected double chiSoCu;
        private double dienTieuThu;
        public KhungGio() { }

        public KhungGio(int heSoNhan, double chiSoMoi, double chiSoCu)
        {
            this.heSoNhan = heSoNhan;
            this.chiSoMoi = chiSoMoi;
            this.chiSoCu = chiSoCu;
            this.dienTieuThu = chiSoMoi- chiSoCu;
        }
        public double getDienTieuThu() { return dienTieuThu; }
    }
    public class KGBinhThuong : KhungGio
    {
        public KGBinhThuong(int heSoNhan, double chiSoMoi, double chiSoCu) : base(heSoNhan, chiSoMoi, chiSoCu)
        {
        }
    }
    public class KGCaoDiem : KhungGio
    {
        public KGCaoDiem(int heSoNhan, double chiSoMoi, double chiSoCu) : base(heSoNhan, chiSoMoi, chiSoCu)
        {
        }
    }
    public class KGThapDiem : KhungGio
    {
        public KGThapDiem(int heSoNhan, double chiSoMoi, double chiSoCu) : base(heSoNhan, chiSoMoi, chiSoCu)
        {
        }
    }

    public class CongToNuoc : CongTo
    {
        public CongToNuoc(string congToDoDem) : base(congToDoDem)
        {

        }
    }
}
