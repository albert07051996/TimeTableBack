using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class CompanyEmployee
{
    public Guid Id { get; set; }

    public string CompanyCode { get; set; } = null!;

    public string ScenarioCode { get; set; } = null!;

    public int FinYear { get; set; }

    public int FinPeriod { get; set; }

    public string CostcenterCode { get; set; } = null!;

    public int? EmployeesCount { get; set; }

    public double? EmployeesFte { get; set; }

    public double? EmployeesBudget { get; set; }

    public short? Division { get; set; }

    public byte[] Timestamp { get; set; } = null!;
}
