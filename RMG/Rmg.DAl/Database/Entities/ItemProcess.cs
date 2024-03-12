using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class ItemProcess
{
    public Guid Id { get; set; }

    public int Type { get; set; }

    public int RequestBy { get; set; }

    public DateTime RequestDate { get; set; }

    public int Status { get; set; }

    public string? Company { get; set; }

    public DateTime DateStart { get; set; }

    public DateTime DateEnd { get; set; }

    public Guid? DocumentId { get; set; }

    public string? Remark { get; set; }

    public int Mode { get; set; }

    public string? ScenarioCode { get; set; }

    public short? Division { get; set; }

    public short ContractType { get; set; }

    public int? Assortment { get; set; }

    public short? Indexing { get; set; }

    public string? Indexation { get; set; }

    public string? InvoiceDivision { get; set; }

    public string? InvoiceCurrency { get; set; }

    public string? InvoiceFrequency { get; set; }

    public string? Xmlmessage { get; set; }

    public Guid? Account { get; set; }

    public string? InvoiceDebtor { get; set; }

    public string? SalesInvoiceDivision { get; set; }

    public string? SalesInvoiceDebtor { get; set; }

    public string? FieldList { get; set; }
}
