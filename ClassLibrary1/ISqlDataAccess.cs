using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlData
{
    class ISqlDataAccess
    {
        public interface ISqlDataAccess
        {
            string ConnectionStringName { get; set; }

            Task<List<T>> LoadData<T, U>(string sql, U parameters);
            Task SaveData<T>(string sql, T parameters);
        }
    }
}
