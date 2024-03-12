using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class WebStyle
{
    public Guid Id { get; set; }

    public string? SiteName { get; set; }

    public string? SiteBgcolour { get; set; }

    public string? SiteLayout { get; set; }

    public bool SiteComboBox { get; set; }

    public bool SiteDocSearch { get; set; }

    public Guid? Logo { get; set; }

    public Guid? Bgimage { get; set; }

    public Guid? BgimageTop { get; set; }

    public Guid? BgimageBottom { get; set; }

    public Guid? BgimageTopFrame { get; set; }

    public string? BgcolourTopFrame { get; set; }

    public int WidthLeftFrame { get; set; }

    public byte? IsByHandLeftFrame { get; set; }

    public string? HtmltextLeftFrame { get; set; }

    public string? Htmltext { get; set; }

    public DateTime? ActiveDate { get; set; }

    public byte IsActiveDate { get; set; }

    public byte? IsHideBanner { get; set; }

    public byte? IsMarqueeBanner { get; set; }

    public int MarqueeSpeedBanner { get; set; }

    public string? TextColourBanner { get; set; }

    public string? BgcolourBanner { get; set; }

    public int FrontPageType { get; set; }

    public string? FrontPage { get; set; }

    public int HeightTopFrame { get; set; }

    public byte? IsByHandTopFrame { get; set; }

    public string? HtmltextTopFrame { get; set; }

    public string? AspleftFrame { get; set; }

    public string? AsptopFrame { get; set; }

    public int SetupLeftFrame { get; set; }

    public int SetupTopFrame { get; set; }

    public string? DomainName { get; set; }

    public bool IsEnabled { get; set; }

    public Guid? LeftFrameDocId { get; set; }

    public Guid? TopFrameDocId { get; set; }

    public string? Bedrnr { get; set; }

    public string? SiteTextColour { get; set; }

    public int Wstype { get; set; }

    public string? TbgcolourTopFrame { get; set; }

    public Guid? TbgimageTopFrame { get; set; }

    public string? TabColorTopFrame { get; set; }

    public Guid? Rbgimage { get; set; }

    public string? SiteLanguage { get; set; }

    public string? LeftFontSize { get; set; }

    public string? LeftFontFace { get; set; }

    public string? TextAlignment { get; set; }

    public string? ItemSearchType { get; set; }

    public byte SearchRequest { get; set; }

    public byte SearchItems { get; set; }

    public byte SearchDocuments { get; set; }

    public byte SearchAccounts { get; set; }

    public byte SearchProject { get; set; }

    public string? Classification { get; set; }

    public string? Sector { get; set; }

    public string? MetatagKeyword { get; set; }

    public short? Division { get; set; }

    public byte PortalFormat { get; set; }

    public int? AccountWorkspace { get; set; }

    public byte ShowSearch { get; set; }

    public byte ShowCreate { get; set; }

    public byte ShowModules { get; set; }

    public byte ShowWorkspaceCatalogue { get; set; }

    public byte CanCreateWorkspace { get; set; }

    public byte ShowMenuBar { get; set; }

    public byte ShowMainMenu { get; set; }
}
