using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class OutstandingTerm
{
    public Guid Id { get; set; }

    public int TermId { get; set; }

    public string? DebtorNumber { get; set; }

    public string? Tccode { get; set; }

    public double? AmountDc { get; set; }

    public double? AmountTc { get; set; }

    public string? Description { get; set; }

    public string? InvoiceNumber { get; set; }

    public string? SupplierInvoiceNumber { get; set; }

    public DateTime? DueDate { get; set; }

    public string? CompanyCode { get; set; }

    public DateTime? InvoiceDate { get; set; }

    public string? TransactionType { get; set; }

    public string Type { get; set; } = null!;

    public string? PaymentCondition { get; set; }

    public int? ReminderLayout { get; set; }

    public DateTime? LastReminderDate { get; set; }

    public bool? Blocked { get; set; }

    public byte[] Bttimestamp { get; set; } = null!;

    public byte[] Gbtimestamp { get; set; } = null!;

    public Guid Sysguid { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime? PaymentDate { get; set; }

    public string? StatementType { get; set; }
}
