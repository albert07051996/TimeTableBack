using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class WordMergeDocument
{
    public Guid Id { get; set; }

    public string Name { get; set; } = null!;

    public Guid GroupId { get; set; }

    public string? Description { get; set; }

    public byte[]? FileContent { get; set; }

    public string? FileName { get; set; }

    public string? Path { get; set; }

    public bool InheritRolesFromGroup { get; set; }

    public byte? MergeType { get; set; }

    public byte? MergeMethod { get; set; }

    public int? SecurityLevel { get; set; }

    public byte WordMergeType { get; set; }

    public int? DocumentType { get; set; }

    public bool? IsStandard { get; set; }

    public string? Language { get; set; }

    public string? Setting { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual WordMergeGroup Group { get; set; } = null!;
}
