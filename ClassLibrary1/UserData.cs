using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlData
{
    class UserData
    {
        public class UserData
        {
            private readonly ISqlDataAccess _db;
            public UserData(ISqlDataAccess db)
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
