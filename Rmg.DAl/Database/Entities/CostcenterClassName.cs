using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class CostcenterClassName
{
    public int ClassId { get; set; }

    public string? Description { get; set; }

    public short? Division { get; set; }

    public byte[] Timestamp { get; set; } = null!;
}
