using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class BdviewColumn
{
    public int Id { get; set; }

    public string Description { get; set; } = null!;

    public int? DescriptionTermId { get; set; }

    public string? Caption { get; set; }

    public int? CaptionTermId { get; set; }

    public string Columns { get; set; } = null!;

    public int ColumnCount { get; set; }

    public int DataType { get; set; }

    public string? Joins { get; set; }

    public bool? InnerJoin { get; set; }

    public bool WorkflowOnly { get; set; }

    public string? DescriptionSuffix { get; set; }

    public int? DescriptionSuffixTermId { get; set; }

    public short? Division { get; set; }
}
