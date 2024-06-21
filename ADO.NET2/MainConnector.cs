﻿using Microsoft.Data.SqlClient;
using System.Data;
using ADO.NET2.Configurations;

namespace ADO.NET2
{
    public class MainConnector
    {
        readonly SqlConnection connection = new SqlConnection(ConnectionString.MsSqlConnection);

        public SqlConnection Connection => connection;

        public async Task<bool> ConnectAsync(SqlConnection connection)
        {
            bool result;
            try
            {
                connection = new SqlConnection(ConnectionString.MsSqlConnection);
                await connection.OpenAsync();
                result = true;
            }
            catch
            {
                result = false;
            }

            return result;
        }

        public async void DisconnectAsync()
        {
            if (connection.State == ConnectionState.Open)
            {
                await connection.CloseAsync();
            }
        }

        public SqlConnection GetConnection()
        {
            if (connection.State == ConnectionState.Open)
            {
                return connection;
            }
            else
            {
                throw new Exception("Подключение уже закрыто!");
            }
        }
    }
}
