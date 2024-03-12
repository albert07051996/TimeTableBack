using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class RequestStatHistory
{
    public int Id { get; set; }

    public DateTime StatDate { get; set; }

    public int? OpenRequests { get; set; }

    public int? WorkflowEntries { get; set; }

    public int? WorkflowResources { get; set; }

    public int? AverageWorkflowEntries { get; set; }

    public int? AverageWorkflowAge { get; set; }

    public short? Division { get; set; }
}
