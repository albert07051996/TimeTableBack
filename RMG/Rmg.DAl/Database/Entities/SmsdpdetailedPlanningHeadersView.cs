using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class SmsdpdetailedPlanningHeadersView
{
    public int ResourceId { get; set; }

    public DateTime? EndDate { get; set; }

    public DateTime? HeaderEndDate { get; set; }

    public string UserName { get; set; } = null!;

    public string FullName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string MiddleName { get; set; } = null!;

    public string Initials { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public string PhoneExtension { get; set; } = null!;

    public string MobilePhone { get; set; } = null!;

    public string MobileExtension { get; set; } = null!;

    public string Fax { get; set; } = null!;

    public string JobTitle { get; set; } = null!;

    public string CostUnit { get; set; } = null!;

    public string Title { get; set; } = null!;

    public string CostCenter { get; set; } = null!;

    public string Manager { get; set; } = null!;

    public string Assistant { get; set; } = null!;

    public string Group { get; set; } = null!;

    public string Division { get; set; } = null!;

    public string JobGroup { get; set; } = null!;

    public string JobActivity { get; set; } = null!;

    public Guid? AbsenceId { get; set; }
}
