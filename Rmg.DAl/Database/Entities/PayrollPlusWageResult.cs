using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class PayrollPlusWageResult
{
    public int Id { get; set; }

    public int ResourceId { get; set; }

    public short WageYear { get; set; }

    public short WagePeriod { get; set; }

    public int DepartmentId { get; set; }

    public int FunctionId { get; set; }

    public int ComponentCode { get; set; }

    public int CategoryCode { get; set; }

    public double Content { get; set; }

    public double ContentRate { get; set; }

    public short EmployerCost { get; set; }

    public short? ClientNumber { get; set; }

    public int RunYear { get; set; }

    public int RunPeriod { get; set; }

    public int RunSequence { get; set; }

    public int? PayrollNo { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }
}
