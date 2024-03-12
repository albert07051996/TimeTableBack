using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class AccountClass
{
    public Guid Id { get; set; }

    public int ClassId { get; set; }

    public string AccountClassCode { get; set; } = null!;

    public string? Description { get; set; }

    public string? Description0 { get; set; }

    public string? Description1 { get; set; }

    public string? Description2 { get; set; }

    public string? Description3 { get; set; }

    public string? Description4 { get; set; }

    public int IdentId { get; set; }

    public short? Division { get; set; }

    public Guid Sysguid { get; set; }

    public byte[] Timestamp { get; set; } = null!;
}
