using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class StringRelation
{
    public short Type { get; set; }

    public string Code { get; set; } = null!;

    public string Parent { get; set; } = null!;

    public byte Level { get; set; }
}
