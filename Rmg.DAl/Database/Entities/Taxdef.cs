using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class Taxdef
{
    public int Id { get; set; }

    public string? Typedefault { get; set; }

    public string? Reknr { get; set; }

    public string? Debnr { get; set; }

    public string? Crdnr { get; set; }

    public string? Artcode { get; set; }

    public int SeqNr { get; set; }

    public string? Taxtype { get; set; }

    public string? Taxcode { get; set; }

    public string? Invoicetype { get; set; }

    public double Percentage { get; set; }

    public double Percnonded { get; set; }

    public double Amount { get; set; }

    public short? Division { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }

    public Guid Sysguid { get; set; }

    public byte[] Timestamp { get; set; } = null!;
}
