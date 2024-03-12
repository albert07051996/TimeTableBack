using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class Sysmnu
{
    public int MnuId { get; set; }

    public int PrntId { get; set; }

    public int SeqNo { get; set; }

    public string? MType { get; set; }

    public string? FncId { get; set; }

    public string? Descr64 { get; set; }

    public int RootId { get; set; }

    public string? OptionExp { get; set; }

    public string? Settings { get; set; }

    public string? Keyshortcut { get; set; }

    public short? Division { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }

    public Guid Sysguid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public int TreeLevel { get; set; }

    public int MenuNumber { get; set; }
}
