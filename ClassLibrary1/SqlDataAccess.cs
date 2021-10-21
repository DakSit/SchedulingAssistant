﻿using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace SqlData
{
    public class SqlData
    {
        public class SqlDataAccess
        {
            private readonly IConfiguration _config;

            public string ConnectionStringName { get; set; } = "Default";

            public SqlDataAccess(IConfiguration config)
            {
                _config = config;
            }

            public async Task<List<T>> LoadData<T, U>(string sql, U parameters)
            {
                string connectionString = _config.GetConnectionString(ConnectionStringName);

                using (IDbConnection connection = new SqlConnection(connectionString))
                {
                    var data = await connection.QueryAsync<T>(sql, parameters);

                    return data.ToList();
                }
            }

            public async Task SaveData<T>(string sql, T parameters)
            {
                string connectionString = _config.GetConnectionString(ConnectionStringName);

                using (IDbConnection connection = new SqlConnection(connectionString))
                {
                    object p = await connection.ExecuteAsync(sql, parameters);
                }
            }
        }
    }
}
