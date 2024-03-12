using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class WordMergeLog
{
    public Guid Id { get; set; }

    public Guid MailMergePendingId { get; set; }

    public Guid? DocumentId { get; set; }

    public Guid? AttachmentId { get; set; }

    public string? Email { get; set; }

    public int Status { get; set; }

    public DateTime SysCreated { get; set; }
}
