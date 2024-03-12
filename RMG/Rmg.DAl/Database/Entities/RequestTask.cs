using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class RequestTask
{
    public Guid Id { get; set; }

    public Guid RequestId { get; set; }

    public int EmpId { get; set; }

    public int Action { get; set; }

    public bool Private { get; set; }

    public int MainType { get; set; }

    public int Type { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime? DueDate { get; set; }

    public DateTime Created { get; set; }

    public short WorkflowOrigin { get; set; }

    public short WorkflowReason { get; set; }

    public int? RoleId { get; set; }

    public int? RoleLevel { get; set; }

    public int? OwnershipAssignedBy { get; set; }

    public bool WorkflowRead { get; set; }

    public short? Division { get; set; }
}
