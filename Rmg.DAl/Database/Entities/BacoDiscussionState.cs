using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class BacoDiscussionState
{
    public int State { get; set; }

    public string? Description { get; set; }

    public int? TermId { get; set; }

    public short? Division { get; set; }
}
