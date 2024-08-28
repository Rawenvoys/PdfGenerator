using System.Data;
using System.Data.SqlClient;
using Dapper.Lib.Models.ConnectionString;

namespace Dapper.Lib.Models.DbContext;
public abstract class ADbContext(AConnectionString connectionString) : IDbContext
{
    public IDbConnection CreateConnection()
        => new SqlConnection(connectionString.Key);
}
