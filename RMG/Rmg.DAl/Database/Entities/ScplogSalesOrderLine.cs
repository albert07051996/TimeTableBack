using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class ScplogSalesOrderLine
{
    public Guid Id { get; set; }

    public Guid SalesOrderHeaderId { get; set; }

    public Guid PortalId { get; set; }

    public Guid ContactPersonId { get; set; }

    public Guid? TransactionKey { get; set; }

    public string? SalesOrderNumber { get; set; }

    public string ItemCode { get; set; } = null!;

    public double Quantity { get; set; }

    public double? DiscountPercentage { get; set; }

    public byte Status { get; set; }

    public DateTime Timestamp { get; set; }
}
