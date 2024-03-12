using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class Bdgtbl
{
    public int Id { get; set; }

    public string? BudMeth { get; set; }

    public string? VerdCalc { get; set; }

    public string? Kstplcode { get; set; }

    public string? Kstdrcode { get; set; }

    public string? Periode { get; set; }

    public double Percentage { get; set; }

    public double Bedrag { get; set; }

    public double Aantal { get; set; }

    public short? Division { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }

    public Guid Sysguid { get; set; }

    public byte[] Timestamp { get; set; } = null!;
}
