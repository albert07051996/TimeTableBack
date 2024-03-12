using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class ScppageSetting
{
    public Guid Id { get; set; }

    public Guid PortalId { get; set; }

    public bool IsAuthenticated { get; set; }

    public string Type { get; set; } = null!;

    public string? Settings { get; set; }
}
