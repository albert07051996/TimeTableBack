using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class Hrsk
{
    public int Id { get; set; }

    public int ResId { get; set; }

    public short Line { get; set; }

    public string? SkillType { get; set; }

    public string? Sklevel { get; set; }

    public short? Division { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }

    public Guid Sysguid { get; set; }

    public byte[] Timestamp { get; set; } = null!;
}
