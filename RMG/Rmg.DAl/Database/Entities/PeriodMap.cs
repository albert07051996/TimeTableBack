using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class PeriodMap
{
    public int ParentGroupId { get; set; }

    public int ParentId { get; set; }

    public int SubGroupId { get; set; }

    public int SubId { get; set; }

    public DateTime Created { get; set; }

    public int Creator { get; set; }

    public DateTime Modified { get; set; }

    public int Modifier { get; set; }
}
