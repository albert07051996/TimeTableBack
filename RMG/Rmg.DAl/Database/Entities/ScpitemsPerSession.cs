using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class ScpitemsPerSession
{
    public int Id { get; set; }

    public Guid PortalId { get; set; }

    public Guid SessionId { get; set; }

    public string? CategoryTree { get; set; }

    public DateTime SysCreated { get; set; }
}
