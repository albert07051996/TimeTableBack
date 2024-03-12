using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class SmspmbatchLog
{
    public Guid Id { get; set; }

    public int? Batch { get; set; }

    public int? Delegate { get; set; }

    public DateTime? PlanUntil { get; set; }

    public short? GenerateBy { get; set; }

    public int? RequestType { get; set; }

    public Guid? Assortment { get; set; }

    public Guid? Item { get; set; }

    public string? ItemCode { get; set; }

    public byte? ItemCodeToggle { get; set; }

    public string? ItemDescription { get; set; }

    public byte? ItemDescriptionToggle { get; set; }

    public string? SerialNumberStart { get; set; }

    public string? SerialNumberEnd { get; set; }

    public string? SerialNumberDescription { get; set; }

    public byte? SerialNumberDescriptionToggle { get; set; }

    public string? SnUserField01 { get; set; }

    public byte? SnUserField01Toggle { get; set; }

    public string? SnUserField02 { get; set; }

    public byte? SnUserField02Toggle { get; set; }

    public string? SnUserField03 { get; set; }

    public byte? SnUserField03Toggle { get; set; }

    public string? SnUserField04 { get; set; }

    public byte? SnUserField04Toggle { get; set; }

    public string? SnUserField05 { get; set; }

    public byte? SnUserField05Toggle { get; set; }

    public string? SnUserField06 { get; set; }

    public byte? SnUserField06Toggle { get; set; }

    public string? SnUserField07 { get; set; }

    public byte? SnUserField07Toggle { get; set; }

    public string? SnUserField08 { get; set; }

    public byte? SnUserField08Toggle { get; set; }

    public string? SnUserField09 { get; set; }

    public byte? SnUserField09Toggle { get; set; }

    public string? SnUserField10 { get; set; }

    public byte? SnUserField10Toggle { get; set; }

    public DateTime? SnUserDate01Start { get; set; }

    public DateTime? SnUserDate01End { get; set; }

    public DateTime? SnUserDate02Start { get; set; }

    public DateTime? SnUserDate02End { get; set; }

    public DateTime? SnUserDate03Start { get; set; }

    public DateTime? SnUserDate03End { get; set; }

    public DateTime? SnUserDate04Start { get; set; }

    public DateTime? SnUserDate04End { get; set; }

    public DateTime? SnUserDate05Start { get; set; }

    public DateTime? SnUserDate05End { get; set; }

    public double? SnUserNumber01Start { get; set; }

    public double? SnUserNumber01End { get; set; }

    public double? SnUserNumber02Start { get; set; }

    public double? SnUserNumber02End { get; set; }

    public double? SnUserNumber03Start { get; set; }

    public double? SnUserNumber03End { get; set; }

    public double? SnUserNumber04Start { get; set; }

    public double? SnUserNumber04End { get; set; }

    public double? SnUserNumber05Start { get; set; }

    public double? SnUserNumber05End { get; set; }

    public bool? SnUserYesNo01 { get; set; }

    public bool? SnUserYesNo02 { get; set; }

    public bool? SnUserYesNo03 { get; set; }

    public bool? SnUserYesNo04 { get; set; }

    public bool? SnUserYesNo05 { get; set; }

    public string? ContractAccountStart { get; set; }

    public string? ContractAccountEnd { get; set; }

    public string? ContractNumberStart { get; set; }

    public string? ContractNumberEnd { get; set; }

    public Guid? ContractType { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }
}
