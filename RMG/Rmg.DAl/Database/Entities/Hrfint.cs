using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class Hrfint
{
    public int Id { get; set; }

    public string? CompType { get; set; }

    public string? Fingroup { get; set; }

    public string? Descr500 { get; set; }

    public string? Descr501 { get; set; }

    public string? Descr502 { get; set; }

    public string? Descr503 { get; set; }

    public string? Descr504 { get; set; }

    public string? Glac { get; set; }

    public string? Unit { get; set; }

    public byte EmployeeNy { get; set; }

    public byte EmployerNy { get; set; }

    public string? PayPeriod { get; set; }

    public string? Gn { get; set; }

    public string? Country { get; set; }

    public double DefAmt { get; set; }

    public string? Fixed { get; set; }

    public int? Notes { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }

    public Guid Sysguid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public Guid? DocId { get; set; }

    public byte Payroll { get; set; }

    public string? ToeSrt { get; set; }

    public string? Gbknr2 { get; set; }

    public int Scale { get; set; }

    public string? Currency { get; set; }

    public bool DefAmtEditable { get; set; }

    public string? MainType { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public string? JobActivity { get; set; }

    public short? Division { get; set; }
}
