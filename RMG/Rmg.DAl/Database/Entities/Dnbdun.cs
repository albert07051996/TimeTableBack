using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class Dnbdun
{
    public int Id { get; set; }

    public string DunsNbr { get; set; } = null!;

    public string Package { get; set; } = null!;

    public Guid? CmpWwn { get; set; }

    public double ActPay { get; set; }

    public double ActRec { get; set; }

    public string? AdrLine { get; set; }

    public string? AdrTenrTypeCd { get; set; }

    public string? AudtInd { get; set; }

    public string? AudtQlfnInd { get; set; }

    public double AvgHighCr { get; set; }

    public string? BrInd { get; set; }

    public string? BusRegnNbr { get; set; }

    public string? BusRegnNbrTypeCd { get; set; }

    public string? BusStru { get; set; }

    public double CaplAmt { get; set; }

    public string? CaplCrcyCd { get; set; }

    public string? CaplTypeCd { get; set; }

    public double CashLiqAset { get; set; }

    public string? CeoNme { get; set; }

    public string? CeoTitl { get; set; }

    public string? ClmInd { get; set; }

    public double CnglDistCd { get; set; }

    public string? ConsInd { get; set; }

    public double CostOfSls { get; set; }

    public short CrScr { get; set; }

    public string? CrScrCmty { get; set; }

    public string? CrcyCd { get; set; }

    public string? CrimInd { get; set; }

    public string? CtryCd { get; set; }

    public short CurrCntlYr { get; set; }

    public double CurrRato { get; set; }

    public string? DavdInd { get; set; }

    public int DbarCnt { get; set; }

    public DateTime? DbarDt { get; set; }

    public double Divd { get; set; }

    public string? DnbRatg { get; set; }

    public string? DomUltCtryCd { get; set; }

    public string? DomUltPntDuns { get; set; }

    public string? DomUltPntNme { get; set; }

    public string? DstrInd { get; set; }

    public string? EmplAtPrimAdr { get; set; }

    public string? EmplAtPrimAdrEstdInd { get; set; }

    public string? EmplAtPrimAdrText { get; set; }

    public string? EmplAtPrimAdrMinInd { get; set; }

    public string? EnqDuns { get; set; }

    public string? EstdInd { get; set; }

    public string? ExptInd { get; set; }

    public short FailScr { get; set; }

    public string? FailScrCmty { get; set; }

    public byte FailScrNatlPctg { get; set; }

    public string? FailScrOvrdCd { get; set; }

    public string? FaxNbr { get; set; }

    public string? FcstInd { get; set; }

    public string? FinlEmbtInd { get; set; }

    public string? FinlLglEvntInd { get; set; }

    public string? FiscInd { get; set; }

    public double FixdAset { get; set; }

    public string? FnalInd { get; set; }

    public string? GblUltCtryCd { get; set; }

    public string? GblUltPntDuns { get; set; }

    public string? GblUltPntNme { get; set; }

    public int GlblFailScr { get; set; }

    public double GrosIncm { get; set; }

    public double HighCr { get; set; }

    public string? HistInd { get; set; }

    public string? HqCtryCd { get; set; }

    public string? HqDuns { get; set; }

    public string? HqNme { get; set; }

    public string? ImptInd { get; set; }

    public DateTime? IncmStmtDt { get; set; }

    public short IncnYr { get; set; }

    public double IntlDlngCd { get; set; }

    public double ItngAset { get; set; }

    public string? LbrSplsAreaInd { get; set; }

    public string? LclActvCd { get; set; }

    public string? LclActvCdType { get; set; }

    public string? LglForm { get; set; }

    public string? LocnStat { get; set; }

    public double LtDbt { get; set; }

    public double MaxCr { get; set; }

    public string? MaxCrCrcyCd { get; set; }

    public string? MinyOwndInd { get; set; }

    public double NetIncm { get; set; }

    public double NetWrth { get; set; }

    public string? NonPostTown { get; set; }

    public string? OpenInd { get; set; }

    public string? OprgSpecEvntInd { get; set; }

    public string? OthrSpecEvntInd { get; set; }

    public string? OutBusInd { get; set; }

    public double Payd3MoAgo { get; set; }

    public double PaydNorm { get; set; }

    public short PaydScr { get; set; }

    public double PftBefTax { get; set; }

    public string? PntCtryCd { get; set; }

    public string? PntDuns { get; set; }

    public string? PntNme { get; set; }

    public string? PostCode { get; set; }

    public string? PostTown { get; set; }

    public double PrevNetWrth { get; set; }

    public double PrevSls { get; set; }

    public DateTime? PrevStmtDt { get; set; }

    public double PrevWrkgCapl { get; set; }

    public string? PrimGeoArea { get; set; }

    public string? PrimNme { get; set; }

    public string? PrimSic { get; set; }

    public string? PrimSicTypeCd { get; set; }

    public string? PrinNme { get; set; }

    public string? PrinTtl { get; set; }

    public string? ProFrmaInd { get; set; }

    public double QkRato { get; set; }

    public string? RegnType { get; set; }

    public string? RestInd { get; set; }

    public double RetnErng { get; set; }

    public string? ScdyGeoArea { get; set; }

    public string? ScrdFlngInd { get; set; }

    public double SerRat { get; set; }

    public string? SgndInd { get; set; }

    public double Sls { get; set; }

    public string? SmlBusInd { get; set; }

    public string? Stat { get; set; }

    public double Stk { get; set; }

    public string? StmtCrcyCd { get; set; }

    public DateTime? StmtDt { get; set; }

    public DateTime? StmtFromDt { get; set; }

    public DateTime? StmtToDt { get; set; }

    public short StrtYr { get; set; }

    public string? SuitJdgtInd { get; set; }

    public string? TlcmNbr { get; set; }

    public double TotAset { get; set; }

    public double TotCurrAset { get; set; }

    public double TotCurrLiab { get; set; }

    public double TotEmpl { get; set; }

    public string? TotEmplEstdInd { get; set; }

    public string? TotEmplInd { get; set; }

    public string? TotEmplMinInd { get; set; }

    public string? TotEmplText { get; set; }

    public double TotLiab { get; set; }

    public double TotLiabAndEqy { get; set; }

    public double TotLtLiab { get; set; }

    public double TotPmt { get; set; }

    public string? TrdgStyl { get; set; }

    public string? TrlBalInd { get; set; }

    public string? UbalInd { get; set; }

    public string? WomnOwndInd { get; set; }

    public Guid? DocumentId { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }

    public Guid Sysguid { get; set; }

    public byte[] Timestamp { get; set; } = null!;
}
