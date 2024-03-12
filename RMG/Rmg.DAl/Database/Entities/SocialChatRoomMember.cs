using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class SocialChatRoomMember
{
    public Guid Id { get; set; }

    public Guid ChatRoomId { get; set; }

    public Guid MemberId { get; set; }

    public short Type { get; set; }

    public DateTime DateJoined { get; set; }
}
