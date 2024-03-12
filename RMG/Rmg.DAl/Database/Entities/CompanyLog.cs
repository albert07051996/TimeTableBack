using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class CompanyLog
{
    public int LogId { get; set; }

    public string CompanyCode { get; set; } = null!;

    public DateTime DateStart { get; set; }

    public DateTime DateEnd { get; set; }

    public string? Source { get; set; }

    public int? Records { get; set; }

    public string? Action { get; set; }

    public string? Status { get; set; }

    public string? Remark { get; set; }

    public int? ResId { get; set; }

    public short? Division { get; set; }

    public byte[] Timestamp { get; set; } = null!;
}
