using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class SearchHistory
{
    public Guid Id { get; set; }

    public int ResourceId { get; set; }

    public string Entity { get; set; } = null!;

    public string SearchValue { get; set; } = null!;

    public DateTime LastSearched { get; set; }
}
