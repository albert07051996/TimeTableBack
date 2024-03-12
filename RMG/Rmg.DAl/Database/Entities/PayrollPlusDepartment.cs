using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class PayrollPlusDepartment
{
    public int Id { get; set; }

    public int DepartmentId { get; set; }

    public string? Description { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }
}
