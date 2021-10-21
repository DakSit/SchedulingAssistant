using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SqlData.SqlData;

namespace SqlData
{
    class UserData
    {
        public class Users
        {
            private readonly SqlDataAccess _db;
            public Users(ISqlDataAccess db)
            {
                _db = db; 
            }

            public Task<List<UserModel>> GetUsers()
            {
                string sql = "select * from dbo.Users";
            }
        }
    }
}
