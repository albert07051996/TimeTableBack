using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class FilteredIdentity
{
    public Guid Id { get; set; }

    public Guid PreferenceId { get; set; }

    public Guid EntityId { get; set; }

    public byte EntityType { get; set; }
}
