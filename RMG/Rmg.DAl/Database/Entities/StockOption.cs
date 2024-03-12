using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class StockOption
{
    public int Id { get; set; }

    public int EmpId { get; set; }

    public DateTime? TransactionDate { get; set; }

    public string? TransactionType { get; set; }

    public string? CompanyName { get; set; }

    public double? Qty { get; set; }

    public double? PremiumAmount { get; set; }

    public string? Currency { get; set; }

    public double? ExercisePrice { get; set; }

    public DateTime? VestingDate { get; set; }

    public DateTime? EndDate { get; set; }

    public string? Notes { get; set; }

    public short? Division { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }
}
