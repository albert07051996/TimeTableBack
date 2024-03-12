using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class CompanyParticipation
{
    public Guid Id { get; set; }

    public string ParentCompanyCode { get; set; } = null!;

    public string ChildCompanyCode { get; set; } = null!;

    public double PercentageControl { get; set; }

    public double PercentageFinancial { get; set; }

    public short? Division { get; set; }

    public byte[] Timestamp { get; set; } = null!;
}
