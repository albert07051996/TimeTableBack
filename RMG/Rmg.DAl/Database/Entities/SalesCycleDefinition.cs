using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class SalesCycleDefinition
{
    public int Id { get; set; }

    public string Description { get; set; } = null!;

    public bool Active { get; set; }

    public int Creator { get; set; }

    public DateTime Created { get; set; }

    public int Modifier { get; set; }

    public DateTime Modified { get; set; }
}
