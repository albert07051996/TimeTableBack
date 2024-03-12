using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class CnfentityAction
{
    public Guid Id { get; set; }

    public string EntityCode { get; set; } = null!;

    public string Code { get; set; } = null!;

    public string Label { get; set; } = null!;

    public int? LabelTermId { get; set; }

    public int Type { get; set; }

    public string? Url { get; set; }

    public string? PageNavigation { get; set; }

    public int? OpenIn { get; set; }

    public string? StatusCode { get; set; }

    public int? Position { get; set; }

    public bool? IsDeployed { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }
}
