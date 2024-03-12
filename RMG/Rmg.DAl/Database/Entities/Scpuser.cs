using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class Scpuser
{
    public Guid ContactPersonId { get; set; }

    public string? Username { get; set; }

    public string? Password { get; set; }
}
