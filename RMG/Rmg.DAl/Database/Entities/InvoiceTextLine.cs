using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class InvoiceTextLine
{
    public Guid Id { get; set; }

    public Guid RequestId { get; set; }

    public string? Description { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime Created { get; set; }

    public int Creator { get; set; }

    public DateTime Modified { get; set; }

    public int Modifier { get; set; }
}
