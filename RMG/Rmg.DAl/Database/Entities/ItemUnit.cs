using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class ItemUnit
{
    public int Id { get; set; }

    public string Code { get; set; } = null!;

    public string Unit { get; set; } = null!;

    public string UnitType { get; set; } = null!;

    public byte Active { get; set; }

    public short? Division { get; set; }

    public Guid Sysguid { get; set; }
}
