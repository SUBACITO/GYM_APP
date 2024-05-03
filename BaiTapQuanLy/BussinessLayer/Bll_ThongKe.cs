using System.Text;
using System.Data;
using System.Threading.Tasks;
using QuanLyBanHang.DataLayer;
using System.Data.SqlClient;
using BaiTapQuanLy.DTO;
using System;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace BaiTapQuanLy.BussinessLayer
{
    public class Bll_ThongKe
    {
        MyDatabase db;

        public Bll_ThongKe(string path)
        {
            db = new MyDatabase(path);
        }

        public DataTable GetPackageStats(ref string err, DateTime fromDate, DateTime toDate)
        {
            SqlParameter[] sqlPara = new SqlParameter[]
            {
                new SqlParameter("@fromDate", fromDate),
                new SqlParameter("@toDate", toDate)
            };
            return db.GetDataTable(ref err, "GetStats", CommandType.StoredProcedure, sqlPara);
        }

        public DataTable GetMembersByGender(ref string err)
        {
            return db.GetDataTable(ref err, "GetStats_Gender", CommandType.StoredProcedure, null);
        }

        public DataTable GetDetailPackage(ref string err)
        {
            return db.GetDataTable(ref err, "GetDetailPackage", CommandType.StoredProcedure, null);
        }

        public DataTable GetPackage(ref string err)
        {
            return db.GetDataTable(ref err, "GetPackage", CommandType.StoredProcedure, null);
        }
    }
}
