using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// Hud1Es
    /// </summary>
    public sealed partial class Hud1Es : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<decimal?> _annualCityTax;
        /// <summary>
        /// HUD Annual City Tax Payment [HUD45]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "HUD Annual City Tax Payment")]
        public decimal? AnnualCityTax { get => _annualCityTax; set => _annualCityTax = value; }
        private DirtyValue<int?> _annualFeeCushion;
        /// <summary>
        /// No. Annual Fee Pymts for Cushion [HUD38]
        /// </summary>
        [LoanFieldProperty(Description = "No. Annual Fee Pymts for Cushion")]
        public int? AnnualFeeCushion { get => _annualFeeCushion; set => _annualFeeCushion = value; }
        private DirtyValue<decimal?> _annualFloodInsurance;
        /// <summary>
        /// HUD Annual Flood Insurance Payment [HUD44]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "HUD Annual Flood Insurance Payment")]
        public decimal? AnnualFloodInsurance { get => _annualFloodInsurance; set => _annualFloodInsurance = value; }
        private DirtyValue<decimal?> _annualHazardInsurance;
        /// <summary>
        /// HUD Annual Hazard Insurance Payment [HUD42]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "HUD Annual Hazard Insurance Payment")]
        public decimal? AnnualHazardInsurance { get => _annualHazardInsurance; set => _annualHazardInsurance = value; }
        private DirtyValue<decimal?> _annualMortgageInsurance;
        /// <summary>
        /// HUD Annual Mortgage Insurance Payment [HUD43]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "HUD Annual Mortgage Insurance Payment")]
        public decimal? AnnualMortgageInsurance { get => _annualMortgageInsurance; set => _annualMortgageInsurance = value; }
        private DirtyValue<decimal?> _annualTax;
        /// <summary>
        /// HUD Annual Tax Payment [HUD41]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "HUD Annual Tax Payment")]
        public decimal? AnnualTax { get => _annualTax; set => _annualTax = value; }
        private DirtyValue<decimal?> _annualUserEscrow1;
        /// <summary>
        /// HUD Annual User Escrow Payment 1 [HUD46]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "HUD Annual User Escrow Payment 1")]
        public decimal? AnnualUserEscrow1 { get => _annualUserEscrow1; set => _annualUserEscrow1 = value; }
        private DirtyValue<decimal?> _annualUserEscrow2;
        /// <summary>
        /// HUD Annual User Escrow Payment 2 [HUD47]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "HUD Annual User Escrow Payment 2")]
        public decimal? AnnualUserEscrow2 { get => _annualUserEscrow2; set => _annualUserEscrow2 = value; }
        private DirtyValue<decimal?> _annualUserEscrow3;
        /// <summary>
        /// HUD Annual User Escrow Payment 3 [HUD48]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "HUD Annual User Escrow Payment 3")]
        public decimal? AnnualUserEscrow3 { get => _annualUserEscrow3; set => _annualUserEscrow3 = value; }
        private DirtyValue<decimal?> _biweeklyCityPropertyTaxes;
        /// <summary>
        /// HUD Biweekly Escrow Payment - City Property Taxes [HUD56]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "HUD Biweekly Escrow Payment - City Property Taxes")]
        public decimal? BiweeklyCityPropertyTaxes { get => _biweeklyCityPropertyTaxes; set => _biweeklyCityPropertyTaxes = value; }
        private DirtyValue<decimal?> _biweeklyCountyTaxes;
        /// <summary>
        /// HUD Biweekly Escrow Payment - County Taxes [HUD52]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "HUD Biweekly Escrow Payment - County Taxes")]
        public decimal? BiweeklyCountyTaxes { get => _biweeklyCountyTaxes; set => _biweeklyCountyTaxes = value; }
        private DirtyValue<decimal?> _biweeklyFloodInsurance;
        /// <summary>
        /// HUD Biweekly Escrow Payment - Flood Insurance [HUD55]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "HUD Biweekly Escrow Payment - Flood Insurance")]
        public decimal? BiweeklyFloodInsurance { get => _biweeklyFloodInsurance; set => _biweeklyFloodInsurance = value; }
        private DirtyValue<decimal?> _biweeklyHazardInsurance;
        /// <summary>
        /// HUD Biweekly Escrow Payment - Hazard Insurance [HUD53]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "HUD Biweekly Escrow Payment - Hazard Insurance")]
        public decimal? BiweeklyHazardInsurance { get => _biweeklyHazardInsurance; set => _biweeklyHazardInsurance = value; }
        private DirtyValue<decimal?> _biweeklyMortgageInsurance;
        /// <summary>
        /// HUD Biweekly Escrow Payment - Mortgage Insurance [HUD54]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "HUD Biweekly Escrow Payment - Mortgage Insurance")]
        public decimal? BiweeklyMortgageInsurance { get => _biweeklyMortgageInsurance; set => _biweeklyMortgageInsurance = value; }
        private DirtyValue<decimal?> _biweeklyPITI;
        /// <summary>
        /// HUD Biweekly Escrow Payment - PITI [HUD51]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "HUD Biweekly Escrow Payment - PITI")]
        public decimal? BiweeklyPITI { get => _biweeklyPITI; set => _biweeklyPITI = value; }
        private DirtyValue<decimal?> _biweeklyTotalBiweeklyPayment;
        /// <summary>
        /// HUD Biweekly Escrow Payment - Total Biweekly Payment Amount [HUD64]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "HUD Biweekly Escrow Payment - Total Biweekly Payment Amount")]
        public decimal? BiweeklyTotalBiweeklyPayment { get => _biweeklyTotalBiweeklyPayment; set => _biweeklyTotalBiweeklyPayment = value; }
        private DirtyValue<decimal?> _biweeklyTotalBiweeklyPaymentToEscrow;
        /// <summary>
        /// HUD Biweekly Escrow Payment - Total Biweekly Payment to Escrow [HUD65]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "HUD Biweekly Escrow Payment - Total Biweekly Payment to Escrow")]
        public decimal? BiweeklyTotalBiweeklyPaymentToEscrow { get => _biweeklyTotalBiweeklyPaymentToEscrow; set => _biweeklyTotalBiweeklyPaymentToEscrow = value; }
        private DirtyValue<decimal?> _biweeklyUSDAFee;
        /// <summary>
        /// HUD Biweekly Escrow Payment - USDA Annual Fee [HUD63]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "HUD Biweekly Escrow Payment - USDA Annual Fee")]
        public decimal? BiweeklyUSDAFee { get => _biweeklyUSDAFee; set => _biweeklyUSDAFee = value; }
        private DirtyValue<decimal?> _biweeklyUserDefinedEscrowFee1;
        /// <summary>
        /// HUD Biweekly Escrow Payment - User Defined Escrow Fee 1 [HUD58]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "HUD Biweekly Escrow Payment - User Defined Escrow Fee 1")]
        public decimal? BiweeklyUserDefinedEscrowFee1 { get => _biweeklyUserDefinedEscrowFee1; set => _biweeklyUserDefinedEscrowFee1 = value; }
        private DirtyValue<decimal?> _biweeklyUserDefinedEscrowFee2;
        /// <summary>
        /// HUD Biweekly Escrow Payment - User Defined Escrow Fee 2 [HUD60]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "HUD Biweekly Escrow Payment - User Defined Escrow Fee 2")]
        public decimal? BiweeklyUserDefinedEscrowFee2 { get => _biweeklyUserDefinedEscrowFee2; set => _biweeklyUserDefinedEscrowFee2 = value; }
        private DirtyValue<decimal?> _biweeklyUserDefinedEscrowFee3;
        /// <summary>
        /// HUD Biweekly Escrow Payment - User Defined Escrow Fee 3 [HUD62]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "HUD Biweekly Escrow Payment - User Defined Escrow Fee 3")]
        public decimal? BiweeklyUserDefinedEscrowFee3 { get => _biweeklyUserDefinedEscrowFee3; set => _biweeklyUserDefinedEscrowFee3 = value; }
        private DirtyValue<string> _cityPropertyTaxAddress;
        /// <summary>
        /// HUD1ES City Property Tax Pay To Address [VEND.X333]
        /// </summary>
        [LoanFieldProperty(Description = "HUD1ES City Property Tax Pay To Address")]
        public string CityPropertyTaxAddress { get => _cityPropertyTaxAddress; set => _cityPropertyTaxAddress = value; }
        private DirtyValue<decimal?> _cityPropertyTaxAmountLastPay;
        /// <summary>
        /// HUD1ES City Property Tax Pay To Amount Last Paid [VEND.X450]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "HUD1ES City Property Tax Pay To Amount Last Paid")]
        public decimal? CityPropertyTaxAmountLastPay { get => _cityPropertyTaxAmountLastPay; set => _cityPropertyTaxAmountLastPay = value; }
        private DirtyValue<decimal?> _cityPropertyTaxAmountNextDue;
        /// <summary>
        /// HUD1ES City Property Tax Pay To Amount Next Due [VEND.X452]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "HUD1ES City Property Tax Pay To Amount Next Due")]
        public decimal? CityPropertyTaxAmountNextDue { get => _cityPropertyTaxAmountNextDue; set => _cityPropertyTaxAmountNextDue = value; }
        private DirtyValue<string> _cityPropertyTaxCity;
        /// <summary>
        /// HUD1ES City Property Tax Pay To City [VEND.X334]
        /// </summary>
        [LoanFieldProperty(Description = "HUD1ES City Property Tax Pay To City")]
        public string CityPropertyTaxCity { get => _cityPropertyTaxCity; set => _cityPropertyTaxCity = value; }
        private DirtyValue<string> _cityPropertyTaxContactName;
        /// <summary>
        /// HUD1ES City Property Tax Pay To Contact [VEND.X337]
        /// </summary>
        [LoanFieldProperty(Description = "HUD1ES City Property Tax Pay To Contact")]
        public string CityPropertyTaxContactName { get => _cityPropertyTaxContactName; set => _cityPropertyTaxContactName = value; }
        private DirtyValue<DateTime?> _cityPropertyTaxDatePaid;
        /// <summary>
        /// HUD1ES City Property Tax Pay To Date Paid [VEND.X451]
        /// </summary>
        [LoanFieldProperty(Description = "HUD1ES City Property Tax Pay To Date Paid")]
        public DateTime? CityPropertyTaxDatePaid { get => _cityPropertyTaxDatePaid; set => _cityPropertyTaxDatePaid = value; }
        private DirtyValue<DateTime?> _cityPropertyTaxDelinquentDate;
        /// <summary>
        /// HUD1ES City Property Tax Pay To Delinquent Date [VEND.X454]
        /// </summary>
        [LoanFieldProperty(Description = "HUD1ES City Property Tax Pay To Delinquent Date")]
        public DateTime? CityPropertyTaxDelinquentDate { get => _cityPropertyTaxDelinquentDate; set => _cityPropertyTaxDelinquentDate = value; }
        private DirtyValue<string> _cityPropertyTaxEmail;
        /// <summary>
        /// HUD1ES City Property Tax Pay To Email [VEND.X339]
        /// </summary>
        [LoanFieldProperty(Description = "HUD1ES City Property Tax Pay To Email")]
        public string CityPropertyTaxEmail { get => _cityPropertyTaxEmail; set => _cityPropertyTaxEmail = value; }
        private DirtyValue<string> _cityPropertyTaxFax;
        /// <summary>
        /// Fees City Property Tax Pay To Fax [VEND.X340]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE, Description = "Fees City Property Tax Pay To Fax")]
        public string CityPropertyTaxFax { get => _cityPropertyTaxFax; set => _cityPropertyTaxFax = value; }
        private DirtyValue<string> _cityPropertyTaxName;
        /// <summary>
        /// HUD1ES City Property Tax Pay To Name [VEND.X332]
        /// </summary>
        [LoanFieldProperty(Description = "HUD1ES City Property Tax Pay To Name")]
        public string CityPropertyTaxName { get => _cityPropertyTaxName; set => _cityPropertyTaxName = value; }
        private DirtyValue<DateTime?> _cityPropertyTaxNextDueDate;
        /// <summary>
        /// HUD1ES City Property Tax Pay To Next Due Date [VEND.X453]
        /// </summary>
        [LoanFieldProperty(Description = "HUD1ES City Property Tax Pay To Next Due Date")]
        public DateTime? CityPropertyTaxNextDueDate { get => _cityPropertyTaxNextDueDate; set => _cityPropertyTaxNextDueDate = value; }
        private DirtyValue<string> _cityPropertyTaxPaymentSchedule;
        /// <summary>
        /// HUD1ES City Property Tax Pay To Payment Schedule [VEND.X449]
        /// </summary>
        [LoanFieldProperty(Description = "HUD1ES City Property Tax Pay To Payment Schedule")]
        public string CityPropertyTaxPaymentSchedule { get => _cityPropertyTaxPaymentSchedule; set => _cityPropertyTaxPaymentSchedule = value; }
        private DirtyValue<string> _cityPropertyTaxPhone;
        /// <summary>
        /// HUD1ES City Property Tax Pay To Phone [VEND.X338]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE, Description = "HUD1ES City Property Tax Pay To Phone")]
        public string CityPropertyTaxPhone { get => _cityPropertyTaxPhone; set => _cityPropertyTaxPhone = value; }
        private DirtyValue<string> _cityPropertyTaxPostalCode;
        /// <summary>
        /// HUD1ES City Property Tax Pay To Zip [VEND.X336]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE, Description = "HUD1ES City Property Tax Pay To Zip")]
        public string CityPropertyTaxPostalCode { get => _cityPropertyTaxPostalCode; set => _cityPropertyTaxPostalCode = value; }
        private DirtyValue<string> _cityPropertyTaxState;
        /// <summary>
        /// HUD1ES City Property Tax Pay To State [VEND.X335]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.STATE, Description = "HUD1ES City Property Tax Pay To State")]
        public string CityPropertyTaxState { get => _cityPropertyTaxState; set => _cityPropertyTaxState = value; }
        private DirtyValue<decimal?> _endingBalance;
        /// <summary>
        /// HUD Ending Balance [HUD25]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "HUD Ending Balance")]
        public decimal? EndingBalance { get => _endingBalance; set => _endingBalance = value; }
        private DirtyValue<DateTime?> _escrowFirstPaymentDate;
        /// <summary>
        /// Escrow First Payment Date [HUD68]
        /// </summary>
        [LoanFieldProperty(Description = "Escrow First Payment Date")]
        public DateTime? EscrowFirstPaymentDate { get => _escrowFirstPaymentDate; set => _escrowFirstPaymentDate = value; }
        private DirtyValue<StringEnumValue<EscrowFirstPaymentDateType>> _escrowFirstPaymentDateType;
        /// <summary>
        /// Escrow First Payment Date Type [HUD69]
        /// </summary>
        [LoanFieldProperty(Description = "Escrow First Payment Date Type")]
        public StringEnumValue<EscrowFirstPaymentDateType> EscrowFirstPaymentDateType { get => _escrowFirstPaymentDateType; set => _escrowFirstPaymentDateType = value; }
        private DirtyValue<decimal?> _escrowPayment;
        /// <summary>
        /// HUD Escrow Monthly Payment [HUD24]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "HUD Escrow Monthly Payment")]
        public decimal? EscrowPayment { get => _escrowPayment; set => _escrowPayment = value; }
        private DirtyValue<decimal?> _escrowPaymentYearly;
        /// <summary>
        /// HUD Escrow Yearly Payment [HUD66]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "HUD Escrow Yearly Payment")]
        public decimal? EscrowPaymentYearly { get => _escrowPaymentYearly; set => _escrowPaymentYearly = value; }
        private DirtyValue<int?> _floodInsDisbCushion;
        /// <summary>
        /// No. Flood Ins Pymts for Cushion [HUD33]
        /// </summary>
        [LoanFieldProperty(Description = "No. Flood Ins Pymts for Cushion")]
        public int? FloodInsDisbCushion { get => _floodInsDisbCushion; set => _floodInsDisbCushion = value; }
        private DirtyValue<int?> _hazInsDisbCushion;
        /// <summary>
        /// No. Hazard Ins Pymts for Cushion [HUD31]
        /// </summary>
        [LoanFieldProperty(Description = "No. Hazard Ins Pymts for Cushion")]
        public int? HazInsDisbCushion { get => _hazInsDisbCushion; set => _hazInsDisbCushion = value; }
        private DirtyList<Hud1EsDate> _hud1EsDates;
        /// <summary>
        /// Hud1Es Hud1EsDates
        /// </summary>
        public IList<Hud1EsDate> Hud1EsDates { get => _hud1EsDates ?? (_hud1EsDates = new DirtyList<Hud1EsDate>()); set => _hud1EsDates = new DirtyList<Hud1EsDate>(value); }
        private DirtyList<Hud1EsDueDate> _hud1EsDueDates;
        /// <summary>
        /// Hud1Es Hud1EsDueDates
        /// </summary>
        public IList<Hud1EsDueDate> Hud1EsDueDates { get => _hud1EsDueDates ?? (_hud1EsDueDates = new DirtyList<Hud1EsDueDate>()); set => _hud1EsDueDates = new DirtyList<Hud1EsDueDate>(value); }
        private DirtyList<Hud1EsItemize> _hud1EsItemizes;
        /// <summary>
        /// Hud1Es Hud1EsItemizes
        /// </summary>
        public IList<Hud1EsItemize> Hud1EsItemizes { get => _hud1EsItemizes ?? (_hud1EsItemizes = new DirtyList<Hud1EsItemize>()); set => _hud1EsItemizes = new DirtyList<Hud1EsItemize>(value); }
        private DirtyValue<int?> _hud1EsItemizesTotalLines;
        /// <summary>
        /// Itemize Escrow Number of Lines in Escrow Output [AEA.X1]
        /// </summary>
        [LoanFieldProperty(Description = "Itemize Escrow Number of Lines in Escrow Output")]
        public int? Hud1EsItemizesTotalLines { get => _hud1EsItemizesTotalLines; set => _hud1EsItemizesTotalLines = value; }
        private DirtyValue<bool?> _hud1EsItemizesUseItemizeEscrowIndicator;
        /// <summary>
        /// Itemize Escrow Use Itemize Escrow Output Format [AEA.X2]
        /// </summary>
        [LoanFieldProperty(Description = "Itemize Escrow Use Itemize Escrow Output Format")]
        public bool? Hud1EsItemizesUseItemizeEscrowIndicator { get => _hud1EsItemizesUseItemizeEscrowIndicator; set => _hud1EsItemizesUseItemizeEscrowIndicator = value; }
        private DirtyList<Hud1EsPayTo> _hud1EsPayTos;
        /// <summary>
        /// Hud1Es Hud1EsPayTos
        /// </summary>
        public IList<Hud1EsPayTo> Hud1EsPayTos { get => _hud1EsPayTos ?? (_hud1EsPayTos = new DirtyList<Hud1EsPayTo>()); set => _hud1EsPayTos = new DirtyList<Hud1EsPayTo>(value); }
        private DirtyList<Hud1EsSetup> _hud1EsSetups;
        /// <summary>
        /// Hud1Es Hud1EsSetups
        /// </summary>
        public IList<Hud1EsSetup> Hud1EsSetups { get => _hud1EsSetups ?? (_hud1EsSetups = new DirtyList<Hud1EsSetup>()); set => _hud1EsSetups = new DirtyList<Hud1EsSetup>(value); }
        private DirtyValue<string> _id;
        /// <summary>
        /// Hud1Es Id
        /// </summary>
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<bool?> _mtgInsCushionTerminationIndicator;
        /// <summary>
        /// Servicer to refund Mtg Ins Cushion upon termination [HUD49]
        /// </summary>
        [LoanFieldProperty(Description = "Servicer to refund Mtg Ins Cushion upon termination")]
        public bool? MtgInsCushionTerminationIndicator { get => _mtgInsCushionTerminationIndicator; set => _mtgInsCushionTerminationIndicator = value; }
        private DirtyValue<int?> _mtgInsDisbCushion;
        /// <summary>
        /// No. Mtg Ins Pymts for Cushion [HUD32]
        /// </summary>
        [LoanFieldProperty(Description = "No. Mtg Ins Pymts for Cushion")]
        public int? MtgInsDisbCushion { get => _mtgInsDisbCushion; set => _mtgInsDisbCushion = value; }
        private DirtyValue<decimal?> _nonEscrowCostsYearly;
        /// <summary>
        /// HUD Non Escrow Yearly Costs [HUD67]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "HUD Non Escrow Yearly Costs")]
        public decimal? NonEscrowCostsYearly { get => _nonEscrowCostsYearly; set => _nonEscrowCostsYearly = value; }
        private DirtyValue<string> _realEstateTaxAddress;
        /// <summary>
        /// HUD1ES Tax Pay To Address [VEND.X324]
        /// </summary>
        [LoanFieldProperty(Description = "HUD1ES Tax Pay To Address")]
        public string RealEstateTaxAddress { get => _realEstateTaxAddress; set => _realEstateTaxAddress = value; }
        private DirtyValue<decimal?> _realEstateTaxAmountLastPay;
        /// <summary>
        /// HUD1ES Tax Pay To Amount Last Paid [VEND.X438]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "HUD1ES Tax Pay To Amount Last Paid")]
        public decimal? RealEstateTaxAmountLastPay { get => _realEstateTaxAmountLastPay; set => _realEstateTaxAmountLastPay = value; }
        private DirtyValue<decimal?> _realEstateTaxAmountNextDue;
        /// <summary>
        /// HUD1ES Tax Pay To Amount Next Due [VEND.X440]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "HUD1ES Tax Pay To Amount Next Due")]
        public decimal? RealEstateTaxAmountNextDue { get => _realEstateTaxAmountNextDue; set => _realEstateTaxAmountNextDue = value; }
        private DirtyValue<string> _realEstateTaxCity;
        /// <summary>
        /// HUD1ES Tax Pay To City [VEND.X325]
        /// </summary>
        [LoanFieldProperty(Description = "HUD1ES Tax Pay To City")]
        public string RealEstateTaxCity { get => _realEstateTaxCity; set => _realEstateTaxCity = value; }
        private DirtyValue<string> _realEstateTaxContactName;
        /// <summary>
        /// HUD1ES Tax Pay To Contact Name [VEND.X328]
        /// </summary>
        [LoanFieldProperty(Description = "HUD1ES Tax Pay To Contact Name")]
        public string RealEstateTaxContactName { get => _realEstateTaxContactName; set => _realEstateTaxContactName = value; }
        private DirtyValue<DateTime?> _realEstateTaxDatePaid;
        /// <summary>
        /// HUD1ES Tax Pay To Date Paid [VEND.X439]
        /// </summary>
        [LoanFieldProperty(Description = "HUD1ES Tax Pay To Date Paid")]
        public DateTime? RealEstateTaxDatePaid { get => _realEstateTaxDatePaid; set => _realEstateTaxDatePaid = value; }
        private DirtyValue<DateTime?> _realEstateTaxDelinquentDate;
        /// <summary>
        /// HUD1ES Tax Pay To Delinquent Date [VEND.X442]
        /// </summary>
        [LoanFieldProperty(Description = "HUD1ES Tax Pay To Delinquent Date")]
        public DateTime? RealEstateTaxDelinquentDate { get => _realEstateTaxDelinquentDate; set => _realEstateTaxDelinquentDate = value; }
        private DirtyValue<string> _realEstateTaxEmail;
        /// <summary>
        /// HUD1ES Tax Pay To Email [VEND.X330]
        /// </summary>
        [LoanFieldProperty(Description = "HUD1ES Tax Pay To Email")]
        public string RealEstateTaxEmail { get => _realEstateTaxEmail; set => _realEstateTaxEmail = value; }
        private DirtyValue<string> _realEstateTaxFax;
        /// <summary>
        /// HUD1ES Tax Pay To Fax [VEND.X331]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE, Description = "HUD1ES Tax Pay To Fax")]
        public string RealEstateTaxFax { get => _realEstateTaxFax; set => _realEstateTaxFax = value; }
        private DirtyValue<string> _realEstateTaxName;
        /// <summary>
        /// HUD1ES Tax Pay To Name [VEND.X323]
        /// </summary>
        [LoanFieldProperty(Description = "HUD1ES Tax Pay To Name")]
        public string RealEstateTaxName { get => _realEstateTaxName; set => _realEstateTaxName = value; }
        private DirtyValue<DateTime?> _realEstateTaxNextDueDate;
        /// <summary>
        /// HUD1ES Tax Pay To Next Due Date [VEND.X441]
        /// </summary>
        [LoanFieldProperty(Description = "HUD1ES Tax Pay To Next Due Date")]
        public DateTime? RealEstateTaxNextDueDate { get => _realEstateTaxNextDueDate; set => _realEstateTaxNextDueDate = value; }
        private DirtyValue<string> _realEstateTaxPaymentSchedule;
        /// <summary>
        /// HUD1ES Tax Pay To Payment Schedule [VEND.X437]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "HUD1ES Tax Pay To Payment Schedule")]
        public string RealEstateTaxPaymentSchedule { get => _realEstateTaxPaymentSchedule; set => _realEstateTaxPaymentSchedule = value; }
        private DirtyValue<string> _realEstateTaxPhone;
        /// <summary>
        /// HUD1ES Tax Pay To Phone [VEND.X329]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE, Description = "HUD1ES Tax Pay To Phone")]
        public string RealEstateTaxPhone { get => _realEstateTaxPhone; set => _realEstateTaxPhone = value; }
        private DirtyValue<string> _realEstateTaxPostalCode;
        /// <summary>
        /// HUD1ES Tax Pay To Zip [VEND.X327]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE, Description = "HUD1ES Tax Pay To Zip")]
        public string RealEstateTaxPostalCode { get => _realEstateTaxPostalCode; set => _realEstateTaxPostalCode = value; }
        private DirtyValue<string> _realEstateTaxState;
        /// <summary>
        /// HUD1ES Tax Pay To State [VEND.X326]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.STATE, Description = "HUD1ES Tax Pay To State")]
        public string RealEstateTaxState { get => _realEstateTaxState; set => _realEstateTaxState = value; }
        private DirtyValue<int?> _schoolTaxesCushion;
        /// <summary>
        /// No. City Tax Pymts for Cushion [HUD34]
        /// </summary>
        [LoanFieldProperty(Description = "No. City Tax Pymts for Cushion")]
        public int? SchoolTaxesCushion { get => _schoolTaxesCushion; set => _schoolTaxesCushion = value; }
        private DirtyValue<string> _servicerAddress;
        /// <summary>
        /// Escrow Servicer Address [L631]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Escrow Servicer Address")]
        public string ServicerAddress { get => _servicerAddress; set => _servicerAddress = value; }
        private DirtyValue<string> _servicerCity;
        /// <summary>
        /// Escrow Servicer City [L632]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Escrow Servicer City")]
        public string ServicerCity { get => _servicerCity; set => _servicerCity = value; }
        private DirtyValue<string> _servicerContactName;
        /// <summary>
        /// Escrow Servicer Name [L611]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Escrow Servicer Name")]
        public string ServicerContactName { get => _servicerContactName; set => _servicerContactName = value; }
        private DirtyValue<string> _servicerPhone;
        /// <summary>
        /// Escrow Servicer Phone [L635]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE, ReadOnly = true, Description = "Escrow Servicer Phone")]
        public string ServicerPhone { get => _servicerPhone; set => _servicerPhone = value; }
        private DirtyValue<string> _servicerPostalCode;
        /// <summary>
        /// Escrow Servicer Zipcode [L634]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE, ReadOnly = true, Description = "Escrow Servicer Zipcode")]
        public string ServicerPostalCode { get => _servicerPostalCode; set => _servicerPostalCode = value; }
        private DirtyValue<string> _servicerState;
        /// <summary>
        /// Escrow Servicer State [L633]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.STATE, ReadOnly = true, Description = "Escrow Servicer State")]
        public string ServicerState { get => _servicerState; set => _servicerState = value; }
        private DirtyValue<decimal?> _singleLineAnalysis;
        /// <summary>
        /// HUD Single Line Analysis [HUD40]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "HUD Single Line Analysis")]
        public decimal? SingleLineAnalysis { get => _singleLineAnalysis; set => _singleLineAnalysis = value; }
        private DirtyValue<decimal?> _startingBalance;
        /// <summary>
        /// HUD Starting Balance [HUD23]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "HUD Starting Balance")]
        public decimal? StartingBalance { get => _startingBalance; set => _startingBalance = value; }
        private DirtyValue<int?> _taxDisbCushion;
        /// <summary>
        /// No. Tax Pymts for Cushion [HUD30]
        /// </summary>
        [LoanFieldProperty(Description = "No. Tax Pymts for Cushion")]
        public int? TaxDisbCushion { get => _taxDisbCushion; set => _taxDisbCushion = value; }
        private DirtyValue<decimal?> _totalEscrowReserves;
        /// <summary>
        /// HUD Total Escrow Reserves [HUD26]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "HUD Total Escrow Reserves")]
        public decimal? TotalEscrowReserves { get => _totalEscrowReserves; set => _totalEscrowReserves = value; }
        private DirtyValue<decimal?> _usdaAnnualFee;
        /// <summary>
        /// HUD USDA Annual Fee [HUD50]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "HUD USDA Annual Fee")]
        public decimal? UsdaAnnualFee { get => _usdaAnnualFee; set => _usdaAnnualFee = value; }
        private DirtyValue<int?> _userDefinedCushion1;
        /// <summary>
        /// No. User Defined 1 Pymts for Cushion [HUD35]
        /// </summary>
        [LoanFieldProperty(Description = "No. User Defined 1 Pymts for Cushion")]
        public int? UserDefinedCushion1 { get => _userDefinedCushion1; set => _userDefinedCushion1 = value; }
        private DirtyValue<int?> _userDefinedCushion2;
        /// <summary>
        /// No. User Defined 2 Pymts for Cushion [HUD36]
        /// </summary>
        [LoanFieldProperty(Description = "No. User Defined 2 Pymts for Cushion")]
        public int? UserDefinedCushion2 { get => _userDefinedCushion2; set => _userDefinedCushion2 = value; }
        private DirtyValue<int?> _userDefinedCushion3;
        /// <summary>
        /// No. User Defined 3 Pymts for Cushion [HUD37]
        /// </summary>
        [LoanFieldProperty(Description = "No. User Defined 3 Pymts for Cushion")]
        public int? UserDefinedCushion3 { get => _userDefinedCushion3; set => _userDefinedCushion3 = value; }
        private DirtyValue<decimal?> _yearlyMortgageInsurance;
        /// <summary>
        /// HUD Yearly Mortgage Insurance Before Rounding [HUD.YearlyMIFee]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "HUD Yearly Mortgage Insurance Before Rounding")]
        public decimal? YearlyMortgageInsurance { get => _yearlyMortgageInsurance; set => _yearlyMortgageInsurance = value; }
        private DirtyValue<decimal?> _yearlyUsdaFee;
        /// <summary>
        /// HUD Yearly USDA Fee Before Monthly Payment Rounding [HUD.YearlyUSDAFee]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "HUD Yearly USDA Fee Before Monthly Payment Rounding")]
        public decimal? YearlyUsdaFee { get => _yearlyUsdaFee; set => _yearlyUsdaFee = value; }
        internal override bool DirtyInternal
        {
            get => _annualCityTax.Dirty
                || _annualFeeCushion.Dirty
                || _annualFloodInsurance.Dirty
                || _annualHazardInsurance.Dirty
                || _annualMortgageInsurance.Dirty
                || _annualTax.Dirty
                || _annualUserEscrow1.Dirty
                || _annualUserEscrow2.Dirty
                || _annualUserEscrow3.Dirty
                || _biweeklyCityPropertyTaxes.Dirty
                || _biweeklyCountyTaxes.Dirty
                || _biweeklyFloodInsurance.Dirty
                || _biweeklyHazardInsurance.Dirty
                || _biweeklyMortgageInsurance.Dirty
                || _biweeklyPITI.Dirty
                || _biweeklyTotalBiweeklyPayment.Dirty
                || _biweeklyTotalBiweeklyPaymentToEscrow.Dirty
                || _biweeklyUSDAFee.Dirty
                || _biweeklyUserDefinedEscrowFee1.Dirty
                || _biweeklyUserDefinedEscrowFee2.Dirty
                || _biweeklyUserDefinedEscrowFee3.Dirty
                || _cityPropertyTaxAddress.Dirty
                || _cityPropertyTaxAmountLastPay.Dirty
                || _cityPropertyTaxAmountNextDue.Dirty
                || _cityPropertyTaxCity.Dirty
                || _cityPropertyTaxContactName.Dirty
                || _cityPropertyTaxDatePaid.Dirty
                || _cityPropertyTaxDelinquentDate.Dirty
                || _cityPropertyTaxEmail.Dirty
                || _cityPropertyTaxFax.Dirty
                || _cityPropertyTaxName.Dirty
                || _cityPropertyTaxNextDueDate.Dirty
                || _cityPropertyTaxPaymentSchedule.Dirty
                || _cityPropertyTaxPhone.Dirty
                || _cityPropertyTaxPostalCode.Dirty
                || _cityPropertyTaxState.Dirty
                || _endingBalance.Dirty
                || _escrowFirstPaymentDate.Dirty
                || _escrowFirstPaymentDateType.Dirty
                || _escrowPayment.Dirty
                || _escrowPaymentYearly.Dirty
                || _floodInsDisbCushion.Dirty
                || _hazInsDisbCushion.Dirty
                || _hud1EsItemizesTotalLines.Dirty
                || _hud1EsItemizesUseItemizeEscrowIndicator.Dirty
                || _id.Dirty
                || _mtgInsCushionTerminationIndicator.Dirty
                || _mtgInsDisbCushion.Dirty
                || _nonEscrowCostsYearly.Dirty
                || _realEstateTaxAddress.Dirty
                || _realEstateTaxAmountLastPay.Dirty
                || _realEstateTaxAmountNextDue.Dirty
                || _realEstateTaxCity.Dirty
                || _realEstateTaxContactName.Dirty
                || _realEstateTaxDatePaid.Dirty
                || _realEstateTaxDelinquentDate.Dirty
                || _realEstateTaxEmail.Dirty
                || _realEstateTaxFax.Dirty
                || _realEstateTaxName.Dirty
                || _realEstateTaxNextDueDate.Dirty
                || _realEstateTaxPaymentSchedule.Dirty
                || _realEstateTaxPhone.Dirty
                || _realEstateTaxPostalCode.Dirty
                || _realEstateTaxState.Dirty
                || _schoolTaxesCushion.Dirty
                || _servicerAddress.Dirty
                || _servicerCity.Dirty
                || _servicerContactName.Dirty
                || _servicerPhone.Dirty
                || _servicerPostalCode.Dirty
                || _servicerState.Dirty
                || _singleLineAnalysis.Dirty
                || _startingBalance.Dirty
                || _taxDisbCushion.Dirty
                || _totalEscrowReserves.Dirty
                || _usdaAnnualFee.Dirty
                || _userDefinedCushion1.Dirty
                || _userDefinedCushion2.Dirty
                || _userDefinedCushion3.Dirty
                || _yearlyMortgageInsurance.Dirty
                || _yearlyUsdaFee.Dirty
                || _hud1EsDates?.Dirty == true
                || _hud1EsDueDates?.Dirty == true
                || _hud1EsItemizes?.Dirty == true
                || _hud1EsPayTos?.Dirty == true
                || _hud1EsSetups?.Dirty == true;
            set
            {
                _annualCityTax.Dirty = value;
                _annualFeeCushion.Dirty = value;
                _annualFloodInsurance.Dirty = value;
                _annualHazardInsurance.Dirty = value;
                _annualMortgageInsurance.Dirty = value;
                _annualTax.Dirty = value;
                _annualUserEscrow1.Dirty = value;
                _annualUserEscrow2.Dirty = value;
                _annualUserEscrow3.Dirty = value;
                _biweeklyCityPropertyTaxes.Dirty = value;
                _biweeklyCountyTaxes.Dirty = value;
                _biweeklyFloodInsurance.Dirty = value;
                _biweeklyHazardInsurance.Dirty = value;
                _biweeklyMortgageInsurance.Dirty = value;
                _biweeklyPITI.Dirty = value;
                _biweeklyTotalBiweeklyPayment.Dirty = value;
                _biweeklyTotalBiweeklyPaymentToEscrow.Dirty = value;
                _biweeklyUSDAFee.Dirty = value;
                _biweeklyUserDefinedEscrowFee1.Dirty = value;
                _biweeklyUserDefinedEscrowFee2.Dirty = value;
                _biweeklyUserDefinedEscrowFee3.Dirty = value;
                _cityPropertyTaxAddress.Dirty = value;
                _cityPropertyTaxAmountLastPay.Dirty = value;
                _cityPropertyTaxAmountNextDue.Dirty = value;
                _cityPropertyTaxCity.Dirty = value;
                _cityPropertyTaxContactName.Dirty = value;
                _cityPropertyTaxDatePaid.Dirty = value;
                _cityPropertyTaxDelinquentDate.Dirty = value;
                _cityPropertyTaxEmail.Dirty = value;
                _cityPropertyTaxFax.Dirty = value;
                _cityPropertyTaxName.Dirty = value;
                _cityPropertyTaxNextDueDate.Dirty = value;
                _cityPropertyTaxPaymentSchedule.Dirty = value;
                _cityPropertyTaxPhone.Dirty = value;
                _cityPropertyTaxPostalCode.Dirty = value;
                _cityPropertyTaxState.Dirty = value;
                _endingBalance.Dirty = value;
                _escrowFirstPaymentDate.Dirty = value;
                _escrowFirstPaymentDateType.Dirty = value;
                _escrowPayment.Dirty = value;
                _escrowPaymentYearly.Dirty = value;
                _floodInsDisbCushion.Dirty = value;
                _hazInsDisbCushion.Dirty = value;
                _hud1EsItemizesTotalLines.Dirty = value;
                _hud1EsItemizesUseItemizeEscrowIndicator.Dirty = value;
                _id.Dirty = value;
                _mtgInsCushionTerminationIndicator.Dirty = value;
                _mtgInsDisbCushion.Dirty = value;
                _nonEscrowCostsYearly.Dirty = value;
                _realEstateTaxAddress.Dirty = value;
                _realEstateTaxAmountLastPay.Dirty = value;
                _realEstateTaxAmountNextDue.Dirty = value;
                _realEstateTaxCity.Dirty = value;
                _realEstateTaxContactName.Dirty = value;
                _realEstateTaxDatePaid.Dirty = value;
                _realEstateTaxDelinquentDate.Dirty = value;
                _realEstateTaxEmail.Dirty = value;
                _realEstateTaxFax.Dirty = value;
                _realEstateTaxName.Dirty = value;
                _realEstateTaxNextDueDate.Dirty = value;
                _realEstateTaxPaymentSchedule.Dirty = value;
                _realEstateTaxPhone.Dirty = value;
                _realEstateTaxPostalCode.Dirty = value;
                _realEstateTaxState.Dirty = value;
                _schoolTaxesCushion.Dirty = value;
                _servicerAddress.Dirty = value;
                _servicerCity.Dirty = value;
                _servicerContactName.Dirty = value;
                _servicerPhone.Dirty = value;
                _servicerPostalCode.Dirty = value;
                _servicerState.Dirty = value;
                _singleLineAnalysis.Dirty = value;
                _startingBalance.Dirty = value;
                _taxDisbCushion.Dirty = value;
                _totalEscrowReserves.Dirty = value;
                _usdaAnnualFee.Dirty = value;
                _userDefinedCushion1.Dirty = value;
                _userDefinedCushion2.Dirty = value;
                _userDefinedCushion3.Dirty = value;
                _yearlyMortgageInsurance.Dirty = value;
                _yearlyUsdaFee.Dirty = value;
                if (_hud1EsDates != null) _hud1EsDates.Dirty = value;
                if (_hud1EsDueDates != null) _hud1EsDueDates.Dirty = value;
                if (_hud1EsItemizes != null) _hud1EsItemizes.Dirty = value;
                if (_hud1EsPayTos != null) _hud1EsPayTos.Dirty = value;
                if (_hud1EsSetups != null) _hud1EsSetups.Dirty = value;
            }
        }
    }
}