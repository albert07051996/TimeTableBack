using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class AddressState
{
    public int IdEx { get; set; }

    public Guid Id { get; set; }

    public string? StateCode { get; set; }

    public string? CountryCode { get; set; }

    public string Name { get; set; } = null!;

    public short? Division { get; set; }
}
