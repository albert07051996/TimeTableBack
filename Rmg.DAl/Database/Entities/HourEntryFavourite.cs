using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class HourEntryFavourite
{
    public Guid Id { get; set; }

    public int EmployeeId { get; set; }

    public Guid? CustomerId { get; set; }

    public string? ItemCode { get; set; }

    public string? Description { get; set; }

    public string? ProjectNumber { get; set; }

    public string? DeliverableCode { get; set; }

    public Guid? WorkBreakdownStructureLine { get; set; }

    public int? BudgetLine { get; set; }

    public byte Section { get; set; }

    public string? SettingName { get; set; }

    public int? RequestType { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }
}
