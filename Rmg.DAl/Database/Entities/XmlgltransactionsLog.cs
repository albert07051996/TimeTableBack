using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class XmlgltransactionsLog
{
    public Guid Id { get; set; }

    public string CompanyCode { get; set; } = null!;

    public int HumresId { get; set; }

    public DateTime ImportDate { get; set; }

    public Guid EntryGuid { get; set; }

    public string Status { get; set; } = null!;

    public short? Division { get; set; }
}
