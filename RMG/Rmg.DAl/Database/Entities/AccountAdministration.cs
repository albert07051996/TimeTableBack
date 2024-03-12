using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class AccountAdministration
{
    public int Id { get; set; }

    public Guid Account { get; set; }

    public string ServerName { get; set; } = null!;

    public string DataBaseName { get; set; } = null!;

    public string? Description { get; set; }

    public string? Extra { get; set; }

    public string? Url { get; set; }

    public string? BackupDirectory { get; set; }

    public string? WebServer { get; set; }

    public string? IntervalType { get; set; }

    public string Type { get; set; } = null!;

    public DateTime? Date1 { get; set; }

    public DateTime? Date2 { get; set; }

    public DateTime? Date3 { get; set; }

    public DateTime? Date4 { get; set; }

    public DateTime? Date5 { get; set; }

    public DateTime? Date6 { get; set; }

    public DateTime? Date7 { get; set; }

    public DateTime? Date8 { get; set; }

    public DateTime? Date9 { get; set; }

    public DateTime? Date10 { get; set; }

    public string? Description1 { get; set; }

    public string? Description2 { get; set; }

    public string? Description3 { get; set; }

    public string? Description4 { get; set; }

    public string? Description5 { get; set; }

    public string? Description6 { get; set; }

    public string? Description7 { get; set; }

    public string? Description8 { get; set; }

    public string? Description9 { get; set; }

    public string? Description10 { get; set; }

    public double Quantity1 { get; set; }

    public double Quantity2 { get; set; }

    public double Quantity3 { get; set; }

    public double Quantity4 { get; set; }

    public double Quantity5 { get; set; }

    public double Quantity6 { get; set; }

    public double Quantity7 { get; set; }

    public double Quantity8 { get; set; }

    public double Quantity9 { get; set; }

    public double Quantity10 { get; set; }

    public short? Division { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }

    public Guid Sysguid { get; set; }

    public byte[] Timestamp { get; set; } = null!;
}
