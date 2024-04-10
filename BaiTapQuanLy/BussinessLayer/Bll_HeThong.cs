using System.Text;
using System.Data;
using System.Threading.Tasks;
using QuanLyBanHang.DataLayer;
using System.Data.SqlClient;
using BaiTapQuanLy.DTO;


namespace BaiTapQuanLy.BussinessLayer
{

    class Bll_HeThong
    {
        MyDatabase db;
        
        public Bll_HeThong(string path)
        {
            db = new MyDatabase(path);
        }

        //Get List Customer
        public DataTable KiemTraDangNhap (ref string err, string username, string password)
        {
            SqlParameter[] sqlPara = new SqlParameter[]{
                new SqlParameter("@Username", username),
                new SqlParameter("@Password", password)
            };
            return db.GetDataTable(ref err, "PSP_Login", CommandType.StoredProcedure, sqlPara);
        }     
    }
}
