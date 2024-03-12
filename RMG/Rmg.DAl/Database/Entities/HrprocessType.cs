using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class HrprocessType
{
    public int Id { get; set; }

    public string Description { get; set; } = null!;

    public int ProcessType { get; set; }

    public int? RequestType { get; set; }

    public string? TableName { get; set; }

    public string? FieldName { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public bool AutoGenerate { get; set; }

    public bool Active { get; set; }

    public bool Blocked { get; set; }

    public int? SecurityLevel { get; set; }

    public int? RightsManager { get; set; }

    public int? CreateRole1 { get; set; }

    public int? CreateRoleLevel1 { get; set; }

    public int? CreateRole2 { get; set; }

    public int? CreateRoleLevel2 { get; set; }

    public int? CreateRole3 { get; set; }

    public int? CreateRoleLevel3 { get; set; }

    public int? ProcessManager { get; set; }

    public int? ProcessRole1 { get; set; }

    public int? ProcessRoleLevel1 { get; set; }

    public int? ProcessRole2 { get; set; }

    public int? ProcessRoleLevel2 { get; set; }

    public int? ProcessRole3 { get; set; }

    public int? ProcessRoleLevel3 { get; set; }

    public string? CompanyCode { get; set; }

    public short? Division { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }

    public byte[] Timestamp { get; set; } = null!;
}
