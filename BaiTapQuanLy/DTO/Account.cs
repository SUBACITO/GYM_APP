using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapQuanLy.DTO
{
    public class Account
    {
        public static Account instance { get;private set; }
        public static string userID, userName, userActive, userRole;


    }
}
