using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class AddressPostCode
{
    public Guid Id { get; set; }

    public int Idcol { get; set; }

    public string? PostCode { get; set; }

    public string? CountryCode { get; set; }

    public string? StateCode { get; set; }

    public string? City { get; set; }

    public short? Division { get; set; }
}
