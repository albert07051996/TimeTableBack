using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class TagIndividualWeight
{
    public int Id { get; set; }

    public int WordId { get; set; }

    public Guid Entity { get; set; }

    public int? TagsCount { get; set; }

    public int? Score { get; set; }
}
