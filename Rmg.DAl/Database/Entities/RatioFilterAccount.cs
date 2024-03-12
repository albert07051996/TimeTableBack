using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class RatioFilterAccount
{
    public string RatioCode { get; set; } = null!;

    public string AccountCode { get; set; } = null!;

    public short? Division { get; set; }

    public byte[] Timestamp { get; set; } = null!;
}
