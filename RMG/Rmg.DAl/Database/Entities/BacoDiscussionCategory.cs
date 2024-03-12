using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class BacoDiscussionCategory
{
    public Guid Id { get; set; }

    public int GroupId { get; set; }

    public string Category { get; set; } = null!;

    public short? Division { get; set; }

    public Guid? TemplateId { get; set; }
}
