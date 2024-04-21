using System.Text;
using System.Data;
using System.Threading.Tasks;
using QuanLyBanHang.DataLayer;
using System.Data.SqlClient;
using BaiTapQuanLy.DTO;
using System;


namespace BaiTapQuanLy.BussinessLayer
{

    public class Bll_HeThong
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
