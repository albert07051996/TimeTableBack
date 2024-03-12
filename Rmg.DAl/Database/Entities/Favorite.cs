using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class Favorite
{
    public Guid Id { get; set; }

    public int ResId { get; set; }

    public Guid Category { get; set; }

    public string Description { get; set; } = null!;

    public string Url { get; set; } = null!;

    public short? Division { get; set; }

    public int ViewOrder { get; set; }

    public DateTime? Syscreated { get; set; }
}
