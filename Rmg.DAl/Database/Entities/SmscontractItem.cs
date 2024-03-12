using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class SmscontractItem
{
    public Guid Id { get; set; }

    public int LineNumber { get; set; }

    public Guid? ContractHeader { get; set; }

    public Guid? Configuration { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public DateTime? InvoicedUntilDate { get; set; }

    public DateTime? OldInvoicedUntilDate { get; set; }

    public int? Vatcode { get; set; }

    public string? ProlongationType { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }
}
