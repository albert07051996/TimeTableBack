using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class WebContent
{
    public Guid Id { get; set; }

    public Guid? WebStyleId { get; set; }

    public string? WebFrameType { get; set; }

    public string? WebFrameObject { get; set; }

    public int OrderNr { get; set; }

    public string? WebText { get; set; }

    public string? WebHlink { get; set; }

    public int WebSize { get; set; }

    public string? WebInputLink { get; set; }

    public int WebLinkType { get; set; }

    public string? WebTarget { get; set; }

    public string? Htmltext { get; set; }

    public Guid? ContentImage { get; set; }

    public Guid? TabImage { get; set; }

    public string? TabColor { get; set; }

    public string? TextColor { get; set; }

    public string? TextFontSize { get; set; }

    public string? TextFontFace { get; set; }

    public string? TabSelectedColor { get; set; }

    public Guid? SelectButtonImage { get; set; }

    public string? LinkFontSize { get; set; }

    public string? LinkFontFace { get; set; }

    public string? LinkAlignment { get; set; }

    public string? LeftLinkColor { get; set; }

    public short? Division { get; set; }
}
