using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class CostcenterClass
{
    public Guid Id { get; set; }

    public int ClassId { get; set; }

    public string CostcenterClassCode { get; set; } = null!;

    public string? Description { get; set; }

    public short? Division { get; set; }

    public byte[] Timestamp { get; set; } = null!;
}
