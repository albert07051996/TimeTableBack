using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class Inthi
{
    public int Id { get; set; }

    public string? IntraNr { get; set; }

    public string? Ref { get; set; }

    public string? Statjaar { get; set; }

    public string? Statperiod { get; set; }

    public DateTime? Datum { get; set; }

    public string? Status { get; set; }

    public string? Rubriek { get; set; }

    public string? Landoorspr { get; set; }

    public string? Landbest { get; set; }

    public string? Landherk { get; set; }

    public string? Landabc { get; set; }

    public string? LandIso { get; set; }

    public string? Statistnr { get; set; }

    public string? Taric { get; set; }

    public string? Stelsel { get; set; }

    public string? TransactA { get; set; }

    public string? TransactB { get; set; }

    public string? Vervoer { get; set; }

    public byte Container { get; set; }

    public string? PltsLl { get; set; }

    public string? IntRegio { get; set; }

    public string? TrsshpmCd { get; set; }

    public string? IntraLvcd { get; set; }

    public double GewichtIn { get; set; }

    public string? Statfactor { get; set; }

    public string? Statfact2 { get; set; }

    public double Stateenh { get; set; }

    public double Statwaarde { get; set; }

    public double Nettowrde { get; set; }

    public string? Boecode { get; set; }

    public string? Valcode { get; set; }

    public double Koers { get; set; }

    public double ValBdr { get; set; }

    public string? Affiliates { get; set; }

    public string? Csacode { get; set; }

    public string? Artcode { get; set; }

    public double Aantal { get; set; }

    public string? Oms20 { get; set; }

    public string? Debnr { get; set; }

    public string? Crdnr { get; set; }

    public string? Faknr { get; set; }

    public string? Ontvfnr { get; set; }

    public string? Docnumber { get; set; }

    public byte Gereed { get; set; }

    public Guid? TransactionGuid { get; set; }

    public short? Division { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }

    public Guid Sysguid { get; set; }

    public byte[] Timestamp { get; set; } = null!;
}
