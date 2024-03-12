using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class BacoDiscussionCount
{
    public int GroupId { get; set; }

    public string? Category { get; set; }

    public string? SubCategory { get; set; }

    public int JobLevel { get; set; }

    public int RecCount { get; set; }

    public int NewCount { get; set; }

    public short? Division { get; set; }
}
