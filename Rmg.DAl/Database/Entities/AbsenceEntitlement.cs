using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class AbsenceEntitlement
{
    public Guid Id { get; set; }

    public int AbsenceType { get; set; }

    public int? EmpId { get; set; }

    public string? CompanyCode { get; set; }

    public double Scale { get; set; }

    public string? JobGroup { get; set; }

    public double Hours { get; set; }

    public double Days { get; set; }

    public short? Division { get; set; }

    public int StatutoryEntitlementExpiry { get; set; }

    public double StatutoryEntitlementDays { get; set; }

    public string? StatutoryEntitlementUnit { get; set; }

    public double StatutoryEntitlementHours { get; set; }

    public int NonStatutoryEntitlementExpiry { get; set; }

    public double NonStatutoryEntitlementDays { get; set; }

    public string? NonStatutoryEntitlementUnit { get; set; }

    public double NonStatutoryEntitlementHours { get; set; }

    public bool? ApplyExpiryDate { get; set; }

    public string? EffectiveExpiryPeriod { get; set; }

    public short? EffectiveExpiryYear { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }
}
