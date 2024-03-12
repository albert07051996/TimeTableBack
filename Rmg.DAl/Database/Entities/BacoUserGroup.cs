using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class BacoUserGroup
{
    public string GroupName { get; set; } = null!;

    public string AppRole { get; set; } = null!;

    public Guid AppRolePassword { get; set; }

    public short? Division { get; set; }
}
