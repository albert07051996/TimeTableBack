using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class Xmlevent
{
    public Guid Id { get; set; }

    public string CompanyCode { get; set; } = null!;

    public int BatchId { get; set; }

    public int HumresId { get; set; }

    public int EventType { get; set; }

    public string? EventDescription { get; set; }

    public DateTime EventDate { get; set; }

    public string? Topic { get; set; }

    public string? Node { get; set; }

    public string? ImportExport { get; set; }

    public string? DataKey { get; set; }

    public string? DataKeyAlt { get; set; }

    public string? Xmlnode { get; set; }

    public short? Division { get; set; }
}
