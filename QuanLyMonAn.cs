using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_QLMonAn
{
    public class QuanLyMonAn
    {
        private List<MonAn> ds;

        public QuanLyMonAn()
        {
            ds = new List<MonAn>();
        }

        public void them(MonAn item)
        {
            ds.Add(item);
        }

        public List<MonAn> layDS()
        {
            return ds;
        }

        public void clear()
        {
            ds.Clear();
        }

        public List<MonAn> timMonAnTheoTen(string ten)
        {
            string t = ten.ToLower();
            return ds.FindAll(i => i.tenMonAn.ToLower().Contains(t));
        }

        public MonAn timMonAnTheoMa(int ma)
        {
            return ds.Find(i => i.maMonAn == ma);
        }

        public List<MonAn> locMonAnTheoNhom(int maNhom)
        {
            return ds.FindAll(i => i.nhom == maNhom);
        }
    }
}
