using Dapper.Lib.Exceptions;
using Microsoft.Extensions.Configuration;

namespace Dapper.Lib.Models.ConnectionString;
public abstract class AConnectionString
{
    private readonly string _value;
    public string Value => _value;
    public abstract string Key { get; }

    protected AConnectionString(IConfiguration configuration)
        => _value = configuration.GetConnectionString(Key)
            ?? throw new ConnectionStringNotFoundException(Key);
}
