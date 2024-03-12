using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class ItemRelationTypeState
{
    public int State { get; set; }

    public string? Description { get; set; }

    public int TermId { get; set; }

    public string? ImageFileName { get; set; }

    public int BackgroundColor { get; set; }

    public string? DescriptionSufix { get; set; }

    public int DescriptionSufixTermId { get; set; }

    public short? Division { get; set; }

    public byte[] Timestamp { get; set; } = null!;
}
