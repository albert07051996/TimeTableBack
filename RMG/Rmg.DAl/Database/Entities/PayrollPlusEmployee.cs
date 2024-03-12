using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class PayrollPlusEmployee
{
    public int Id { get; set; }

    public int ResourceId { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public int FunctionId { get; set; }

    public int DepartmentId { get; set; }

    public double TeamHours { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }
}
