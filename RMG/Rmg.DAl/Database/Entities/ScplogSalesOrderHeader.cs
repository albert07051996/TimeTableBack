using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class ScplogSalesOrderHeader
{
    public Guid Id { get; set; }

    public Guid PortalId { get; set; }

    public Guid ContactPersonId { get; set; }

    public Guid? TransactionKey { get; set; }

    public string? SalesOrderNumber { get; set; }

    public string OrderDebtor { get; set; } = null!;

    public string ShippingVia { get; set; } = null!;

    public string YourReference { get; set; } = null!;

    public string? Reference { get; set; }

    public string? Description1 { get; set; }

    public string? Description2 { get; set; }

    public string? Description3 { get; set; }

    public string? Freefield1 { get; set; }

    public string? Freefield2 { get; set; }

    public string? Freefield3 { get; set; }

    public byte Status { get; set; }

    public string? DeliveryDebtor { get; set; }

    public string? DeliveryDebtorName { get; set; }

    public string? DeliveryDebtorAddress1 { get; set; }

    public string? DeliveryDebtorAddress2 { get; set; }

    public string? DeliveryDebtorAddress3 { get; set; }

    public string? DeliveryDebtorPhone { get; set; }

    public string? DeliveryDebtorFax { get; set; }

    public string? DeliveryDebtorPostCode { get; set; }

    public string? DeliveryDebtorCity { get; set; }

    public string? DeliveryDebtorCounty { get; set; }

    public string? DeliveryDebtorStateCode { get; set; }

    public string? DeliveryDebtorCountryCode { get; set; }

    public string? DeliveryDebtorContactEmail { get; set; }

    public string? DeliveryDebtorContactPerson { get; set; }

    public DateTime? DeliveryDate { get; set; }

    public string? SelectionCode { get; set; }

    public string? Warehouse { get; set; }

    public int? Resource { get; set; }

    public DateTime Timestamp { get; set; }
}
