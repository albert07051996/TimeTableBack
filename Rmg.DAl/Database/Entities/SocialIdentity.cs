using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class SocialIdentity
{
    public Guid Id { get; set; }

    public string IdentityKey { get; set; } = null!;

    public int IdentityType { get; set; }

    public string? Metadata { get; set; }
}
