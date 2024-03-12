using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class SmsagreementSet
{
    public Guid Id { get; set; }

    public string? Code { get; set; }

    public string? Description { get; set; }

    public bool? Active { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public bool? Invoice { get; set; }

    public int? Vatcode { get; set; }

    public double? RateDiscount { get; set; }

    public string? InvoiceFrequency { get; set; }

    public string? ProlongationType { get; set; }

    public string? Bedrnr { get; set; }

    public string? CostCenterCode { get; set; }

    public string? CostUnitCode { get; set; }

    public byte MaintenanceType { get; set; }

    public string IndexationStatus { get; set; } = null!;

    public byte IndexationType { get; set; }

    public byte IndexationMonth { get; set; }

    public double IndexationAmountPercentage { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }
}
