using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class HrcompanyPeriod
{
    public Guid Id { get; set; }

    public string CompanyCode { get; set; } = null!;

    public int FinYear { get; set; }

    public int FinPeriod { get; set; }

    public int Status { get; set; }

    public short? Division { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }
}
