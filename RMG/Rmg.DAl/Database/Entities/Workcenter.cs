using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class Workcenter
{
    public int Id { get; set; }

    public string Workcenter1 { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string? MachineHour { get; set; }

    public string? LaborHourOperating { get; set; }

    public double? LaborMachineRatio { get; set; }

    public string? LaborHourSetup { get; set; }

    public double? SetupQuantity { get; set; }

    public byte? Blocked { get; set; }

    public short? Division { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }

    public Guid Sysguid { get; set; }

    public byte[] Timestamp { get; set; } = null!;
}
