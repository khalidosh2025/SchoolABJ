using Microsoft.Extensions.Configuration;
using Dapper;
using Microsoft.Data.SqlClient;

public class EmpService
{
    private readonly string _connectionString;

    public EmpService(IConfiguration configuration)
    {
        // Ensure the connection string is not null to avoid CS8601
        _connectionString = configuration.GetConnectionString("SchoolDB")
                            ?? throw new ArgumentNullException(nameof(configuration), "Connection string 'SchoolDB' cannot be null.");
    }

    public async Task<bool> ValidateUserAsync(string UserName, string Password)
    {
        using var connection = new SqlConnection(_connectionString);
        var sql = "SELECT COUNT(1) FROM Emp WHERE UserName = @UserName AND Password = @Password";
        var result = await connection.ExecuteScalarAsync<int>(sql, new { UserName = UserName, Password = Password });
        return result > 0;
    }

    //public string? GetFirstEmpPassword()
    //{
    //    using var connection = new SqlConnection(_connectionString);
    //    return connection.QueryFirstOrDefault<string>("SELECT TOP 1 Password FROM Emp");
    //}
}