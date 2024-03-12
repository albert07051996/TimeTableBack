using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class WordMergeGroup
{
    public Guid Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public int Module { get; set; }

    public byte WordMergeType { get; set; }

    public int? FunctionRight { get; set; }

    public bool? IsStandard { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual ICollection<WordMergeDocument> WordMergeDocuments { get; set; } = new List<WordMergeDocument>();
}
