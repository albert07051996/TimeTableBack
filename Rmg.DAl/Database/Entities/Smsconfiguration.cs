using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class Smsconfiguration
{
    public Guid Id { get; set; }

    public Guid ConfigurationHeaderId { get; set; }

    public int Tree { get; set; }

    public int Branch { get; set; }

    public Guid? Parent { get; set; }

    public bool Active { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public string? StartType { get; set; }

    public string? StartOrigin { get; set; }

    public string? EndAction { get; set; }

    public Guid Item { get; set; }

    public Guid? SerialNumber { get; set; }

    public double Quantity { get; set; }

    public double? QuantityPartial { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }
}
