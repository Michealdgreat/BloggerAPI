using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using System.Data;
using Dapper;


namespace Infrastructure.DataAccess;

public class RepositoryBase(IConfiguration config) : IRepositoryBase
{
    private readonly IConfiguration _config = config;

    public async Task<List<T>> FromDataBase<T, U>(string dbSp, U parameters, string dbConnString)
    {
        string? connectionString = _config.GetConnectionString(dbConnString);

        using IDbConnection connection = new SqlConnection(connectionString);

        var rows = await connection.QueryAsync<T>(dbSp, parameters,
            commandType: CommandType.StoredProcedure);

        return rows.ToList();
    }

    public async Task ToDataBase<T>(string dbSp, T parameters, string dbConnString)
    {
        string? connectionString = _config.GetConnectionString(dbConnString);

        using IDbConnection connection = new SqlConnection(connectionString);

        await connection.ExecuteAsync(dbSp,
            parameters, commandType: CommandType.StoredProcedure);
    }

}

