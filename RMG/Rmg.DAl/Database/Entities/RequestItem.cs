using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class RequestItem
{
    public Guid Id { get; set; }

    public int RequestType { get; set; }

    public string ItemCode { get; set; } = null!;

    public int Type { get; set; }

    public short? Division { get; set; }
}
