using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class BacoFunction
{
    public int Id { get; set; }

    public string Description { get; set; } = null!;

    public int? DescriptionTermId { get; set; }

    public int Product { get; set; }

    public string? Target { get; set; }

    public bool UseDivision { get; set; }

    public string? Notes { get; set; }

    public short? Division { get; set; }

    public virtual ICollection<BacoFunctionRole> BacoFunctionRoles { get; set; } = new List<BacoFunctionRole>();
}
