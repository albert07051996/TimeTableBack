﻿using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class Smspmschedule
{
    public Guid Id { get; set; }

    public string Code { get; set; } = null!;

    public string Description { get; set; } = null!;

    public Guid? Pmtype { get; set; }

    public bool? Active { get; set; }

    public string? DefinedPer { get; set; }

    public Guid? Assortment { get; set; }

    public Guid? Item { get; set; }

    public Guid? SerialNumber { get; set; }

    public DateTime? StartDate { get; set; }

    public bool? Time { get; set; }

    public double? TimeInterval { get; set; }

    public string? TimeUnits { get; set; }

    public bool? Usage { get; set; }

    public double? UsageInterval { get; set; }

    public string? StartNext { get; set; }

    public string? Contract { get; set; }

    public DateTime? StartTime { get; set; }

    public double? Duration { get; set; }

    public string? ItemCode { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }
}
