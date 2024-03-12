using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class LandClass
{
    public Guid Id { get; set; }

    public int ClassId { get; set; }

    public string LandClassCode { get; set; } = null!;

    public string? Description { get; set; }

    public short? Division { get; set; }
}
