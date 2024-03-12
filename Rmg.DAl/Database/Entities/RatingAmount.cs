using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class RatingAmount
{
    public Guid Id { get; set; }

    public int Rating { get; set; }

    public string Type { get; set; } = null!;

    public string? Currency { get; set; }

    public double AmountStart { get; set; }

    public double AmountEnd { get; set; }

    public short? Division { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }
}
