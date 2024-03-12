using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class Ordlev
{
    public int Id { get; set; }

    public string? Levwijze { get; set; }

    public string? Oms400 { get; set; }

    public string? Oms401 { get; set; }

    public string? Oms402 { get; set; }

    public string? Oms403 { get; set; }

    public string? Oms404 { get; set; }

    public string? Shipping { get; set; }

    public byte DirectShipping { get; set; }

    public short? Division { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }

    public Guid Sysguid { get; set; }

    public byte[] Timestamp { get; set; } = null!;
}
