using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class TimeZone
{
    public int Id { get; set; }

    public string Description { get; set; } = null!;

    public int Bias { get; set; }

    public short? Division { get; set; }
}
