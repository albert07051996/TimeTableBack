using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class Operation
{
    public int Id { get; set; }

    public string Operation1 { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string? LayoutName { get; set; }

    public bool Blocked { get; set; }

    public bool OperationPrint { get; set; }

    public string? AssetGroup { get; set; }

    public string? AssetCode { get; set; }

    public string? MachineHour { get; set; }

    public string? CostCenter { get; set; }

    public int? ResId { get; set; }

    public string? LaborHourOperating { get; set; }

    public double? OperatingTime { get; set; }

    public double? LaborMachineRatio { get; set; }

    public string? LaborHourSetup { get; set; }

    public double? SetupTime { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }

    public Guid Sysguid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public short? Division { get; set; }
}
