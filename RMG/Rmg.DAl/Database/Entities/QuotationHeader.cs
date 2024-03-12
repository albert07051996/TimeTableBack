using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class QuotationHeader
{
    public int Id { get; set; }

    public string QuotationNo { get; set; } = null!;

    public Guid AccountId { get; set; }

    public Guid? ContactId { get; set; }

    public int Owner { get; set; }

    public string? CurrencyCode { get; set; }

    public string? PaymentConditionCode { get; set; }

    public string? YourReference { get; set; }

    public DateTime? ExpiryDate { get; set; }

    public int? OpportunityId { get; set; }

    public string? ProjectCode { get; set; }

    public bool IsDeleted { get; set; }

    public string Status { get; set; } = null!;

    public Guid? TemplateId { get; set; }

    public string? SalesOrderNumber { get; set; }

    public string? DivisionCode { get; set; }

    public DateTime Created { get; set; }

    public int Creator { get; set; }

    public DateTime Modified { get; set; }

    public int Modifier { get; set; }

    public byte[] Timestamp { get; set; } = null!;
}
