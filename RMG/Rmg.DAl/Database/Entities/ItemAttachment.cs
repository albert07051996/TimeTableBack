using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class ItemAttachment
{
    public string ItemCode { get; set; } = null!;

    public Guid ReleaseId { get; set; }

    public byte[]? Attachment { get; set; }

    public string? AttachmentFilename { get; set; }

    public DateTime? AttachmentDateTime { get; set; }

    public byte[]? CompressedAttachment { get; set; }

    public string? FileVersion { get; set; }

    public DateTime? CheckedOut { get; set; }

    public int? CheckedOutBy { get; set; }

    public DateTime? LastModified { get; set; }

    public string? LastModifier { get; set; }

    public int? Owner { get; set; }

    public int? AttachmentSize { get; set; }

    public int? AttachmentCompressedSize { get; set; }

    public short? Division { get; set; }
}
