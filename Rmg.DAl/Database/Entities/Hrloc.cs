using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class Hrloc
{
    public int Id { get; set; }

    public string? Loc { get; set; }

    public string? Descr50 { get; set; }

    public string? Street0 { get; set; }

    public string? Street1 { get; set; }

    public string? AddrNo { get; set; }

    public string? AddrSuf { get; set; }

    public string? Postcode { get; set; }

    public string? City { get; set; }

    public string? Country { get; set; }

    public string? Telnr { get; set; }

    public string? Faxnr { get; set; }

    public string? Xaddress2 { get; set; }

    public string? StateCode { get; set; }

    public int WeekendStart { get; set; }

    public int WeekendEnd { get; set; }

    public short? Division { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }

    public Guid Sysguid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public string? Region { get; set; }

    public string? Type { get; set; }

    public string? FullName { get; set; }

    public string? OldCode { get; set; }
}
