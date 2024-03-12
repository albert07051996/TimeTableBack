using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class ProductionTimeEntry
{
    public int Id { get; set; }

    public string Project { get; set; } = null!;

    public int Step { get; set; }

    public string Operation { get; set; } = null!;

    public string ItemCode { get; set; } = null!;

    public string ItemType { get; set; } = null!;

    public string Condition { get; set; } = null!;

    public int Resource { get; set; }

    public DateTime StartTime { get; set; }

    public DateTime? EndTime { get; set; }

    public string? Machine { get; set; }

    public Guid? TransactionKey { get; set; }

    public byte? Status { get; set; }

    public string? LogText { get; set; }

    public Guid Sysguid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public string Division { get; set; } = null!;

    public int Creator { get; set; }

    public DateTime Created { get; set; }

    public int Modifier { get; set; }

    public DateTime Modified { get; set; }
}
