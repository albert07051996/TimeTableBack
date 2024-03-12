using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class RatioDefinition
{
    public string RatioCode { get; set; } = null!;

    public int RatioType { get; set; }

    public string? Description { get; set; }

    public string? RatioFirst { get; set; }

    public string? RatioSecond { get; set; }

    public string? RatioSql { get; set; }

    public string? RatioSqlcc { get; set; }

    public int RatioSide { get; set; }

    public bool Enabled { get; set; }

    public int? TableType { get; set; }

    public int? ReportClass { get; set; }

    public bool IsPercentage { get; set; }

    public short? Division { get; set; }

    public byte[] Timestamp { get; set; } = null!;
}
