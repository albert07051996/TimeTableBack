using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class PayrollPlusEmployerCost
{
    public int Id { get; set; }

    public short Code { get; set; }

    public string? Description { get; set; }

    public int TermId { get; set; }
}
