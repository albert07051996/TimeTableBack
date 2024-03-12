using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class HrroleLevel
{
    public int Id { get; set; }

    public string Description { get; set; } = null!;

    public int? TermId { get; set; }

    public short? Division { get; set; }
}
