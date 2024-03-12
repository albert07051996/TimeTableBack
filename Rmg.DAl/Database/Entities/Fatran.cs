using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class Fatran
{
    public int Id { get; set; }

    public string? Assetcode { get; set; }

    public string? Assetpartnum { get; set; }

    public string? Valuation { get; set; }

    public string? Tranyear { get; set; }

    public string? Tranper { get; set; }

    public string? Seqnum { get; set; }

    public string? Trantype { get; set; }

    public DateTime? Trandate { get; set; }

    public string? Assetgroup { get; set; }

    public int ResId { get; set; }

    public string? Kstdrcode { get; set; }

    public string? Kstplcode { get; set; }

    public string? Valcode { get; set; }

    public double Exchrate { get; set; }

    public double Tranamt { get; set; }

    public double Tranamtfc { get; set; }

    public double Tranperc { get; set; }

    public string? Olddataval { get; set; }

    public string? Newdataval { get; set; }

    public double Purchamt { get; set; }

    public double Purchamtfc { get; set; }

    public double Purchamtpart { get; set; }

    public double Purchamtpartfc { get; set; }

    public double Bookvalue { get; set; }

    public double Bookvaluefc { get; set; }

    public double Bookvaluepart { get; set; }

    public double Bookvaluepartfc { get; set; }

    public double Revalamt { get; set; }

    public double Revalamtfc { get; set; }

    public double Revalamtpos { get; set; }

    public double Revalamtposfc { get; set; }

    public double Revalamtneg { get; set; }

    public double Revalamtnegfc { get; set; }

    public double Cumreval { get; set; }

    public double Cumrevalfc { get; set; }

    public double Cumrevalpos { get; set; }

    public double Cumrevalposfc { get; set; }

    public double Cumrevalneg { get; set; }

    public double Cumrevalnegfc { get; set; }

    public double Depramt { get; set; }

    public double Depramtfc { get; set; }

    public double Hghrdepramt { get; set; }

    public double Hghrdepramtfc { get; set; }

    public double Lwrdepramt { get; set; }

    public double Lwrdepramtfc { get; set; }

    public double Cumdepramt { get; set; }

    public double Cumdepramtfc { get; set; }

    public double Salvagevalue { get; set; }

    public double Salvagevaluefc { get; set; }

    public string? Disposaltype { get; set; }

    public double Disposalexp { get; set; }

    public double Disposalexpfc { get; set; }

    public double Salesamt { get; set; }

    public double Salesamtfc { get; set; }

    public double Plamount { get; set; }

    public double Plamountfc { get; set; }

    public string? Dagbknr { get; set; }

    public string? Descr50 { get; set; }

    public string? Status { get; set; }

    public string? Jrnper { get; set; }

    public string? Jrnyear { get; set; }

    public double Deprfactor { get; set; }

    public double Deprcalcrate { get; set; }

    public string? Entrynumber { get; set; }

    public string? Fiscalgroup { get; set; }

    public string? Reknr { get; set; }

    public string? Deprmeth { get; set; }

    public short? Division { get; set; }

    public DateTime Syscreated { get; set; }

    public double Depradjamt { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }

    public Guid Sysguid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public double Depradjamtfc { get; set; }

    public string? Artcode { get; set; }
}
