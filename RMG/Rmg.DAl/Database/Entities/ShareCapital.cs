using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class ShareCapital
{
    public int Id { get; set; }

    public string ShareType { get; set; } = null!;

    public string TransactionType { get; set; } = null!;

    public double Quantity { get; set; }

    public DateTime Date { get; set; }

    public double ParValue { get; set; }

    public string? Description { get; set; }

    public string Division { get; set; } = null!;

    public DateTime Created { get; set; }

    public int Creator { get; set; }

    public DateTime Modified { get; set; }

    public int Modifier { get; set; }
}
