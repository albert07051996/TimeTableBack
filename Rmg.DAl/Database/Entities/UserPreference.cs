using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class UserPreference
{
    public Guid Id { get; set; }

    public Guid OwnerId { get; set; }

    public byte Category { get; set; }

    public byte Type { get; set; }

    public bool IsActive { get; set; }

    public byte FilterType { get; set; }
}
