using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class AccountClassName
{
    public int ClassId { get; set; }

    public string? Description { get; set; }

    public string? Description0 { get; set; }

    public string? Description1 { get; set; }

    public string? Description2 { get; set; }

    public string? Description3 { get; set; }

    public string? Description4 { get; set; }

    public bool Enabled { get; set; }

    public bool Fixed { get; set; }

    public string? CompanyCode { get; set; }

    public int? ClassNumber { get; set; }

    public short? Division { get; set; }

    public Guid Sysguid { get; set; }

    public byte[] Timestamp { get; set; } = null!;
}
