using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class SmsconfigAgreementRegistry
{
    public Guid Id { get; set; }

    public Guid? Configuration { get; set; }

    public Guid? Contract { get; set; }

    public Guid? ContractAgreement { get; set; }

    public Guid? ContractLink { get; set; }

    public bool? Historical { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }
}
