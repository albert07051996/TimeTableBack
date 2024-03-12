using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class BacoDiscussionVersion
{
    public Guid Id { get; set; }

    public int Hid { get; set; }

    public Guid DocumentId { get; set; }

    public string Version { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime ModifiedDate { get; set; }

    public string Subject { get; set; } = null!;

    public string? Body { get; set; }

    public string? Filename { get; set; }

    public byte[]? Attachment { get; set; }

    public int Status { get; set; }

    public string? StatusText { get; set; }

    public string? FpintroText { get; set; }

    public DateTime? StartDate { get; set; }

    public string? VersionNote { get; set; }

    public DateTime? CheckedOut { get; set; }

    public int? CheckedOutBy { get; set; }

    public short? Division { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public byte[]? CompressBody { get; set; }
}
