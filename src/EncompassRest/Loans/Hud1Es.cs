using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// Hud1Es
    /// </summary>
    public sealed partial class Hud1Es : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<decimal?> _annualCityTax;
        /// <summary>
        /// HUD Annual City Tax Payment [HUD45]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "HUD Annual City Tax Payment")]
        public decimal? AnnualCityTax { get => _annualCityTax; set => SetField(ref _annualCityTax, value); }
        private DirtyValue<int?> _annualFeeCushion;
        /// <summary>
        /// No. Annual Fee Pymts for Cushion [HUD38]
        /// </summary>
        [LoanFieldProperty(Description = "No. Annual Fee Pymts for Cushion")]
        public int? AnnualFeeCushion { get => _annualFeeCushion; set => SetField(ref _annualFeeCushion, value); }
        private DirtyValue<decimal?> _annualFloodInsurance;
        /// <summary>
        /// HUD Annual Flood Insurance Payment [HUD44]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "HUD Annual Flood Insurance Payment")]
        public decimal? AnnualFloodInsurance { get => _annualFloodInsurance; set => SetField(ref _annualFloodInsurance, value); }
        private DirtyValue<decimal?> _annualHazardInsurance;
        /// <summary>
        /// HUD Annual Hazard Insurance Payment [HUD42]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "HUD Annual Hazard Insurance Payment")]
        public decimal? AnnualHazardInsurance { get => _annualHazardInsurance; set => SetField(ref _annualHazardInsurance, value); }
        private DirtyValue<decimal?> _annualMortgageInsurance;
        /// <summary>
        /// HUD Annual Mortgage Insurance Payment [HUD43]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "HUD Annual Mortgage Insurance Payment")]
        public decimal? AnnualMortgageInsurance { get => _annualMortgageInsurance; set => SetField(ref _annualMortgageInsurance, value); }
        private DirtyValue<decimal?> _annualTax;
        /// <summary>
        /// HUD Annual Tax Payment [HUD41]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "HUD Annual Tax Payment")]
        public decimal? AnnualTax { get => _annualTax; set => SetField(ref _annualTax, value); }
        private DirtyValue<decimal?> _annualUserEscrow1;
        /// <summary>
        /// HUD Annual User Escrow Payment 1 [HUD46]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "HUD Annual User Escrow Payment 1")]
        public decimal? AnnualUserEscrow1 { get => _annualUserEscrow1; set => SetField(ref _annualUserEscrow1, value); }
        private DirtyValue<decimal?> _annualUserEscrow2;
        /// <summary>
        /// HUD Annual User Escrow Payment 2 [HUD47]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "HUD Annual User Escrow Payment 2")]
        public decimal? AnnualUserEscrow2 { get => _annualUserEscrow2; set => SetField(ref _annualUserEscrow2, value); }
        private DirtyValue<decimal?> _annualUserEscrow3;
        /// <summary>
        /// HUD Annual User Escrow Payment 3 [HUD48]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "HUD Annual User Escrow Payment 3")]
        public decimal? AnnualUserEscrow3 { get => _annualUserEscrow3; set => SetField(ref _annualUserEscrow3, value); }
        private DirtyValue<decimal?> _biweeklyCityPropertyTaxes;
        /// <summary>
        /// HUD Biweekly Escrow Payment - City Property Taxes [HUD56]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "HUD Biweekly Escrow Payment - City Property Taxes")]
        public decimal? BiweeklyCityPropertyTaxes { get => _biweeklyCityPropertyTaxes; set => SetField(ref _biweeklyCityPropertyTaxes, value); }
        private DirtyValue<decimal?> _biweeklyCountyTaxes;
        /// <summary>
        /// HUD Biweekly Escrow Payment - County Taxes [HUD52]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "HUD Biweekly Escrow Payment - County Taxes")]
        public decimal? BiweeklyCountyTaxes { get => _biweeklyCountyTaxes; set => SetField(ref _biweeklyCountyTaxes, value); }
        private DirtyValue<decimal?> _biweeklyFloodInsurance;
        /// <summary>
        /// HUD Biweekly Escrow Payment - Flood Insurance [HUD55]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "HUD Biweekly Escrow Payment - Flood Insurance")]
        public decimal? BiweeklyFloodInsurance { get => _biweeklyFloodInsurance; set => SetField(ref _biweeklyFloodInsurance, value); }
        private DirtyValue<decimal?> _biweeklyHazardInsurance;
        /// <summary>
        /// HUD Biweekly Escrow Payment - Hazard Insurance [HUD53]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "HUD Biweekly Escrow Payment - Hazard Insurance")]
        public decimal? BiweeklyHazardInsurance { get => _biweeklyHazardInsurance; set => SetField(ref _biweeklyHazardInsurance, value); }
        private DirtyValue<decimal?> _biweeklyMortgageInsurance;
        /// <summary>
        /// HUD Biweekly Escrow Payment - Mortgage Insurance [HUD54]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "HUD Biweekly Escrow Payment - Mortgage Insurance")]
        public decimal? BiweeklyMortgageInsurance { get => _biweeklyMortgageInsurance; set => SetField(ref _biweeklyMortgageInsurance, value); }
        private DirtyValue<decimal?> _biweeklyPITI;
        /// <summary>
        /// HUD Biweekly Escrow Payment - PITI [HUD51]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "HUD Biweekly Escrow Payment - PITI")]
        public decimal? BiweeklyPITI { get => _biweeklyPITI; set => SetField(ref _biweeklyPITI, value); }
        private DirtyValue<decimal?> _biweeklyTotalBiweeklyPayment;
        /// <summary>
        /// HUD Biweekly Escrow Payment - Total Biweekly Payment Amount [HUD64]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "HUD Biweekly Escrow Payment - Total Biweekly Payment Amount")]
        public decimal? BiweeklyTotalBiweeklyPayment { get => _biweeklyTotalBiweeklyPayment; set => SetField(ref _biweeklyTotalBiweeklyPayment, value); }
        private DirtyValue<decimal?> _biweeklyTotalBiweeklyPaymentToEscrow;
        /// <summary>
        /// HUD Biweekly Escrow Payment - Total Biweekly Payment to Escrow [HUD65]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "HUD Biweekly Escrow Payment - Total Biweekly Payment to Escrow")]
        public decimal? BiweeklyTotalBiweeklyPaymentToEscrow { get => _biweeklyTotalBiweeklyPaymentToEscrow; set => SetField(ref _biweeklyTotalBiweeklyPaymentToEscrow, value); }
        private DirtyValue<decimal?> _biweeklyUSDAFee;
        /// <summary>
        /// HUD Biweekly Escrow Payment - USDA Annual Fee [HUD63]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "HUD Biweekly Escrow Payment - USDA Annual Fee")]
        public decimal? BiweeklyUSDAFee { get => _biweeklyUSDAFee; set => SetField(ref _biweeklyUSDAFee, value); }
        private DirtyValue<decimal?> _biweeklyUserDefinedEscrowFee1;
        /// <summary>
        /// HUD Biweekly Escrow Payment - User Defined Escrow Fee 1 [HUD58]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "HUD Biweekly Escrow Payment - User Defined Escrow Fee 1")]
        public decimal? BiweeklyUserDefinedEscrowFee1 { get => _biweeklyUserDefinedEscrowFee1; set => SetField(ref _biweeklyUserDefinedEscrowFee1, value); }
        private DirtyValue<decimal?> _biweeklyUserDefinedEscrowFee2;
        /// <summary>
        /// HUD Biweekly Escrow Payment - User Defined Escrow Fee 2 [HUD60]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "HUD Biweekly Escrow Payment - User Defined Escrow Fee 2")]
        public decimal? BiweeklyUserDefinedEscrowFee2 { get => _biweeklyUserDefinedEscrowFee2; set => SetField(ref _biweeklyUserDefinedEscrowFee2, value); }
        private DirtyValue<decimal?> _biweeklyUserDefinedEscrowFee3;
        /// <summary>
        /// HUD Biweekly Escrow Payment - User Defined Escrow Fee 3 [HUD62]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "HUD Biweekly Escrow Payment - User Defined Escrow Fee 3")]
        public decimal? BiweeklyUserDefinedEscrowFee3 { get => _biweeklyUserDefinedEscrowFee3; set => SetField(ref _biweeklyUserDefinedEscrowFee3, value); }
        private DirtyValue<string> _cityPropertyTaxAddress;
        /// <summary>
        /// HUD1ES City Property Tax Pay To Address [VEND.X333]
        /// </summary>
        [LoanFieldProperty(Description = "HUD1ES City Property Tax Pay To Address")]
        public string CityPropertyTaxAddress { get => _cityPropertyTaxAddress; set => SetField(ref _cityPropertyTaxAddress, value); }
        private DirtyValue<decimal?> _cityPropertyTaxAmountLastPay;
        /// <summary>
        /// HUD1ES City Property Tax Pay To Amount Last Paid [VEND.X450]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "HUD1ES City Property Tax Pay To Amount Last Paid")]
        public decimal? CityPropertyTaxAmountLastPay { get => _cityPropertyTaxAmountLastPay; set => SetField(ref _cityPropertyTaxAmountLastPay, value); }
        private DirtyValue<decimal?> _cityPropertyTaxAmountNextDue;
        /// <summary>
        /// HUD1ES City Property Tax Pay To Amount Next Due [VEND.X452]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "HUD1ES City Property Tax Pay To Amount Next Due")]
        public decimal? CityPropertyTaxAmountNextDue { get => _cityPropertyTaxAmountNextDue; set => SetField(ref _cityPropertyTaxAmountNextDue, value); }
        private DirtyValue<string> _cityPropertyTaxCity;
        /// <summary>
        /// HUD1ES City Property Tax Pay To City [VEND.X334]
        /// </summary>
        [LoanFieldProperty(Description = "HUD1ES City Property Tax Pay To City")]
        public string CityPropertyTaxCity { get => _cityPropertyTaxCity; set => SetField(ref _cityPropertyTaxCity, value); }
        private DirtyValue<string> _cityPropertyTaxContactName;
        /// <summary>
        /// HUD1ES City Property Tax Pay To Contact [VEND.X337]
        /// </summary>
        [LoanFieldProperty(Description = "HUD1ES City Property Tax Pay To Contact")]
        public string CityPropertyTaxContactName { get => _cityPropertyTaxContactName; set => SetField(ref _cityPropertyTaxContactName, value); }
        private DirtyValue<DateTime?> _cityPropertyTaxDatePaid;
        /// <summary>
        /// HUD1ES City Property Tax Pay To Date Paid [VEND.X451]
        /// </summary>
        [LoanFieldProperty(Description = "HUD1ES City Property Tax Pay To Date Paid")]
        public DateTime? CityPropertyTaxDatePaid { get => _cityPropertyTaxDatePaid; set => SetField(ref _cityPropertyTaxDatePaid, value); }
        private DirtyValue<DateTime?> _cityPropertyTaxDelinquentDate;
        /// <summary>
        /// HUD1ES City Property Tax Pay To Delinquent Date [VEND.X454]
        /// </summary>
        [LoanFieldProperty(Description = "HUD1ES City Property Tax Pay To Delinquent Date")]
        public DateTime? CityPropertyTaxDelinquentDate { get => _cityPropertyTaxDelinquentDate; set => SetField(ref _cityPropertyTaxDelinquentDate, value); }
        private DirtyValue<string> _cityPropertyTaxEmail;
        /// <summary>
        /// HUD1ES City Property Tax Pay To Email [VEND.X339]
        /// </summary>
        [LoanFieldProperty(Description = "HUD1ES City Property Tax Pay To Email")]
        public string CityPropertyTaxEmail { get => _cityPropertyTaxEmail; set => SetField(ref _cityPropertyTaxEmail, value); }
        private DirtyValue<string> _cityPropertyTaxFax;
        /// <summary>
        /// Fees City Property Tax Pay To Fax [VEND.X340]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE, Description = "Fees City Property Tax Pay To Fax")]
        public string CityPropertyTaxFax { get => _cityPropertyTaxFax; set => SetField(ref _cityPropertyTaxFax, value); }
        private DirtyValue<string> _cityPropertyTaxName;
        /// <summary>
        /// HUD1ES City Property Tax Pay To Name [VEND.X332]
        /// </summary>
        [LoanFieldProperty(Description = "HUD1ES City Property Tax Pay To Name")]
        public string CityPropertyTaxName { get => _cityPropertyTaxName; set => SetField(ref _cityPropertyTaxName, value); }
        private DirtyValue<DateTime?> _cityPropertyTaxNextDueDate;
        /// <summary>
        /// HUD1ES City Property Tax Pay To Next Due Date [VEND.X453]
        /// </summary>
        [LoanFieldProperty(Description = "HUD1ES City Property Tax Pay To Next Due Date")]
        public DateTime? CityPropertyTaxNextDueDate { get => _cityPropertyTaxNextDueDate; set => SetField(ref _cityPropertyTaxNextDueDate, value); }
        private DirtyValue<string> _cityPropertyTaxPaymentSchedule;
        /// <summary>
        /// HUD1ES City Property Tax Pay To Payment Schedule [VEND.X449]
        /// </summary>
        [LoanFieldProperty(Description = "HUD1ES City Property Tax Pay To Payment Schedule")]
        public string CityPropertyTaxPaymentSchedule { get => _cityPropertyTaxPaymentSchedule; set => SetField(ref _cityPropertyTaxPaymentSchedule, value); }
        private DirtyValue<string> _cityPropertyTaxPhone;
        /// <summary>
        /// HUD1ES City Property Tax Pay To Phone [VEND.X338]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE, Description = "HUD1ES City Property Tax Pay To Phone")]
        public string CityPropertyTaxPhone { get => _cityPropertyTaxPhone; set => SetField(ref _cityPropertyTaxPhone, value); }
        private DirtyValue<string> _cityPropertyTaxPostalCode;
        /// <summary>
        /// HUD1ES City Property Tax Pay To Zip [VEND.X336]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE, Description = "HUD1ES City Property Tax Pay To Zip")]
        public string CityPropertyTaxPostalCode { get => _cityPropertyTaxPostalCode; set => SetField(ref _cityPropertyTaxPostalCode, value); }
        private DirtyValue<StringEnumValue<State>> _cityPropertyTaxState;
        /// <summary>
        /// HUD1ES City Property Tax Pay To State [VEND.X335]
        /// </summary>
        [LoanFieldProperty(Description = "HUD1ES City Property Tax Pay To State")]
        public StringEnumValue<State> CityPropertyTaxState { get => _cityPropertyTaxState; set => SetField(ref _cityPropertyTaxState, value); }
        private DirtyValue<decimal?> _endingBalance;
        /// <summary>
        /// HUD Ending Balance [HUD25]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "HUD Ending Balance")]
        public decimal? EndingBalance { get => _endingBalance; set => SetField(ref _endingBalance, value); }
        private DirtyValue<DateTime?> _escrowFirstPaymentDate;
        /// <summary>
        /// Escrow First Payment Date [HUD68]
        /// </summary>
        [LoanFieldProperty(Description = "Escrow First Payment Date")]
        public DateTime? EscrowFirstPaymentDate { get => _escrowFirstPaymentDate; set => SetField(ref _escrowFirstPaymentDate, value); }
        private DirtyValue<StringEnumValue<EscrowFirstPaymentDateType>> _escrowFirstPaymentDateType;
        /// <summary>
        /// Escrow First Payment Date Type [HUD69]
        /// </summary>
        [LoanFieldProperty(Description = "Escrow First Payment Date Type")]
        public StringEnumValue<EscrowFirstPaymentDateType> EscrowFirstPaymentDateType { get => _escrowFirstPaymentDateType; set => SetField(ref _escrowFirstPaymentDateType, value); }
        private DirtyValue<decimal?> _escrowPayment;
        /// <summary>
        /// HUD Escrow Monthly Payment [HUD24]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "HUD Escrow Monthly Payment")]
        public decimal? EscrowPayment { get => _escrowPayment; set => SetField(ref _escrowPayment, value); }
        private DirtyValue<decimal?> _escrowPaymentYearly;
        /// <summary>
        /// HUD Escrow Yearly Payment [HUD66]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "HUD Escrow Yearly Payment")]
        public decimal? EscrowPaymentYearly { get => _escrowPaymentYearly; set => SetField(ref _escrowPaymentYearly, value); }
        private DirtyValue<int?> _floodInsDisbCushion;
        /// <summary>
        /// No. Flood Ins Pymts for Cushion [HUD33]
        /// </summary>
        [LoanFieldProperty(Description = "No. Flood Ins Pymts for Cushion")]
        public int? FloodInsDisbCushion { get => _floodInsDisbCushion; set => SetField(ref _floodInsDisbCushion, value); }
        private DirtyValue<int?> _hazInsDisbCushion;
        /// <summary>
        /// No. Hazard Ins Pymts for Cushion [HUD31]
        /// </summary>
        [LoanFieldProperty(Description = "No. Hazard Ins Pymts for Cushion")]
        public int? HazInsDisbCushion { get => _hazInsDisbCushion; set => SetField(ref _hazInsDisbCushion, value); }
        private DirtyList<Hud1EsDate> _hud1EsDates;
        /// <summary>
        /// Hud1Es Hud1EsDates
        /// </summary>
        public IList<Hud1EsDate> Hud1EsDates { get => GetField(ref _hud1EsDates); set => SetField(ref _hud1EsDates, value); }
        private DirtyList<Hud1EsDueDate> _hud1EsDueDates;
        /// <summary>
        /// Hud1Es Hud1EsDueDates
        /// </summary>
        public IList<Hud1EsDueDate> Hud1EsDueDates { get => GetField(ref _hud1EsDueDates); set => SetField(ref _hud1EsDueDates, value); }
        private DirtyList<Hud1EsItemize> _hud1EsItemizes;
        /// <summary>
        /// Hud1Es Hud1EsItemizes
        /// </summary>
        public IList<Hud1EsItemize> Hud1EsItemizes { get => GetField(ref _hud1EsItemizes); set => SetField(ref _hud1EsItemizes, value); }
        private DirtyValue<int?> _hud1EsItemizesTotalLines;
        /// <summary>
        /// Itemize Escrow Number of Lines in Escrow Output [AEA.X1]
        /// </summary>
        [LoanFieldProperty(Description = "Itemize Escrow Number of Lines in Escrow Output")]
        public int? Hud1EsItemizesTotalLines { get => _hud1EsItemizesTotalLines; set => SetField(ref _hud1EsItemizesTotalLines, value); }
        private DirtyValue<bool?> _hud1EsItemizesUseItemizeEscrowIndicator;
        /// <summary>
        /// Itemize Escrow Use Itemize Escrow Output Format [AEA.X2]
        /// </summary>
        [LoanFieldProperty(Description = "Itemize Escrow Use Itemize Escrow Output Format")]
        public bool? Hud1EsItemizesUseItemizeEscrowIndicator { get => _hud1EsItemizesUseItemizeEscrowIndicator; set => SetField(ref _hud1EsItemizesUseItemizeEscrowIndicator, value); }
        private DirtyList<Hud1EsPayTo> _hud1EsPayTos;
        /// <summary>
        /// Hud1Es Hud1EsPayTos
        /// </summary>
        public IList<Hud1EsPayTo> Hud1EsPayTos { get => GetField(ref _hud1EsPayTos); set => SetField(ref _hud1EsPayTos, value); }
        private DirtyList<Hud1EsSetup> _hud1EsSetups;
        /// <summary>
        /// Hud1Es Hud1EsSetups
        /// </summary>
        public IList<Hud1EsSetup> Hud1EsSetups { get => GetField(ref _hud1EsSetups); set => SetField(ref _hud1EsSetups, value); }
        private DirtyValue<string> _id;
        /// <summary>
        /// Hud1Es Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }
        private DirtyValue<bool?> _mtgInsCushionTerminationIndicator;
        /// <summary>
        /// Servicer to refund Mtg Ins Cushion upon termination [HUD49]
        /// </summary>
        [LoanFieldProperty(Description = "Servicer to refund Mtg Ins Cushion upon termination")]
        public bool? MtgInsCushionTerminationIndicator { get => _mtgInsCushionTerminationIndicator; set => SetField(ref _mtgInsCushionTerminationIndicator, value); }
        private DirtyValue<int?> _mtgInsDisbCushion;
        /// <summary>
        /// No. Mtg Ins Pymts for Cushion [HUD32]
        /// </summary>
        [LoanFieldProperty(Description = "No. Mtg Ins Pymts for Cushion")]
        public int? MtgInsDisbCushion { get => _mtgInsDisbCushion; set => SetField(ref _mtgInsDisbCushion, value); }
        private DirtyValue<decimal?> _nonEscrowCostsYearly;
        /// <summary>
        /// HUD Non Escrow Yearly Costs [HUD67]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "HUD Non Escrow Yearly Costs")]
        public decimal? NonEscrowCostsYearly { get => _nonEscrowCostsYearly; set => SetField(ref _nonEscrowCostsYearly, value); }
        private DirtyValue<string> _realEstateTaxAddress;
        /// <summary>
        /// HUD1ES Tax Pay To Address [VEND.X324]
        /// </summary>
        [LoanFieldProperty(Description = "HUD1ES Tax Pay To Address")]
        public string RealEstateTaxAddress { get => _realEstateTaxAddress; set => SetField(ref _realEstateTaxAddress, value); }
        private DirtyValue<decimal?> _realEstateTaxAmountLastPay;
        /// <summary>
        /// HUD1ES Tax Pay To Amount Last Paid [VEND.X438]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "HUD1ES Tax Pay To Amount Last Paid")]
        public decimal? RealEstateTaxAmountLastPay { get => _realEstateTaxAmountLastPay; set => SetField(ref _realEstateTaxAmountLastPay, value); }
        private DirtyValue<decimal?> _realEstateTaxAmountNextDue;
        /// <summary>
        /// HUD1ES Tax Pay To Amount Next Due [VEND.X440]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "HUD1ES Tax Pay To Amount Next Due")]
        public decimal? RealEstateTaxAmountNextDue { get => _realEstateTaxAmountNextDue; set => SetField(ref _realEstateTaxAmountNextDue, value); }
        private DirtyValue<string> _realEstateTaxCity;
        /// <summary>
        /// HUD1ES Tax Pay To City [VEND.X325]
        /// </summary>
        [LoanFieldProperty(Description = "HUD1ES Tax Pay To City")]
        public string RealEstateTaxCity { get => _realEstateTaxCity; set => SetField(ref _realEstateTaxCity, value); }
        private DirtyValue<string> _realEstateTaxContactName;
        /// <summary>
        /// HUD1ES Tax Pay To Contact Name [VEND.X328]
        /// </summary>
        [LoanFieldProperty(Description = "HUD1ES Tax Pay To Contact Name")]
        public string RealEstateTaxContactName { get => _realEstateTaxContactName; set => SetField(ref _realEstateTaxContactName, value); }
        private DirtyValue<DateTime?> _realEstateTaxDatePaid;
        /// <summary>
        /// HUD1ES Tax Pay To Date Paid [VEND.X439]
        /// </summary>
        [LoanFieldProperty(Description = "HUD1ES Tax Pay To Date Paid")]
        public DateTime? RealEstateTaxDatePaid { get => _realEstateTaxDatePaid; set => SetField(ref _realEstateTaxDatePaid, value); }
        private DirtyValue<DateTime?> _realEstateTaxDelinquentDate;
        /// <summary>
        /// HUD1ES Tax Pay To Delinquent Date [VEND.X442]
        /// </summary>
        [LoanFieldProperty(Description = "HUD1ES Tax Pay To Delinquent Date")]
        public DateTime? RealEstateTaxDelinquentDate { get => _realEstateTaxDelinquentDate; set => SetField(ref _realEstateTaxDelinquentDate, value); }
        private DirtyValue<string> _realEstateTaxEmail;
        /// <summary>
        /// HUD1ES Tax Pay To Email [VEND.X330]
        /// </summary>
        [LoanFieldProperty(Description = "HUD1ES Tax Pay To Email")]
        public string RealEstateTaxEmail { get => _realEstateTaxEmail; set => SetField(ref _realEstateTaxEmail, value); }
        private DirtyValue<string> _realEstateTaxFax;
        /// <summary>
        /// HUD1ES Tax Pay To Fax [VEND.X331]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE, Description = "HUD1ES Tax Pay To Fax")]
        public string RealEstateTaxFax { get => _realEstateTaxFax; set => SetField(ref _realEstateTaxFax, value); }
        private DirtyValue<string> _realEstateTaxName;
        /// <summary>
        /// HUD1ES Tax Pay To Name [VEND.X323]
        /// </summary>
        [LoanFieldProperty(Description = "HUD1ES Tax Pay To Name")]
        public string RealEstateTaxName { get => _realEstateTaxName; set => SetField(ref _realEstateTaxName, value); }
        private DirtyValue<DateTime?> _realEstateTaxNextDueDate;
        /// <summary>
        /// HUD1ES Tax Pay To Next Due Date [VEND.X441]
        /// </summary>
        [LoanFieldProperty(Description = "HUD1ES Tax Pay To Next Due Date")]
        public DateTime? RealEstateTaxNextDueDate { get => _realEstateTaxNextDueDate; set => SetField(ref _realEstateTaxNextDueDate, value); }
        private DirtyValue<string> _realEstateTaxPaymentSchedule;
        /// <summary>
        /// HUD1ES Tax Pay To Payment Schedule [VEND.X437]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "HUD1ES Tax Pay To Payment Schedule")]
        public string RealEstateTaxPaymentSchedule { get => _realEstateTaxPaymentSchedule; set => SetField(ref _realEstateTaxPaymentSchedule, value); }
        private DirtyValue<string> _realEstateTaxPhone;
        /// <summary>
        /// HUD1ES Tax Pay To Phone [VEND.X329]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE, Description = "HUD1ES Tax Pay To Phone")]
        public string RealEstateTaxPhone { get => _realEstateTaxPhone; set => SetField(ref _realEstateTaxPhone, value); }
        private DirtyValue<string> _realEstateTaxPostalCode;
        /// <summary>
        /// HUD1ES Tax Pay To Zip [VEND.X327]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE, Description = "HUD1ES Tax Pay To Zip")]
        public string RealEstateTaxPostalCode { get => _realEstateTaxPostalCode; set => SetField(ref _realEstateTaxPostalCode, value); }
        private DirtyValue<StringEnumValue<State>> _realEstateTaxState;
        /// <summary>
        /// HUD1ES Tax Pay To State [VEND.X326]
        /// </summary>
        [LoanFieldProperty(Description = "HUD1ES Tax Pay To State")]
        public StringEnumValue<State> RealEstateTaxState { get => _realEstateTaxState; set => SetField(ref _realEstateTaxState, value); }
        private DirtyValue<int?> _schoolTaxesCushion;
        /// <summary>
        /// No. City Tax Pymts for Cushion [HUD34]
        /// </summary>
        [LoanFieldProperty(Description = "No. City Tax Pymts for Cushion")]
        public int? SchoolTaxesCushion { get => _schoolTaxesCushion; set => SetField(ref _schoolTaxesCushion, value); }
        private DirtyValue<string> _servicerAddress;
        /// <summary>
        /// Escrow Servicer Address [L631]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Escrow Servicer Address")]
        public string ServicerAddress { get => _servicerAddress; set => SetField(ref _servicerAddress, value); }
        private DirtyValue<string> _servicerCity;
        /// <summary>
        /// Escrow Servicer City [L632]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Escrow Servicer City")]
        public string ServicerCity { get => _servicerCity; set => SetField(ref _servicerCity, value); }
        private DirtyValue<string> _servicerContactName;
        /// <summary>
        /// Escrow Servicer Name [L611]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Escrow Servicer Name")]
        public string ServicerContactName { get => _servicerContactName; set => SetField(ref _servicerContactName, value); }
        private DirtyValue<string> _servicerPhone;
        /// <summary>
        /// Escrow Servicer Phone [L635]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE, ReadOnly = true, Description = "Escrow Servicer Phone")]
        public string ServicerPhone { get => _servicerPhone; set => SetField(ref _servicerPhone, value); }
        private DirtyValue<string> _servicerPostalCode;
        /// <summary>
        /// Escrow Servicer Zipcode [L634]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE, ReadOnly = true, Description = "Escrow Servicer Zipcode")]
        public string ServicerPostalCode { get => _servicerPostalCode; set => SetField(ref _servicerPostalCode, value); }
        private DirtyValue<StringEnumValue<State>> _servicerState;
        /// <summary>
        /// Escrow Servicer State [L633]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Escrow Servicer State")]
        public StringEnumValue<State> ServicerState { get => _servicerState; set => SetField(ref _servicerState, value); }
        private DirtyValue<decimal?> _singleLineAnalysis;
        /// <summary>
        /// HUD Single Line Analysis [HUD40]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "HUD Single Line Analysis")]
        public decimal? SingleLineAnalysis { get => _singleLineAnalysis; set => SetField(ref _singleLineAnalysis, value); }
        private DirtyValue<decimal?> _startingBalance;
        /// <summary>
        /// HUD Starting Balance [HUD23]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "HUD Starting Balance")]
        public decimal? StartingBalance { get => _startingBalance; set => SetField(ref _startingBalance, value); }
        private DirtyValue<int?> _taxDisbCushion;
        /// <summary>
        /// No. Tax Pymts for Cushion [HUD30]
        /// </summary>
        [LoanFieldProperty(Description = "No. Tax Pymts for Cushion")]
        public int? TaxDisbCushion { get => _taxDisbCushion; set => SetField(ref _taxDisbCushion, value); }
        private DirtyValue<decimal?> _totalEscrowReserves;
        /// <summary>
        /// HUD Total Escrow Reserves [HUD26]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "HUD Total Escrow Reserves")]
        public decimal? TotalEscrowReserves { get => _totalEscrowReserves; set => SetField(ref _totalEscrowReserves, value); }
        private DirtyValue<decimal?> _usdaAnnualFee;
        /// <summary>
        /// HUD USDA Annual Fee [HUD50]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "HUD USDA Annual Fee")]
        public decimal? UsdaAnnualFee { get => _usdaAnnualFee; set => SetField(ref _usdaAnnualFee, value); }
        private DirtyValue<int?> _userDefinedCushion1;
        /// <summary>
        /// No. User Defined 1 Pymts for Cushion [HUD35]
        /// </summary>
        [LoanFieldProperty(Description = "No. User Defined 1 Pymts for Cushion")]
        public int? UserDefinedCushion1 { get => _userDefinedCushion1; set => SetField(ref _userDefinedCushion1, value); }
        private DirtyValue<int?> _userDefinedCushion2;
        /// <summary>
        /// No. User Defined 2 Pymts for Cushion [HUD36]
        /// </summary>
        [LoanFieldProperty(Description = "No. User Defined 2 Pymts for Cushion")]
        public int? UserDefinedCushion2 { get => _userDefinedCushion2; set => SetField(ref _userDefinedCushion2, value); }
        private DirtyValue<int?> _userDefinedCushion3;
        /// <summary>
        /// No. User Defined 3 Pymts for Cushion [HUD37]
        /// </summary>
        [LoanFieldProperty(Description = "No. User Defined 3 Pymts for Cushion")]
        public int? UserDefinedCushion3 { get => _userDefinedCushion3; set => SetField(ref _userDefinedCushion3, value); }
        private DirtyValue<decimal?> _yearlyMortgageInsurance;
        /// <summary>
        /// HUD Yearly Mortgage Insurance Before Rounding [HUD.YearlyMIFee]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "HUD Yearly Mortgage Insurance Before Rounding")]
        public decimal? YearlyMortgageInsurance { get => _yearlyMortgageInsurance; set => SetField(ref _yearlyMortgageInsurance, value); }
        private DirtyValue<decimal?> _yearlyUsdaFee;
        /// <summary>
        /// HUD Yearly USDA Fee Before Monthly Payment Rounding [HUD.YearlyUSDAFee]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "HUD Yearly USDA Fee Before Monthly Payment Rounding")]
        public decimal? YearlyUsdaFee { get => _yearlyUsdaFee; set => SetField(ref _yearlyUsdaFee, value); }
    }
}