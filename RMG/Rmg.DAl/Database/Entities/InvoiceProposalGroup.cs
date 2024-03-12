using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class InvoiceProposalGroup
{
    public Guid Id { get; set; }

    public Guid RequestId { get; set; }

    public byte InvoiceGrouping { get; set; }

    public string? Description { get; set; }

    public byte Status { get; set; }

    public string Type { get; set; } = null!;

    public DateTime Created { get; set; }

    public int Creator { get; set; }

    public DateTime Modified { get; set; }

    public int Modifier { get; set; }
}
