using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class SocialChatRoom
{
    public Guid Id { get; set; }

    public Guid OwnerId { get; set; }

    public string? Title { get; set; }

    public string? Description { get; set; }

    public short Type { get; set; }

    public string? Metadata { get; set; }

    public string? InvitationToken { get; set; }

    public byte[]? Image { get; set; }
}
