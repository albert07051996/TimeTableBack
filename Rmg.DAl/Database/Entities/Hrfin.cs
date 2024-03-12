using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class Hrfin
{
    public int Id { get; set; }

    public int ResId { get; set; }

    public short Line { get; set; }

    public string? CompType { get; set; }

    public string? PayPeriod { get; set; }

    public string? Gn { get; set; }

    public string? Valcode { get; set; }

    public double EmployeeAmt { get; set; }

    public double EmployerAmt { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public string? Notes { get; set; }

    public int PayType { get; set; }

    public double Hours { get; set; }

    public short? Division { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }

    public Guid Sysguid { get; set; }

    public byte[] Timestamp { get; set; } = null!;
}
