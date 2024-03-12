using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class CnfsearchTemplate
{
    public Guid Id { get; set; }

    public string SearchCode { get; set; } = null!;

    public string Description { get; set; } = null!;

    public int? DescriptionTermId { get; set; }

    public string SearchTemplatePage { get; set; } = null!;

    public bool? IsStandardTemplate { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }
}
