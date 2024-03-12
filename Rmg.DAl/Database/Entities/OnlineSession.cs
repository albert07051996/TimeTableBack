using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class OnlineSession
{
    public Guid Id { get; set; }

    public int? HumresId { get; set; }

    public string SessionId { get; set; } = null!;

    public DateTime SessionDateTime { get; set; }
}
