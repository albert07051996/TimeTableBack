using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class ScpshippingLink
{
    public Guid Id { get; set; }

    public string Carrier { get; set; } = null!;

    public string? ServiceLevelTime { get; set; }

    public string? ServiceLevelOther { get; set; }

    public string DeliveryMethod { get; set; } = null!;

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }

    public Guid PortalId { get; set; }
}
