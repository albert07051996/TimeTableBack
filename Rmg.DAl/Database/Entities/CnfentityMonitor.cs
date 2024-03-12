using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class CnfentityMonitor
{
    public Guid Id { get; set; }

    public string EntityCode { get; set; } = null!;

    public string Code { get; set; } = null!;

    public string Description { get; set; } = null!;

    public int? DescriptionTermId { get; set; }

    public string? SearchUrl { get; set; }

    public string? Url { get; set; }

    public string? Icon { get; set; }

    public byte[]? IconImage { get; set; }

    public bool? IsDeployed { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }
}
