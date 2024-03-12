using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class BacoSearchTemplate
{
    public Guid Id { get; set; }

    public string SearchCode { get; set; } = null!;

    public int ResourceId { get; set; }

    public string Description { get; set; } = null!;

    public DateTime? Created { get; set; }

    public int Creator { get; set; }

    public short? Division { get; set; }
}
