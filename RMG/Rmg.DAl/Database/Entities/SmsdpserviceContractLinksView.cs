using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class SmsdpserviceContractLinksView
{
    public Guid? ContractHeader { get; set; }

    public string? AlAgreement { get; set; }

    public DateTime? AlStartDate { get; set; }

    public DateTime? AlEndDate { get; set; }

    public DateTime? AlInvoicedUntilDate { get; set; }

    public string AlProlongationType { get; set; } = null!;

    public string? AlVatcode { get; set; }

    public double? AlVatpercentage { get; set; }

    public bool AlInvoiceYesNo { get; set; }

    public string AlDefaultFrequency { get; set; } = null!;

    public int AlDefaultRatePeriod { get; set; }

    public decimal? AlDefaultRate { get; set; }

    public string AlInvoiceFrequency { get; set; } = null!;

    public decimal? AlRateDiscount { get; set; }

    public decimal? AlInvoiceRate { get; set; }

    public string AlAgreementType { get; set; } = null!;

    public string AlShortDescription { get; set; } = null!;

    public string AlLongDescription { get; set; } = null!;

    public string AlAgreementDocument { get; set; } = null!;

    public string AlPartHourGroup { get; set; } = null!;

    public string AlPartHourAssortment { get; set; } = null!;

    public bool? AlPartHourInclExcl { get; set; }

    public decimal? AlPartHourPercentage { get; set; }

    public string AlAddPartHour { get; set; } = null!;

    public int? AlResponseTime { get; set; }

    public string? AlResponseTimeUnit { get; set; }

    public string? AlPrepaidType { get; set; }

    public decimal? AlPrepaidAmount { get; set; }

    public decimal? AlPrepaidAmountRemain { get; set; }

    public double? AlPrepaidQuantity { get; set; }

    public double AlPrepaidQuantityRemain { get; set; }

    public double AlPmtimeInterval { get; set; }

    public string? AlPmtimeUnits { get; set; }

    public DateTime? AlInvoiceDate { get; set; }

    public Guid? ConfigurationId { get; set; }

    public string? ContractNumber { get; set; }
}
