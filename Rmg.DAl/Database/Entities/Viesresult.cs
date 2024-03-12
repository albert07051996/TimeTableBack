using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class Viesresult
{
    public Guid Id { get; set; }

    public Guid Account { get; set; }

    public string VatNumber { get; set; } = null!;

    public string? CountryCode { get; set; }

    public string? ValidationStatus { get; set; }

    public DateTime? ValidationDate { get; set; }

    public string? RequestIdentifier { get; set; }

    public Guid? ValidationId { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }
}
