using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class SsrspersonAuthorization
{
    public Guid Id { get; set; }

    public Guid ItemId { get; set; }

    public int ResId { get; set; }

    public string? Divisions { get; set; }
}
