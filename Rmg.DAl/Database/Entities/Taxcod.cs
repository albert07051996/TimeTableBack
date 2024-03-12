using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class Taxcod
{
    public int Id { get; set; }

    public string? Country { get; set; }

    public string? Taxtype { get; set; }

    public string? Taxcode { get; set; }

    public string? Descr400 { get; set; }

    public string? Descr401 { get; set; }

    public string? Descr402 { get; set; }

    public string? Descr403 { get; set; }

    public string? Descr404 { get; set; }

    public string? Invoicetype { get; set; }

    public string? Origdest { get; set; }

    public string? Dateregister { get; set; }

    public double Percentage { get; set; }

    public double Percnonded { get; set; }

    public byte Varpercentage { get; set; }

    public byte Varpercnonded { get; set; }

    public double Amount { get; set; }

    public string? Curamount { get; set; }

    public byte Taxcharged { get; set; }

    public byte Taxcorrection { get; set; }

    public byte Taxexempt { get; set; }

    public byte Withholding { get; set; }

    public string? Invoiceuse { get; set; }

    public string? Glreceivable { get; set; }

    public string? Glpayable { get; set; }

    public string? Glsreceivable { get; set; }

    public string? Glspayable { get; set; }

    public string? Inclexcl { get; set; }

    public int SeqNr { get; set; }

    public byte Vat { get; set; }

    public string? Returnbox { get; set; }

    public string? Glextra1 { get; set; }

    public string? Glextra2 { get; set; }

    public string? Glextra3 { get; set; }

    public string? Freefield1 { get; set; }

    public string? Freefield2 { get; set; }

    public string? Freefield3 { get; set; }

    public string? Freefield4 { get; set; }

    public string? Freefield5 { get; set; }

    public string? Freefield6 { get; set; }

    public string? Freefield7 { get; set; }

    public double Freefield8 { get; set; }

    public double Freefield9 { get; set; }

    public double Freefield10 { get; set; }

    public double Freefield11 { get; set; }

    public double Freefield12 { get; set; }

    public double Freefield13 { get; set; }

    public DateTime? Freefield14 { get; set; }

    public DateTime? Freefield15 { get; set; }

    public DateTime? Freefield16 { get; set; }

    public byte Freefield17 { get; set; }

    public byte Freefield18 { get; set; }

    public byte Freefield19 { get; set; }

    public byte Freefield20 { get; set; }

    public DateTime Syscreated { get; set; }

    public byte Active { get; set; }

    public short? Division { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }

    public Guid Sysguid { get; set; }

    public byte[] Timestamp { get; set; } = null!;
}
