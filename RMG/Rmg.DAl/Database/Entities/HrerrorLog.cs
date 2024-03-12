using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class HrerrorLog
{
    public Guid Id { get; set; }

    public Guid TransId { get; set; }

    public string? TransType { get; set; }

    public string? Value1 { get; set; }

    public string? Value2 { get; set; }

    public string? Value3 { get; set; }

    public string? AppName { get; set; }

    public string? Description { get; set; }

    public string? Comp { get; set; }

    public int? Status { get; set; }

    public short? Division { get; set; }

    public DateTime Created { get; set; }

    public int Creator { get; set; }
}
