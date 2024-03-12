using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class OpportunityItem
{
    public int Id { get; set; }

    public int OpportunityId { get; set; }

    public string ItemCode { get; set; } = null!;

    public double Quantity { get; set; }

    public string Unit { get; set; } = null!;

    public string Currency { get; set; } = null!;

    public double Price { get; set; }

    public double PriceFc { get; set; }

    public int Creator { get; set; }

    public DateTime Created { get; set; }

    public int Modifier { get; set; }

    public DateTime Modified { get; set; }
}
