using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class BacoDiscussionStdPicture
{
    public Guid Id { get; set; }

    public string Description { get; set; } = null!;

    public byte[]? Picture { get; set; }

    public string? Filename { get; set; }

    public string Type { get; set; } = null!;

    public int Width { get; set; }

    public int Height { get; set; }

    public int Size { get; set; }

    public short? Division { get; set; }
}
