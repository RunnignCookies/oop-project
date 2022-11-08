using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongTro
{
    public class KienTruc
    {
        protected Nguoi nguoi;
        protected String diaChi;
        protected String tenKienTruc;

        public KienTruc()
        {
        }

        public KienTruc(Nguoi nguoi, string diaChi, string tenKienTruc)
        {
            this.nguoi = nguoi;
            this.diaChi = diaChi;
            this.tenKienTruc = tenKienTruc;
        }
    }
    public class NhaTro : KienTruc
    {
        public NhaTro()
        {
        }

        public NhaTro(NguoiChoThue nguoi, string diaChi, string tenKienTruc) : base(nguoi, diaChi, tenKienTruc)
        {
        }
    }
    public class CongTyMoiGioi : KienTruc
    {
        public CongTyMoiGioi()
        {
        }

        public CongTyMoiGioi(NguoiMoiGioi nguoi, string diaChi, string tenKienTruc) : base(nguoi, diaChi, tenKienTruc)
        {
        }
    }
}
