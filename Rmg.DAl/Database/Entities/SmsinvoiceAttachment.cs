using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class SmsinvoiceAttachment
{
    public Guid Id { get; set; }

    public Guid InvoiceHeaderId { get; set; }

    public Guid? AttachmentId { get; set; }

    public Guid? ContractId { get; set; }

    public string? ContractDocType { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }
}
