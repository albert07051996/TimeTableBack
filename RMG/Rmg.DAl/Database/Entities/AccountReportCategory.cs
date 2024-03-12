using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class AccountReportCategory
{
    public int AccountReportCategory1 { get; set; }

    public string? Description { get; set; }

    public int DescriptionTermId { get; set; }

    public string? DescriptionSuffix { get; set; }

    public int? DescriptionSuffixTermId { get; set; }

    public short? Division { get; set; }

    public double Multiplier { get; set; }

    public bool Visible { get; set; }

    public int? ReportOrder { get; set; }

    public byte[] Timestamp { get; set; } = null!;
}
