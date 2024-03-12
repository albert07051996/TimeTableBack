using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class IntegerRelation
{
    public short Type { get; set; }

    public int Id { get; set; }

    public int Parent { get; set; }

    public byte Level { get; set; }
}
