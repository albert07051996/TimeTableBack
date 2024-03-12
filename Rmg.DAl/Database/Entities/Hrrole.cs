using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class Hrrole
{
    public Guid Id { get; set; }

    public int RoleId { get; set; }

    public int EmpId { get; set; }

    public int RoleLevel { get; set; }

    public short? Division { get; set; }
}
