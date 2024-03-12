using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class DivisionPerson
{
    public Guid Id { get; set; }

    public int PersonId { get; set; }

    public string Division { get; set; } = null!;

    public Guid? DivisionDebtorId { get; set; }

    public Guid? DivisionCreditorId { get; set; }

    public bool MainDivision { get; set; }

    public int? Manager { get; set; }

    public int? Assistant { get; set; }

    public string? CostUnit { get; set; }

    public string? CostCenter { get; set; }

    public string? Phone { get; set; }

    public string? Extension { get; set; }

    public string? Mobile { get; set; }

    public string? Fax { get; set; }

    public string? MainLocation { get; set; }

    public string? Location { get; set; }

    public string? Room { get; set; }

    public string? Email { get; set; }

    public string? CurrentRating { get; set; }

    public string? PreviousRating { get; set; }

    public int SecurityLevel { get; set; }

    public byte BackOfficeBlocked { get; set; }

    public string? Status { get; set; }

    public string? Type { get; set; }

    public string? JobTitle { get; set; }

    public int JobLevel { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime? Inactive { get; set; }

    public DateTime? ContractEndDate { get; set; }

    public string? Reason { get; set; }

    public double Fte { get; set; }

    public string? Rate { get; set; }

    public double InternalRate { get; set; }

    public double PurchaseLimit { get; set; }

    public double SalesLimit { get; set; }

    public double InvoiceLimit { get; set; }

    public double Rmalimit { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }
}
