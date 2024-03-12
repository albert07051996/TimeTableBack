using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class ItemAttachmentArchive
{
    public Guid Id { get; set; }

    public string ItemCode { get; set; } = null!;

    public Guid ReleaseId { get; set; }

    public DateTime ArchiveDate { get; set; }

    public int Archiver { get; set; }

    public byte[]? Attachment { get; set; }

    public string? AttachmentFileName { get; set; }

    public DateTime? LastModified { get; set; }

    public string? LastModifier { get; set; }

    public string? FileVersion { get; set; }

    public short? Division { get; set; }
}
