using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class Recipe
{
    public int Id { get; set; }

    public string Itemprod { get; set; } = null!;

    public string Version { get; set; } = null!;

    public int Sequenceno { get; set; }

    public string? Description { get; set; }

    public string? Itemreq { get; set; }

    public string? DescrTxt { get; set; }

    public string? GenLedger { get; set; }

    public double Quantity { get; set; }

    public double CostPrice { get; set; }

    public double Length { get; set; }

    public double Width { get; set; }

    public double Height { get; set; }

    public string? PosNo { get; set; }

    public string? UsageMeth { get; set; }

    public string? Costcenter { get; set; }

    public int ResId { get; set; }

    public string? Assetgroup { get; set; }

    public string? Assetcode { get; set; }

    public string? Companycode { get; set; }

    public Guid? Docguid { get; set; }

    public string? LineType { get; set; }

    public double ManCostpr { get; set; }

    public double CalCostpr { get; set; }

    public double Salesprice { get; set; }

    public string? Debtor { get; set; }

    public string? Supplier { get; set; }

    public string? Variant { get; set; }

    public double VarQuantity { get; set; }

    public string? Drawingno { get; set; }

    public string? Activityno { get; set; }

    public string? Activity { get; set; }

    public DateTime? EffDate { get; set; }

    public DateTime? ExpDate { get; set; }

    public Guid? NotesId { get; set; }

    public double Freefield1 { get; set; }

    public double Freefield2 { get; set; }

    public double Freefield3 { get; set; }

    public string? Freefield4 { get; set; }

    public string? Freefield5 { get; set; }

    public string? Freefield6 { get; set; }

    public string? Freefield7 { get; set; }

    public string? Freefield8 { get; set; }

    public string? Freefield9 { get; set; }

    public string? Freefield10 { get; set; }

    public DateTime? Freefield11 { get; set; }

    public DateTime? Freefield12 { get; set; }

    public double Freefield13 { get; set; }

    public double Freefield14 { get; set; }

    public double Freefield15 { get; set; }

    public byte Freefield16 { get; set; }

    public byte Freefield17 { get; set; }

    public byte Freefield18 { get; set; }

    public byte Freefield19 { get; set; }

    public byte Freefield20 { get; set; }

    public byte? MainVersion { get; set; }

    public string? Warehouse { get; set; }

    public byte Backflush { get; set; }

    public int? Step { get; set; }

    public int? DocumentId { get; set; }

    public short? Division { get; set; }

    public string? Unit { get; set; }

    public double? ConversionFactor { get; set; }

    public string? Operation { get; set; }

    public string? Routing { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }

    public Guid Sysguid { get; set; }

    public byte[] Timestamp { get; set; } = null!;
}
