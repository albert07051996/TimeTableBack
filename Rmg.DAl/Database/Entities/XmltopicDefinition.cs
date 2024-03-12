using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class XmltopicDefinition
{
    public Guid Id { get; set; }

    public string Code { get; set; } = null!;

    public string Description { get; set; } = null!;

    public int? DescriptionTermId { get; set; }

    public int Type { get; set; }

    public string? Assembly { get; set; }

    public string? Class { get; set; }

    public string? List { get; set; }

    public int PageSize { get; set; }

    public int Scenario { get; set; }

    public int? FunctionPoint { get; set; }

    public bool AllowUpdate { get; set; }

    public bool AllowCreate { get; set; }
}
