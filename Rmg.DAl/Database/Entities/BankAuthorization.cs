using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class BankAuthorization
{
    public int Id { get; set; }

    public string BankAccount { get; set; } = null!;

    public int ResourceId { get; set; }

    public double Amount { get; set; }

    public Guid? DocumentId { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public double AmountRestricted { get; set; }

    public short? Division { get; set; }
}
