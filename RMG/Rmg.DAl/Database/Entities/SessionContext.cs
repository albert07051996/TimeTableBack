using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class SessionContext
{
    public int Id { get; set; }

    public string? EntityName { get; set; }

    public string? Query { get; set; }

    public string? LastKeyRetrieved { get; set; }

    public DateTime LastAccessedDate { get; set; }
}
