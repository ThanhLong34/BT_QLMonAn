using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_QLMonAn
{
    public class QuanLyNhomMonAn
    {
        private List<NhomMonAn> ds;

        public QuanLyNhomMonAn()
        {
            ds = new List<NhomMonAn>();
        }

        public void them(NhomMonAn item)
        {
            ds.Add(item);
        }

        public List<NhomMonAn> layDS()
        {
            return ds;
        }

        public void clear()
        {
            ds.Clear();
        }
    }
}
