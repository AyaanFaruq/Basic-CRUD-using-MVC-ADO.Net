using System.Configuration;
using System.Data.SqlClient;

namespace BasicMVC_ADO.Net.Gateway
{
    public class CommonGateway
    {
        private readonly string _connectionString = ConfigurationManager
            .ConnectionStrings["DataBaseContext"]
            .ConnectionString;
        protected SqlConnection Connection { get; set; }
        protected string Query { get; set; }
        protected SqlCommand Command { get; set; }
        protected SqlDataReader Reader { get; set; }
        protected CommonGateway()
        {
            Connection = new SqlConnection(_connectionString);
        }

    }
}