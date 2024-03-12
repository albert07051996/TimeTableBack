using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class Hrwdoc
{
    public int Id { get; set; }

    public string? DocCode { get; set; }

    public string? Descr400 { get; set; }

    public string? Descr401 { get; set; }

    public string? Descr402 { get; set; }

    public string? Descr403 { get; set; }

    public string? Descr404 { get; set; }

    public Guid? Docid { get; set; }

    public string? Type { get; set; }

    public string? MergeType { get; set; }

    public short? Division { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }

    public Guid Sysguid { get; set; }

    public byte[] Timestamp { get; set; } = null!;
}
