using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class Verslg
{
    public int Id { get; set; }

    public string? Verwerknr { get; set; }

    public short? Bkjrcode { get; set; }

    public string? Periode { get; set; }

    public string? Dagbknr { get; set; }

    public string? Oms40 { get; set; }

    public DateTime? Datum { get; set; }

    public double TotDebet { get; set; }

    public double TotCredit { get; set; }

    public string? UserId { get; set; }

    public short AantAfgdr { get; set; }

    public short? Division { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }

    public Guid Sysguid { get; set; }

    public byte[] Timestamp { get; set; } = null!;
}
