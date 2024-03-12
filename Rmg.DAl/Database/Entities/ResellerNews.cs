using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class ResellerNews
{
    public Guid Id { get; set; }

    public int Administration { get; set; }

    public string BdlayoutId { get; set; } = null!;

    public int Type { get; set; }

    public short? Division { get; set; }
}
