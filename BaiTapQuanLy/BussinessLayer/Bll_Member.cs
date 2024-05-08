using BaiTapQuanLy.DTO;
using QuanLyBanHang.DataLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapQuanLy.BussinessLayer
{
    public class Bll_Member
    {
        MyDatabase db;

        public Bll_Member(string path)
        {
            db = new MyDatabase(path);
        }

        //Get list membership 
        public DataTable GetMembersListToDGV(ref string err, string memberID = "")
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
                new SqlParameter("@JoinDate", member.JoinDate)
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
                new SqlParameter("@JoinDate", member.JoinDate)
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

        //Get package
        public DataTable GetPackage(ref string err)
        {
            return db.GetDataTable(ref err, "GetPackage", CommandType.StoredProcedure, null);
        }

        //Buy or renew membership package
        public int BuyOrRenewPackage(ref string err, int memberID, int packageID, double packagePrice)
        {
            SqlParameter[] sqlPara = new SqlParameter[]
            {
                new SqlParameter("@MemberID", memberID),
                new SqlParameter("@PackageID", packageID),
                new SqlParameter("@PackagePrice", packagePrice)
            };
            return db.MyExcuteNonQuery(ref err, "PurchaseOrRenewPackage", CommandType.StoredProcedure, sqlPara);
        }

    }
}
