using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class Stfom
{
    public int Id { get; set; }

    public string? Prijslijst { get; set; }

    public string? Oms300 { get; set; }

    public string? Oms301 { get; set; }

    public string? Oms302 { get; set; }

    public string? Oms303 { get; set; }

    public string? Oms304 { get; set; }

    public string? Valcode { get; set; }

    public string? Country { get; set; }

    public string? Type { get; set; }

    public string? AccountType { get; set; }

    public string? AccountStatus { get; set; }

    public string? AccountClassificationId { get; set; }

    public byte MainPricelist { get; set; }

    public short? Division { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }

    public Guid Sysguid { get; set; }

    public byte[] Timestamp { get; set; } = null!;
}
