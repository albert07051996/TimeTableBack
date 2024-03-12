using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class ProjectAccount
{
    public string Project { get; set; } = null!;

    public Guid Account { get; set; }

    public short? Division { get; set; }
}
