using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class ResourceType
{
    public string Type { get; set; } = null!;

    public string Description { get; set; } = null!;

    public int TermId { get; set; }

    public short? Division { get; set; }
}
