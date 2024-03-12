using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class CnfentityChild
{
    public Guid Id { get; set; }

    public string EntityCode { get; set; } = null!;

    public string Code { get; set; } = null!;

    public string Label { get; set; } = null!;

    public int? LabelTermId { get; set; }

    public string ChildEntityCode { get; set; } = null!;

    public string? ChildEntityField { get; set; }

    public int? RowNumber { get; set; }

    public string? DisplayColumns { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }
}
