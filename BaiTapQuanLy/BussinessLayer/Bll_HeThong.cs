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

        //Get List Customer
        public DataTable KiemTraDangNhap (ref string err, string username, string password)
        {
            SqlParameter[] sqlPara = new SqlParameter[]{
                new SqlParameter("@Username", username),
                new SqlParameter("@Password", password)
            };
            return db.GetDataTable(ref err, "PSP_Login", CommandType.StoredProcedure, sqlPara);
        }     

        //Get list membership 
        public DataTable GetMembersListToDGV (ref string err, string memberID = "")
        {
            SqlParameter[] sqlPara = new SqlParameter[]
            {
                new SqlParameter("@MemberID", string.IsNullOrEmpty(memberID) ? (object)DBNull.Value : memberID)
            };
            return db.GetDataTable(ref err, "MembersList_Select", CommandType.StoredProcedure, sqlPara);
        }

        //Add Member
        public int AddMemberToDGV(ref string err, Member member)
        {
            SqlParameter[] sqlPara = new SqlParameter[]
            {
                new SqlParameter("@FullName", member.FullName),
                new SqlParameter("@Gender", member.Gender),
                new SqlParameter("@DateOfBirth", member.DateOfBirth),
                new SqlParameter("@Email", member.Email),
                new SqlParameter("@Phone", member.Phone),
                new SqlParameter("@JoinDate", member.JoinDate),
                new SqlParameter("@MembershipType", member.MembershipType),
            };

            return db.MyExcuteNonQuery(ref err, "Member_AddOrUpdate", CommandType.StoredProcedure, sqlPara);
        }

        //Update Member
        public int UpdateMemberToDGV(ref string err, Member member)
        {
            SqlParameter[] sqlPara = new SqlParameter[]
            {
                new SqlParameter("@MemberID", member.MemberID),
                new SqlParameter("@FullName", member.FullName),
                new SqlParameter("@Gender", member.Gender),
                new SqlParameter("@DateOfBirth", member.DateOfBirth),
                new SqlParameter("@Email", member.Email),
                new SqlParameter("@Phone", member.Phone),
                new SqlParameter("@JoinDate", member.JoinDate),
                new SqlParameter("@MembershipType", member.MembershipType),
            };

            return db.MyExcuteNonQuery(ref err, "Member_AddOrUpdate", CommandType.StoredProcedure, sqlPara);
        }

        //Delete Member
        public int DeleteMemberFromDGV(ref string err, Member member)
        {
            SqlParameter[] sqlPara = new SqlParameter[]
            {
                new SqlParameter("@MemberID", member.MemberID)
            };
            return db.MyExcuteNonQuery(ref err, "Member_Delete", CommandType.StoredProcedure, sqlPara);
        }

        
    }
}
