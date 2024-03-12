using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class Number
{
    public string CompanyCode { get; set; } = null!;

    public short Type { get; set; }

    public int Number1 { get; set; }

    public bool Used { get; set; }

    public short? Division { get; set; }
}
