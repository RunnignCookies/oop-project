using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiNhaTro
{
    class NhaTro
    {
        public Nguoichothue chutro;
        public string diachi;
        public string dientich;
        public string noithat;
        public double giaphong;
        public int sophong;
        public NhaTro()
        {

        }
        public NhaTro(string diachi,Nguoichothue chutro, string dientich, string noithat, double giaphong, int sophong)
        {
            this.diachi = diachi;
            this.chutro = chutro;
            this.dientich = dientich;
            this.noithat = noithat;
            this.giaphong = giaphong;
            this.sophong = sophong;
        }
        
    }
    class Phongtro : NhaTro
    {
         
        public Phongtro()
        {

        }

        public Phongtro(string diachi, Nguoichothue chutro, string dientich, string noithat, double giaphong, int sophong) : base(diachi, chutro, dientich, noithat, giaphong, sophong)
        {
        }
    }
}
