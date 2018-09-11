using System.Data;
using Chloe.Infrastructure;
using MySql.Data.MySqlClient;
using OfficeAutomation.DAL.Helper;

namespace OfficeAutomation.DAL.DB
{
    public class MySqlConnectionFactory : IDbConnectionFactory
    {
        private readonly string _connString = string.Empty;

        public MySqlConnectionFactory()
        {
            this._connString = ConfigHelper.GetSectionValue("MySQLConnectionString");
        }

        public IDbConnection CreateConnection()
        {
            MySqlConnection conn = new MySqlConnection(this._connString);
            return conn;
        }
    }
}
