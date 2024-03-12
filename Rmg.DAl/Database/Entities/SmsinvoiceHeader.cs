using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class SmsinvoiceHeader
{
    public Guid Id { get; set; }

    public Guid Division { get; set; }

    public string Currency { get; set; } = null!;

    public string? InvoiceDescription { get; set; }

    public Guid Account { get; set; }

    public Guid InvoiceAccount { get; set; }

    public string? OrderNumber { get; set; }

    public short? ExportStatus { get; set; }

    public string? DivisionCode { get; set; }

    public int? EgcommunicationStatus { get; set; }

    public string? EgerrorMessage { get; set; }

    public string? SelectionCode { get; set; }

    public string? PaymentCondition { get; set; }

    public bool ManuallyModified { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }
}
