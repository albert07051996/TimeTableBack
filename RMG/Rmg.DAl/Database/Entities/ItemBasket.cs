using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class ItemBasket
{
    public Guid Id { get; set; }

    public int BasketMode { get; set; }

    public int BasketStatus { get; set; }

    public int BasketOwner { get; set; }

    public int Resource { get; set; }

    public Guid? Account { get; set; }

    public Guid? AccountInvoice { get; set; }

    public int RequestType { get; set; }

    public Guid? RequestId { get; set; }

    public string ItemCode { get; set; } = null!;

    public string? CountryCode { get; set; }

    public double Quantity { get; set; }

    public string? CurrencyCode { get; set; }

    public Guid? PriceId { get; set; }

    public int PriceQuantity { get; set; }

    public double PriceLocal { get; set; }

    public double Price { get; set; }

    public string? OrderNumber { get; set; }

    public string? ProcessNumber { get; set; }

    public DateTime? StartDate { get; set; }

    public string? Project { get; set; }

    public int BillingType { get; set; }

    public DateTime Created { get; set; }

    public int? Creator { get; set; }

    public DateTime Modified { get; set; }

    public int? Modifier { get; set; }

    public DateTime? Processed { get; set; }

    public int? Processor { get; set; }

    public string? ReferenceNumber { get; set; }

    public Guid? ContactId { get; set; }

    public short? Division { get; set; }
}
