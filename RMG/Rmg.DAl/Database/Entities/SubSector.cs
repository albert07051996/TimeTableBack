using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class SubSector
{
    public int Id { get; set; }

    public string SubSectorId { get; set; } = null!;

    public int SectorId { get; set; }

    public string Description { get; set; } = null!;

    public Guid? PolicyDocId { get; set; }

    public short? Division { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }

    public Guid Sysguid { get; set; }
}
