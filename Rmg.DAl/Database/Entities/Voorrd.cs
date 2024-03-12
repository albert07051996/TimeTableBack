using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class Voorrd
{
    public int Id { get; set; }

    public string? Magcode { get; set; }

    public string? Artcode { get; set; }

    public string? Maglok { get; set; }

    public double Minvrd { get; set; }

    public double Maxvrd { get; set; }

    public double Veilvrd { get; set; }

    public double Bestniv { get; set; }

    public byte Blokkeer { get; set; }

    public int DeliveryTimeInDays { get; set; }

    public int ResId { get; set; }

    public double? CostPrice { get; set; }

    public short CountingCycle { get; set; }

    public string? OrderPolicyCode { get; set; }

    public int PeriodOrderDays { get; set; }

    public DateTime? DateLastCounted { get; set; }

    public short? Division { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }

    public Guid Sysguid { get; set; }

    public byte[] Timestamp { get; set; } = null!;
}
