using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class ItemReleaseStatus
{
    public int Status { get; set; }

    public string? Description { get; set; }

    public int TermId { get; set; }

    public short? Division { get; set; }

    public byte[] Timestamp { get; set; } = null!;
}
