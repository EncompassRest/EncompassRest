using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    [JsonConverter(typeof(PublicallySerializableConverter))]
    public sealed partial class Hud1Es : IDirty
    {
        private DirtyValue<decimal?> _annualCityTax;
        public decimal? AnnualCityTax { get { return _annualCityTax; } set { _annualCityTax = value; } }
        private DirtyValue<int?> _annualFeeCushion;
        public int? AnnualFeeCushion { get { return _annualFeeCushion; } set { _annualFeeCushion = value; } }
        private DirtyValue<decimal?> _annualFloodInsurance;
        public decimal? AnnualFloodInsurance { get { return _annualFloodInsurance; } set { _annualFloodInsurance = value; } }
        private DirtyValue<decimal?> _annualHazardInsurance;
        public decimal? AnnualHazardInsurance { get { return _annualHazardInsurance; } set { _annualHazardInsurance = value; } }
        private DirtyValue<decimal?> _annualMortgageInsurance;
        public decimal? AnnualMortgageInsurance { get { return _annualMortgageInsurance; } set { _annualMortgageInsurance = value; } }
        private DirtyValue<decimal?> _annualTax;
        public decimal? AnnualTax { get { return _annualTax; } set { _annualTax = value; } }
        private DirtyValue<decimal?> _annualUserEscrow1;
        public decimal? AnnualUserEscrow1 { get { return _annualUserEscrow1; } set { _annualUserEscrow1 = value; } }
        private DirtyValue<decimal?> _annualUserEscrow2;
        public decimal? AnnualUserEscrow2 { get { return _annualUserEscrow2; } set { _annualUserEscrow2 = value; } }
        private DirtyValue<decimal?> _annualUserEscrow3;
        public decimal? AnnualUserEscrow3 { get { return _annualUserEscrow3; } set { _annualUserEscrow3 = value; } }
        private DirtyValue<decimal?> _biweeklyCityPropertyTaxes;
        public decimal? BiweeklyCityPropertyTaxes { get { return _biweeklyCityPropertyTaxes; } set { _biweeklyCityPropertyTaxes = value; } }
        private DirtyValue<decimal?> _biweeklyCountyTaxes;
        public decimal? BiweeklyCountyTaxes { get { return _biweeklyCountyTaxes; } set { _biweeklyCountyTaxes = value; } }
        private DirtyValue<decimal?> _biweeklyFloodInsurance;
        public decimal? BiweeklyFloodInsurance { get { return _biweeklyFloodInsurance; } set { _biweeklyFloodInsurance = value; } }
        private DirtyValue<decimal?> _biweeklyHazardInsurance;
        public decimal? BiweeklyHazardInsurance { get { return _biweeklyHazardInsurance; } set { _biweeklyHazardInsurance = value; } }
        private DirtyValue<decimal?> _biweeklyMortgageInsurance;
        public decimal? BiweeklyMortgageInsurance { get { return _biweeklyMortgageInsurance; } set { _biweeklyMortgageInsurance = value; } }
        private DirtyValue<decimal?> _biweeklyPITI;
        public decimal? BiweeklyPITI { get { return _biweeklyPITI; } set { _biweeklyPITI = value; } }
        private DirtyValue<decimal?> _biweeklyTotalBiweeklyPayment;
        public decimal? BiweeklyTotalBiweeklyPayment { get { return _biweeklyTotalBiweeklyPayment; } set { _biweeklyTotalBiweeklyPayment = value; } }
        private DirtyValue<decimal?> _biweeklyTotalBiweeklyPaymentToEscrow;
        public decimal? BiweeklyTotalBiweeklyPaymentToEscrow { get { return _biweeklyTotalBiweeklyPaymentToEscrow; } set { _biweeklyTotalBiweeklyPaymentToEscrow = value; } }
        private DirtyValue<decimal?> _biweeklyUSDAFee;
        public decimal? BiweeklyUSDAFee { get { return _biweeklyUSDAFee; } set { _biweeklyUSDAFee = value; } }
        private DirtyValue<decimal?> _biweeklyUserDefinedEscrowFee1;
        public decimal? BiweeklyUserDefinedEscrowFee1 { get { return _biweeklyUserDefinedEscrowFee1; } set { _biweeklyUserDefinedEscrowFee1 = value; } }
        private DirtyValue<decimal?> _biweeklyUserDefinedEscrowFee2;
        public decimal? BiweeklyUserDefinedEscrowFee2 { get { return _biweeklyUserDefinedEscrowFee2; } set { _biweeklyUserDefinedEscrowFee2 = value; } }
        private DirtyValue<decimal?> _biweeklyUserDefinedEscrowFee3;
        public decimal? BiweeklyUserDefinedEscrowFee3 { get { return _biweeklyUserDefinedEscrowFee3; } set { _biweeklyUserDefinedEscrowFee3 = value; } }
        private DirtyValue<string> _cityPropertyTaxAddress;
        public string CityPropertyTaxAddress { get { return _cityPropertyTaxAddress; } set { _cityPropertyTaxAddress = value; } }
        private DirtyValue<decimal?> _cityPropertyTaxAmountLastPay;
        public decimal? CityPropertyTaxAmountLastPay { get { return _cityPropertyTaxAmountLastPay; } set { _cityPropertyTaxAmountLastPay = value; } }
        private DirtyValue<decimal?> _cityPropertyTaxAmountNextDue;
        public decimal? CityPropertyTaxAmountNextDue { get { return _cityPropertyTaxAmountNextDue; } set { _cityPropertyTaxAmountNextDue = value; } }
        private DirtyValue<string> _cityPropertyTaxCity;
        public string CityPropertyTaxCity { get { return _cityPropertyTaxCity; } set { _cityPropertyTaxCity = value; } }
        private DirtyValue<string> _cityPropertyTaxContactName;
        public string CityPropertyTaxContactName { get { return _cityPropertyTaxContactName; } set { _cityPropertyTaxContactName = value; } }
        private DirtyValue<DateTime?> _cityPropertyTaxDatePaid;
        public DateTime? CityPropertyTaxDatePaid { get { return _cityPropertyTaxDatePaid; } set { _cityPropertyTaxDatePaid = value; } }
        private DirtyValue<DateTime?> _cityPropertyTaxDelinquentDate;
        public DateTime? CityPropertyTaxDelinquentDate { get { return _cityPropertyTaxDelinquentDate; } set { _cityPropertyTaxDelinquentDate = value; } }
        private DirtyValue<string> _cityPropertyTaxEmail;
        public string CityPropertyTaxEmail { get { return _cityPropertyTaxEmail; } set { _cityPropertyTaxEmail = value; } }
        private DirtyValue<string> _cityPropertyTaxFax;
        public string CityPropertyTaxFax { get { return _cityPropertyTaxFax; } set { _cityPropertyTaxFax = value; } }
        private DirtyValue<string> _cityPropertyTaxName;
        public string CityPropertyTaxName { get { return _cityPropertyTaxName; } set { _cityPropertyTaxName = value; } }
        private DirtyValue<DateTime?> _cityPropertyTaxNextDueDate;
        public DateTime? CityPropertyTaxNextDueDate { get { return _cityPropertyTaxNextDueDate; } set { _cityPropertyTaxNextDueDate = value; } }
        private DirtyValue<string> _cityPropertyTaxPaymentSchedule;
        public string CityPropertyTaxPaymentSchedule { get { return _cityPropertyTaxPaymentSchedule; } set { _cityPropertyTaxPaymentSchedule = value; } }
        private DirtyValue<string> _cityPropertyTaxPhone;
        public string CityPropertyTaxPhone { get { return _cityPropertyTaxPhone; } set { _cityPropertyTaxPhone = value; } }
        private DirtyValue<string> _cityPropertyTaxPostalCode;
        public string CityPropertyTaxPostalCode { get { return _cityPropertyTaxPostalCode; } set { _cityPropertyTaxPostalCode = value; } }
        private DirtyValue<string> _cityPropertyTaxState;
        public string CityPropertyTaxState { get { return _cityPropertyTaxState; } set { _cityPropertyTaxState = value; } }
        private DirtyValue<decimal?> _endingBalance;
        public decimal? EndingBalance { get { return _endingBalance; } set { _endingBalance = value; } }
        private DirtyValue<DateTime?> _escrowFirstPaymentDate;
        public DateTime? EscrowFirstPaymentDate { get { return _escrowFirstPaymentDate; } set { _escrowFirstPaymentDate = value; } }
        private DirtyValue<string> _escrowFirstPaymentDateType;
        public string EscrowFirstPaymentDateType { get { return _escrowFirstPaymentDateType; } set { _escrowFirstPaymentDateType = value; } }
        private DirtyValue<decimal?> _escrowPayment;
        public decimal? EscrowPayment { get { return _escrowPayment; } set { _escrowPayment = value; } }
        private DirtyValue<decimal?> _escrowPaymentYearly;
        public decimal? EscrowPaymentYearly { get { return _escrowPaymentYearly; } set { _escrowPaymentYearly = value; } }
        private DirtyValue<int?> _floodInsDisbCushion;
        public int? FloodInsDisbCushion { get { return _floodInsDisbCushion; } set { _floodInsDisbCushion = value; } }
        private DirtyValue<int?> _hazInsDisbCushion;
        public int? HazInsDisbCushion { get { return _hazInsDisbCushion; } set { _hazInsDisbCushion = value; } }
        private DirtyList<Hud1EsDate> _hud1EsDates;
        public IList<Hud1EsDate> Hud1EsDates { get { return _hud1EsDates ?? (_hud1EsDates = new DirtyList<Hud1EsDate>()); } set { _hud1EsDates = new DirtyList<Hud1EsDate>(value); } }
        private DirtyList<Hud1EsDueDate> _hud1EsDueDates;
        public IList<Hud1EsDueDate> Hud1EsDueDates { get { return _hud1EsDueDates ?? (_hud1EsDueDates = new DirtyList<Hud1EsDueDate>()); } set { _hud1EsDueDates = new DirtyList<Hud1EsDueDate>(value); } }
        private DirtyList<Hud1EsItemize> _hud1EsItemizes;
        public IList<Hud1EsItemize> Hud1EsItemizes { get { return _hud1EsItemizes ?? (_hud1EsItemizes = new DirtyList<Hud1EsItemize>()); } set { _hud1EsItemizes = new DirtyList<Hud1EsItemize>(value); } }
        private DirtyValue<int?> _hud1EsItemizesTotalLines;
        public int? Hud1EsItemizesTotalLines { get { return _hud1EsItemizesTotalLines; } set { _hud1EsItemizesTotalLines = value; } }
        private DirtyValue<bool?> _hud1EsItemizesUseItemizeEscrowIndicator;
        public bool? Hud1EsItemizesUseItemizeEscrowIndicator { get { return _hud1EsItemizesUseItemizeEscrowIndicator; } set { _hud1EsItemizesUseItemizeEscrowIndicator = value; } }
        private DirtyList<Hud1EsPayTo> _hud1EsPayTos;
        public IList<Hud1EsPayTo> Hud1EsPayTos { get { return _hud1EsPayTos ?? (_hud1EsPayTos = new DirtyList<Hud1EsPayTo>()); } set { _hud1EsPayTos = new DirtyList<Hud1EsPayTo>(value); } }
        private DirtyList<Hud1EsSetup> _hud1EsSetups;
        public IList<Hud1EsSetup> Hud1EsSetups { get { return _hud1EsSetups ?? (_hud1EsSetups = new DirtyList<Hud1EsSetup>()); } set { _hud1EsSetups = new DirtyList<Hud1EsSetup>(value); } }
        private DirtyValue<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private DirtyValue<bool?> _mtgInsCushionTerminationIndicator;
        public bool? MtgInsCushionTerminationIndicator { get { return _mtgInsCushionTerminationIndicator; } set { _mtgInsCushionTerminationIndicator = value; } }
        private DirtyValue<int?> _mtgInsDisbCushion;
        public int? MtgInsDisbCushion { get { return _mtgInsDisbCushion; } set { _mtgInsDisbCushion = value; } }
        private DirtyValue<decimal?> _nonEscrowCostsYearly;
        public decimal? NonEscrowCostsYearly { get { return _nonEscrowCostsYearly; } set { _nonEscrowCostsYearly = value; } }
        private DirtyValue<string> _realEstateTaxAddress;
        public string RealEstateTaxAddress { get { return _realEstateTaxAddress; } set { _realEstateTaxAddress = value; } }
        private DirtyValue<decimal?> _realEstateTaxAmountLastPay;
        public decimal? RealEstateTaxAmountLastPay { get { return _realEstateTaxAmountLastPay; } set { _realEstateTaxAmountLastPay = value; } }
        private DirtyValue<decimal?> _realEstateTaxAmountNextDue;
        public decimal? RealEstateTaxAmountNextDue { get { return _realEstateTaxAmountNextDue; } set { _realEstateTaxAmountNextDue = value; } }
        private DirtyValue<string> _realEstateTaxCity;
        public string RealEstateTaxCity { get { return _realEstateTaxCity; } set { _realEstateTaxCity = value; } }
        private DirtyValue<string> _realEstateTaxContactName;
        public string RealEstateTaxContactName { get { return _realEstateTaxContactName; } set { _realEstateTaxContactName = value; } }
        private DirtyValue<DateTime?> _realEstateTaxDatePaid;
        public DateTime? RealEstateTaxDatePaid { get { return _realEstateTaxDatePaid; } set { _realEstateTaxDatePaid = value; } }
        private DirtyValue<DateTime?> _realEstateTaxDelinquentDate;
        public DateTime? RealEstateTaxDelinquentDate { get { return _realEstateTaxDelinquentDate; } set { _realEstateTaxDelinquentDate = value; } }
        private DirtyValue<string> _realEstateTaxEmail;
        public string RealEstateTaxEmail { get { return _realEstateTaxEmail; } set { _realEstateTaxEmail = value; } }
        private DirtyValue<string> _realEstateTaxFax;
        public string RealEstateTaxFax { get { return _realEstateTaxFax; } set { _realEstateTaxFax = value; } }
        private DirtyValue<string> _realEstateTaxName;
        public string RealEstateTaxName { get { return _realEstateTaxName; } set { _realEstateTaxName = value; } }
        private DirtyValue<DateTime?> _realEstateTaxNextDueDate;
        public DateTime? RealEstateTaxNextDueDate { get { return _realEstateTaxNextDueDate; } set { _realEstateTaxNextDueDate = value; } }
        private DirtyValue<string> _realEstateTaxPaymentSchedule;
        public string RealEstateTaxPaymentSchedule { get { return _realEstateTaxPaymentSchedule; } set { _realEstateTaxPaymentSchedule = value; } }
        private DirtyValue<string> _realEstateTaxPhone;
        public string RealEstateTaxPhone { get { return _realEstateTaxPhone; } set { _realEstateTaxPhone = value; } }
        private DirtyValue<string> _realEstateTaxPostalCode;
        public string RealEstateTaxPostalCode { get { return _realEstateTaxPostalCode; } set { _realEstateTaxPostalCode = value; } }
        private DirtyValue<string> _realEstateTaxState;
        public string RealEstateTaxState { get { return _realEstateTaxState; } set { _realEstateTaxState = value; } }
        private DirtyValue<int?> _schoolTaxesCushion;
        public int? SchoolTaxesCushion { get { return _schoolTaxesCushion; } set { _schoolTaxesCushion = value; } }
        private DirtyValue<string> _servicerAddress;
        public string ServicerAddress { get { return _servicerAddress; } set { _servicerAddress = value; } }
        private DirtyValue<string> _servicerCity;
        public string ServicerCity { get { return _servicerCity; } set { _servicerCity = value; } }
        private DirtyValue<string> _servicerContactName;
        public string ServicerContactName { get { return _servicerContactName; } set { _servicerContactName = value; } }
        private DirtyValue<string> _servicerPhone;
        public string ServicerPhone { get { return _servicerPhone; } set { _servicerPhone = value; } }
        private DirtyValue<string> _servicerPostalCode;
        public string ServicerPostalCode { get { return _servicerPostalCode; } set { _servicerPostalCode = value; } }
        private DirtyValue<string> _servicerState;
        public string ServicerState { get { return _servicerState; } set { _servicerState = value; } }
        private DirtyValue<decimal?> _singleLineAnalysis;
        public decimal? SingleLineAnalysis { get { return _singleLineAnalysis; } set { _singleLineAnalysis = value; } }
        private DirtyValue<decimal?> _startingBalance;
        public decimal? StartingBalance { get { return _startingBalance; } set { _startingBalance = value; } }
        private DirtyValue<int?> _taxDisbCushion;
        public int? TaxDisbCushion { get { return _taxDisbCushion; } set { _taxDisbCushion = value; } }
        private DirtyValue<decimal?> _totalEscrowReserves;
        public decimal? TotalEscrowReserves { get { return _totalEscrowReserves; } set { _totalEscrowReserves = value; } }
        private DirtyValue<decimal?> _usdaAnnualFee;
        public decimal? UsdaAnnualFee { get { return _usdaAnnualFee; } set { _usdaAnnualFee = value; } }
        private DirtyValue<int?> _userDefinedCushion1;
        public int? UserDefinedCushion1 { get { return _userDefinedCushion1; } set { _userDefinedCushion1 = value; } }
        private DirtyValue<int?> _userDefinedCushion2;
        public int? UserDefinedCushion2 { get { return _userDefinedCushion2; } set { _userDefinedCushion2 = value; } }
        private DirtyValue<int?> _userDefinedCushion3;
        public int? UserDefinedCushion3 { get { return _userDefinedCushion3; } set { _userDefinedCushion3 = value; } }
        private DirtyValue<decimal?> _yearlyMortgageInsurance;
        public decimal? YearlyMortgageInsurance { get { return _yearlyMortgageInsurance; } set { _yearlyMortgageInsurance = value; } }
        private DirtyValue<decimal?> _yearlyUsdaFee;
        public decimal? YearlyUsdaFee { get { return _yearlyUsdaFee; } set { _yearlyUsdaFee = value; } }
        private ExtensionDataObject _extensionDataInternal;
        [JsonExtensionData]
        private ExtensionDataObject ExtensionDataInternal { get { return _extensionDataInternal ?? (_extensionDataInternal = new ExtensionDataObject()); } set { _extensionDataInternal = value; } }
        [JsonIgnore]
        public IDictionary<string, object> ExtensionData { get { return ExtensionDataInternal.InternalDictionary; } set { _extensionDataInternal = new ExtensionDataObject(value); } }
        private bool _gettingDirty;
        private bool _settingDirty; 
        internal bool Dirty
        {
            get
            {
                if (_gettingDirty) return false;
                _gettingDirty = true;
                var dirty = _annualCityTax.Dirty
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
                    || _hud1EsSetups?.Dirty == true
                    || _extensionDataInternal?.Dirty == true;
                _gettingDirty = false;
                return dirty;
            }
            set
            {
                if (_settingDirty) return;
                _settingDirty = true;
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
                if (_extensionDataInternal != null) _extensionDataInternal.Dirty = value;
                _settingDirty = false;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}