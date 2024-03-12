using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class ItemClass
{
    public Guid Id { get; set; }

    public int ClassId { get; set; }

    public string ItemClassCode { get; set; } = null!;

    public string? Description { get; set; }

    public int ItemJobLevel { get; set; }

    public string? Note { get; set; }

    public byte[]? Picture { get; set; }

    public string? PictureFilename { get; set; }

    public int ClassOrder { get; set; }

    public short? Division { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public Guid Sysguid { get; set; }
}
