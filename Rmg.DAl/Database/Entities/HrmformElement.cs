using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class HrmformElement
{
    public Guid Id { get; set; }

    public Guid? FormLayoutId { get; set; }

    public Guid? ParentElementId { get; set; }

    public string? Reference { get; set; }

    public short SequenceNumber { get; set; }

    public bool ViewResource { get; set; }

    public bool ViewManager { get; set; }

    public int ViewFunction { get; set; }

    public int ViewSecurityLevel { get; set; }

    public bool EditResource { get; set; }

    public bool EditManager { get; set; }

    public int EditFunction { get; set; }

    public int EditSecurityLevel { get; set; }

    public int TermId { get; set; }

    public string? Caption { get; set; }

    public string? UserDefineCaption { get; set; }

    public byte ColumnCount { get; set; }

    public bool IsRadioSet { get; set; }

    public bool IsGroup { get; set; }

    public bool ShowKeyInCombo { get; set; }

    public bool AddEmptyValue { get; set; }

    public byte Mandatory { get; set; }

    public short? Division { get; set; }

    public bool Deselect { get; set; }

    public bool EffectiveDateLog { get; set; }

    public bool RequireAuthorize { get; set; }

    public int? AutoAuthorizeRole { get; set; }

    public int? AutoAuthorizeRoleLevel { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedDate { get; set; }

    public int ModifiedBy { get; set; }

    public DateTime ModifiedDate { get; set; }
}
