using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class EbcLogCustom
{
    public Guid Component { get; set; }

    public Guid Property { get; set; }

    public int Log { get; set; }
}
