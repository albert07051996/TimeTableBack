﻿using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class Intlev
{
    public int Id { get; set; }

    public string? LandIso { get; set; }

    public string? IntraLvcd { get; set; }

    public string? Oms50 { get; set; }

    public string? Intlevcode { get; set; }

    public byte Tonen { get; set; }

    public short? Division { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }

    public Guid Sysguid { get; set; }

    public byte[] Timestamp { get; set; } = null!;
}
