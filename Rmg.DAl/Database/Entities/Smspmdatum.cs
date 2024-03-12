using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class Smspmdatum
{
    public Guid Id { get; set; }

    public string Status { get; set; } = null!;

    public Guid? RequestId { get; set; }

    public Guid? JobDetailId { get; set; }

    public Guid CustomerId { get; set; }

    public Guid ContractId { get; set; }

    public Guid AddressId { get; set; }

    public Guid? Configuration { get; set; }

    public int? Engineer { get; set; }

    public double? Duration { get; set; }

    public Guid ContractAgreement { get; set; }

    public Guid? ContractLink { get; set; }

    public DateTime? StartDateTime { get; set; }

    public DateTime? EndDateTime { get; set; }

    public int? GroupNo { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }
}
