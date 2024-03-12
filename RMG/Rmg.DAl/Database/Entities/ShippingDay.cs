using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class ShippingDay
{
    public int Id { get; set; }

    public Guid AddressId { get; set; }

    public string? Magcode { get; set; }

    public string? Levwijze { get; set; }

    public int? ShippingDays { get; set; }

    public short? Division { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }

    public Guid Sysguid { get; set; }
}
