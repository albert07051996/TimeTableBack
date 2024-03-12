using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class HrroleDef
{
    public int Id { get; set; }

    public string Description { get; set; } = null!;

    public string? JobGroup { get; set; }

    public Guid? DocId { get; set; }

    public string? Ntgroup { get; set; }

    public short? Type { get; set; }

    public short? Division { get; set; }
}
