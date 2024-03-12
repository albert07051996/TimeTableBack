using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class BacoAppLogApp
{
    public DateTime Day { get; set; }

    public int Rank { get; set; }

    public string App { get; set; } = null!;

    public int AppCount { get; set; }

    public int AppAverageDuration { get; set; }

    public int AppMaxDuration { get; set; }

    public short? Division { get; set; }
}
