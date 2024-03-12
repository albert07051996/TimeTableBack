using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class SocialChatLine
{
    public Guid Id { get; set; }

    public Guid ChatRoomId { get; set; }

    public Guid CreatorId { get; set; }

    public DateTime CreatedDate { get; set; }

    public string? Text { get; set; }

    public short Status { get; set; }

    public string? Metadata { get; set; }
}
