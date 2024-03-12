using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class CardSetting
{
    public int Id { get; set; }

    public string Module { get; set; } = null!;

    public short ApplicationId { get; set; }

    public byte SettingType { get; set; }

    public byte Type { get; set; }

    public int ResourceId { get; set; }

    public string? Parameter0 { get; set; }

    public string? Parameter1 { get; set; }

    public string? Parameter2 { get; set; }

    public string? Xmlvalue { get; set; }

    public short? Division { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }

    public Guid Sysguid { get; set; }

    public byte[]? Timestamp { get; set; }
}
