using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class Ddreference
{
    public int Id { get; set; }

    public string TableName { get; set; } = null!;

    public string ReferenceName { get; set; } = null!;

    public int? SeqNr { get; set; }

    public string TargetIndexName { get; set; } = null!;

    public string TargetTableName { get; set; } = null!;

    public string DeletionType { get; set; } = null!;

    public string? Description { get; set; }

    public int? TermId { get; set; }

    public string? Suffix { get; set; }

    public int? SuffixId { get; set; }
}
