using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class Nlsal
{
    public int Id { get; set; }

    public string? Loonjaar { get; set; }

    public int ResId { get; set; }

    public string? CaoCode { get; set; }

    public string? DagenAanv { get; set; }

    public string? BdrUitk { get; set; }

    public string? Woonland { get; set; }

    public string? NatCode { get; set; }

    public string? AantDagpr { get; set; }

    public string? BdrA { get; set; }

    public string? Orgnr1 { get; set; }

    public string? Isp1 { get; set; }

    public string? Orgnr2 { get; set; }

    public string? Isp2 { get; set; }

    public string? Orgnr3 { get; set; }

    public string? Isp3 { get; set; }

    public string? Orgnr4 { get; set; }

    public string? Isp4 { get; set; }

    public string? BdrB { get; set; }

    public string? Vakbon { get; set; }

    public string? NrSfb { get; set; }

    public string? Bpf { get; set; }

    public string? CdUitz { get; set; }

    public string? AardDv { get; set; }

    public byte VerzAbp { get; set; }

    public string? PrechtZkv { get; set; }

    public string? PrGroep { get; set; }

    public string? CdOverl { get; set; }

    public string? CdSpec { get; set; }

    public string? CdSpcAd1 { get; set; }

    public string? BdSpcAd1 { get; set; }

    public string? CdSpcAd2 { get; set; }

    public string? BdSpcAd2 { get; set; }

    public string? CdSpcAd3 { get; set; }

    public string? BdSpcAd3 { get; set; }

    public double BdrSpcAd1 { get; set; }

    public double BdrSpcAd2 { get; set; }

    public double BdrSpcAd3 { get; set; }

    public byte RegArbeid { get; set; }

    public string? RedWg { get; set; }

    public byte DlnmrVnps { get; set; }

    public byte DlnmrStein { get; set; }

    public byte DlnmrObf { get; set; }

    public byte DlnmrBps { get; set; }

    public string? BvNummer { get; set; }

    public string? PensType { get; set; }

    public double PensWnr { get; set; }

    public double PensWgv { get; set; }

    public string? VutType { get; set; }

    public double VutWnr { get; set; }

    public double VutWgv { get; set; }

    public string? SocfType { get; set; }

    public double SocfWnr { get; set; }

    public double SocfWgv { get; set; }

    public string? WgatType { get; set; }

    public double WgatWnr { get; set; }

    public double WgatWgv { get; set; }

    public byte KaderReg { get; set; }

    public string? Reg35 { get; set; }

    public double PercReg35 { get; set; }

    public byte Thuiswrk { get; set; }

    public double TwrkLb { get; set; }

    public byte Grensarb { get; set; }

    public string? Artiest { get; set; }

    public string? HerlOhTs { get; set; }

    public string? HerlRegel { get; set; }

    public byte OverhJN { get; set; }

    public byte LoonhJN { get; set; }

    public byte Voordeelrg { get; set; }

    public byte SocVerz { get; set; }

    public string? WwJN { get; set; }

    public string? ZwType { get; set; }

    public string? WaoType { get; set; }

    public string? ZfwJN { get; set; }

    public string? CdInkomen { get; set; }

    public string? Targroep1 { get; set; }

    public DateTime? DatTargr1 { get; set; }

    public string? Targroep2 { get; set; }

    public DateTime? DatTargr2 { get; set; }

    public string? Targroep3 { get; set; }

    public DateTime? DatTargr3 { get; set; }

    public string? Tabkleur { get; set; }

    public byte AutoJN { get; set; }

    public string? CdBesch { get; set; }

    public double BdrBesch { get; set; }

    public string? ExtrLhPb { get; set; }

    public double BdrExtlh { get; set; }

    public double UrenDag { get; set; }

    public double DagnWeek { get; set; }

    public double DagnPer { get; set; }

    public string? BetPer { get; set; }

    public byte BerekCum { get; set; }

    public double Salaris { get; set; }

    public double Uurloon { get; set; }

    public string? Brntloon { get; set; }

    public double FisclnVor { get; set; }

    public double OhJrloon { get; set; }

    public double Minloon { get; set; }

    public string? MinlNB { get; set; }

    public double PLhBijz { get; set; }

    public double POhBijz { get; set; }

    public double PVakgeld { get; set; }

    public double RchtVakdg { get; set; }

    public string? VakOpbtyp { get; set; }

    public string? VakUurdag { get; set; }

    public double P13emnd { get; set; }

    public string? AtvOpbtyp { get; set; }

    public double AtvRchtdg { get; set; }

    public string? AtvUurdag { get; set; }

    public double ZiekgldP { get; set; }

    public double ZkPercBv { get; set; }

    public double ZkPercEr { get; set; }

    public string? WachtDgn { get; set; }

    public double AtvP { get; set; }

    public double VakP { get; set; }

    public byte TvtJN { get; set; }

    public double TvtBegin { get; set; }

    public double TvtBij { get; set; }

    public double TvtAf { get; set; }

    public double Hoofdsom { get; set; }

    public double BdrAflos { get; set; }

    public double TotAflos { get; set; }

    public double HisAflos { get; set; }

    public double VschOpgeb { get; set; }

    public double VschBdr { get; set; }

    public double VschUitb { get; set; }

    public double VschStorn { get; set; }

    public string? VolgnrCum { get; set; }

    public string? PerVast { get; set; }

    public string? Pggmdeelnr { get; set; }

    public double BrutoJrln { get; set; }

    public double UrenPweek { get; set; }

    public string? VermLlTyp { get; set; }

    public string? VermLhTyp { get; set; }

    public byte LeerlingNj { get; set; }

    public string? AwwType { get; set; }

    public string? BerCumVip { get; set; }

    public string? VpCaoCd { get; set; }

    public string? TslCode { get; set; }

    public string? VpPrnJn { get; set; }

    public string? VpMldTyp { get; set; }

    public string? VpAardA { get; set; }

    public string? VpAardB { get; set; }

    public DateTime? VpWyzDat { get; set; }

    public string? VpRdUitd { get; set; }

    public byte VpArbOvk { get; set; }

    public string? VpArbTyp { get; set; }

    public string? VpArbRel { get; set; }

    public string? VpWaoPrc { get; set; }

    public string? VpBrpCd { get; set; }

    public string? VpBrpOms { get; set; }

    public string? VpZwGrp { get; set; }

    public string? VpUrnWk { get; set; }

    public string? VpDgnLp { get; set; }

    public byte VpNwtoetr { get; set; }

    public byte VpDispPf { get; set; }

    public byte VpVfJn { get; set; }

    public byte VpRfJn { get; set; }

    public byte VpUtaBrp { get; set; }

    public byte VpVrywJn { get; set; }

    public string? VpTypBp { get; set; }

    public double VpBdrPrc { get; set; }

    public string? VpTypBdr { get; set; }

    public string? VpArbVnr { get; set; }

    public string? VpSrtReg { get; set; }

    public string? VpPensdJn { get; set; }

    public double VpPensdP { get; set; }

    public double VpAfwPfg { get; set; }

    public string? RfOfWw { get; set; }

    public byte VpAvwNj { get; set; }

    public string? VpVpuDisp { get; set; }

    public string? RfEigenRis { get; set; }

    public string? ZfwN { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public string? SlipTekst1 { get; set; }

    public string? SlipTekst2 { get; set; }

    public string? SlipTekst3 { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }

    public Guid Sysguid { get; set; }

    public string? LhkrtCode0 { get; set; }

    public string? LhkrtCode1 { get; set; }

    public string? LhkrtCode2 { get; set; }

    public DateTime? LhkrtLdate0 { get; set; }

    public DateTime? LhkrtLdate1 { get; set; }

    public DateTime? LhkrtLdate2 { get; set; }

    public byte? AanvOudkrt { get; set; }

    public byte? JhdcapNj { get; set; }

    public string? BolType { get; set; }

    public double? BolWnr { get; set; }

    public string? DeclareTypeDesc { get; set; }

    public string? Bankac0 { get; set; }

    public string? Bankac1 { get; set; }

    public string? Bankactype0 { get; set; }

    public string? Bankactype1 { get; set; }

    public string? Bankacdesc0 { get; set; }

    public string? Bankacdesc1 { get; set; }

    public short? Division { get; set; }
}
