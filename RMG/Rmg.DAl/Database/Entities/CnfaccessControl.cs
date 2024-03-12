using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class CnfaccessControl
{
    public Guid Id { get; set; }

    public string? EntityCode { get; set; }

    public string? TypeCode { get; set; }

    public string? StatusCode { get; set; }

    public string? PropertyCode { get; set; }

    public string? ActionCode { get; set; }

    public string? ControlCode { get; set; }

    public byte[] AccessControl { get; set; } = null!;

    public bool? Mandatory { get; set; }

    public bool? HideLabel { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }
}
