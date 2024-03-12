using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class PersonalDataClassification
{
    public int Id { get; set; }

    public string Code { get; set; } = null!;

    public string? Description { get; set; }

    public string? Status { get; set; }

    public string? Category { get; set; }

    public string? Type { get; set; }

    public string? Event { get; set; }

    public int? ExpiryPeriod { get; set; }

    public string? TimeScale { get; set; }

    public short? Division { get; set; }

    public bool AutoLink { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }
}
