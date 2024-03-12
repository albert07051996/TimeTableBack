using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class HrmformLayout
{
    public Guid Id { get; set; }

    public string? Type { get; set; }

    public string? Description { get; set; }

    public string? CompanyCode { get; set; }

    public short? Division { get; set; }

    public int? Assortment { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedDate { get; set; }

    public int ModifiedBy { get; set; }

    public DateTime ModifiedDate { get; set; }
}
