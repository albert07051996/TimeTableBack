using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class ScpshoppingCart
{
    public Guid PortalId { get; set; }

    public int Code { get; set; }

    public Guid ContactPersonId { get; set; }

    public string? Cart { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }

    public virtual Cicntp ContactPerson { get; set; } = null!;
}
