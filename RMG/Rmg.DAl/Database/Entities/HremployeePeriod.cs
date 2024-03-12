using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class HremployeePeriod
{
    public Guid Id { get; set; }

    public int EmpId { get; set; }

    public int FinYear { get; set; }

    public int FinPeriod { get; set; }

    public double HoursWorked { get; set; }

    public double DaysWorked { get; set; }

    public double HoursAbsent { get; set; }

    public double DaysAbsent { get; set; }

    public short? Division { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }
}
