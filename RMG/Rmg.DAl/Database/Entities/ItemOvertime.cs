using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class ItemOvertime
{
    public Guid Id { get; set; }

    public string ItemCode { get; set; } = null!;

    public string ParentItem { get; set; } = null!;

    public DateTime Created { get; set; }

    public int Creator { get; set; }

    public DateTime Modified { get; set; }

    public int Modifier { get; set; }
}
