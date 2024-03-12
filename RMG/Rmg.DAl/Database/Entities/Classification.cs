using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class Classification
{
    public int Id { get; set; }

    public string ClassificationId { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string? MlDesc0 { get; set; }

    public string? MlDesc1 { get; set; }

    public string? MlDesc2 { get; set; }

    public string? MlDesc3 { get; set; }

    public string? MlDesc4 { get; set; }

    public string? Type { get; set; }

    public int? Rank { get; set; }

    public Guid? PolicyDocId { get; set; }

    public short? Division { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }

    public Guid Sysguid { get; set; }

    public byte[] Timestamp { get; set; } = null!;
}
