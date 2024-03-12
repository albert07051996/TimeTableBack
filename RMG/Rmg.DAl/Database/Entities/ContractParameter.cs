using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class ContractParameter
{
    public Guid Id { get; set; }

    public string Company { get; set; } = null!;

    public DateTime ValidFrom { get; set; }

    public int Method { get; set; }

    public int RenewalPeriod { get; set; }

    public string RenewalInterval { get; set; } = null!;

    public double PriceIndex { get; set; }

    public int CurrencySource { get; set; }

    public string DocumentType { get; set; } = null!;

    public int MonthsToBillAhead { get; set; }

    public string? InvoiceCode { get; set; }

    public int BillingType { get; set; }

    public string? YourRef { get; set; }

    public string? Description { get; set; }

    public string? SelectionCode { get; set; }

    public string? CostCenterCode { get; set; }

    public int? ResourceId { get; set; }

    public short? Division { get; set; }

    public bool UseIndex { get; set; }

    public string? SalesInvoiceCode { get; set; }

    public string? DeliveryDebtor { get; set; }
}
