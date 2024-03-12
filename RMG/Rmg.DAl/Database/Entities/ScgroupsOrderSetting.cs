using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class ScgroupsOrderSetting
{
    public Guid Person { get; set; }

    public string? GroupsOrder { get; set; }

    public bool Sorting { get; set; }
}
