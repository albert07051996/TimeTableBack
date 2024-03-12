using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class BacoFunctionRole
{
    public Guid Id { get; set; }

    public int FunctionId { get; set; }

    public int RoleId { get; set; }

    public int RoleLevel { get; set; }

    public short? Division { get; set; }

    public virtual BacoFunction Function { get; set; } = null!;
}
