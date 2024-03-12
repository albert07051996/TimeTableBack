using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class DdbrowseInfo
{
    public string TableName { get; set; } = null!;

    public string? Statement { get; set; }

    public string? Tables { get; set; }

    public string? ColInfo { get; set; }
}
