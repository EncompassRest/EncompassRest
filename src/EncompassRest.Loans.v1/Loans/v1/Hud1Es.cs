using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v1;

/// <summary>
/// Hud1Es
/// </summary>
public sealed partial class Hud1Es : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// HUD Annual City Tax Payment [HUD45]
    /// </summary>
    public decimal? AnnualCityTax { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// No. Annual Fee Pymts for Cushion [HUD38]
    /// </summary>
    public int? AnnualFeeCushion { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// HUD Annual Flood Insurance Payment [HUD44]
    /// </summary>
    public decimal? AnnualFloodInsurance { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// HUD Annual Hazard Insurance Payment [HUD42]
    /// </summary>
    public decimal? AnnualHazardInsurance { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// HUD Annual Mortgage Insurance Payment [HUD43]
    /// </summary>
    public decimal? AnnualMortgageInsurance { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// HUD Annual Tax Payment [HUD41]
    /// </summary>
    public decimal? AnnualTax { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// HUD Annual User Escrow Payment 1 [HUD46]
    /// </summary>
    public decimal? AnnualUserEscrow1 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// HUD Annual User Escrow Payment 2 [HUD47]
    /// </summary>
    public decimal? AnnualUserEscrow2 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// HUD Annual User Escrow Payment 3 [HUD48]
    /// </summary>
    public decimal? AnnualUserEscrow3 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// HUD Biweekly Escrow Payment - City Property Taxes [HUD56]
    /// </summary>
    public decimal? BiweeklyCityPropertyTaxes { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// HUD Biweekly Escrow Payment - County Taxes [HUD52]
    /// </summary>
    public decimal? BiweeklyCountyTaxes { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// HUD Biweekly Escrow Payment - Flood Insurance [HUD55]
    /// </summary>
    public decimal? BiweeklyFloodInsurance { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// HUD Biweekly Escrow Payment - Hazard Insurance [HUD53]
    /// </summary>
    public decimal? BiweeklyHazardInsurance { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// HUD Biweekly Escrow Payment - Mortgage Insurance [HUD54]
    /// </summary>
    public decimal? BiweeklyMortgageInsurance { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// HUD Biweekly Escrow Payment - PITI [HUD51]
    /// </summary>
    public decimal? BiweeklyPITI { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// HUD Biweekly Escrow Payment - Total Biweekly Payment Amount [HUD64]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? BiweeklyTotalBiweeklyPayment { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// HUD Biweekly Escrow Payment - Total Biweekly Payment to Escrow [HUD65]
    /// </summary>
    public decimal? BiweeklyTotalBiweeklyPaymentToEscrow { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// HUD Biweekly Escrow Payment - USDA Annual Fee [HUD63]
    /// </summary>
    public decimal? BiweeklyUSDAFee { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// HUD Biweekly Escrow Payment - User Defined Escrow Fee 1 [HUD58]
    /// </summary>
    public decimal? BiweeklyUserDefinedEscrowFee1 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// HUD Biweekly Escrow Payment - User Defined Escrow Fee 2 [HUD60]
    /// </summary>
    public decimal? BiweeklyUserDefinedEscrowFee2 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// HUD Biweekly Escrow Payment - User Defined Escrow Fee 3 [HUD62]
    /// </summary>
    public decimal? BiweeklyUserDefinedEscrowFee3 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// HUD1ES City Property Tax Pay To Address [VEND.X333]
    /// </summary>
    public string? CityPropertyTaxAddress { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// HUD1ES City Property Tax Pay To Amount Last Paid [VEND.X450]
    /// </summary>
    public decimal? CityPropertyTaxAmountLastPay { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// HUD1ES City Property Tax Pay To Amount Next Due [VEND.X452]
    /// </summary>
    public decimal? CityPropertyTaxAmountNextDue { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// HUD1ES City Property Tax Pay To City [VEND.X334]
    /// </summary>
    public string? CityPropertyTaxCity { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// HUD1ES City Property Tax Pay To Contact [VEND.X337]
    /// </summary>
    public string? CityPropertyTaxContactName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// HUD1ES City Property Tax Pay To Date Paid [VEND.X451]
    /// </summary>
    public DateTime? CityPropertyTaxDatePaid { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// HUD1ES City Property Tax Pay To Delinquent Date [VEND.X454]
    /// </summary>
    public DateTime? CityPropertyTaxDelinquentDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// HUD1ES City Property Tax Pay To Email [VEND.X339]
    /// </summary>
    public string? CityPropertyTaxEmail { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Fees City Property Tax Pay To Fax [VEND.X340]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? CityPropertyTaxFax { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// HUD1ES City Property Tax Pay To Name [VEND.X332]
    /// </summary>
    public string? CityPropertyTaxName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// HUD1ES City Property Tax Pay To Next Due Date [VEND.X453]
    /// </summary>
    public DateTime? CityPropertyTaxNextDueDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// HUD1ES City Property Tax Pay To Payment Schedule [VEND.X449]
    /// </summary>
    public string? CityPropertyTaxPaymentSchedule { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// HUD1ES City Property Tax Pay To Phone [VEND.X338]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? CityPropertyTaxPhone { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// HUD1ES City Property Tax Pay To Zip [VEND.X336]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
    public string? CityPropertyTaxPostalCode { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// HUD1ES City Property Tax Pay To State [VEND.X335]
    /// </summary>
    public StringEnumValue<State> CityPropertyTaxState { get => GetValue<StringEnumValue<State>>(); set => SetValue(value); }

    /// <summary>
    /// HUD Ending Balance [HUD25]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? EndingBalance { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Escrow First Payment Date [HUD68]
    /// </summary>
    public DateTime? EscrowFirstPaymentDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Escrow First Payment Date Type [HUD69]
    /// </summary>
    public StringEnumValue<EscrowFirstPaymentDateType> EscrowFirstPaymentDateType { get => GetValue<StringEnumValue<EscrowFirstPaymentDateType>>(); set => SetValue(value); }

    /// <summary>
    /// HUD Escrow Monthly Payment [HUD24]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? EscrowPayment { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// HUD Escrow Yearly Payment [HUD66]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? EscrowPaymentYearly { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// No. Flood Ins Pymts for Cushion [HUD33]
    /// </summary>
    public int? FloodInsDisbCushion { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// No. Hazard Ins Pymts for Cushion [HUD31]
    /// </summary>
    public int? HazInsDisbCushion { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Hud1Es Hud1EsDates
    /// </summary>
    [AllowNull]
    public IList<Hud1EsDate> Hud1EsDates { get => GetList<Hud1EsDate>(); set => SetList(value); }

    /// <summary>
    /// Hud1Es Hud1EsDueDates
    /// </summary>
    [AllowNull]
    public IList<Hud1EsDueDate> Hud1EsDueDates { get => GetList<Hud1EsDueDate>(); set => SetList(value); }

    /// <summary>
    /// Hud1Es Hud1EsItemizes
    /// </summary>
    [AllowNull]
    public IList<Hud1EsItemize> Hud1EsItemizes { get => GetList<Hud1EsItemize>(); set => SetList(value); }

    /// <summary>
    /// Itemize Escrow Number of Lines in Escrow Output [AEA.X1]
    /// </summary>
    public int? Hud1EsItemizesTotalLines { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Itemize Escrow Use Itemize Escrow Output Format [AEA.X2]
    /// </summary>
    public bool? Hud1EsItemizesUseItemizeEscrowIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Hud1Es Hud1EsPayTos
    /// </summary>
    [AllowNull]
    public IList<Hud1EsPayTo> Hud1EsPayTos { get => GetList<Hud1EsPayTo>(); set => SetList(value); }

    /// <summary>
    /// Hud1Es Hud1EsSetups
    /// </summary>
    [AllowNull]
    public IList<Hud1EsSetup> Hud1EsSetups { get => GetList<Hud1EsSetup>(); set => SetList(value); }

    /// <summary>
    /// Hud1Es Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Servicer to refund Mtg Ins Cushion upon termination [HUD49]
    /// </summary>
    public bool? MtgInsCushionTerminationIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// No. Mtg Ins Pymts for Cushion [HUD32]
    /// </summary>
    public int? MtgInsDisbCushion { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// HUD Non Escrow Yearly Costs [HUD67]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? NonEscrowCostsYearly { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// HUD1ES Tax Pay To Address [VEND.X324]
    /// </summary>
    public string? RealEstateTaxAddress { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// HUD1ES Tax Pay To Amount Last Paid [VEND.X438]
    /// </summary>
    public decimal? RealEstateTaxAmountLastPay { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// HUD1ES Tax Pay To Amount Next Due [VEND.X440]
    /// </summary>
    public decimal? RealEstateTaxAmountNextDue { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// HUD1ES Tax Pay To City [VEND.X325]
    /// </summary>
    public string? RealEstateTaxCity { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// HUD1ES Tax Pay To Contact Name [VEND.X328]
    /// </summary>
    public string? RealEstateTaxContactName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// HUD1ES Tax Pay To Date Paid [VEND.X439]
    /// </summary>
    public DateTime? RealEstateTaxDatePaid { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// HUD1ES Tax Pay To Delinquent Date [VEND.X442]
    /// </summary>
    public DateTime? RealEstateTaxDelinquentDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// HUD1ES Tax Pay To Email [VEND.X330]
    /// </summary>
    public string? RealEstateTaxEmail { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// HUD1ES Tax Pay To Fax [VEND.X331]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? RealEstateTaxFax { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// HUD1ES Tax Pay To Name [VEND.X323]
    /// </summary>
    public string? RealEstateTaxName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// HUD1ES Tax Pay To Next Due Date [VEND.X441]
    /// </summary>
    public DateTime? RealEstateTaxNextDueDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// HUD1ES Tax Pay To Payment Schedule [VEND.X437]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? RealEstateTaxPaymentSchedule { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// HUD1ES Tax Pay To Phone [VEND.X329]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? RealEstateTaxPhone { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// HUD1ES Tax Pay To Zip [VEND.X327]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
    public string? RealEstateTaxPostalCode { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// HUD1ES Tax Pay To State [VEND.X326]
    /// </summary>
    public StringEnumValue<State> RealEstateTaxState { get => GetValue<StringEnumValue<State>>(); set => SetValue(value); }

    /// <summary>
    /// No. City Tax Pymts for Cushion [HUD34]
    /// </summary>
    public int? SchoolTaxesCushion { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Escrow Servicer Address [L631]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? ServicerAddress { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Escrow Servicer City [L632]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? ServicerCity { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Escrow Servicer Name [L611]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? ServicerContactName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Escrow Servicer Phone [L635]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE, ReadOnly = true)]
    public string? ServicerPhone { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Escrow Servicer Zipcode [L634]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE, ReadOnly = true)]
    public string? ServicerPostalCode { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Escrow Servicer State [L633]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public StringEnumValue<State> ServicerState { get => GetValue<StringEnumValue<State>>(); set => SetValue(value); }

    /// <summary>
    /// HUD Single Line Analysis [HUD40]
    /// </summary>
    public decimal? SingleLineAnalysis { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// HUD Starting Balance [HUD23]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? StartingBalance { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// No. Tax Pymts for Cushion [HUD30]
    /// </summary>
    public int? TaxDisbCushion { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// HUD Total Escrow Reserves [HUD26]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TotalEscrowReserves { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// HUD USDA Annual Fee [HUD50]
    /// </summary>
    public decimal? UsdaAnnualFee { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// No. User Defined 1 Pymts for Cushion [HUD35]
    /// </summary>
    public int? UserDefinedCushion1 { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// No. User Defined 2 Pymts for Cushion [HUD36]
    /// </summary>
    public int? UserDefinedCushion2 { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// No. User Defined 3 Pymts for Cushion [HUD37]
    /// </summary>
    public int? UserDefinedCushion3 { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// HUD Yearly Mortgage Insurance Before Rounding [HUD.YearlyMIFee]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? YearlyMortgageInsurance { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// HUD Yearly USDA Fee Before Monthly Payment Rounding [HUD.YearlyUSDAFee]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? YearlyUsdaFee { get => GetValue<decimal?>(); set => SetValue(value); }
}