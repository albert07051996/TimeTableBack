using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class BacoDiscussionNewsLayout
{
    public string BdlayoutId { get; set; } = null!;

    public string? Description { get; set; }

    public string? HeaderPage { get; set; }

    public string? FooterPage { get; set; }

    public string? DefaultImage { get; set; }

    public bool Headlines { get; set; }

    public string? HlbackGround { get; set; }

    public string? Condition { get; set; }

    public short MaxNews { get; set; }

    public short MaxHeadlines { get; set; }

    public string? TextHeader { get; set; }

    public string? TextFooter { get; set; }

    public byte Enabled { get; set; }

    public byte UseSelectionCombo { get; set; }

    public Guid? ImageDefault { get; set; }

    public Guid? ImageHlbackground { get; set; }

    public byte LayoutType { get; set; }

    public Guid? EditorialDocId { get; set; }

    public Guid? HeaderDocId { get; set; }

    public Guid? FooterDocId { get; set; }

    public string? Bedrnr { get; set; }

    public string? ConditionDivision { get; set; }

    public string? ConditionLanguage { get; set; }

    public string? ConditionJobLevelOperator { get; set; }

    public int? ConditionJobLevelValue { get; set; }

    public byte OrDivisionUse { get; set; }

    public byte OrCountryUse { get; set; }

    public byte OrDivisionGroupUse { get; set; }

    public bool HeadlineImage { get; set; }

    public short? Division { get; set; }
}
