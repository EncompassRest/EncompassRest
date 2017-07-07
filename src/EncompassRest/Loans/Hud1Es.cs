using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class Hud1Es : IClean
    {
        private Value<decimal?> _annualCityTax;
        public decimal? AnnualCityTax { get { return _annualCityTax; } set { _annualCityTax = value; } }
        private Value<int?> _annualFeeCushion;
        public int? AnnualFeeCushion { get { return _annualFeeCushion; } set { _annualFeeCushion = value; } }
        private Value<decimal?> _annualFloodInsurance;
        public decimal? AnnualFloodInsurance { get { return _annualFloodInsurance; } set { _annualFloodInsurance = value; } }
        private Value<decimal?> _annualHazardInsurance;
        public decimal? AnnualHazardInsurance { get { return _annualHazardInsurance; } set { _annualHazardInsurance = value; } }
        private Value<decimal?> _annualMortgageInsurance;
        public decimal? AnnualMortgageInsurance { get { return _annualMortgageInsurance; } set { _annualMortgageInsurance = value; } }
        private Value<decimal?> _annualTax;
        public decimal? AnnualTax { get { return _annualTax; } set { _annualTax = value; } }
        private Value<decimal?> _annualUserEscrow1;
        public decimal? AnnualUserEscrow1 { get { return _annualUserEscrow1; } set { _annualUserEscrow1 = value; } }
        private Value<decimal?> _annualUserEscrow2;
        public decimal? AnnualUserEscrow2 { get { return _annualUserEscrow2; } set { _annualUserEscrow2 = value; } }
        private Value<decimal?> _annualUserEscrow3;
        public decimal? AnnualUserEscrow3 { get { return _annualUserEscrow3; } set { _annualUserEscrow3 = value; } }
        private Value<decimal?> _biweeklyCityPropertyTaxes;
        public decimal? BiweeklyCityPropertyTaxes { get { return _biweeklyCityPropertyTaxes; } set { _biweeklyCityPropertyTaxes = value; } }
        private Value<decimal?> _biweeklyCountyTaxes;
        public decimal? BiweeklyCountyTaxes { get { return _biweeklyCountyTaxes; } set { _biweeklyCountyTaxes = value; } }
        private Value<decimal?> _biweeklyFloodInsurance;
        public decimal? BiweeklyFloodInsurance { get { return _biweeklyFloodInsurance; } set { _biweeklyFloodInsurance = value; } }
        private Value<decimal?> _biweeklyHazardInsurance;
        public decimal? BiweeklyHazardInsurance { get { return _biweeklyHazardInsurance; } set { _biweeklyHazardInsurance = value; } }
        private Value<decimal?> _biweeklyMortgageInsurance;
        public decimal? BiweeklyMortgageInsurance { get { return _biweeklyMortgageInsurance; } set { _biweeklyMortgageInsurance = value; } }
        private Value<decimal?> _biweeklyPITI;
        public decimal? BiweeklyPITI { get { return _biweeklyPITI; } set { _biweeklyPITI = value; } }
        private Value<decimal?> _biweeklyTotalBiweeklyPayment;
        public decimal? BiweeklyTotalBiweeklyPayment { get { return _biweeklyTotalBiweeklyPayment; } set { _biweeklyTotalBiweeklyPayment = value; } }
        private Value<decimal?> _biweeklyTotalBiweeklyPaymentToEscrow;
        public decimal? BiweeklyTotalBiweeklyPaymentToEscrow { get { return _biweeklyTotalBiweeklyPaymentToEscrow; } set { _biweeklyTotalBiweeklyPaymentToEscrow = value; } }
        private Value<decimal?> _biweeklyUSDAFee;
        public decimal? BiweeklyUSDAFee { get { return _biweeklyUSDAFee; } set { _biweeklyUSDAFee = value; } }
        private Value<decimal?> _biweeklyUserDefinedEscrowFee1;
        public decimal? BiweeklyUserDefinedEscrowFee1 { get { return _biweeklyUserDefinedEscrowFee1; } set { _biweeklyUserDefinedEscrowFee1 = value; } }
        private Value<decimal?> _biweeklyUserDefinedEscrowFee2;
        public decimal? BiweeklyUserDefinedEscrowFee2 { get { return _biweeklyUserDefinedEscrowFee2; } set { _biweeklyUserDefinedEscrowFee2 = value; } }
        private Value<decimal?> _biweeklyUserDefinedEscrowFee3;
        public decimal? BiweeklyUserDefinedEscrowFee3 { get { return _biweeklyUserDefinedEscrowFee3; } set { _biweeklyUserDefinedEscrowFee3 = value; } }
        private Value<string> _cityPropertyTaxAddress;
        public string CityPropertyTaxAddress { get { return _cityPropertyTaxAddress; } set { _cityPropertyTaxAddress = value; } }
        private Value<decimal?> _cityPropertyTaxAmountLastPay;
        public decimal? CityPropertyTaxAmountLastPay { get { return _cityPropertyTaxAmountLastPay; } set { _cityPropertyTaxAmountLastPay = value; } }
        private Value<decimal?> _cityPropertyTaxAmountNextDue;
        public decimal? CityPropertyTaxAmountNextDue { get { return _cityPropertyTaxAmountNextDue; } set { _cityPropertyTaxAmountNextDue = value; } }
        private Value<string> _cityPropertyTaxCity;
        public string CityPropertyTaxCity { get { return _cityPropertyTaxCity; } set { _cityPropertyTaxCity = value; } }
        private Value<string> _cityPropertyTaxContactName;
        public string CityPropertyTaxContactName { get { return _cityPropertyTaxContactName; } set { _cityPropertyTaxContactName = value; } }
        private Value<DateTime?> _cityPropertyTaxDatePaid;
        public DateTime? CityPropertyTaxDatePaid { get { return _cityPropertyTaxDatePaid; } set { _cityPropertyTaxDatePaid = value; } }
        private Value<DateTime?> _cityPropertyTaxDelinquentDate;
        public DateTime? CityPropertyTaxDelinquentDate { get { return _cityPropertyTaxDelinquentDate; } set { _cityPropertyTaxDelinquentDate = value; } }
        private Value<string> _cityPropertyTaxEmail;
        public string CityPropertyTaxEmail { get { return _cityPropertyTaxEmail; } set { _cityPropertyTaxEmail = value; } }
        private Value<string> _cityPropertyTaxFax;
        public string CityPropertyTaxFax { get { return _cityPropertyTaxFax; } set { _cityPropertyTaxFax = value; } }
        private Value<string> _cityPropertyTaxName;
        public string CityPropertyTaxName { get { return _cityPropertyTaxName; } set { _cityPropertyTaxName = value; } }
        private Value<DateTime?> _cityPropertyTaxNextDueDate;
        public DateTime? CityPropertyTaxNextDueDate { get { return _cityPropertyTaxNextDueDate; } set { _cityPropertyTaxNextDueDate = value; } }
        private Value<string> _cityPropertyTaxPaymentSchedule;
        public string CityPropertyTaxPaymentSchedule { get { return _cityPropertyTaxPaymentSchedule; } set { _cityPropertyTaxPaymentSchedule = value; } }
        private Value<string> _cityPropertyTaxPhone;
        public string CityPropertyTaxPhone { get { return _cityPropertyTaxPhone; } set { _cityPropertyTaxPhone = value; } }
        private Value<string> _cityPropertyTaxPostalCode;
        public string CityPropertyTaxPostalCode { get { return _cityPropertyTaxPostalCode; } set { _cityPropertyTaxPostalCode = value; } }
        private Value<string> _cityPropertyTaxState;
        public string CityPropertyTaxState { get { return _cityPropertyTaxState; } set { _cityPropertyTaxState = value; } }
        private Value<decimal?> _endingBalance;
        public decimal? EndingBalance { get { return _endingBalance; } set { _endingBalance = value; } }
        private Value<DateTime?> _escrowFirstPaymentDate;
        public DateTime? EscrowFirstPaymentDate { get { return _escrowFirstPaymentDate; } set { _escrowFirstPaymentDate = value; } }
        private Value<string> _escrowFirstPaymentDateType;
        public string EscrowFirstPaymentDateType { get { return _escrowFirstPaymentDateType; } set { _escrowFirstPaymentDateType = value; } }
        private Value<decimal?> _escrowPayment;
        public decimal? EscrowPayment { get { return _escrowPayment; } set { _escrowPayment = value; } }
        private Value<decimal?> _escrowPaymentYearly;
        public decimal? EscrowPaymentYearly { get { return _escrowPaymentYearly; } set { _escrowPaymentYearly = value; } }
        private Value<int?> _floodInsDisbCushion;
        public int? FloodInsDisbCushion { get { return _floodInsDisbCushion; } set { _floodInsDisbCushion = value; } }
        private Value<int?> _hazInsDisbCushion;
        public int? HazInsDisbCushion { get { return _hazInsDisbCushion; } set { _hazInsDisbCushion = value; } }
        private Value<List<Hud1EsDate>> _hud1EsDates;
        public List<Hud1EsDate> Hud1EsDates { get { return _hud1EsDates; } set { _hud1EsDates = value; } }
        private Value<List<Hud1EsDueDate>> _hud1EsDueDates;
        public List<Hud1EsDueDate> Hud1EsDueDates { get { return _hud1EsDueDates; } set { _hud1EsDueDates = value; } }
        private Value<List<Hud1EsItemize>> _hud1EsItemizes;
        public List<Hud1EsItemize> Hud1EsItemizes { get { return _hud1EsItemizes; } set { _hud1EsItemizes = value; } }
        private Value<int?> _hud1EsItemizesTotalLines;
        public int? Hud1EsItemizesTotalLines { get { return _hud1EsItemizesTotalLines; } set { _hud1EsItemizesTotalLines = value; } }
        private Value<bool?> _hud1EsItemizesUseItemizeEscrowIndicator;
        public bool? Hud1EsItemizesUseItemizeEscrowIndicator { get { return _hud1EsItemizesUseItemizeEscrowIndicator; } set { _hud1EsItemizesUseItemizeEscrowIndicator = value; } }
        private Value<List<Hud1EsPayTo>> _hud1EsPayTos;
        public List<Hud1EsPayTo> Hud1EsPayTos { get { return _hud1EsPayTos; } set { _hud1EsPayTos = value; } }
        private Value<List<Hud1EsSetup>> _hud1EsSetups;
        public List<Hud1EsSetup> Hud1EsSetups { get { return _hud1EsSetups; } set { _hud1EsSetups = value; } }
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private Value<bool?> _mtgInsCushionTerminationIndicator;
        public bool? MtgInsCushionTerminationIndicator { get { return _mtgInsCushionTerminationIndicator; } set { _mtgInsCushionTerminationIndicator = value; } }
        private Value<int?> _mtgInsDisbCushion;
        public int? MtgInsDisbCushion { get { return _mtgInsDisbCushion; } set { _mtgInsDisbCushion = value; } }
        private Value<decimal?> _nonEscrowCostsYearly;
        public decimal? NonEscrowCostsYearly { get { return _nonEscrowCostsYearly; } set { _nonEscrowCostsYearly = value; } }
        private Value<string> _realEstateTaxAddress;
        public string RealEstateTaxAddress { get { return _realEstateTaxAddress; } set { _realEstateTaxAddress = value; } }
        private Value<decimal?> _realEstateTaxAmountLastPay;
        public decimal? RealEstateTaxAmountLastPay { get { return _realEstateTaxAmountLastPay; } set { _realEstateTaxAmountLastPay = value; } }
        private Value<decimal?> _realEstateTaxAmountNextDue;
        public decimal? RealEstateTaxAmountNextDue { get { return _realEstateTaxAmountNextDue; } set { _realEstateTaxAmountNextDue = value; } }
        private Value<string> _realEstateTaxCity;
        public string RealEstateTaxCity { get { return _realEstateTaxCity; } set { _realEstateTaxCity = value; } }
        private Value<string> _realEstateTaxContactName;
        public string RealEstateTaxContactName { get { return _realEstateTaxContactName; } set { _realEstateTaxContactName = value; } }
        private Value<DateTime?> _realEstateTaxDatePaid;
        public DateTime? RealEstateTaxDatePaid { get { return _realEstateTaxDatePaid; } set { _realEstateTaxDatePaid = value; } }
        private Value<DateTime?> _realEstateTaxDelinquentDate;
        public DateTime? RealEstateTaxDelinquentDate { get { return _realEstateTaxDelinquentDate; } set { _realEstateTaxDelinquentDate = value; } }
        private Value<string> _realEstateTaxEmail;
        public string RealEstateTaxEmail { get { return _realEstateTaxEmail; } set { _realEstateTaxEmail = value; } }
        private Value<string> _realEstateTaxFax;
        public string RealEstateTaxFax { get { return _realEstateTaxFax; } set { _realEstateTaxFax = value; } }
        private Value<string> _realEstateTaxName;
        public string RealEstateTaxName { get { return _realEstateTaxName; } set { _realEstateTaxName = value; } }
        private Value<DateTime?> _realEstateTaxNextDueDate;
        public DateTime? RealEstateTaxNextDueDate { get { return _realEstateTaxNextDueDate; } set { _realEstateTaxNextDueDate = value; } }
        private Value<string> _realEstateTaxPaymentSchedule;
        public string RealEstateTaxPaymentSchedule { get { return _realEstateTaxPaymentSchedule; } set { _realEstateTaxPaymentSchedule = value; } }
        private Value<string> _realEstateTaxPhone;
        public string RealEstateTaxPhone { get { return _realEstateTaxPhone; } set { _realEstateTaxPhone = value; } }
        private Value<string> _realEstateTaxPostalCode;
        public string RealEstateTaxPostalCode { get { return _realEstateTaxPostalCode; } set { _realEstateTaxPostalCode = value; } }
        private Value<string> _realEstateTaxState;
        public string RealEstateTaxState { get { return _realEstateTaxState; } set { _realEstateTaxState = value; } }
        private Value<int?> _schoolTaxesCushion;
        public int? SchoolTaxesCushion { get { return _schoolTaxesCushion; } set { _schoolTaxesCushion = value; } }
        private Value<string> _servicerAddress;
        public string ServicerAddress { get { return _servicerAddress; } set { _servicerAddress = value; } }
        private Value<string> _servicerCity;
        public string ServicerCity { get { return _servicerCity; } set { _servicerCity = value; } }
        private Value<string> _servicerContactName;
        public string ServicerContactName { get { return _servicerContactName; } set { _servicerContactName = value; } }
        private Value<string> _servicerPhone;
        public string ServicerPhone { get { return _servicerPhone; } set { _servicerPhone = value; } }
        private Value<string> _servicerPostalCode;
        public string ServicerPostalCode { get { return _servicerPostalCode; } set { _servicerPostalCode = value; } }
        private Value<string> _servicerState;
        public string ServicerState { get { return _servicerState; } set { _servicerState = value; } }
        private Value<decimal?> _singleLineAnalysis;
        public decimal? SingleLineAnalysis { get { return _singleLineAnalysis; } set { _singleLineAnalysis = value; } }
        private Value<decimal?> _startingBalance;
        public decimal? StartingBalance { get { return _startingBalance; } set { _startingBalance = value; } }
        private Value<int?> _taxDisbCushion;
        public int? TaxDisbCushion { get { return _taxDisbCushion; } set { _taxDisbCushion = value; } }
        private Value<decimal?> _totalEscrowReserves;
        public decimal? TotalEscrowReserves { get { return _totalEscrowReserves; } set { _totalEscrowReserves = value; } }
        private Value<decimal?> _usdaAnnualFee;
        public decimal? UsdaAnnualFee { get { return _usdaAnnualFee; } set { _usdaAnnualFee = value; } }
        private Value<int?> _userDefinedCushion1;
        public int? UserDefinedCushion1 { get { return _userDefinedCushion1; } set { _userDefinedCushion1 = value; } }
        private Value<int?> _userDefinedCushion2;
        public int? UserDefinedCushion2 { get { return _userDefinedCushion2; } set { _userDefinedCushion2 = value; } }
        private Value<int?> _userDefinedCushion3;
        public int? UserDefinedCushion3 { get { return _userDefinedCushion3; } set { _userDefinedCushion3 = value; } }
        private Value<decimal?> _yearlyMortgageInsurance;
        public decimal? YearlyMortgageInsurance { get { return _yearlyMortgageInsurance; } set { _yearlyMortgageInsurance = value; } }
        private Value<decimal?> _yearlyUsdaFee;
        public decimal? YearlyUsdaFee { get { return _yearlyUsdaFee; } set { _yearlyUsdaFee = value; } }
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = _annualCityTax.Clean
                    && _annualFeeCushion.Clean
                    && _annualFloodInsurance.Clean
                    && _annualHazardInsurance.Clean
                    && _annualMortgageInsurance.Clean
                    && _annualTax.Clean
                    && _annualUserEscrow1.Clean
                    && _annualUserEscrow2.Clean
                    && _annualUserEscrow3.Clean
                    && _biweeklyCityPropertyTaxes.Clean
                    && _biweeklyCountyTaxes.Clean
                    && _biweeklyFloodInsurance.Clean
                    && _biweeklyHazardInsurance.Clean
                    && _biweeklyMortgageInsurance.Clean
                    && _biweeklyPITI.Clean
                    && _biweeklyTotalBiweeklyPayment.Clean
                    && _biweeklyTotalBiweeklyPaymentToEscrow.Clean
                    && _biweeklyUSDAFee.Clean
                    && _biweeklyUserDefinedEscrowFee1.Clean
                    && _biweeklyUserDefinedEscrowFee2.Clean
                    && _biweeklyUserDefinedEscrowFee3.Clean
                    && _cityPropertyTaxAddress.Clean
                    && _cityPropertyTaxAmountLastPay.Clean
                    && _cityPropertyTaxAmountNextDue.Clean
                    && _cityPropertyTaxCity.Clean
                    && _cityPropertyTaxContactName.Clean
                    && _cityPropertyTaxDatePaid.Clean
                    && _cityPropertyTaxDelinquentDate.Clean
                    && _cityPropertyTaxEmail.Clean
                    && _cityPropertyTaxFax.Clean
                    && _cityPropertyTaxName.Clean
                    && _cityPropertyTaxNextDueDate.Clean
                    && _cityPropertyTaxPaymentSchedule.Clean
                    && _cityPropertyTaxPhone.Clean
                    && _cityPropertyTaxPostalCode.Clean
                    && _cityPropertyTaxState.Clean
                    && _endingBalance.Clean
                    && _escrowFirstPaymentDate.Clean
                    && _escrowFirstPaymentDateType.Clean
                    && _escrowPayment.Clean
                    && _escrowPaymentYearly.Clean
                    && _floodInsDisbCushion.Clean
                    && _hazInsDisbCushion.Clean
                    && _hud1EsDates.Clean
                    && _hud1EsDueDates.Clean
                    && _hud1EsItemizes.Clean
                    && _hud1EsItemizesTotalLines.Clean
                    && _hud1EsItemizesUseItemizeEscrowIndicator.Clean
                    && _hud1EsPayTos.Clean
                    && _hud1EsSetups.Clean
                    && _id.Clean
                    && _mtgInsCushionTerminationIndicator.Clean
                    && _mtgInsDisbCushion.Clean
                    && _nonEscrowCostsYearly.Clean
                    && _realEstateTaxAddress.Clean
                    && _realEstateTaxAmountLastPay.Clean
                    && _realEstateTaxAmountNextDue.Clean
                    && _realEstateTaxCity.Clean
                    && _realEstateTaxContactName.Clean
                    && _realEstateTaxDatePaid.Clean
                    && _realEstateTaxDelinquentDate.Clean
                    && _realEstateTaxEmail.Clean
                    && _realEstateTaxFax.Clean
                    && _realEstateTaxName.Clean
                    && _realEstateTaxNextDueDate.Clean
                    && _realEstateTaxPaymentSchedule.Clean
                    && _realEstateTaxPhone.Clean
                    && _realEstateTaxPostalCode.Clean
                    && _realEstateTaxState.Clean
                    && _schoolTaxesCushion.Clean
                    && _servicerAddress.Clean
                    && _servicerCity.Clean
                    && _servicerContactName.Clean
                    && _servicerPhone.Clean
                    && _servicerPostalCode.Clean
                    && _servicerState.Clean
                    && _singleLineAnalysis.Clean
                    && _startingBalance.Clean
                    && _taxDisbCushion.Clean
                    && _totalEscrowReserves.Clean
                    && _usdaAnnualFee.Clean
                    && _userDefinedCushion1.Clean
                    && _userDefinedCushion2.Clean
                    && _userDefinedCushion3.Clean
                    && _yearlyMortgageInsurance.Clean
                    && _yearlyUsdaFee.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var annualCityTax = _annualCityTax; annualCityTax.Clean = value; _annualCityTax = annualCityTax;
                var annualFeeCushion = _annualFeeCushion; annualFeeCushion.Clean = value; _annualFeeCushion = annualFeeCushion;
                var annualFloodInsurance = _annualFloodInsurance; annualFloodInsurance.Clean = value; _annualFloodInsurance = annualFloodInsurance;
                var annualHazardInsurance = _annualHazardInsurance; annualHazardInsurance.Clean = value; _annualHazardInsurance = annualHazardInsurance;
                var annualMortgageInsurance = _annualMortgageInsurance; annualMortgageInsurance.Clean = value; _annualMortgageInsurance = annualMortgageInsurance;
                var annualTax = _annualTax; annualTax.Clean = value; _annualTax = annualTax;
                var annualUserEscrow1 = _annualUserEscrow1; annualUserEscrow1.Clean = value; _annualUserEscrow1 = annualUserEscrow1;
                var annualUserEscrow2 = _annualUserEscrow2; annualUserEscrow2.Clean = value; _annualUserEscrow2 = annualUserEscrow2;
                var annualUserEscrow3 = _annualUserEscrow3; annualUserEscrow3.Clean = value; _annualUserEscrow3 = annualUserEscrow3;
                var biweeklyCityPropertyTaxes = _biweeklyCityPropertyTaxes; biweeklyCityPropertyTaxes.Clean = value; _biweeklyCityPropertyTaxes = biweeklyCityPropertyTaxes;
                var biweeklyCountyTaxes = _biweeklyCountyTaxes; biweeklyCountyTaxes.Clean = value; _biweeklyCountyTaxes = biweeklyCountyTaxes;
                var biweeklyFloodInsurance = _biweeklyFloodInsurance; biweeklyFloodInsurance.Clean = value; _biweeklyFloodInsurance = biweeklyFloodInsurance;
                var biweeklyHazardInsurance = _biweeklyHazardInsurance; biweeklyHazardInsurance.Clean = value; _biweeklyHazardInsurance = biweeklyHazardInsurance;
                var biweeklyMortgageInsurance = _biweeklyMortgageInsurance; biweeklyMortgageInsurance.Clean = value; _biweeklyMortgageInsurance = biweeklyMortgageInsurance;
                var biweeklyPITI = _biweeklyPITI; biweeklyPITI.Clean = value; _biweeklyPITI = biweeklyPITI;
                var biweeklyTotalBiweeklyPayment = _biweeklyTotalBiweeklyPayment; biweeklyTotalBiweeklyPayment.Clean = value; _biweeklyTotalBiweeklyPayment = biweeklyTotalBiweeklyPayment;
                var biweeklyTotalBiweeklyPaymentToEscrow = _biweeklyTotalBiweeklyPaymentToEscrow; biweeklyTotalBiweeklyPaymentToEscrow.Clean = value; _biweeklyTotalBiweeklyPaymentToEscrow = biweeklyTotalBiweeklyPaymentToEscrow;
                var biweeklyUSDAFee = _biweeklyUSDAFee; biweeklyUSDAFee.Clean = value; _biweeklyUSDAFee = biweeklyUSDAFee;
                var biweeklyUserDefinedEscrowFee1 = _biweeklyUserDefinedEscrowFee1; biweeklyUserDefinedEscrowFee1.Clean = value; _biweeklyUserDefinedEscrowFee1 = biweeklyUserDefinedEscrowFee1;
                var biweeklyUserDefinedEscrowFee2 = _biweeklyUserDefinedEscrowFee2; biweeklyUserDefinedEscrowFee2.Clean = value; _biweeklyUserDefinedEscrowFee2 = biweeklyUserDefinedEscrowFee2;
                var biweeklyUserDefinedEscrowFee3 = _biweeklyUserDefinedEscrowFee3; biweeklyUserDefinedEscrowFee3.Clean = value; _biweeklyUserDefinedEscrowFee3 = biweeklyUserDefinedEscrowFee3;
                var cityPropertyTaxAddress = _cityPropertyTaxAddress; cityPropertyTaxAddress.Clean = value; _cityPropertyTaxAddress = cityPropertyTaxAddress;
                var cityPropertyTaxAmountLastPay = _cityPropertyTaxAmountLastPay; cityPropertyTaxAmountLastPay.Clean = value; _cityPropertyTaxAmountLastPay = cityPropertyTaxAmountLastPay;
                var cityPropertyTaxAmountNextDue = _cityPropertyTaxAmountNextDue; cityPropertyTaxAmountNextDue.Clean = value; _cityPropertyTaxAmountNextDue = cityPropertyTaxAmountNextDue;
                var cityPropertyTaxCity = _cityPropertyTaxCity; cityPropertyTaxCity.Clean = value; _cityPropertyTaxCity = cityPropertyTaxCity;
                var cityPropertyTaxContactName = _cityPropertyTaxContactName; cityPropertyTaxContactName.Clean = value; _cityPropertyTaxContactName = cityPropertyTaxContactName;
                var cityPropertyTaxDatePaid = _cityPropertyTaxDatePaid; cityPropertyTaxDatePaid.Clean = value; _cityPropertyTaxDatePaid = cityPropertyTaxDatePaid;
                var cityPropertyTaxDelinquentDate = _cityPropertyTaxDelinquentDate; cityPropertyTaxDelinquentDate.Clean = value; _cityPropertyTaxDelinquentDate = cityPropertyTaxDelinquentDate;
                var cityPropertyTaxEmail = _cityPropertyTaxEmail; cityPropertyTaxEmail.Clean = value; _cityPropertyTaxEmail = cityPropertyTaxEmail;
                var cityPropertyTaxFax = _cityPropertyTaxFax; cityPropertyTaxFax.Clean = value; _cityPropertyTaxFax = cityPropertyTaxFax;
                var cityPropertyTaxName = _cityPropertyTaxName; cityPropertyTaxName.Clean = value; _cityPropertyTaxName = cityPropertyTaxName;
                var cityPropertyTaxNextDueDate = _cityPropertyTaxNextDueDate; cityPropertyTaxNextDueDate.Clean = value; _cityPropertyTaxNextDueDate = cityPropertyTaxNextDueDate;
                var cityPropertyTaxPaymentSchedule = _cityPropertyTaxPaymentSchedule; cityPropertyTaxPaymentSchedule.Clean = value; _cityPropertyTaxPaymentSchedule = cityPropertyTaxPaymentSchedule;
                var cityPropertyTaxPhone = _cityPropertyTaxPhone; cityPropertyTaxPhone.Clean = value; _cityPropertyTaxPhone = cityPropertyTaxPhone;
                var cityPropertyTaxPostalCode = _cityPropertyTaxPostalCode; cityPropertyTaxPostalCode.Clean = value; _cityPropertyTaxPostalCode = cityPropertyTaxPostalCode;
                var cityPropertyTaxState = _cityPropertyTaxState; cityPropertyTaxState.Clean = value; _cityPropertyTaxState = cityPropertyTaxState;
                var endingBalance = _endingBalance; endingBalance.Clean = value; _endingBalance = endingBalance;
                var escrowFirstPaymentDate = _escrowFirstPaymentDate; escrowFirstPaymentDate.Clean = value; _escrowFirstPaymentDate = escrowFirstPaymentDate;
                var escrowFirstPaymentDateType = _escrowFirstPaymentDateType; escrowFirstPaymentDateType.Clean = value; _escrowFirstPaymentDateType = escrowFirstPaymentDateType;
                var escrowPayment = _escrowPayment; escrowPayment.Clean = value; _escrowPayment = escrowPayment;
                var escrowPaymentYearly = _escrowPaymentYearly; escrowPaymentYearly.Clean = value; _escrowPaymentYearly = escrowPaymentYearly;
                var floodInsDisbCushion = _floodInsDisbCushion; floodInsDisbCushion.Clean = value; _floodInsDisbCushion = floodInsDisbCushion;
                var hazInsDisbCushion = _hazInsDisbCushion; hazInsDisbCushion.Clean = value; _hazInsDisbCushion = hazInsDisbCushion;
                var hud1EsDates = _hud1EsDates; hud1EsDates.Clean = value; _hud1EsDates = hud1EsDates;
                var hud1EsDueDates = _hud1EsDueDates; hud1EsDueDates.Clean = value; _hud1EsDueDates = hud1EsDueDates;
                var hud1EsItemizes = _hud1EsItemizes; hud1EsItemizes.Clean = value; _hud1EsItemizes = hud1EsItemizes;
                var hud1EsItemizesTotalLines = _hud1EsItemizesTotalLines; hud1EsItemizesTotalLines.Clean = value; _hud1EsItemizesTotalLines = hud1EsItemizesTotalLines;
                var hud1EsItemizesUseItemizeEscrowIndicator = _hud1EsItemizesUseItemizeEscrowIndicator; hud1EsItemizesUseItemizeEscrowIndicator.Clean = value; _hud1EsItemizesUseItemizeEscrowIndicator = hud1EsItemizesUseItemizeEscrowIndicator;
                var hud1EsPayTos = _hud1EsPayTos; hud1EsPayTos.Clean = value; _hud1EsPayTos = hud1EsPayTos;
                var hud1EsSetups = _hud1EsSetups; hud1EsSetups.Clean = value; _hud1EsSetups = hud1EsSetups;
                var id = _id; id.Clean = value; _id = id;
                var mtgInsCushionTerminationIndicator = _mtgInsCushionTerminationIndicator; mtgInsCushionTerminationIndicator.Clean = value; _mtgInsCushionTerminationIndicator = mtgInsCushionTerminationIndicator;
                var mtgInsDisbCushion = _mtgInsDisbCushion; mtgInsDisbCushion.Clean = value; _mtgInsDisbCushion = mtgInsDisbCushion;
                var nonEscrowCostsYearly = _nonEscrowCostsYearly; nonEscrowCostsYearly.Clean = value; _nonEscrowCostsYearly = nonEscrowCostsYearly;
                var realEstateTaxAddress = _realEstateTaxAddress; realEstateTaxAddress.Clean = value; _realEstateTaxAddress = realEstateTaxAddress;
                var realEstateTaxAmountLastPay = _realEstateTaxAmountLastPay; realEstateTaxAmountLastPay.Clean = value; _realEstateTaxAmountLastPay = realEstateTaxAmountLastPay;
                var realEstateTaxAmountNextDue = _realEstateTaxAmountNextDue; realEstateTaxAmountNextDue.Clean = value; _realEstateTaxAmountNextDue = realEstateTaxAmountNextDue;
                var realEstateTaxCity = _realEstateTaxCity; realEstateTaxCity.Clean = value; _realEstateTaxCity = realEstateTaxCity;
                var realEstateTaxContactName = _realEstateTaxContactName; realEstateTaxContactName.Clean = value; _realEstateTaxContactName = realEstateTaxContactName;
                var realEstateTaxDatePaid = _realEstateTaxDatePaid; realEstateTaxDatePaid.Clean = value; _realEstateTaxDatePaid = realEstateTaxDatePaid;
                var realEstateTaxDelinquentDate = _realEstateTaxDelinquentDate; realEstateTaxDelinquentDate.Clean = value; _realEstateTaxDelinquentDate = realEstateTaxDelinquentDate;
                var realEstateTaxEmail = _realEstateTaxEmail; realEstateTaxEmail.Clean = value; _realEstateTaxEmail = realEstateTaxEmail;
                var realEstateTaxFax = _realEstateTaxFax; realEstateTaxFax.Clean = value; _realEstateTaxFax = realEstateTaxFax;
                var realEstateTaxName = _realEstateTaxName; realEstateTaxName.Clean = value; _realEstateTaxName = realEstateTaxName;
                var realEstateTaxNextDueDate = _realEstateTaxNextDueDate; realEstateTaxNextDueDate.Clean = value; _realEstateTaxNextDueDate = realEstateTaxNextDueDate;
                var realEstateTaxPaymentSchedule = _realEstateTaxPaymentSchedule; realEstateTaxPaymentSchedule.Clean = value; _realEstateTaxPaymentSchedule = realEstateTaxPaymentSchedule;
                var realEstateTaxPhone = _realEstateTaxPhone; realEstateTaxPhone.Clean = value; _realEstateTaxPhone = realEstateTaxPhone;
                var realEstateTaxPostalCode = _realEstateTaxPostalCode; realEstateTaxPostalCode.Clean = value; _realEstateTaxPostalCode = realEstateTaxPostalCode;
                var realEstateTaxState = _realEstateTaxState; realEstateTaxState.Clean = value; _realEstateTaxState = realEstateTaxState;
                var schoolTaxesCushion = _schoolTaxesCushion; schoolTaxesCushion.Clean = value; _schoolTaxesCushion = schoolTaxesCushion;
                var servicerAddress = _servicerAddress; servicerAddress.Clean = value; _servicerAddress = servicerAddress;
                var servicerCity = _servicerCity; servicerCity.Clean = value; _servicerCity = servicerCity;
                var servicerContactName = _servicerContactName; servicerContactName.Clean = value; _servicerContactName = servicerContactName;
                var servicerPhone = _servicerPhone; servicerPhone.Clean = value; _servicerPhone = servicerPhone;
                var servicerPostalCode = _servicerPostalCode; servicerPostalCode.Clean = value; _servicerPostalCode = servicerPostalCode;
                var servicerState = _servicerState; servicerState.Clean = value; _servicerState = servicerState;
                var singleLineAnalysis = _singleLineAnalysis; singleLineAnalysis.Clean = value; _singleLineAnalysis = singleLineAnalysis;
                var startingBalance = _startingBalance; startingBalance.Clean = value; _startingBalance = startingBalance;
                var taxDisbCushion = _taxDisbCushion; taxDisbCushion.Clean = value; _taxDisbCushion = taxDisbCushion;
                var totalEscrowReserves = _totalEscrowReserves; totalEscrowReserves.Clean = value; _totalEscrowReserves = totalEscrowReserves;
                var usdaAnnualFee = _usdaAnnualFee; usdaAnnualFee.Clean = value; _usdaAnnualFee = usdaAnnualFee;
                var userDefinedCushion1 = _userDefinedCushion1; userDefinedCushion1.Clean = value; _userDefinedCushion1 = userDefinedCushion1;
                var userDefinedCushion2 = _userDefinedCushion2; userDefinedCushion2.Clean = value; _userDefinedCushion2 = userDefinedCushion2;
                var userDefinedCushion3 = _userDefinedCushion3; userDefinedCushion3.Clean = value; _userDefinedCushion3 = userDefinedCushion3;
                var yearlyMortgageInsurance = _yearlyMortgageInsurance; yearlyMortgageInsurance.Clean = value; _yearlyMortgageInsurance = yearlyMortgageInsurance;
                var yearlyUsdaFee = _yearlyUsdaFee; yearlyUsdaFee.Clean = value; _yearlyUsdaFee = yearlyUsdaFee;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
        [JsonConstructor]
        public Hud1Es()
        {
            Clean = true;
        }
    }
}