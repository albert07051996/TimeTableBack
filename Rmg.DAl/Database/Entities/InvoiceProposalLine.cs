using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class InvoiceProposalLine
{
    public Guid Id { get; set; }

    public Guid LineId { get; set; }

    public byte LineType { get; set; }

    public Guid GroupId { get; set; }

    public byte Status { get; set; }

    public DateTime Created { get; set; }

    public int Creator { get; set; }

    public DateTime Modified { get; set; }

    public int Modifier { get; set; }
}
