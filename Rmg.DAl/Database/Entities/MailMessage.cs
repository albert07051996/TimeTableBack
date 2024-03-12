using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class MailMessage
{
    public Guid Id { get; set; }

    public Guid DocumentId { get; set; }

    public string? Version { get; set; }

    public string? Subject { get; set; }

    public string? MailFrom { get; set; }

    public string? MailTo { get; set; }

    public string? Cc { get; set; }

    public string? OnBehalf { get; set; }

    public DateTime? SentOn { get; set; }

    public string? ConversationIndex { get; set; }

    public Guid? ConversationId { get; set; }
}
