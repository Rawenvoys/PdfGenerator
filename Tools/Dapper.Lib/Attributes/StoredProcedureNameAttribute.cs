using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper.Lib.Attributes;
public class StoredProcedureNameAttribute(string name) : Attribute
{
    public readonly string Name = name;
}
