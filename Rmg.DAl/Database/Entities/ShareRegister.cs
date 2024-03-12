using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class ShareRegister
{
    public int Id { get; set; }

    public string Parent { get; set; } = null!;

    public string ShareType { get; set; } = null!;

    public double Quantity { get; set; }

    public string Division { get; set; } = null!;

    public DateTime Created { get; set; }

    public int Creator { get; set; }

    public DateTime Modified { get; set; }

    public int Modifier { get; set; }
}
