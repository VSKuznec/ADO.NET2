using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace ADO.NET2.Configurations
{
    public static class ConnectionString
    {
        public static string MsSqlConnection => @"Server=.\SQLExpress;Database=testing;Trusted_Connection=True;TrustServerCertificate=True;MultipleActiveResultSets=True;";

    }
}
