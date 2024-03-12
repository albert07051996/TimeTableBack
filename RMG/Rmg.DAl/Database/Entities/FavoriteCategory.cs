using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class FavoriteCategory
{
    public Guid Id { get; set; }

    public int ResId { get; set; }

    public string Description { get; set; } = null!;

    public short? Division { get; set; }
}
