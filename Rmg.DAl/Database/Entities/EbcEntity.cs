using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class EbcEntity
{
    public Guid EntityId { get; set; }

    public int GroupId { get; set; }

    public string EntityName { get; set; } = null!;

    public string? Description { get; set; }

    public int? TermId { get; set; }

    public Guid HeaderCompId { get; set; }

    public Guid? LineCompId { get; set; }
}
