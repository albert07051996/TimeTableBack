using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class ExactTrialModule
{
    public string ItemCode { get; set; } = null!;

    public string Description { get; set; } = null!;

    public int TermId { get; set; }

    public bool Active { get; set; }

    public DateTime ActivationDate { get; set; }

    public DateTime ExpirationDate { get; set; }

    public short Credit { get; set; }

    public int Checksum { get; set; }

    public short? Division { get; set; }
}
