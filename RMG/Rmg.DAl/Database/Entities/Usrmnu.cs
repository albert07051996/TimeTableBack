using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class Usrmnu
{
    public int EwfCrc { get; set; }

    public int ResId { get; set; }

    public byte Type { get; set; }

    public int RightsCrc { get; set; }

    public byte[]? Data { get; set; }

    public int SettingsCrc { get; set; }

    public int OptionsCrc { get; set; }

    public short? Division { get; set; }

    public int Sysmodifier { get; set; }

    public int Syscreator { get; set; }

    public DateTime Syscreated { get; set; }

    public DateTime Sysmodified { get; set; }

    public Guid Sysguid { get; set; }
}
