using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class GroupMember
{
    public Guid Id { get; set; }

    public Guid GroupId { get; set; }

    public bool IsAdmin { get; set; }

    public DateTime DateJoined { get; set; }

    public Guid MemberId { get; set; }
}
