using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class ScpportalsEditRight
{
    public Guid Id { get; set; }

    public Guid PortalId { get; set; }

    public Guid ContactPersonId { get; set; }

    public bool AccessRights { get; set; }

    public bool CheckOutRights { get; set; }

    public bool ViewAllCardsRights { get; set; }

    public virtual Cicntp ContactPerson { get; set; } = null!;
}
