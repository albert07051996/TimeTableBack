using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class SmscontractRate
{
    public Guid Id { get; set; }

    public Guid? Agreement { get; set; }

    public Guid? ContractItem { get; set; }

    public Guid? ContractLink { get; set; }

    public Guid? ContractHeader { get; set; }

    public bool? Invoice { get; set; }

    public Guid? DefaultContractRateId { get; set; }

    public string? DefaultFrequency { get; set; }

    public double? DefaultRate { get; set; }

    public string? InvoiceFrequency { get; set; }

    public double? RateDiscount { get; set; }

    public double? InvoiceRate { get; set; }

    public double? ProposedRate { get; set; }

    public byte IsPercentage { get; set; }

    public double? LineDiscount { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }
}
