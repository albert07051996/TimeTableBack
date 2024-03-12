using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class SmscontractTemplateAgrSet
{
    public Guid Id { get; set; }

    public int? LineOrder { get; set; }

    public Guid? ContractTemplate { get; set; }

    public Guid? AgreementSet { get; set; }

    public Guid? Parent { get; set; }

    public Guid? AgrSetLineId { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }
}
