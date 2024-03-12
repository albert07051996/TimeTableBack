using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class RequestTypeAction
{
    public int ActionId { get; set; }

    public int AbsenceTypesId { get; set; }

    public string Description { get; set; } = null!;

    public int DescriptionTermId { get; set; }
}
