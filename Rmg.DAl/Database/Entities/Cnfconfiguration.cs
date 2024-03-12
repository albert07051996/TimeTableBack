using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class Cnfconfiguration
{
    public Guid Id { get; set; }

    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public int? NameTermId { get; set; }

    public int? ModuleId { get; set; }

    public int? RepGroupId { get; set; }

    public string Version { get; set; } = null!;

    public bool? IsGenerated { get; set; }

    public int Batch { get; set; }

    public int Status { get; set; }

    public int? Rights { get; set; }

    public Guid? Owner { get; set; }

    public int? TestBatch { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }

    public string? Icon { get; set; }

    public byte[]? IconImage { get; set; }
}
