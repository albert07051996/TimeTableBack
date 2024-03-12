using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class Cnfentity
{
    public Guid Id { get; set; }

    public string ConfigurationCode { get; set; } = null!;

    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public int? NameTermId { get; set; }

    public string PluralName { get; set; } = null!;

    public int? PluralNameTermId { get; set; }

    public bool? ShowOnSidebar { get; set; }

    public int? SearchLinkId { get; set; }

    public string? InheritsEntity { get; set; }

    public string? ExtendsEntity { get; set; }

    public bool? HasTypes { get; set; }

    public bool? HasStates { get; set; }

    public bool? HasMembers { get; set; }

    public bool? HasChildren { get; set; }

    public bool? HasNewButton { get; set; }

    public bool? EnableWebService { get; set; }

    public bool? EnableLogActions { get; set; }

    public int? SecurityLevel { get; set; }

    public int? FunctionRight { get; set; }

    public string? Icon { get; set; }

    public byte[]? IconImage { get; set; }

    public string? AssociatedBc { get; set; }

    public string? AssociatedSqltable { get; set; }

    public string? AssociatedFc { get; set; }

    public string? AssociatedBrowser { get; set; }

    public bool? IsDisabled { get; set; }

    public bool? IsDeployed { get; set; }

    public bool IsGenerated { get; set; }

    public string? KeyProperty { get; set; }

    public string? KeyDescription { get; set; }

    public string? InitialState { get; set; }

    public bool? ExposeWebService { get; set; }

    public int? Status { get; set; }

    public bool? SupportAttachment { get; set; }

    public int? GeneratedSecurityLevel { get; set; }

    public int? GeneratedFunctionRight { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }
}
