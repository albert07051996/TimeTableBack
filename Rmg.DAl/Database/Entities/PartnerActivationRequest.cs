using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class PartnerActivationRequest
{
    public Guid ActrequestId { get; set; }

    public int ActrequestCode { get; set; }

    public Guid ActivationId { get; set; }

    public Guid RequestId { get; set; }

    public int HumresId { get; set; }

    public string? DbServer { get; set; }

    public string? DbName { get; set; }

    public short ReqStatus { get; set; }

    public short TotalLog { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime? Sysmodified { get; set; }

    public int? Sysmodifier { get; set; }
}
