using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class ScpcustomPage
{
    public Guid Id { get; set; }

    public Guid PortalId { get; set; }

    public bool IsAuthenticated { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }
}
