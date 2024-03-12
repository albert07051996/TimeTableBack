using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class WordMergeAuthorization
{
    public Guid Id { get; set; }

    public Guid ItemId { get; set; }

    public int RoleId { get; set; }

    public int RoleLevel { get; set; }

    public int? Division { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }
}
