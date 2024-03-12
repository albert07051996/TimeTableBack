using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class RequestTypeStatus
{
    public int StatusId { get; set; }

    public int AbsenceTypesId { get; set; }

    public string Description { get; set; } = null!;

    public int DescriptionTermId { get; set; }

    public short? OrderId { get; set; }
}
