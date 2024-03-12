using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class AccountTypeProperty
{
    public Guid Id { get; set; }

    public string AccountType { get; set; } = null!;

    public int AccountLevel { get; set; }

    public string AccountStatus { get; set; } = null!;

    public int CodeEditMode { get; set; }

    public int AddressEditMode { get; set; }

    public int NotesEditMode { get; set; }

    public int DocumentEditMode { get; set; }

    public int LogoEditMode { get; set; }

    public int TypeEditMode { get; set; }

    public int StatusEditMode { get; set; }

    public int FreeFieldsEditMode { get; set; }

    public int SectorEditMode { get; set; }

    public int RelationEditMode { get; set; }

    public int SubsidiariesEditMode { get; set; }

    public int LastLoginEditMode { get; set; }

    public int MonitorEditMode { get; set; }

    public int EditEmployeeEditMode { get; set; }

    public int AccManagerEditMode { get; set; }

    public int WebAccessEditMode { get; set; }

    public int DatabaseEditMode { get; set; }

    public int ChamberOfCommerceEditMode { get; set; }

    public int SourceEditMode { get; set; }

    public int SalesPersonEditMode { get; set; }

    public int DunNumberEditMode { get; set; }

    public int? CodeFunctionId { get; set; }

    public int? AddressFunctionId { get; set; }

    public int? NotesFunctionId { get; set; }

    public int? DocumentFunctionId { get; set; }

    public int? LogoFunctionId { get; set; }

    public int? TypeFunctionId { get; set; }

    public int? StatusFunctionId { get; set; }

    public int? FreeFieldsFunctionId { get; set; }

    public int? SectorFunctionId { get; set; }

    public int? RelationFunctionId { get; set; }

    public int? SubsidiariesFunctionId { get; set; }

    public int? LastLoginFunctionId { get; set; }

    public int? MonitorFunctionId { get; set; }

    public int? EditEmployeeFunctionId { get; set; }

    public int? AccManagerFunctionId { get; set; }

    public int? WebAccessFunctionId { get; set; }

    public int? DatabaseFunctionId { get; set; }

    public int? ChamberOfCommerceFunctionId { get; set; }

    public int? SourceFunctionId { get; set; }

    public int? SalesPersonFunctionId { get; set; }

    public int? DunNumberFunctionId { get; set; }

    public byte LinkLog { get; set; }

    public byte LinkExit { get; set; }

    public byte LinkReference { get; set; }

    public byte LinkBlocked { get; set; }

    public byte LinkPilot { get; set; }

    public byte LinkPassword { get; set; }

    public byte LinkEdit { get; set; }

    public byte LinkValidate { get; set; }

    public byte LinkMailMerge { get; set; }

    public byte LinkBudget { get; set; }

    public byte LinkAr { get; set; }

    public byte LinkAp { get; set; }

    public byte LinkProspects { get; set; }

    public byte LinkCustomers { get; set; }

    public byte LinkLabel { get; set; }

    public byte LinkProject { get; set; }

    public byte LinkItems { get; set; }

    public byte LinkAddresses { get; set; }

    public byte LinkActive { get; set; }

    public byte LinkRequests { get; set; }

    public byte LinkPersons { get; set; }

    public byte LinkDocuments { get; set; }

    public byte LinkContracts { get; set; }

    public byte LinkPurchase { get; set; }

    public byte LinkPassive { get; set; }

    public byte LinkMap { get; set; }

    public byte LinkCredit { get; set; }

    public byte LinkSalesStatistics { get; set; }

    public int? LinkLogFunctionId { get; set; }

    public int? LinkExitFunctionId { get; set; }

    public int? LinkReferenceFunctionId { get; set; }

    public int? LinkBlockedFunctionId { get; set; }

    public int? LinkPilotFunctionId { get; set; }

    public int? LinkPasswordFunctionId { get; set; }

    public int? LinkEditFunctionId { get; set; }

    public int? LinkValidateFunctionId { get; set; }

    public int? LinkMailMergeFunctionId { get; set; }

    public int? LinkBudgetFunctionId { get; set; }

    public int? LinkArfunctionId { get; set; }

    public int? LinkApfunctionId { get; set; }

    public int? LinkProspectsFunctionId { get; set; }

    public int? LinkCustomersFunctionId { get; set; }

    public int? LinkLabelFunctionId { get; set; }

    public int? LinkProjectFunctionId { get; set; }

    public int? LinkItemsFunctionId { get; set; }

    public int? LinkAddressesFunctionId { get; set; }

    public int? LinkActiveFunctionId { get; set; }

    public int? LinkRequestsFunctionId { get; set; }

    public int? LinkPersonsFunctionId { get; set; }

    public int? LinkDocumentsFunctionId { get; set; }

    public int? LinkContractsFunctionId { get; set; }

    public int? LinkPurchaseFunctionId { get; set; }

    public int? LinkPassiveFunctionId { get; set; }

    public int? LinkMapFunctionId { get; set; }

    public int? LinkCreditFunctionId { get; set; }

    public int? LinkSalesStatisticsFunctionId { get; set; }

    public int Blocked { get; set; }

    public short? Division { get; set; }

    public int Syscreator { get; set; }

    public DateTime Syscreated { get; set; }

    public int Sysmodifier { get; set; }

    public DateTime Sysmodified { get; set; }
}
