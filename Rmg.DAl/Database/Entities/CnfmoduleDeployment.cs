using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class CnfmoduleDeployment
{
    public Guid Id { get; set; }

    public int ModuleId { get; set; }

    public int? RequestTypeId { get; set; }

    public int? RuleId { get; set; }

    public int? CategoryId { get; set; }

    public int? RoleId { get; set; }

    public int? DocumentTypeId { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }
}
