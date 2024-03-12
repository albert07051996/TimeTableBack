using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class Btwavk
{
    public int Id { get; set; }

    public string? LandIso { get; set; }

    public string? Vak { get; set; }

    public string? Oms40 { get; set; }

    public string? Soort { get; set; }

    public byte Opvragen { get; set; }

    public string? TypeRek { get; set; }

    public byte ContrTot { get; set; }

    public string? AangVak { get; set; }

    public byte BtwnafNj { get; set; }

    public short? Division { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }

    public Guid Sysguid { get; set; }

    public byte[] Timestamp { get; set; } = null!;
}
