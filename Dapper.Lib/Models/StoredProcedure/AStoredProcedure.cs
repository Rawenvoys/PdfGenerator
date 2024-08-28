using Dapper.Lib.Extensions;

namespace Dapper.Lib.Models.StoredProcedure;
public abstract class AStoredProcedure(Dictionary<string,object>? dictionary = null)
{
    public abstract string Name { get; }
    //public abstract ResultType ResultType { get; }
    public DynamicParameters? DynamicParameters { get; set; } = dictionary.ToDynamicParameters();
}



