using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapQuanLy.DTO
{
    public class LoaiHang
    {
        //Field
        string maLH, tenLH;

        public string TenLH
        {
            get { return tenLH; }
            set { tenLH = value; }
        }

        public string MaLH
        {
            get { return maLH; }
            set { maLH = value; }
        }
     
    }
}
