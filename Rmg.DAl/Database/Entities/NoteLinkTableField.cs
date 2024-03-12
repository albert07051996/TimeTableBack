using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class NoteLinkTableField
{
    public string SourceTable { get; set; } = null!;

    public string DiscussionColumn { get; set; } = null!;

    public short? Division { get; set; }
}
