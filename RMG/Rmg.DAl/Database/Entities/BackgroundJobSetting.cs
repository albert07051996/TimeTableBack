using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class BackgroundJobSetting
{
    public int Id { get; set; }

    public string Assembly { get; set; } = null!;

    public string Class { get; set; } = null!;

    public string? Parameters { get; set; }

    public bool Enabled { get; set; }

    public byte Interval { get; set; }

    public byte Counter { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }
}
