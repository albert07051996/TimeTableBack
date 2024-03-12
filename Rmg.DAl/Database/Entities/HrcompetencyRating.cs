using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class HrcompetencyRating
{
    public Guid? Id { get; set; }

    public int EmpId { get; set; }

    public DateTime ReferenceDate { get; set; }

    public int CompetencyId { get; set; }

    public string? Rating { get; set; }

    public short? Division { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }
}
