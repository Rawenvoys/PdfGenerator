using Dapper.Lib.Models.DbContext;
using Dapper.Lib.Models.StoredProcedure;
using System.Data;

namespace Dapper.Lib.Extensions;
public static class DbContextExtensions
{
    public static async Task ExecuteAsync(this IDbContext dbContext, AStoredProcedure storedProcedure)
    {
        using var connection = dbContext.CreateConnection();
        await connection.QueryAsync(storedProcedure.Name, storedProcedure.DynamicParameters, commandType: CommandType.StoredProcedure);
    }

    public static async Task<TResult?> ExecuteAsync<TResult>(this IDbContext dbContext, AStoredProcedure storedProcedure)
    {
        using var connection = dbContext.CreateConnection();
        return await connection.QueryFirstOrDefaultAsync<TResult>(storedProcedure.Name, storedProcedure.DynamicParameters, commandType: CommandType.StoredProcedure);
    }

    public static async Task<IEnumerable<TResult>> ExecuteListAsync<TResult>(this IDbContext dbContext, AStoredProcedure storedProcedure)
    {
        using var connection = dbContext.CreateConnection();
        return await connection.QueryAsync<TResult>(storedProcedure.Name, storedProcedure.DynamicParameters, commandType: CommandType.StoredProcedure);
    }

}
