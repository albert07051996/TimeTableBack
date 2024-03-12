using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class DeletionLog
{
    public int Id { get; set; }

    public string TableName { get; set; } = null!;

    public string? KeyString1 { get; set; }

    public string? KeyString2 { get; set; }

    public string? KeyString3 { get; set; }

    public string? KeyString4 { get; set; }

    public string? KeyString5 { get; set; }

    public int? KeyInt1 { get; set; }

    public int? KeyInt2 { get; set; }

    public int? KeyInt3 { get; set; }

    public int? KeyInt4 { get; set; }

    public int? KeyInt5 { get; set; }

    public DateTime? KeyDate1 { get; set; }

    public DateTime? KeyDate2 { get; set; }

    public DateTime? KeyDate3 { get; set; }

    public Guid? KeyGuid1 { get; set; }

    public Guid? KeyGuid2 { get; set; }

    public Guid? KeyGuid3 { get; set; }

    public string CompanyCode { get; set; } = null!;

    public short? Division { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public Guid Sysguid { get; set; }

    public byte[] Timestamp { get; set; } = null!;
}
