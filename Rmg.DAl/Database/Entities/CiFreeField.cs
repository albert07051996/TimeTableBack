using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class CiFreeField
{
    public Guid Id { get; set; }

    public string BedrNr { get; set; } = null!;

    public string TableName { get; set; } = null!;

    public string ColumnName { get; set; } = null!;

    public string? Description { get; set; }

    public string? SelectionValues { get; set; }

    public string? Selection { get; set; }

    public int? Reference { get; set; }

    public short? Division { get; set; }

    public int? TableId { get; set; }

    public int? TermId { get; set; }
}
