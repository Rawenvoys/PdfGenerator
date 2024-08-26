namespace Dapper.Lib.Extensions;
public static class DictionaryExtensions
{
    public static DynamicParameters? ToDynamicParameters(this IDictionary<string, object>? dictionary) 
        => dictionary == null || dictionary.Count == 0 ? null : new DynamicParameters(dictionary);
}
