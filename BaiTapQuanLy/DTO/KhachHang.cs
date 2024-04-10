using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapQuanLy.DTO
{
    public class KhachHang
    {
        //Field
        string maKH, hoKH, tenKh, dcKH, dtKH;

   

        public string DtKH
        {
            get { return dtKH; }
            set { dtKH = value; }
        }

        public string DcKH
        {
            get { return dcKH; }
            set { dcKH = value; }
        }

        public string TenKh
        {
            get { return tenKh; }
            set { tenKh = value; }
        }

        public string HoKH
        {
            get { return hoKH; }
            set { hoKH = value; }
        }

        public string MaKH
        {
            get { return maKH; }
            set { maKH = value; }
        }
    }
}
