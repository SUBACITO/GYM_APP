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

        //Get member list for statistics datagridview
        public DataTable GetMembersListToDGV(ref string err)
        {
            return db.GetDataTable(ref err, "MembersList_Select", CommandType.StoredProcedure, null);
        }

        //Get package stats
        public DataTable GetPackageStats(ref string err, DateTime fromDate, DateTime toDate)
        {
            SqlParameter[] sqlPara = new SqlParameter[]
            {
                new SqlParameter("@fromDate", fromDate),
                new SqlParameter("@toDate", toDate)
            };
            return db.GetDataTable(ref err, "GetStats", CommandType.StoredProcedure, sqlPara);
        }

        //Get member gender stats
        public DataTable GetMembersByGender(ref string err)
        {
            return db.GetDataTable(ref err, "GetStats_Gender", CommandType.StoredProcedure, null);
        }

        //Get detail package
        public DataTable GetDetailPackage(ref string err)
        {
            return db.GetDataTable(ref err, "GetDetailPackage", CommandType.StoredProcedure, null);
        }

        //Get package
        public DataTable GetPackage(ref string err)
        {
            return db.GetDataTable(ref err, "GetPackage", CommandType.StoredProcedure, null);
        }
    }
}
