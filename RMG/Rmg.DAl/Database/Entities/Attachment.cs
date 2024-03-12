using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class Attachment
{
    public Guid Id { get; set; }

    public Guid Entity { get; set; }

    public int EntityType { get; set; }

    public byte[] Attachment1 { get; set; } = null!;

    public string AttachmentFileName { get; set; } = null!;

    public string? AttachmentFileExtension { get; set; }

    public int AttachmentType { get; set; }

    public string? AttachmentUrl { get; set; }

    public string? VersionId { get; set; }

    public int? AttachmentSize { get; set; }

    public short? Division { get; set; }
}
