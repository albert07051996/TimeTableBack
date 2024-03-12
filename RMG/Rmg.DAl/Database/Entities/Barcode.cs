using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class Barcode
{
    public int Id { get; set; }

    public string Barcode1 { get; set; } = null!;

    public string BarcodeType { get; set; } = null!;

    public string Itemcode { get; set; } = null!;

    public string? Unitcode { get; set; }

    public double? Unitfactor { get; set; }

    public Guid? Account { get; set; }

    public short? Division { get; set; }

    public bool IsDefault { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }

    public Guid Sysguid { get; set; }

    public byte[] Timestamp { get; set; } = null!;
}
