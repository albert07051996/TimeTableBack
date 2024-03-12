using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class RequestFieldOption
{
    public Guid Id { get; set; }

    public int RequestType { get; set; }

    public int FieldId { get; set; }

    public int Position { get; set; }

    public int Columns { get; set; }

    public bool Front { get; set; }

    public string? Caption { get; set; }

    public int? CaptionTermId { get; set; }

    public int TextColor { get; set; }

    public short FontSize { get; set; }

    public short Style { get; set; }

    public bool VisibleNew { get; set; }

    public bool VisibleOpen { get; set; }

    public bool VisibleApproved { get; set; }

    public bool VisibleRealized { get; set; }

    public bool VisibleProcessed { get; set; }

    public bool EditOpen { get; set; }

    public bool EditApproved { get; set; }

    public bool EditRealized { get; set; }

    public bool EditProcessed { get; set; }

    public short EditOption1 { get; set; }

    public short EditOption2 { get; set; }

    public short EditOption3 { get; set; }

    public bool MandatoryOpen { get; set; }

    public bool MandatoryApproved { get; set; }

    public bool MandatoryRealized { get; set; }

    public bool MandatoryProcessed { get; set; }

    public string? DefaultString { get; set; }

    public int? DefaultInt { get; set; }

    public DateTime? DefaultDate { get; set; }

    public double? DefaultDouble { get; set; }

    public Guid? DefaultGuid { get; set; }

    public short DefaultOption { get; set; }

    public string? Selection { get; set; }

    public short SelectionOption1 { get; set; }

    public short SelectionOption2 { get; set; }

    public short SelectionOption3 { get; set; }

    public short SelectionOption4 { get; set; }

    public short SelectionOption5 { get; set; }

    public short WorkflowOption1 { get; set; }

    public short WorkflowOption2 { get; set; }

    public short WorkflowOption3 { get; set; }

    public bool ManualEntry { get; set; }

    public bool Calculate { get; set; }

    public short CalculateOption1 { get; set; }

    public short CalculateOption2 { get; set; }

    public short CalculateOption3 { get; set; }

    public short DisplayType { get; set; }

    public int? RefType { get; set; }

    public string? SelectionValues { get; set; }

    public int? CalculateField1 { get; set; }

    public int? CalculateField2 { get; set; }

    public byte? CalculateOperator { get; set; }

    public short UseScheduleMethod { get; set; }

    public int TextColor2 { get; set; }

    public bool IsLeadingAccount { get; set; }

    public bool IsLeadingItem1 { get; set; }

    public bool IsLeadingItem2 { get; set; }

    public bool IsLeadingProject { get; set; }

    public bool IsLeadingResource { get; set; }

    public bool IsLeadingSerialNumber1 { get; set; }

    public bool IsLeadingSerialNumber2 { get; set; }

    public bool? ShowSectionAsTab { get; set; }

    public bool VisibleRejected { get; set; }

    public bool EditRejected { get; set; }

    public bool MandatoryRejected { get; set; }

    public short? Division { get; set; }

    public byte? SectionType { get; set; }

    public int? SectionHeight { get; set; }

    public string? SectionBrowserInfo { get; set; }
}
