using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class Xmlfile
{
    public string Name { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public short? Division { get; set; }
}
