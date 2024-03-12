using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class GuidRelation
{
    public short Type { get; set; }

    public Guid Id { get; set; }

    public Guid Parent { get; set; }

    public byte Level { get; set; }
}
