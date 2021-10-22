using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public class UsersData
    {
        private readonly ISqlDataAccess _db;

        public UsersData(ISqlDataAccess _db)
        {
            this._db = _db;
        }

        public Task<List<UserModel>> GetUsers()
        {
            string sql = "select * from dbo.Users";
        }
    }
}
