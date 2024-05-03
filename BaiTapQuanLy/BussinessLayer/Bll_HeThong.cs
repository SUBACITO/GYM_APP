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

    public class Bll_HeThong
    {
        MyDatabase db;
        
        public Bll_HeThong(string path)
        {
            db = new MyDatabase(path);
        }

        // Check username existence
        public int CheckUsernameExistence(ref string err, string username)
        {
            SqlParameter[] sqlPara = new SqlParameter[]
            {
                new SqlParameter("@Username", username)
            };
            DataTable dt = db.GetDataTable(ref err, "PSP_UsernameChecker", CommandType.StoredProcedure, sqlPara);
            if (dt.Rows.Count > 0)
            {
                return Convert.ToInt32(dt.Rows[0]["State_callback"]);
            }
            return 0; // Username không tồn tại
        }

        // Kiểm tra đăng nhập
        public string AuthenticateUser(ref string err, string username, string password)
        {
            string loginStatus = string.Empty;
            SqlParameter[] sqlPara = new SqlParameter[]
            {
                new SqlParameter("@Username", username),
                new SqlParameter("@Password", password)
            };
            DataTable dt = db.GetDataTable(ref err, "PSP_Login", CommandType.StoredProcedure, sqlPara);
            if (dt.Rows.Count > 0)
            {
                loginStatus = dt.Rows[0]["UserID"].ToString();
                if (!string.IsNullOrEmpty(loginStatus))
                {
                    // Đăng nhập thành công, lấy thông tin từ dữ liệu trả về và gán vào đối tượng User
                    Account.userID = dt.Rows[0]["UserID"].ToString();
                    Account.userName = dt.Rows[0]["Username"].ToString();
                    Account.userActive = dt.Rows[0]["UserActive"].ToString();
                    Account.userRole = dt.Rows[0]["UserRole"].ToString();
                }
            }
            return loginStatus; // Đăng nhập thất bại
        }    
    }
}
