using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class Address
{
    public Guid Id { get; set; }

    public int Idcol { get; set; }

    public string Type { get; set; } = null!;

    public Guid Account { get; set; }

    public Guid ContactPerson { get; set; }

    public string? AddressLine1 { get; set; }

    public string? AddressLine2 { get; set; }

    public string? AddressLine3 { get; set; }

    public string? PostCode { get; set; }

    public string? City { get; set; }

    public string? StateCode { get; set; }

    public string? County { get; set; }

    public string? Country { get; set; }

    public string? Phone { get; set; }

    public string? Fax { get; set; }

    public string? Notes { get; set; }

    public bool? KeepSameAsVisit { get; set; }

    public DateTime? Datefield1 { get; set; }

    public DateTime? Datefield2 { get; set; }

    public DateTime? Datefield3 { get; set; }

    public DateTime? Datefield4 { get; set; }

    public DateTime? Datefield5 { get; set; }

    public double Numberfield1 { get; set; }

    public double Numberfield2 { get; set; }

    public double Numberfield3 { get; set; }

    public double Numberfield4 { get; set; }

    public double Numberfield5 { get; set; }

    public byte YesNofield1 { get; set; }

    public byte YesNofield2 { get; set; }

    public byte YesNofield3 { get; set; }

    public byte YesNofield4 { get; set; }

    public byte YesNofield5 { get; set; }

    public string? Textfield1 { get; set; }

    public string? Textfield2 { get; set; }

    public string? Textfield3 { get; set; }

    public string? Textfield4 { get; set; }

    public string? Textfield5 { get; set; }

    public bool? CustomerReq { get; set; }

    public string? PoNumber { get; set; }

    public int? InvoiceType { get; set; }

    public double? DamageWaiver { get; set; }

    public int? InvoiceFrequency { get; set; }

    public byte Main { get; set; }

    public string? AddressCode { get; set; }

    public int? SalesPersonNumber { get; set; }

    public string? ShipVia { get; set; }

    public string? Upszone { get; set; }

    public byte? IsTaxable { get; set; }

    public string? TaxCode { get; set; }

    public string? TaxCode2 { get; set; }

    public string? TaxCode3 { get; set; }

    public string? TaxSchedule { get; set; }

    public string? Warehouse { get; set; }

    public string? Fobcode { get; set; }

    public string? EdiStoreId { get; set; }

    public string? EdiDcid { get; set; }

    public string? EdiStoreName { get; set; }

    public short? Division { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public double? Longitude { get; set; }

    public double? Latitude { get; set; }
}
