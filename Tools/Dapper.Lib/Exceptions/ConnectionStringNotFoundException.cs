using Dapper.Lib.Models;

namespace Dapper.Lib.Exceptions;
internal class ConnectionStringNotFoundException(string key)
    : Exception($"Cannot find connection string with key: {key}")
{
}
