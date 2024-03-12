using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class Btwkpl
{
    public int Id { get; set; }

    public string? LandIso { get; set; }

    public string? Vak { get; set; }

    public string? Btwtrans { get; set; }

    public string? SoortVak { get; set; }

    public string? Posneg { get; set; }

    public short? Division { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }

    public Guid Sysguid { get; set; }

    public byte[] Timestamp { get; set; } = null!;
}
