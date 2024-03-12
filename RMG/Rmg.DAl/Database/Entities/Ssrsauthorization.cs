using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class Ssrsauthorization
{
    public Guid Id { get; set; }

    public Guid ItemId { get; set; }

    public int RoleId { get; set; }

    public int RoleLevel { get; set; }

    public short? Division { get; set; }
}
