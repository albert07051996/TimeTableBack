using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class ScpfavoriteItem
{
    public Guid Id { get; set; }

    public Guid PortalId { get; set; }

    public Guid ContactPersonId { get; set; }

    public string ItemCode { get; set; } = null!;

    public virtual Cicntp ContactPerson { get; set; } = null!;
}
