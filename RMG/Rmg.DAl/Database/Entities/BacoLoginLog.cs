using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class BacoLoginLog
{
    public int Id { get; set; }

    public DateTime Created { get; set; }

    public int HumresId { get; set; }

    public string Status { get; set; } = null!;
}
