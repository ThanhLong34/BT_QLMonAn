using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_QLMonAn
{
    public class MonAn
    {
        public int maMonAn { get; set; }
        public string tenMonAn { get; set; }
        public string dvt { get; set; }
        public int donGia { get; set; }
        public int nhom { get; set; }

        public MonAn()
        {

        }

        public MonAn(int maMonAn, string tenMonAn, string dvt, int donGia, int nhom)
        {
            this.maMonAn = maMonAn;
            this.tenMonAn = tenMonAn;
            this.dvt = dvt;
            this.donGia = donGia;
            this.nhom = nhom;
        }
    }
}
