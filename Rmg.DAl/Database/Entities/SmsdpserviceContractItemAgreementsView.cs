using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class SmsdpserviceContractItemAgreementsView
{
    public Guid? ContractHeader { get; set; }

    public string? ContractItemAgreement { get; set; }

    public string? Configuration { get; set; }

    public int? ConfigurationLevel { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public DateTime? InvoicedUntilDate { get; set; }

    public string ProlongationType { get; set; } = null!;

    public string? Vatcode { get; set; }

    public double? Vat { get; set; }

    public bool InvoiceYesNo { get; set; }

    public string DefaultFrequency { get; set; } = null!;

    public int DefaultRatePeriod { get; set; }

    public decimal? DefaultRate { get; set; }

    public string InvoiceFrequency { get; set; } = null!;

    public decimal? RateDiscount { get; set; }

    public decimal? InvoiceRate { get; set; }

    public string AgreementType { get; set; } = null!;

    public string ShortDescription { get; set; } = null!;

    public string LongDescription { get; set; } = null!;

    public string AgreementDocument { get; set; } = null!;

    public string PartHourGroup { get; set; } = null!;

    public string PartHourAssortment { get; set; } = null!;

    public int? PartHourInclExcl { get; set; }

    public decimal? PartHourPercentage { get; set; }

    public string AddPartHour { get; set; } = null!;

    public int? ResponseTime { get; set; }

    public string? ResponseTimeUnit { get; set; }

    public string? PrepaidType { get; set; }

    public decimal? PrepaidAmount { get; set; }

    public decimal? PrepaidAmountRemain { get; set; }

    public double PrepaidQuantity { get; set; }

    public double PrepaidQuantityRemain { get; set; }

    public double PmtimeInterval { get; set; }

    public string? PmtimeUnits { get; set; }

    public DateTime? InvoiceDate { get; set; }

    public Guid? ConfigurationId { get; set; }

    public string? ContractNumber { get; set; }
}
