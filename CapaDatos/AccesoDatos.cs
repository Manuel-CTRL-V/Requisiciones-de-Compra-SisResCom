using Microsoft.Data.SqlClient;

namespace CapaDatos
{
    public partial class AccesoDatos
    {
        public static SqlConnection Connection()
        {
            var connection = new SqlConnection("Data Source=.;Initial Catalog=SisResComDB;User ID=manuel;Password=123;Trust Server Certificate=True");
            return connection;
        }
    }
}
