using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class SmsresourceGroupMember
{
    public Guid Id { get; set; }

    public Guid GroupId { get; set; }

    public int GroupMemberId { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }

    public int? LineNumber { get; set; }
}
