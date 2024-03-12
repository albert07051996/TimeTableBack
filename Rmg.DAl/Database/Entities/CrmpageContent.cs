using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class CrmpageContent
{
    public Guid Id { get; set; }

    public Guid? PageId { get; set; }

    public string? Description { get; set; }

    public int Type { get; set; }

    public int? DocCategory { get; set; }

    public int? ViewLayoutId { get; set; }

    public byte[]? Picture { get; set; }

    public string? PageText { get; set; }

    public int JobLevel { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }

    public string? PictureFileName { get; set; }

    public int? ContentOrder { get; set; }

    public string? Url { get; set; }

    public short? Division { get; set; }
}
