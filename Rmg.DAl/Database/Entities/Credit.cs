using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class Credit
{
    public int Id { get; set; }

    public string? Crdnr { get; set; }

    public string? Naam { get; set; }

    public string? Adres1 { get; set; }

    public string? Adres2 { get; set; }

    public string? Adres3 { get; set; }

    public string? Postcode { get; set; }

    public string? Woonpl { get; set; }

    public string? Landcode { get; set; }

    public string? Crdzk { get; set; }

    public string? Valcode { get; set; }

    public string? Telnr { get; set; }

    public string? Faxnr { get; set; }

    public string? Cntpers1 { get; set; }

    public string? Mv1 { get; set; }

    public string? Prdcode1 { get; set; }

    public string? Vrlttrs1 { get; set; }

    public string? Functie1 { get; set; }

    public string? Telnrcp1 { get; set; }

    public string? Banknr1 { get; set; }

    public string? Banknr2 { get; set; }

    public string? Pstbanknrc { get; set; }

    public string? Betwijze { get; set; }

    public string? Tegreknr { get; set; }

    public string? Dagbknr { get; set; }

    public int? Crdtext { get; set; }

    public byte Aandacht { get; set; }

    public string? Categorie { get; set; }

    public double Kredlimiet { get; set; }

    public byte Autombet { get; set; }

    public string? Betcond { get; set; }

    public byte? Blokkeer { get; set; }

    public string? Klantcode { get; set; }

    public string? Prijslijst { get; set; }

    public string? ExArtcode { get; set; }

    public double Kortingo { get; set; }

    public string? Layoutcode { get; set; }

    public string? Taalcode { get; set; }

    public double Saldontvwd { get; set; }

    public double Saldontvwc { get; set; }

    public short Blznr { get; set; }

    public double Opensaldo { get; set; }

    public double Bedrbest { get; set; }

    public string? LandIso { get; set; }

    public string? BtwNummer { get; set; }

    public DateTime? Datumctrl { get; set; }

    public byte CategBelg { get; set; }

    public string? Statfactor { get; set; }

    public string? Btwtrans { get; set; }

    public byte WijzBtwt { get; set; }

    public string? Stelsel { get; set; }

    public byte WijzStel { get; set; }

    public string? TransactA { get; set; }

    public byte WijzTrsA { get; set; }

    public string? TransactB { get; set; }

    public byte WijzTrsB { get; set; }

    public string? Landherk { get; set; }

    public byte WijzHerk { get; set; }

    public string? Landoorspr { get; set; }

    public byte WijzOorsp { get; set; }

    public string? Vervoer { get; set; }

    public byte WijzVerv { get; set; }

    public string? PltsLl { get; set; }

    public byte WijzLl { get; set; }

    public string? IntraLvcd { get; set; }

    public byte WijzLevcd { get; set; }

    public string? TrsshpmCd { get; set; }

    public byte WijzTshpm { get; set; }

    public string? Landabc { get; set; }

    public byte WijzAbc { get; set; }

    public string? IntRegio { get; set; }

    public byte WijzRegio { get; set; }

    public short AantBstkp { get; set; }

    public string? Kstplcode { get; set; }

    public byte Bestbev { get; set; }

    public string? CrdAdrnr { get; set; }

    public byte GenietCom { get; set; }

    public string? Voornaam { get; set; }

    public string? Telex { get; set; }

    public string? VerzOp { get; set; }

    public double LimietBdr { get; set; }

    public double MaxwisBdr { get; set; }

    public string? BetZkblwi { get; set; }

    public string? BetZkgcd { get; set; }

    public string? Kostencode { get; set; }

    public string? IcoNummer { get; set; }

    public string? SoortCrd { get; set; }

    public double Percentwka { get; set; }

    public DateTime? SignDatum { get; set; }

    public string? Imocode { get; set; }

    public string? Participant { get; set; }

    public string? Fiscode { get; set; }

    public string? Region { get; set; }

    public byte Erklev { get; set; }

    public string? Email { get; set; }

    public string? Internet { get; set; }

    public string? Freefield1 { get; set; }

    public string? Invname1 { get; set; }

    public string? Freefield2 { get; set; }

    public string? Freefield3 { get; set; }

    public string? Freefield4 { get; set; }

    public string? Freefield5 { get; set; }

    public string? Freefield6 { get; set; }

    public string? Freefield7 { get; set; }

    public string? Freefield8 { get; set; }

    public string? Freefield9 { get; set; }

    public string? Freefield10 { get; set; }

    public double Freefield11 { get; set; }

    public double Freefield12 { get; set; }

    public double Freefield13 { get; set; }

    public double Freefield14 { get; set; }

    public double Freefield15 { get; set; }

    public byte Freefield16 { get; set; }

    public byte Freefield17 { get; set; }

    public byte Freefield18 { get; set; }

    public byte Freefield19 { get; set; }

    public byte Freefield20 { get; set; }

    public string? Status { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }

    public Guid Sysguid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public Guid? DocumentId { get; set; }

    public string? CentrAccount { get; set; }

    public short CompanyType { get; set; }

    public string CompanyCode { get; set; } = null!;
}
