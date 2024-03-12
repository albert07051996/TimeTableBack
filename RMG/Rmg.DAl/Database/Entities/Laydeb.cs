using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class Laydeb
{
    public int Id { get; set; }

    public string? FormType { get; set; }

    public string? Bedrnr { get; set; }

    public string? Categorie { get; set; }

    public string? Debnr { get; set; }

    public string? Subcode { get; set; }

    public string? IsoTaalcd { get; set; }

    public string? Volgnr2 { get; set; }

    public string? Layoutnaam { get; set; }

    public short? Division { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }

    public Guid Sysguid { get; set; }

    public byte[] Timestamp { get; set; } = null!;
}
