using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class BacoFreeNumber
{
    public string NumberKey { get; set; } = null!;

    public int FreeNumber { get; set; }

    public short? Division { get; set; }
}
