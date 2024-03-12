using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class ItemRelation
{
    public Guid Id { get; set; }

    public int Type { get; set; }

    public string ItemCode { get; set; } = null!;

    public string ItemCodeRelated { get; set; } = null!;

    public byte[] Timestamp { get; set; } = null!;

    public double Quantity { get; set; }

    public short? Division { get; set; }

    public Guid Sysguid { get; set; }
}
