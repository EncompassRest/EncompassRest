using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class Hud1Es
    {
        private Value<decimal?> _annualCityTax;
        public decimal? AnnualCityTax { get { return _annualCityTax; } set { _annualCityTax = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAnnualCityTax() => !_annualCityTax.Clean;
        private Value<int?> _annualFeeCushion;
        public int? AnnualFeeCushion { get { return _annualFeeCushion; } set { _annualFeeCushion = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAnnualFeeCushion() => !_annualFeeCushion.Clean;
        private Value<decimal?> _annualFloodInsurance;
        public decimal? AnnualFloodInsurance { get { return _annualFloodInsurance; } set { _annualFloodInsurance = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAnnualFloodInsurance() => !_annualFloodInsurance.Clean;
        private Value<decimal?> _annualHazardInsurance;
        public decimal? AnnualHazardInsurance { get { return _annualHazardInsurance; } set { _annualHazardInsurance = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAnnualHazardInsurance() => !_annualHazardInsurance.Clean;
        private Value<decimal?> _annualMortgageInsurance;
        public decimal? AnnualMortgageInsurance { get { return _annualMortgageInsurance; } set { _annualMortgageInsurance = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAnnualMortgageInsurance() => !_annualMortgageInsurance.Clean;
        private Value<decimal?> _annualTax;
        public decimal? AnnualTax { get { return _annualTax; } set { _annualTax = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAnnualTax() => !_annualTax.Clean;
        private Value<decimal?> _annualUserEscrow1;
        public decimal? AnnualUserEscrow1 { get { return _annualUserEscrow1; } set { _annualUserEscrow1 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAnnualUserEscrow1() => !_annualUserEscrow1.Clean;
        private Value<decimal?> _annualUserEscrow2;
        public decimal? AnnualUserEscrow2 { get { return _annualUserEscrow2; } set { _annualUserEscrow2 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAnnualUserEscrow2() => !_annualUserEscrow2.Clean;
        private Value<decimal?> _annualUserEscrow3;
        public decimal? AnnualUserEscrow3 { get { return _annualUserEscrow3; } set { _annualUserEscrow3 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAnnualUserEscrow3() => !_annualUserEscrow3.Clean;
        private Value<decimal?> _biweeklyCityPropertyTaxes;
        public decimal? BiweeklyCityPropertyTaxes { get { return _biweeklyCityPropertyTaxes; } set { _biweeklyCityPropertyTaxes = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBiweeklyCityPropertyTaxes() => !_biweeklyCityPropertyTaxes.Clean;
        private Value<decimal?> _biweeklyCountyTaxes;
        public decimal? BiweeklyCountyTaxes { get { return _biweeklyCountyTaxes; } set { _biweeklyCountyTaxes = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBiweeklyCountyTaxes() => !_biweeklyCountyTaxes.Clean;
        private Value<decimal?> _biweeklyFloodInsurance;
        public decimal? BiweeklyFloodInsurance { get { return _biweeklyFloodInsurance; } set { _biweeklyFloodInsurance = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBiweeklyFloodInsurance() => !_biweeklyFloodInsurance.Clean;
        private Value<decimal?> _biweeklyHazardInsurance;
        public decimal? BiweeklyHazardInsurance { get { return _biweeklyHazardInsurance; } set { _biweeklyHazardInsurance = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBiweeklyHazardInsurance() => !_biweeklyHazardInsurance.Clean;
        private Value<decimal?> _biweeklyMortgageInsurance;
        public decimal? BiweeklyMortgageInsurance { get { return _biweeklyMortgageInsurance; } set { _biweeklyMortgageInsurance = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBiweeklyMortgageInsurance() => !_biweeklyMortgageInsurance.Clean;
        private Value<decimal?> _biweeklyPITI;
        public decimal? BiweeklyPITI { get { return _biweeklyPITI; } set { _biweeklyPITI = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBiweeklyPITI() => !_biweeklyPITI.Clean;
        private Value<decimal?> _biweeklyTotalBiweeklyPayment;
        public decimal? BiweeklyTotalBiweeklyPayment { get { return _biweeklyTotalBiweeklyPayment; } set { _biweeklyTotalBiweeklyPayment = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBiweeklyTotalBiweeklyPayment() => !_biweeklyTotalBiweeklyPayment.Clean;
        private Value<decimal?> _biweeklyTotalBiweeklyPaymentToEscrow;
        public decimal? BiweeklyTotalBiweeklyPaymentToEscrow { get { return _biweeklyTotalBiweeklyPaymentToEscrow; } set { _biweeklyTotalBiweeklyPaymentToEscrow = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBiweeklyTotalBiweeklyPaymentToEscrow() => !_biweeklyTotalBiweeklyPaymentToEscrow.Clean;
        private Value<decimal?> _biweeklyUSDAFee;
        public decimal? BiweeklyUSDAFee { get { return _biweeklyUSDAFee; } set { _biweeklyUSDAFee = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBiweeklyUSDAFee() => !_biweeklyUSDAFee.Clean;
        private Value<decimal?> _biweeklyUserDefinedEscrowFee1;
        public decimal? BiweeklyUserDefinedEscrowFee1 { get { return _biweeklyUserDefinedEscrowFee1; } set { _biweeklyUserDefinedEscrowFee1 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBiweeklyUserDefinedEscrowFee1() => !_biweeklyUserDefinedEscrowFee1.Clean;
        private Value<decimal?> _biweeklyUserDefinedEscrowFee2;
        public decimal? BiweeklyUserDefinedEscrowFee2 { get { return _biweeklyUserDefinedEscrowFee2; } set { _biweeklyUserDefinedEscrowFee2 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBiweeklyUserDefinedEscrowFee2() => !_biweeklyUserDefinedEscrowFee2.Clean;
        private Value<decimal?> _biweeklyUserDefinedEscrowFee3;
        public decimal? BiweeklyUserDefinedEscrowFee3 { get { return _biweeklyUserDefinedEscrowFee3; } set { _biweeklyUserDefinedEscrowFee3 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBiweeklyUserDefinedEscrowFee3() => !_biweeklyUserDefinedEscrowFee3.Clean;
        private Value<string> _cityPropertyTaxAddress;
        public string CityPropertyTaxAddress { get { return _cityPropertyTaxAddress; } set { _cityPropertyTaxAddress = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCityPropertyTaxAddress() => !_cityPropertyTaxAddress.Clean;
        private Value<decimal?> _cityPropertyTaxAmountLastPay;
        public decimal? CityPropertyTaxAmountLastPay { get { return _cityPropertyTaxAmountLastPay; } set { _cityPropertyTaxAmountLastPay = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCityPropertyTaxAmountLastPay() => !_cityPropertyTaxAmountLastPay.Clean;
        private Value<decimal?> _cityPropertyTaxAmountNextDue;
        public decimal? CityPropertyTaxAmountNextDue { get { return _cityPropertyTaxAmountNextDue; } set { _cityPropertyTaxAmountNextDue = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCityPropertyTaxAmountNextDue() => !_cityPropertyTaxAmountNextDue.Clean;
        private Value<string> _cityPropertyTaxCity;
        public string CityPropertyTaxCity { get { return _cityPropertyTaxCity; } set { _cityPropertyTaxCity = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCityPropertyTaxCity() => !_cityPropertyTaxCity.Clean;
        private Value<string> _cityPropertyTaxContactName;
        public string CityPropertyTaxContactName { get { return _cityPropertyTaxContactName; } set { _cityPropertyTaxContactName = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCityPropertyTaxContactName() => !_cityPropertyTaxContactName.Clean;
        private Value<DateTime?> _cityPropertyTaxDatePaid;
        public DateTime? CityPropertyTaxDatePaid { get { return _cityPropertyTaxDatePaid; } set { _cityPropertyTaxDatePaid = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCityPropertyTaxDatePaid() => !_cityPropertyTaxDatePaid.Clean;
        private Value<DateTime?> _cityPropertyTaxDelinquentDate;
        public DateTime? CityPropertyTaxDelinquentDate { get { return _cityPropertyTaxDelinquentDate; } set { _cityPropertyTaxDelinquentDate = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCityPropertyTaxDelinquentDate() => !_cityPropertyTaxDelinquentDate.Clean;
        private Value<string> _cityPropertyTaxEmail;
        public string CityPropertyTaxEmail { get { return _cityPropertyTaxEmail; } set { _cityPropertyTaxEmail = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCityPropertyTaxEmail() => !_cityPropertyTaxEmail.Clean;
        private Value<string> _cityPropertyTaxFax;
        public string CityPropertyTaxFax { get { return _cityPropertyTaxFax; } set { _cityPropertyTaxFax = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCityPropertyTaxFax() => !_cityPropertyTaxFax.Clean;
        private Value<string> _cityPropertyTaxName;
        public string CityPropertyTaxName { get { return _cityPropertyTaxName; } set { _cityPropertyTaxName = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCityPropertyTaxName() => !_cityPropertyTaxName.Clean;
        private Value<DateTime?> _cityPropertyTaxNextDueDate;
        public DateTime? CityPropertyTaxNextDueDate { get { return _cityPropertyTaxNextDueDate; } set { _cityPropertyTaxNextDueDate = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCityPropertyTaxNextDueDate() => !_cityPropertyTaxNextDueDate.Clean;
        private Value<string> _cityPropertyTaxPaymentSchedule;
        public string CityPropertyTaxPaymentSchedule { get { return _cityPropertyTaxPaymentSchedule; } set { _cityPropertyTaxPaymentSchedule = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCityPropertyTaxPaymentSchedule() => !_cityPropertyTaxPaymentSchedule.Clean;
        private Value<string> _cityPropertyTaxPhone;
        public string CityPropertyTaxPhone { get { return _cityPropertyTaxPhone; } set { _cityPropertyTaxPhone = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCityPropertyTaxPhone() => !_cityPropertyTaxPhone.Clean;
        private Value<string> _cityPropertyTaxPostalCode;
        public string CityPropertyTaxPostalCode { get { return _cityPropertyTaxPostalCode; } set { _cityPropertyTaxPostalCode = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCityPropertyTaxPostalCode() => !_cityPropertyTaxPostalCode.Clean;
        private Value<string> _cityPropertyTaxState;
        public string CityPropertyTaxState { get { return _cityPropertyTaxState; } set { _cityPropertyTaxState = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCityPropertyTaxState() => !_cityPropertyTaxState.Clean;
        private Value<decimal?> _endingBalance;
        public decimal? EndingBalance { get { return _endingBalance; } set { _endingBalance = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEndingBalance() => !_endingBalance.Clean;
        private Value<DateTime?> _escrowFirstPaymentDate;
        public DateTime? EscrowFirstPaymentDate { get { return _escrowFirstPaymentDate; } set { _escrowFirstPaymentDate = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEscrowFirstPaymentDate() => !_escrowFirstPaymentDate.Clean;
        private Value<string> _escrowFirstPaymentDateType;
        public string EscrowFirstPaymentDateType { get { return _escrowFirstPaymentDateType; } set { _escrowFirstPaymentDateType = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEscrowFirstPaymentDateType() => !_escrowFirstPaymentDateType.Clean;
        private Value<decimal?> _escrowPayment;
        public decimal? EscrowPayment { get { return _escrowPayment; } set { _escrowPayment = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEscrowPayment() => !_escrowPayment.Clean;
        private Value<decimal?> _escrowPaymentYearly;
        public decimal? EscrowPaymentYearly { get { return _escrowPaymentYearly; } set { _escrowPaymentYearly = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEscrowPaymentYearly() => !_escrowPaymentYearly.Clean;
        private Value<int?> _floodInsDisbCushion;
        public int? FloodInsDisbCushion { get { return _floodInsDisbCushion; } set { _floodInsDisbCushion = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFloodInsDisbCushion() => !_floodInsDisbCushion.Clean;
        private Value<int?> _hazInsDisbCushion;
        public int? HazInsDisbCushion { get { return _hazInsDisbCushion; } set { _hazInsDisbCushion = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHazInsDisbCushion() => !_hazInsDisbCushion.Clean;
        private Value<List<Hud1EsDate>> _hud1EsDates;
        public List<Hud1EsDate> Hud1EsDates { get { return _hud1EsDates; } set { _hud1EsDates = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHud1EsDates() => !_hud1EsDates.Clean;
        private Value<List<Hud1EsDueDate>> _hud1EsDueDates;
        public List<Hud1EsDueDate> Hud1EsDueDates { get { return _hud1EsDueDates; } set { _hud1EsDueDates = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHud1EsDueDates() => !_hud1EsDueDates.Clean;
        private Value<List<Hud1EsItemize>> _hud1EsItemizes;
        public List<Hud1EsItemize> Hud1EsItemizes { get { return _hud1EsItemizes; } set { _hud1EsItemizes = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHud1EsItemizes() => !_hud1EsItemizes.Clean;
        private Value<int?> _hud1EsItemizesTotalLines;
        public int? Hud1EsItemizesTotalLines { get { return _hud1EsItemizesTotalLines; } set { _hud1EsItemizesTotalLines = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHud1EsItemizesTotalLines() => !_hud1EsItemizesTotalLines.Clean;
        private Value<bool?> _hud1EsItemizesUseItemizeEscrowIndicator;
        public bool? Hud1EsItemizesUseItemizeEscrowIndicator { get { return _hud1EsItemizesUseItemizeEscrowIndicator; } set { _hud1EsItemizesUseItemizeEscrowIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHud1EsItemizesUseItemizeEscrowIndicator() => !_hud1EsItemizesUseItemizeEscrowIndicator.Clean;
        private Value<List<Hud1EsPayTo>> _hud1EsPayTos;
        public List<Hud1EsPayTo> Hud1EsPayTos { get { return _hud1EsPayTos; } set { _hud1EsPayTos = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHud1EsPayTos() => !_hud1EsPayTos.Clean;
        private Value<List<Hud1EsSetup>> _hud1EsSetups;
        public List<Hud1EsSetup> Hud1EsSetups { get { return _hud1EsSetups; } set { _hud1EsSetups = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHud1EsSetups() => !_hud1EsSetups.Clean;
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !_id.Clean;
        private Value<bool?> _mtgInsCushionTerminationIndicator;
        public bool? MtgInsCushionTerminationIndicator { get { return _mtgInsCushionTerminationIndicator; } set { _mtgInsCushionTerminationIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMtgInsCushionTerminationIndicator() => !_mtgInsCushionTerminationIndicator.Clean;
        private Value<int?> _mtgInsDisbCushion;
        public int? MtgInsDisbCushion { get { return _mtgInsDisbCushion; } set { _mtgInsDisbCushion = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMtgInsDisbCushion() => !_mtgInsDisbCushion.Clean;
        private Value<decimal?> _nonEscrowCostsYearly;
        public decimal? NonEscrowCostsYearly { get { return _nonEscrowCostsYearly; } set { _nonEscrowCostsYearly = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNonEscrowCostsYearly() => !_nonEscrowCostsYearly.Clean;
        private Value<string> _realEstateTaxAddress;
        public string RealEstateTaxAddress { get { return _realEstateTaxAddress; } set { _realEstateTaxAddress = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRealEstateTaxAddress() => !_realEstateTaxAddress.Clean;
        private Value<decimal?> _realEstateTaxAmountLastPay;
        public decimal? RealEstateTaxAmountLastPay { get { return _realEstateTaxAmountLastPay; } set { _realEstateTaxAmountLastPay = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRealEstateTaxAmountLastPay() => !_realEstateTaxAmountLastPay.Clean;
        private Value<decimal?> _realEstateTaxAmountNextDue;
        public decimal? RealEstateTaxAmountNextDue { get { return _realEstateTaxAmountNextDue; } set { _realEstateTaxAmountNextDue = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRealEstateTaxAmountNextDue() => !_realEstateTaxAmountNextDue.Clean;
        private Value<string> _realEstateTaxCity;
        public string RealEstateTaxCity { get { return _realEstateTaxCity; } set { _realEstateTaxCity = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRealEstateTaxCity() => !_realEstateTaxCity.Clean;
        private Value<string> _realEstateTaxContactName;
        public string RealEstateTaxContactName { get { return _realEstateTaxContactName; } set { _realEstateTaxContactName = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRealEstateTaxContactName() => !_realEstateTaxContactName.Clean;
        private Value<DateTime?> _realEstateTaxDatePaid;
        public DateTime? RealEstateTaxDatePaid { get { return _realEstateTaxDatePaid; } set { _realEstateTaxDatePaid = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRealEstateTaxDatePaid() => !_realEstateTaxDatePaid.Clean;
        private Value<DateTime?> _realEstateTaxDelinquentDate;
        public DateTime? RealEstateTaxDelinquentDate { get { return _realEstateTaxDelinquentDate; } set { _realEstateTaxDelinquentDate = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRealEstateTaxDelinquentDate() => !_realEstateTaxDelinquentDate.Clean;
        private Value<string> _realEstateTaxEmail;
        public string RealEstateTaxEmail { get { return _realEstateTaxEmail; } set { _realEstateTaxEmail = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRealEstateTaxEmail() => !_realEstateTaxEmail.Clean;
        private Value<string> _realEstateTaxFax;
        public string RealEstateTaxFax { get { return _realEstateTaxFax; } set { _realEstateTaxFax = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRealEstateTaxFax() => !_realEstateTaxFax.Clean;
        private Value<string> _realEstateTaxName;
        public string RealEstateTaxName { get { return _realEstateTaxName; } set { _realEstateTaxName = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRealEstateTaxName() => !_realEstateTaxName.Clean;
        private Value<DateTime?> _realEstateTaxNextDueDate;
        public DateTime? RealEstateTaxNextDueDate { get { return _realEstateTaxNextDueDate; } set { _realEstateTaxNextDueDate = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRealEstateTaxNextDueDate() => !_realEstateTaxNextDueDate.Clean;
        private Value<string> _realEstateTaxPaymentSchedule;
        public string RealEstateTaxPaymentSchedule { get { return _realEstateTaxPaymentSchedule; } set { _realEstateTaxPaymentSchedule = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRealEstateTaxPaymentSchedule() => !_realEstateTaxPaymentSchedule.Clean;
        private Value<string> _realEstateTaxPhone;
        public string RealEstateTaxPhone { get { return _realEstateTaxPhone; } set { _realEstateTaxPhone = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRealEstateTaxPhone() => !_realEstateTaxPhone.Clean;
        private Value<string> _realEstateTaxPostalCode;
        public string RealEstateTaxPostalCode { get { return _realEstateTaxPostalCode; } set { _realEstateTaxPostalCode = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRealEstateTaxPostalCode() => !_realEstateTaxPostalCode.Clean;
        private Value<string> _realEstateTaxState;
        public string RealEstateTaxState { get { return _realEstateTaxState; } set { _realEstateTaxState = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRealEstateTaxState() => !_realEstateTaxState.Clean;
        private Value<int?> _schoolTaxesCushion;
        public int? SchoolTaxesCushion { get { return _schoolTaxesCushion; } set { _schoolTaxesCushion = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSchoolTaxesCushion() => !_schoolTaxesCushion.Clean;
        private Value<string> _servicerAddress;
        public string ServicerAddress { get { return _servicerAddress; } set { _servicerAddress = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeServicerAddress() => !_servicerAddress.Clean;
        private Value<string> _servicerCity;
        public string ServicerCity { get { return _servicerCity; } set { _servicerCity = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeServicerCity() => !_servicerCity.Clean;
        private Value<string> _servicerContactName;
        public string ServicerContactName { get { return _servicerContactName; } set { _servicerContactName = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeServicerContactName() => !_servicerContactName.Clean;
        private Value<string> _servicerPhone;
        public string ServicerPhone { get { return _servicerPhone; } set { _servicerPhone = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeServicerPhone() => !_servicerPhone.Clean;
        private Value<string> _servicerPostalCode;
        public string ServicerPostalCode { get { return _servicerPostalCode; } set { _servicerPostalCode = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeServicerPostalCode() => !_servicerPostalCode.Clean;
        private Value<string> _servicerState;
        public string ServicerState { get { return _servicerState; } set { _servicerState = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeServicerState() => !_servicerState.Clean;
        private Value<decimal?> _singleLineAnalysis;
        public decimal? SingleLineAnalysis { get { return _singleLineAnalysis; } set { _singleLineAnalysis = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSingleLineAnalysis() => !_singleLineAnalysis.Clean;
        private Value<decimal?> _startingBalance;
        public decimal? StartingBalance { get { return _startingBalance; } set { _startingBalance = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeStartingBalance() => !_startingBalance.Clean;
        private Value<int?> _taxDisbCushion;
        public int? TaxDisbCushion { get { return _taxDisbCushion; } set { _taxDisbCushion = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTaxDisbCushion() => !_taxDisbCushion.Clean;
        private Value<decimal?> _totalEscrowReserves;
        public decimal? TotalEscrowReserves { get { return _totalEscrowReserves; } set { _totalEscrowReserves = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalEscrowReserves() => !_totalEscrowReserves.Clean;
        private Value<decimal?> _usdaAnnualFee;
        public decimal? UsdaAnnualFee { get { return _usdaAnnualFee; } set { _usdaAnnualFee = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUsdaAnnualFee() => !_usdaAnnualFee.Clean;
        private Value<int?> _userDefinedCushion1;
        public int? UserDefinedCushion1 { get { return _userDefinedCushion1; } set { _userDefinedCushion1 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUserDefinedCushion1() => !_userDefinedCushion1.Clean;
        private Value<int?> _userDefinedCushion2;
        public int? UserDefinedCushion2 { get { return _userDefinedCushion2; } set { _userDefinedCushion2 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUserDefinedCushion2() => !_userDefinedCushion2.Clean;
        private Value<int?> _userDefinedCushion3;
        public int? UserDefinedCushion3 { get { return _userDefinedCushion3; } set { _userDefinedCushion3 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUserDefinedCushion3() => !_userDefinedCushion3.Clean;
        private Value<decimal?> _yearlyMortgageInsurance;
        public decimal? YearlyMortgageInsurance { get { return _yearlyMortgageInsurance; } set { _yearlyMortgageInsurance = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeYearlyMortgageInsurance() => !_yearlyMortgageInsurance.Clean;
        private Value<decimal?> _yearlyUsdaFee;
        public decimal? YearlyUsdaFee { get { return _yearlyUsdaFee; } set { _yearlyUsdaFee = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeYearlyUsdaFee() => !_yearlyUsdaFee.Clean;
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
                var v0 = _annualCityTax; v0.Clean = value; _annualCityTax = v0;
                var v1 = _annualFeeCushion; v1.Clean = value; _annualFeeCushion = v1;
                var v2 = _annualFloodInsurance; v2.Clean = value; _annualFloodInsurance = v2;
                var v3 = _annualHazardInsurance; v3.Clean = value; _annualHazardInsurance = v3;
                var v4 = _annualMortgageInsurance; v4.Clean = value; _annualMortgageInsurance = v4;
                var v5 = _annualTax; v5.Clean = value; _annualTax = v5;
                var v6 = _annualUserEscrow1; v6.Clean = value; _annualUserEscrow1 = v6;
                var v7 = _annualUserEscrow2; v7.Clean = value; _annualUserEscrow2 = v7;
                var v8 = _annualUserEscrow3; v8.Clean = value; _annualUserEscrow3 = v8;
                var v9 = _biweeklyCityPropertyTaxes; v9.Clean = value; _biweeklyCityPropertyTaxes = v9;
                var v10 = _biweeklyCountyTaxes; v10.Clean = value; _biweeklyCountyTaxes = v10;
                var v11 = _biweeklyFloodInsurance; v11.Clean = value; _biweeklyFloodInsurance = v11;
                var v12 = _biweeklyHazardInsurance; v12.Clean = value; _biweeklyHazardInsurance = v12;
                var v13 = _biweeklyMortgageInsurance; v13.Clean = value; _biweeklyMortgageInsurance = v13;
                var v14 = _biweeklyPITI; v14.Clean = value; _biweeklyPITI = v14;
                var v15 = _biweeklyTotalBiweeklyPayment; v15.Clean = value; _biweeklyTotalBiweeklyPayment = v15;
                var v16 = _biweeklyTotalBiweeklyPaymentToEscrow; v16.Clean = value; _biweeklyTotalBiweeklyPaymentToEscrow = v16;
                var v17 = _biweeklyUSDAFee; v17.Clean = value; _biweeklyUSDAFee = v17;
                var v18 = _biweeklyUserDefinedEscrowFee1; v18.Clean = value; _biweeklyUserDefinedEscrowFee1 = v18;
                var v19 = _biweeklyUserDefinedEscrowFee2; v19.Clean = value; _biweeklyUserDefinedEscrowFee2 = v19;
                var v20 = _biweeklyUserDefinedEscrowFee3; v20.Clean = value; _biweeklyUserDefinedEscrowFee3 = v20;
                var v21 = _cityPropertyTaxAddress; v21.Clean = value; _cityPropertyTaxAddress = v21;
                var v22 = _cityPropertyTaxAmountLastPay; v22.Clean = value; _cityPropertyTaxAmountLastPay = v22;
                var v23 = _cityPropertyTaxAmountNextDue; v23.Clean = value; _cityPropertyTaxAmountNextDue = v23;
                var v24 = _cityPropertyTaxCity; v24.Clean = value; _cityPropertyTaxCity = v24;
                var v25 = _cityPropertyTaxContactName; v25.Clean = value; _cityPropertyTaxContactName = v25;
                var v26 = _cityPropertyTaxDatePaid; v26.Clean = value; _cityPropertyTaxDatePaid = v26;
                var v27 = _cityPropertyTaxDelinquentDate; v27.Clean = value; _cityPropertyTaxDelinquentDate = v27;
                var v28 = _cityPropertyTaxEmail; v28.Clean = value; _cityPropertyTaxEmail = v28;
                var v29 = _cityPropertyTaxFax; v29.Clean = value; _cityPropertyTaxFax = v29;
                var v30 = _cityPropertyTaxName; v30.Clean = value; _cityPropertyTaxName = v30;
                var v31 = _cityPropertyTaxNextDueDate; v31.Clean = value; _cityPropertyTaxNextDueDate = v31;
                var v32 = _cityPropertyTaxPaymentSchedule; v32.Clean = value; _cityPropertyTaxPaymentSchedule = v32;
                var v33 = _cityPropertyTaxPhone; v33.Clean = value; _cityPropertyTaxPhone = v33;
                var v34 = _cityPropertyTaxPostalCode; v34.Clean = value; _cityPropertyTaxPostalCode = v34;
                var v35 = _cityPropertyTaxState; v35.Clean = value; _cityPropertyTaxState = v35;
                var v36 = _endingBalance; v36.Clean = value; _endingBalance = v36;
                var v37 = _escrowFirstPaymentDate; v37.Clean = value; _escrowFirstPaymentDate = v37;
                var v38 = _escrowFirstPaymentDateType; v38.Clean = value; _escrowFirstPaymentDateType = v38;
                var v39 = _escrowPayment; v39.Clean = value; _escrowPayment = v39;
                var v40 = _escrowPaymentYearly; v40.Clean = value; _escrowPaymentYearly = v40;
                var v41 = _floodInsDisbCushion; v41.Clean = value; _floodInsDisbCushion = v41;
                var v42 = _hazInsDisbCushion; v42.Clean = value; _hazInsDisbCushion = v42;
                var v43 = _hud1EsDates; v43.Clean = value; _hud1EsDates = v43;
                var v44 = _hud1EsDueDates; v44.Clean = value; _hud1EsDueDates = v44;
                var v45 = _hud1EsItemizes; v45.Clean = value; _hud1EsItemizes = v45;
                var v46 = _hud1EsItemizesTotalLines; v46.Clean = value; _hud1EsItemizesTotalLines = v46;
                var v47 = _hud1EsItemizesUseItemizeEscrowIndicator; v47.Clean = value; _hud1EsItemizesUseItemizeEscrowIndicator = v47;
                var v48 = _hud1EsPayTos; v48.Clean = value; _hud1EsPayTos = v48;
                var v49 = _hud1EsSetups; v49.Clean = value; _hud1EsSetups = v49;
                var v50 = _id; v50.Clean = value; _id = v50;
                var v51 = _mtgInsCushionTerminationIndicator; v51.Clean = value; _mtgInsCushionTerminationIndicator = v51;
                var v52 = _mtgInsDisbCushion; v52.Clean = value; _mtgInsDisbCushion = v52;
                var v53 = _nonEscrowCostsYearly; v53.Clean = value; _nonEscrowCostsYearly = v53;
                var v54 = _realEstateTaxAddress; v54.Clean = value; _realEstateTaxAddress = v54;
                var v55 = _realEstateTaxAmountLastPay; v55.Clean = value; _realEstateTaxAmountLastPay = v55;
                var v56 = _realEstateTaxAmountNextDue; v56.Clean = value; _realEstateTaxAmountNextDue = v56;
                var v57 = _realEstateTaxCity; v57.Clean = value; _realEstateTaxCity = v57;
                var v58 = _realEstateTaxContactName; v58.Clean = value; _realEstateTaxContactName = v58;
                var v59 = _realEstateTaxDatePaid; v59.Clean = value; _realEstateTaxDatePaid = v59;
                var v60 = _realEstateTaxDelinquentDate; v60.Clean = value; _realEstateTaxDelinquentDate = v60;
                var v61 = _realEstateTaxEmail; v61.Clean = value; _realEstateTaxEmail = v61;
                var v62 = _realEstateTaxFax; v62.Clean = value; _realEstateTaxFax = v62;
                var v63 = _realEstateTaxName; v63.Clean = value; _realEstateTaxName = v63;
                var v64 = _realEstateTaxNextDueDate; v64.Clean = value; _realEstateTaxNextDueDate = v64;
                var v65 = _realEstateTaxPaymentSchedule; v65.Clean = value; _realEstateTaxPaymentSchedule = v65;
                var v66 = _realEstateTaxPhone; v66.Clean = value; _realEstateTaxPhone = v66;
                var v67 = _realEstateTaxPostalCode; v67.Clean = value; _realEstateTaxPostalCode = v67;
                var v68 = _realEstateTaxState; v68.Clean = value; _realEstateTaxState = v68;
                var v69 = _schoolTaxesCushion; v69.Clean = value; _schoolTaxesCushion = v69;
                var v70 = _servicerAddress; v70.Clean = value; _servicerAddress = v70;
                var v71 = _servicerCity; v71.Clean = value; _servicerCity = v71;
                var v72 = _servicerContactName; v72.Clean = value; _servicerContactName = v72;
                var v73 = _servicerPhone; v73.Clean = value; _servicerPhone = v73;
                var v74 = _servicerPostalCode; v74.Clean = value; _servicerPostalCode = v74;
                var v75 = _servicerState; v75.Clean = value; _servicerState = v75;
                var v76 = _singleLineAnalysis; v76.Clean = value; _singleLineAnalysis = v76;
                var v77 = _startingBalance; v77.Clean = value; _startingBalance = v77;
                var v78 = _taxDisbCushion; v78.Clean = value; _taxDisbCushion = v78;
                var v79 = _totalEscrowReserves; v79.Clean = value; _totalEscrowReserves = v79;
                var v80 = _usdaAnnualFee; v80.Clean = value; _usdaAnnualFee = v80;
                var v81 = _userDefinedCushion1; v81.Clean = value; _userDefinedCushion1 = v81;
                var v82 = _userDefinedCushion2; v82.Clean = value; _userDefinedCushion2 = v82;
                var v83 = _userDefinedCushion3; v83.Clean = value; _userDefinedCushion3 = v83;
                var v84 = _yearlyMortgageInsurance; v84.Clean = value; _yearlyMortgageInsurance = v84;
                var v85 = _yearlyUsdaFee; v85.Clean = value; _yearlyUsdaFee = v85;
                _settingClean = 0;
            }
        }
    }
}