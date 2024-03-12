using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class SmspmplanView
{
    public Guid? SerialNumber { get; set; }

    public Guid? ContractId { get; set; }

    public string? ContractNumber { get; set; }

    public Guid? ContractItem { get; set; }

    public Guid? ContractAccount { get; set; }

    public Guid? Pmtype { get; set; }

    public Guid? Pmschedule { get; set; }

    public string? PmscheduleCode { get; set; }

    public string? PmscheduleDescription { get; set; }

    public DateTime? StartDate { get; set; }

    public bool? TimeIntervalCheckbox { get; set; }

    public double? TimeInterval { get; set; }

    public string? TimeIntervalUnits { get; set; }

    public bool? UsageIntervalCheckbox { get; set; }

    public double? UsageInterval { get; set; }

    public string? StartNextRequest { get; set; }

    public string? ContractSelection { get; set; }

    public DateTime? ActivityStartTime { get; set; }

    public double? ActivityDuration { get; set; }
}
