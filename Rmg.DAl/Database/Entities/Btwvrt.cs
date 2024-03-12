using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class Btwvrt
{
    public int Id { get; set; }

    public string? Btwvrtnr { get; set; }

    public string? Naam { get; set; }

    public string? Adres1 { get; set; }

    public string? Adres2 { get; set; }

    public string? Adres3 { get; set; }

    public string? Postcode { get; set; }

    public string? Woonpl { get; set; }

    public string? Landcode { get; set; }

    public string? Telefoon { get; set; }

    public string? Faxnr { get; set; }

    public string? Cpers { get; set; }

    public string? BtwNummer { get; set; }

    public short? Division { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }

    public Guid Sysguid { get; set; }

    public byte[] Timestamp { get; set; } = null!;
}
