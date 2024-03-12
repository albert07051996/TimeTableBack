using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class ScpwidgetSetting
{
    public Guid Id { get; set; }

    public Guid PortalId { get; set; }

    public bool IsAuthenticated { get; set; }

    public string Type { get; set; } = null!;

    public string Page { get; set; } = null!;

    public string Zone { get; set; } = null!;

    public int Order { get; set; }

    public string Alignment { get; set; } = null!;

    public string Settings { get; set; } = null!;
}
