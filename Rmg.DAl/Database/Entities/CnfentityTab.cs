using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class CnfentityTab
{
    public Guid Id { get; set; }

    public string EntityCode { get; set; } = null!;

    public string Code { get; set; } = null!;

    public string? Label { get; set; }

    public int? LabelTermId { get; set; }

    public int Type { get; set; }

    public int? Position { get; set; }

    public Guid? RelationId { get; set; }

    public string? Url { get; set; }

    public int? Height { get; set; }

    public bool? IsDeployed { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }
}
