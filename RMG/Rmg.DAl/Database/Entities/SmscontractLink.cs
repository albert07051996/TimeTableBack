using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class SmscontractLink
{
    public Guid Id { get; set; }

    public Guid? Configuration { get; set; }

    public Guid? ContractItem { get; set; }

    public Guid? ContractAgreement { get; set; }

    public DateTime? InvoicedUntil { get; set; }

    public DateTime? OldInvoicedUntil { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }
}
