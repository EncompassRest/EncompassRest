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
        private DirtyValue<int?> _annualFeeCushion;
        private DirtyValue<decimal?> _annualFloodInsurance;
        private DirtyValue<decimal?> _annualHazardInsurance;
        private DirtyValue<decimal?> _annualMortgageInsurance;
        private DirtyValue<decimal?> _annualTax;
        private DirtyValue<decimal?> _annualUserEscrow1;
        private DirtyValue<decimal?> _annualUserEscrow2;
        private DirtyValue<decimal?> _annualUserEscrow3;
        private DirtyValue<decimal?> _biweeklyCityPropertyTaxes;
        private DirtyValue<decimal?> _biweeklyCountyTaxes;
        private DirtyValue<decimal?> _biweeklyFloodInsurance;
        private DirtyValue<decimal?> _biweeklyHazardInsurance;
        private DirtyValue<decimal?> _biweeklyMortgageInsurance;
        private DirtyValue<decimal?> _biweeklyPITI;
        private DirtyValue<decimal?> _biweeklyTotalBiweeklyPayment;
        private DirtyValue<decimal?> _biweeklyTotalBiweeklyPaymentToEscrow;
        private DirtyValue<decimal?> _biweeklyUSDAFee;
        private DirtyValue<decimal?> _biweeklyUserDefinedEscrowFee1;
        private DirtyValue<decimal?> _biweeklyUserDefinedEscrowFee2;
        private DirtyValue<decimal?> _biweeklyUserDefinedEscrowFee3;
        private DirtyValue<string> _cityPropertyTaxAddress;
        private DirtyValue<decimal?> _cityPropertyTaxAmountLastPay;
        private DirtyValue<decimal?> _cityPropertyTaxAmountNextDue;
        private DirtyValue<string> _cityPropertyTaxCity;
        private DirtyValue<string> _cityPropertyTaxContactName;
        private DirtyValue<DateTime?> _cityPropertyTaxDatePaid;
        private DirtyValue<DateTime?> _cityPropertyTaxDelinquentDate;
        private DirtyValue<string> _cityPropertyTaxEmail;
        private DirtyValue<string> _cityPropertyTaxFax;
        private DirtyValue<string> _cityPropertyTaxName;
        private DirtyValue<DateTime?> _cityPropertyTaxNextDueDate;
        private DirtyValue<string> _cityPropertyTaxPaymentSchedule;
        private DirtyValue<string> _cityPropertyTaxPhone;
        private DirtyValue<string> _cityPropertyTaxPostalCode;
        private DirtyValue<StringEnumValue<State>> _cityPropertyTaxState;
        private DirtyValue<decimal?> _endingBalance;
        private DirtyValue<DateTime?> _escrowFirstPaymentDate;
        private DirtyValue<StringEnumValue<EscrowFirstPaymentDateType>> _escrowFirstPaymentDateType;
        private DirtyValue<decimal?> _escrowPayment;
        private DirtyValue<decimal?> _escrowPaymentYearly;
        private DirtyValue<int?> _floodInsDisbCushion;
        private DirtyValue<int?> _hazInsDisbCushion;
        private DirtyList<Hud1EsDate> _hud1EsDates;
        private DirtyList<Hud1EsDueDate> _hud1EsDueDates;
        private DirtyList<Hud1EsItemize> _hud1EsItemizes;
        private DirtyValue<int?> _hud1EsItemizesTotalLines;
        private DirtyValue<bool?> _hud1EsItemizesUseItemizeEscrowIndicator;
        private DirtyList<Hud1EsPayTo> _hud1EsPayTos;
        private DirtyList<Hud1EsSetup> _hud1EsSetups;
        private DirtyValue<string> _id;
        private DirtyValue<bool?> _mtgInsCushionTerminationIndicator;
        private DirtyValue<int?> _mtgInsDisbCushion;
        private DirtyValue<decimal?> _nonEscrowCostsYearly;
        private DirtyValue<string> _realEstateTaxAddress;
        private DirtyValue<decimal?> _realEstateTaxAmountLastPay;
        private DirtyValue<decimal?> _realEstateTaxAmountNextDue;
        private DirtyValue<string> _realEstateTaxCity;
        private DirtyValue<string> _realEstateTaxContactName;
        private DirtyValue<DateTime?> _realEstateTaxDatePaid;
        private DirtyValue<DateTime?> _realEstateTaxDelinquentDate;
        private DirtyValue<string> _realEstateTaxEmail;
        private DirtyValue<string> _realEstateTaxFax;
        private DirtyValue<string> _realEstateTaxName;
        private DirtyValue<DateTime?> _realEstateTaxNextDueDate;
        private DirtyValue<string> _realEstateTaxPaymentSchedule;
        private DirtyValue<string> _realEstateTaxPhone;
        private DirtyValue<string> _realEstateTaxPostalCode;
        private DirtyValue<StringEnumValue<State>> _realEstateTaxState;
        private DirtyValue<int?> _schoolTaxesCushion;
        private DirtyValue<string> _servicerAddress;
        private DirtyValue<string> _servicerCity;
        private DirtyValue<string> _servicerContactName;
        private DirtyValue<string> _servicerPhone;
        private DirtyValue<string> _servicerPostalCode;
        private DirtyValue<StringEnumValue<State>> _servicerState;
        private DirtyValue<decimal?> _singleLineAnalysis;
        private DirtyValue<decimal?> _startingBalance;
        private DirtyValue<int?> _taxDisbCushion;
        private DirtyValue<decimal?> _totalEscrowReserves;
        private DirtyValue<decimal?> _usdaAnnualFee;
        private DirtyValue<int?> _userDefinedCushion1;
        private DirtyValue<int?> _userDefinedCushion2;
        private DirtyValue<int?> _userDefinedCushion3;
        private DirtyValue<decimal?> _yearlyMortgageInsurance;
        private DirtyValue<decimal?> _yearlyUsdaFee;

        /// <summary>
        /// HUD Annual City Tax Payment [HUD45]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? AnnualCityTax { get => _annualCityTax; set => SetField(ref _annualCityTax, value); }

        /// <summary>
        /// No. Annual Fee Pymts for Cushion [HUD38]
        /// </summary>
        public int? AnnualFeeCushion { get => _annualFeeCushion; set => SetField(ref _annualFeeCushion, value); }

        /// <summary>
        /// HUD Annual Flood Insurance Payment [HUD44]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? AnnualFloodInsurance { get => _annualFloodInsurance; set => SetField(ref _annualFloodInsurance, value); }

        /// <summary>
        /// HUD Annual Hazard Insurance Payment [HUD42]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? AnnualHazardInsurance { get => _annualHazardInsurance; set => SetField(ref _annualHazardInsurance, value); }

        /// <summary>
        /// HUD Annual Mortgage Insurance Payment [HUD43]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? AnnualMortgageInsurance { get => _annualMortgageInsurance; set => SetField(ref _annualMortgageInsurance, value); }

        /// <summary>
        /// HUD Annual Tax Payment [HUD41]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? AnnualTax { get => _annualTax; set => SetField(ref _annualTax, value); }

        /// <summary>
        /// HUD Annual User Escrow Payment 1 [HUD46]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? AnnualUserEscrow1 { get => _annualUserEscrow1; set => SetField(ref _annualUserEscrow1, value); }

        /// <summary>
        /// HUD Annual User Escrow Payment 2 [HUD47]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? AnnualUserEscrow2 { get => _annualUserEscrow2; set => SetField(ref _annualUserEscrow2, value); }

        /// <summary>
        /// HUD Annual User Escrow Payment 3 [HUD48]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? AnnualUserEscrow3 { get => _annualUserEscrow3; set => SetField(ref _annualUserEscrow3, value); }

        /// <summary>
        /// HUD Biweekly Escrow Payment - City Property Taxes [HUD56]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? BiweeklyCityPropertyTaxes { get => _biweeklyCityPropertyTaxes; set => SetField(ref _biweeklyCityPropertyTaxes, value); }

        /// <summary>
        /// HUD Biweekly Escrow Payment - County Taxes [HUD52]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? BiweeklyCountyTaxes { get => _biweeklyCountyTaxes; set => SetField(ref _biweeklyCountyTaxes, value); }

        /// <summary>
        /// HUD Biweekly Escrow Payment - Flood Insurance [HUD55]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? BiweeklyFloodInsurance { get => _biweeklyFloodInsurance; set => SetField(ref _biweeklyFloodInsurance, value); }

        /// <summary>
        /// HUD Biweekly Escrow Payment - Hazard Insurance [HUD53]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? BiweeklyHazardInsurance { get => _biweeklyHazardInsurance; set => SetField(ref _biweeklyHazardInsurance, value); }

        /// <summary>
        /// HUD Biweekly Escrow Payment - Mortgage Insurance [HUD54]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? BiweeklyMortgageInsurance { get => _biweeklyMortgageInsurance; set => SetField(ref _biweeklyMortgageInsurance, value); }

        /// <summary>
        /// HUD Biweekly Escrow Payment - PITI [HUD51]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? BiweeklyPITI { get => _biweeklyPITI; set => SetField(ref _biweeklyPITI, value); }

        /// <summary>
        /// HUD Biweekly Escrow Payment - Total Biweekly Payment Amount [HUD64]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? BiweeklyTotalBiweeklyPayment { get => _biweeklyTotalBiweeklyPayment; set => SetField(ref _biweeklyTotalBiweeklyPayment, value); }

        /// <summary>
        /// HUD Biweekly Escrow Payment - Total Biweekly Payment to Escrow [HUD65]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? BiweeklyTotalBiweeklyPaymentToEscrow { get => _biweeklyTotalBiweeklyPaymentToEscrow; set => SetField(ref _biweeklyTotalBiweeklyPaymentToEscrow, value); }

        /// <summary>
        /// HUD Biweekly Escrow Payment - USDA Annual Fee [HUD63]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? BiweeklyUSDAFee { get => _biweeklyUSDAFee; set => SetField(ref _biweeklyUSDAFee, value); }

        /// <summary>
        /// HUD Biweekly Escrow Payment - User Defined Escrow Fee 1 [HUD58]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? BiweeklyUserDefinedEscrowFee1 { get => _biweeklyUserDefinedEscrowFee1; set => SetField(ref _biweeklyUserDefinedEscrowFee1, value); }

        /// <summary>
        /// HUD Biweekly Escrow Payment - User Defined Escrow Fee 2 [HUD60]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? BiweeklyUserDefinedEscrowFee2 { get => _biweeklyUserDefinedEscrowFee2; set => SetField(ref _biweeklyUserDefinedEscrowFee2, value); }

        /// <summary>
        /// HUD Biweekly Escrow Payment - User Defined Escrow Fee 3 [HUD62]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? BiweeklyUserDefinedEscrowFee3 { get => _biweeklyUserDefinedEscrowFee3; set => SetField(ref _biweeklyUserDefinedEscrowFee3, value); }

        /// <summary>
        /// HUD1ES City Property Tax Pay To Address [VEND.X333]
        /// </summary>
        public string CityPropertyTaxAddress { get => _cityPropertyTaxAddress; set => SetField(ref _cityPropertyTaxAddress, value); }

        /// <summary>
        /// HUD1ES City Property Tax Pay To Amount Last Paid [VEND.X450]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? CityPropertyTaxAmountLastPay { get => _cityPropertyTaxAmountLastPay; set => SetField(ref _cityPropertyTaxAmountLastPay, value); }

        /// <summary>
        /// HUD1ES City Property Tax Pay To Amount Next Due [VEND.X452]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? CityPropertyTaxAmountNextDue { get => _cityPropertyTaxAmountNextDue; set => SetField(ref _cityPropertyTaxAmountNextDue, value); }

        /// <summary>
        /// HUD1ES City Property Tax Pay To City [VEND.X334]
        /// </summary>
        public string CityPropertyTaxCity { get => _cityPropertyTaxCity; set => SetField(ref _cityPropertyTaxCity, value); }

        /// <summary>
        /// HUD1ES City Property Tax Pay To Contact [VEND.X337]
        /// </summary>
        public string CityPropertyTaxContactName { get => _cityPropertyTaxContactName; set => SetField(ref _cityPropertyTaxContactName, value); }

        /// <summary>
        /// HUD1ES City Property Tax Pay To Date Paid [VEND.X451]
        /// </summary>
        public DateTime? CityPropertyTaxDatePaid { get => _cityPropertyTaxDatePaid; set => SetField(ref _cityPropertyTaxDatePaid, value); }

        /// <summary>
        /// HUD1ES City Property Tax Pay To Delinquent Date [VEND.X454]
        /// </summary>
        public DateTime? CityPropertyTaxDelinquentDate { get => _cityPropertyTaxDelinquentDate; set => SetField(ref _cityPropertyTaxDelinquentDate, value); }

        /// <summary>
        /// HUD1ES City Property Tax Pay To Email [VEND.X339]
        /// </summary>
        public string CityPropertyTaxEmail { get => _cityPropertyTaxEmail; set => SetField(ref _cityPropertyTaxEmail, value); }

        /// <summary>
        /// Fees City Property Tax Pay To Fax [VEND.X340]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
        public string CityPropertyTaxFax { get => _cityPropertyTaxFax; set => SetField(ref _cityPropertyTaxFax, value); }

        /// <summary>
        /// HUD1ES City Property Tax Pay To Name [VEND.X332]
        /// </summary>
        public string CityPropertyTaxName { get => _cityPropertyTaxName; set => SetField(ref _cityPropertyTaxName, value); }

        /// <summary>
        /// HUD1ES City Property Tax Pay To Next Due Date [VEND.X453]
        /// </summary>
        public DateTime? CityPropertyTaxNextDueDate { get => _cityPropertyTaxNextDueDate; set => SetField(ref _cityPropertyTaxNextDueDate, value); }

        /// <summary>
        /// HUD1ES City Property Tax Pay To Payment Schedule [VEND.X449]
        /// </summary>
        public string CityPropertyTaxPaymentSchedule { get => _cityPropertyTaxPaymentSchedule; set => SetField(ref _cityPropertyTaxPaymentSchedule, value); }

        /// <summary>
        /// HUD1ES City Property Tax Pay To Phone [VEND.X338]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
        public string CityPropertyTaxPhone { get => _cityPropertyTaxPhone; set => SetField(ref _cityPropertyTaxPhone, value); }

        /// <summary>
        /// HUD1ES City Property Tax Pay To Zip [VEND.X336]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
        public string CityPropertyTaxPostalCode { get => _cityPropertyTaxPostalCode; set => SetField(ref _cityPropertyTaxPostalCode, value); }

        /// <summary>
        /// HUD1ES City Property Tax Pay To State [VEND.X335]
        /// </summary>
        public StringEnumValue<State> CityPropertyTaxState { get => _cityPropertyTaxState; set => SetField(ref _cityPropertyTaxState, value); }

        /// <summary>
        /// HUD Ending Balance [HUD25]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? EndingBalance { get => _endingBalance; set => SetField(ref _endingBalance, value); }

        /// <summary>
        /// Escrow First Payment Date [HUD68]
        /// </summary>
        public DateTime? EscrowFirstPaymentDate { get => _escrowFirstPaymentDate; set => SetField(ref _escrowFirstPaymentDate, value); }

        /// <summary>
        /// Escrow First Payment Date Type [HUD69]
        /// </summary>
        public StringEnumValue<EscrowFirstPaymentDateType> EscrowFirstPaymentDateType { get => _escrowFirstPaymentDateType; set => SetField(ref _escrowFirstPaymentDateType, value); }

        /// <summary>
        /// HUD Escrow Monthly Payment [HUD24]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? EscrowPayment { get => _escrowPayment; set => SetField(ref _escrowPayment, value); }

        /// <summary>
        /// HUD Escrow Yearly Payment [HUD66]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? EscrowPaymentYearly { get => _escrowPaymentYearly; set => SetField(ref _escrowPaymentYearly, value); }

        /// <summary>
        /// No. Flood Ins Pymts for Cushion [HUD33]
        /// </summary>
        public int? FloodInsDisbCushion { get => _floodInsDisbCushion; set => SetField(ref _floodInsDisbCushion, value); }

        /// <summary>
        /// No. Hazard Ins Pymts for Cushion [HUD31]
        /// </summary>
        public int? HazInsDisbCushion { get => _hazInsDisbCushion; set => SetField(ref _hazInsDisbCushion, value); }

        /// <summary>
        /// Hud1Es Hud1EsDates
        /// </summary>
        public IList<Hud1EsDate> Hud1EsDates { get => GetField(ref _hud1EsDates); set => SetField(ref _hud1EsDates, value); }

        /// <summary>
        /// Hud1Es Hud1EsDueDates
        /// </summary>
        public IList<Hud1EsDueDate> Hud1EsDueDates { get => GetField(ref _hud1EsDueDates); set => SetField(ref _hud1EsDueDates, value); }

        /// <summary>
        /// Hud1Es Hud1EsItemizes
        /// </summary>
        public IList<Hud1EsItemize> Hud1EsItemizes { get => GetField(ref _hud1EsItemizes); set => SetField(ref _hud1EsItemizes, value); }

        /// <summary>
        /// Itemize Escrow Number of Lines in Escrow Output [AEA.X1]
        /// </summary>
        public int? Hud1EsItemizesTotalLines { get => _hud1EsItemizesTotalLines; set => SetField(ref _hud1EsItemizesTotalLines, value); }

        /// <summary>
        /// Itemize Escrow Use Itemize Escrow Output Format [AEA.X2]
        /// </summary>
        public bool? Hud1EsItemizesUseItemizeEscrowIndicator { get => _hud1EsItemizesUseItemizeEscrowIndicator; set => SetField(ref _hud1EsItemizesUseItemizeEscrowIndicator, value); }

        /// <summary>
        /// Hud1Es Hud1EsPayTos
        /// </summary>
        public IList<Hud1EsPayTo> Hud1EsPayTos { get => GetField(ref _hud1EsPayTos); set => SetField(ref _hud1EsPayTos, value); }

        /// <summary>
        /// Hud1Es Hud1EsSetups
        /// </summary>
        public IList<Hud1EsSetup> Hud1EsSetups { get => GetField(ref _hud1EsSetups); set => SetField(ref _hud1EsSetups, value); }

        /// <summary>
        /// Hud1Es Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }

        /// <summary>
        /// Servicer to refund Mtg Ins Cushion upon termination [HUD49]
        /// </summary>
        public bool? MtgInsCushionTerminationIndicator { get => _mtgInsCushionTerminationIndicator; set => SetField(ref _mtgInsCushionTerminationIndicator, value); }

        /// <summary>
        /// No. Mtg Ins Pymts for Cushion [HUD32]
        /// </summary>
        public int? MtgInsDisbCushion { get => _mtgInsDisbCushion; set => SetField(ref _mtgInsDisbCushion, value); }

        /// <summary>
        /// HUD Non Escrow Yearly Costs [HUD67]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? NonEscrowCostsYearly { get => _nonEscrowCostsYearly; set => SetField(ref _nonEscrowCostsYearly, value); }

        /// <summary>
        /// HUD1ES Tax Pay To Address [VEND.X324]
        /// </summary>
        public string RealEstateTaxAddress { get => _realEstateTaxAddress; set => SetField(ref _realEstateTaxAddress, value); }

        /// <summary>
        /// HUD1ES Tax Pay To Amount Last Paid [VEND.X438]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? RealEstateTaxAmountLastPay { get => _realEstateTaxAmountLastPay; set => SetField(ref _realEstateTaxAmountLastPay, value); }

        /// <summary>
        /// HUD1ES Tax Pay To Amount Next Due [VEND.X440]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? RealEstateTaxAmountNextDue { get => _realEstateTaxAmountNextDue; set => SetField(ref _realEstateTaxAmountNextDue, value); }

        /// <summary>
        /// HUD1ES Tax Pay To City [VEND.X325]
        /// </summary>
        public string RealEstateTaxCity { get => _realEstateTaxCity; set => SetField(ref _realEstateTaxCity, value); }

        /// <summary>
        /// HUD1ES Tax Pay To Contact Name [VEND.X328]
        /// </summary>
        public string RealEstateTaxContactName { get => _realEstateTaxContactName; set => SetField(ref _realEstateTaxContactName, value); }

        /// <summary>
        /// HUD1ES Tax Pay To Date Paid [VEND.X439]
        /// </summary>
        public DateTime? RealEstateTaxDatePaid { get => _realEstateTaxDatePaid; set => SetField(ref _realEstateTaxDatePaid, value); }

        /// <summary>
        /// HUD1ES Tax Pay To Delinquent Date [VEND.X442]
        /// </summary>
        public DateTime? RealEstateTaxDelinquentDate { get => _realEstateTaxDelinquentDate; set => SetField(ref _realEstateTaxDelinquentDate, value); }

        /// <summary>
        /// HUD1ES Tax Pay To Email [VEND.X330]
        /// </summary>
        public string RealEstateTaxEmail { get => _realEstateTaxEmail; set => SetField(ref _realEstateTaxEmail, value); }

        /// <summary>
        /// HUD1ES Tax Pay To Fax [VEND.X331]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
        public string RealEstateTaxFax { get => _realEstateTaxFax; set => SetField(ref _realEstateTaxFax, value); }

        /// <summary>
        /// HUD1ES Tax Pay To Name [VEND.X323]
        /// </summary>
        public string RealEstateTaxName { get => _realEstateTaxName; set => SetField(ref _realEstateTaxName, value); }

        /// <summary>
        /// HUD1ES Tax Pay To Next Due Date [VEND.X441]
        /// </summary>
        public DateTime? RealEstateTaxNextDueDate { get => _realEstateTaxNextDueDate; set => SetField(ref _realEstateTaxNextDueDate, value); }

        /// <summary>
        /// HUD1ES Tax Pay To Payment Schedule [VEND.X437]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string RealEstateTaxPaymentSchedule { get => _realEstateTaxPaymentSchedule; set => SetField(ref _realEstateTaxPaymentSchedule, value); }

        /// <summary>
        /// HUD1ES Tax Pay To Phone [VEND.X329]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
        public string RealEstateTaxPhone { get => _realEstateTaxPhone; set => SetField(ref _realEstateTaxPhone, value); }

        /// <summary>
        /// HUD1ES Tax Pay To Zip [VEND.X327]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
        public string RealEstateTaxPostalCode { get => _realEstateTaxPostalCode; set => SetField(ref _realEstateTaxPostalCode, value); }

        /// <summary>
        /// HUD1ES Tax Pay To State [VEND.X326]
        /// </summary>
        public StringEnumValue<State> RealEstateTaxState { get => _realEstateTaxState; set => SetField(ref _realEstateTaxState, value); }

        /// <summary>
        /// No. City Tax Pymts for Cushion [HUD34]
        /// </summary>
        public int? SchoolTaxesCushion { get => _schoolTaxesCushion; set => SetField(ref _schoolTaxesCushion, value); }

        /// <summary>
        /// Escrow Servicer Address [L631]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string ServicerAddress { get => _servicerAddress; set => SetField(ref _servicerAddress, value); }

        /// <summary>
        /// Escrow Servicer City [L632]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string ServicerCity { get => _servicerCity; set => SetField(ref _servicerCity, value); }

        /// <summary>
        /// Escrow Servicer Name [L611]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string ServicerContactName { get => _servicerContactName; set => SetField(ref _servicerContactName, value); }

        /// <summary>
        /// Escrow Servicer Phone [L635]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE, ReadOnly = true)]
        public string ServicerPhone { get => _servicerPhone; set => SetField(ref _servicerPhone, value); }

        /// <summary>
        /// Escrow Servicer Zipcode [L634]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE, ReadOnly = true)]
        public string ServicerPostalCode { get => _servicerPostalCode; set => SetField(ref _servicerPostalCode, value); }

        /// <summary>
        /// Escrow Servicer State [L633]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public StringEnumValue<State> ServicerState { get => _servicerState; set => SetField(ref _servicerState, value); }

        /// <summary>
        /// HUD Single Line Analysis [HUD40]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? SingleLineAnalysis { get => _singleLineAnalysis; set => SetField(ref _singleLineAnalysis, value); }

        /// <summary>
        /// HUD Starting Balance [HUD23]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? StartingBalance { get => _startingBalance; set => SetField(ref _startingBalance, value); }

        /// <summary>
        /// No. Tax Pymts for Cushion [HUD30]
        /// </summary>
        public int? TaxDisbCushion { get => _taxDisbCushion; set => SetField(ref _taxDisbCushion, value); }

        /// <summary>
        /// HUD Total Escrow Reserves [HUD26]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? TotalEscrowReserves { get => _totalEscrowReserves; set => SetField(ref _totalEscrowReserves, value); }

        /// <summary>
        /// HUD USDA Annual Fee [HUD50]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? UsdaAnnualFee { get => _usdaAnnualFee; set => SetField(ref _usdaAnnualFee, value); }

        /// <summary>
        /// No. User Defined 1 Pymts for Cushion [HUD35]
        /// </summary>
        public int? UserDefinedCushion1 { get => _userDefinedCushion1; set => SetField(ref _userDefinedCushion1, value); }

        /// <summary>
        /// No. User Defined 2 Pymts for Cushion [HUD36]
        /// </summary>
        public int? UserDefinedCushion2 { get => _userDefinedCushion2; set => SetField(ref _userDefinedCushion2, value); }

        /// <summary>
        /// No. User Defined 3 Pymts for Cushion [HUD37]
        /// </summary>
        public int? UserDefinedCushion3 { get => _userDefinedCushion3; set => SetField(ref _userDefinedCushion3, value); }

        /// <summary>
        /// HUD Yearly Mortgage Insurance Before Rounding [HUD.YearlyMIFee]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? YearlyMortgageInsurance { get => _yearlyMortgageInsurance; set => SetField(ref _yearlyMortgageInsurance, value); }

        /// <summary>
        /// HUD Yearly USDA Fee Before Monthly Payment Rounding [HUD.YearlyUSDAFee]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? YearlyUsdaFee { get => _yearlyUsdaFee; set => SetField(ref _yearlyUsdaFee, value); }
    }
}