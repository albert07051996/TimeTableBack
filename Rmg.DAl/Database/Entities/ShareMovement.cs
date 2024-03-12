using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class ShareMovement
{
    public int Id { get; set; }

    public int ShareRegisterId { get; set; }

    public short Year { get; set; }

    public string Period { get; set; } = null!;

    public string TransactionType { get; set; } = null!;

    public DateTime TransactionDate { get; set; }

    public double Quantity { get; set; }

    public DateTime Created { get; set; }

    public int Creator { get; set; }

    public DateTime Modified { get; set; }

    public int Modifier { get; set; }
}
