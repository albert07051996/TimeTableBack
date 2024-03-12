using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class PersonalDataReqMgt
{
    public int Id { get; set; }

    public int ClassificationId { get; set; }

    public int? ReqTypeId { get; set; }

    public short? Division { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }
}
