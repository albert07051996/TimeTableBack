using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class TransactionType
{
    public int TransactionType1 { get; set; }

    public string? Description { get; set; }

    public int DescriptionTermId { get; set; }

    public string? DescriptionSuffix { get; set; }

    public int? DescriptionSuffixTermId { get; set; }

    public bool IsBudgetType { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public short? Division { get; set; }
}
