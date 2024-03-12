using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class HrmainFint
{
    public string Id { get; set; } = null!;

    public string? Description { get; set; }

    public int GraphColor { get; set; }

    public int? ViewOrder { get; set; }

    public short? Division { get; set; }
}
