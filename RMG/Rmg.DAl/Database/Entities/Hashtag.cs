using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class Hashtag
{
    public Guid Id { get; set; }

    public string Name { get; set; } = null!;

    public int UsedCount { get; set; }

    public int Flags { get; set; }

    public decimal TrendRatio { get; set; }

    public DateTime CreatedOn { get; set; }

    public DateTime? TrendUpdatedOn { get; set; }
}
