using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class CnffunctionalComponent
{
    public Guid Id { get; set; }

    public string EntityCode { get; set; } = null!;

    public string PropName { get; set; } = null!;

    public int Type { get; set; }

    public int Subtype { get; set; }

    public string? FixedValue { get; set; }

    public string? SettingName { get; set; }

    public string? ReferenceEntity { get; set; }

    public string? ReferenceProperty { get; set; }

    public bool? ReferenceForceRenewal { get; set; }

    public byte[]? Expression { get; set; }

    public string? ReferenceEntityBc { get; set; }

    public bool? PostCodeRelated { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }
}
