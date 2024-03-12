using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class Perdat
{
    public int Id { get; set; }

    public short? Bkjrcode { get; set; }

    public string? PerFin { get; set; }

    public DateTime? Bgdatum { get; set; }

    public DateTime? Eddatum { get; set; }

    public int GroupId { get; set; }

    public string CompanyCode { get; set; } = null!;

    public bool YearPeriodStatus { get; set; }

    public short? Division { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }

    public Guid Sysguid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public short? Nlcmwd { get; set; }
}
