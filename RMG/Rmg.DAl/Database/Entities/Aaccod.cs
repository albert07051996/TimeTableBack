using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class Aaccod
{
    public int Id { get; set; }

    public string? AnalytFld { get; set; }

    public string? Descr300 { get; set; }

    public string? Descr301 { get; set; }

    public string? Descr302 { get; set; }

    public string? Descr303 { get; set; }

    public string? Descr304 { get; set; }

    public int Length { get; set; }

    public int Xprecision { get; set; }

    public byte Capitals { get; set; }

    public byte Positive { get; set; }

    public string? AnalytTbl { get; set; }

    public byte Active { get; set; }

    public byte Mandatory { get; set; }

    public byte Adjustable { get; set; }

    public byte Balanced { get; set; }

    public byte Allocation { get; set; }

    public byte MultipleLines { get; set; }

    public int SeqNo { get; set; }

    public byte LinktoItems { get; set; }

    public byte LinktoGlaccounts { get; set; }

    public byte LinktoDebtors { get; set; }

    public byte LinktoCreditors { get; set; }

    public byte LinktoProjects { get; set; }

    public byte LinktoHumres { get; set; }

    public byte LinktoAssets { get; set; }

    public byte LinktoTable1 { get; set; }

    public byte LinktoTable2 { get; set; }

    public byte LinktoTable3 { get; set; }

    public byte LinktoTable4 { get; set; }

    public byte LinktoTable5 { get; set; }

    public byte LinktoTable6 { get; set; }

    public byte LinktoTable7 { get; set; }

    public byte LinktoTable8 { get; set; }

    public byte LinktoTable9 { get; set; }

    public byte LinktoTable10 { get; set; }

    public DateTime Syscreated { get; set; }

    public string? Expression { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }

    public Guid Sysguid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public string? AnalytFieldname { get; set; }

    public short? Division { get; set; }
}
