using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class Hud1Es
    {
        public Value<decimal?> AnnualCityTax { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAnnualCityTax() => !AnnualCityTax.Clean;
        public Value<int?> AnnualFeeCushion { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAnnualFeeCushion() => !AnnualFeeCushion.Clean;
        public Value<decimal?> AnnualFloodInsurance { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAnnualFloodInsurance() => !AnnualFloodInsurance.Clean;
        public Value<decimal?> AnnualHazardInsurance { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAnnualHazardInsurance() => !AnnualHazardInsurance.Clean;
        public Value<decimal?> AnnualMortgageInsurance { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAnnualMortgageInsurance() => !AnnualMortgageInsurance.Clean;
        public Value<decimal?> AnnualTax { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAnnualTax() => !AnnualTax.Clean;
        public Value<decimal?> AnnualUserEscrow1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAnnualUserEscrow1() => !AnnualUserEscrow1.Clean;
        public Value<decimal?> AnnualUserEscrow2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAnnualUserEscrow2() => !AnnualUserEscrow2.Clean;
        public Value<decimal?> AnnualUserEscrow3 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAnnualUserEscrow3() => !AnnualUserEscrow3.Clean;
        public Value<decimal?> BiweeklyCityPropertyTaxes { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBiweeklyCityPropertyTaxes() => !BiweeklyCityPropertyTaxes.Clean;
        public Value<decimal?> BiweeklyCountyTaxes { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBiweeklyCountyTaxes() => !BiweeklyCountyTaxes.Clean;
        public Value<decimal?> BiweeklyFloodInsurance { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBiweeklyFloodInsurance() => !BiweeklyFloodInsurance.Clean;
        public Value<decimal?> BiweeklyHazardInsurance { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBiweeklyHazardInsurance() => !BiweeklyHazardInsurance.Clean;
        public Value<decimal?> BiweeklyMortgageInsurance { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBiweeklyMortgageInsurance() => !BiweeklyMortgageInsurance.Clean;
        public Value<decimal?> BiweeklyPITI { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBiweeklyPITI() => !BiweeklyPITI.Clean;
        public Value<decimal?> BiweeklyTotalBiweeklyPayment { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBiweeklyTotalBiweeklyPayment() => !BiweeklyTotalBiweeklyPayment.Clean;
        public Value<decimal?> BiweeklyTotalBiweeklyPaymentToEscrow { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBiweeklyTotalBiweeklyPaymentToEscrow() => !BiweeklyTotalBiweeklyPaymentToEscrow.Clean;
        public Value<decimal?> BiweeklyUSDAFee { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBiweeklyUSDAFee() => !BiweeklyUSDAFee.Clean;
        public Value<decimal?> BiweeklyUserDefinedEscrowFee1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBiweeklyUserDefinedEscrowFee1() => !BiweeklyUserDefinedEscrowFee1.Clean;
        public Value<decimal?> BiweeklyUserDefinedEscrowFee2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBiweeklyUserDefinedEscrowFee2() => !BiweeklyUserDefinedEscrowFee2.Clean;
        public Value<decimal?> BiweeklyUserDefinedEscrowFee3 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBiweeklyUserDefinedEscrowFee3() => !BiweeklyUserDefinedEscrowFee3.Clean;
        public Value<string> CityPropertyTaxAddress { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCityPropertyTaxAddress() => !CityPropertyTaxAddress.Clean;
        public Value<decimal?> CityPropertyTaxAmountLastPay { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCityPropertyTaxAmountLastPay() => !CityPropertyTaxAmountLastPay.Clean;
        public Value<decimal?> CityPropertyTaxAmountNextDue { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCityPropertyTaxAmountNextDue() => !CityPropertyTaxAmountNextDue.Clean;
        public Value<string> CityPropertyTaxCity { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCityPropertyTaxCity() => !CityPropertyTaxCity.Clean;
        public Value<string> CityPropertyTaxContactName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCityPropertyTaxContactName() => !CityPropertyTaxContactName.Clean;
        public Value<DateTime?> CityPropertyTaxDatePaid { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCityPropertyTaxDatePaid() => !CityPropertyTaxDatePaid.Clean;
        public Value<DateTime?> CityPropertyTaxDelinquentDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCityPropertyTaxDelinquentDate() => !CityPropertyTaxDelinquentDate.Clean;
        public Value<string> CityPropertyTaxEmail { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCityPropertyTaxEmail() => !CityPropertyTaxEmail.Clean;
        public Value<string> CityPropertyTaxFax { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCityPropertyTaxFax() => !CityPropertyTaxFax.Clean;
        public Value<string> CityPropertyTaxName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCityPropertyTaxName() => !CityPropertyTaxName.Clean;
        public Value<DateTime?> CityPropertyTaxNextDueDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCityPropertyTaxNextDueDate() => !CityPropertyTaxNextDueDate.Clean;
        public Value<string> CityPropertyTaxPaymentSchedule { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCityPropertyTaxPaymentSchedule() => !CityPropertyTaxPaymentSchedule.Clean;
        public Value<string> CityPropertyTaxPhone { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCityPropertyTaxPhone() => !CityPropertyTaxPhone.Clean;
        public Value<string> CityPropertyTaxPostalCode { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCityPropertyTaxPostalCode() => !CityPropertyTaxPostalCode.Clean;
        public Value<string> CityPropertyTaxState { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCityPropertyTaxState() => !CityPropertyTaxState.Clean;
        public Value<decimal?> EndingBalance { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEndingBalance() => !EndingBalance.Clean;
        public Value<DateTime?> EscrowFirstPaymentDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEscrowFirstPaymentDate() => !EscrowFirstPaymentDate.Clean;
        public Value<string> EscrowFirstPaymentDateType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEscrowFirstPaymentDateType() => !EscrowFirstPaymentDateType.Clean;
        public Value<decimal?> EscrowPayment { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEscrowPayment() => !EscrowPayment.Clean;
        public Value<decimal?> EscrowPaymentYearly { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEscrowPaymentYearly() => !EscrowPaymentYearly.Clean;
        public Value<int?> FloodInsDisbCushion { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFloodInsDisbCushion() => !FloodInsDisbCushion.Clean;
        public Value<int?> HazInsDisbCushion { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHazInsDisbCushion() => !HazInsDisbCushion.Clean;
        public Value<List<Hud1EsDate>> Hud1EsDates { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHud1EsDates() => !Hud1EsDates.Clean;
        public Value<List<Hud1EsDueDate>> Hud1EsDueDates { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHud1EsDueDates() => !Hud1EsDueDates.Clean;
        public Value<List<Hud1EsItemize>> Hud1EsItemizes { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHud1EsItemizes() => !Hud1EsItemizes.Clean;
        public Value<int?> Hud1EsItemizesTotalLines { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHud1EsItemizesTotalLines() => !Hud1EsItemizesTotalLines.Clean;
        public Value<bool?> Hud1EsItemizesUseItemizeEscrowIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHud1EsItemizesUseItemizeEscrowIndicator() => !Hud1EsItemizesUseItemizeEscrowIndicator.Clean;
        public Value<List<Hud1EsPayTo>> Hud1EsPayTos { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHud1EsPayTos() => !Hud1EsPayTos.Clean;
        public Value<List<Hud1EsSetup>> Hud1EsSetups { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHud1EsSetups() => !Hud1EsSetups.Clean;
        public Value<string> Id { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !Id.Clean;
        public Value<bool?> MtgInsCushionTerminationIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMtgInsCushionTerminationIndicator() => !MtgInsCushionTerminationIndicator.Clean;
        public Value<int?> MtgInsDisbCushion { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMtgInsDisbCushion() => !MtgInsDisbCushion.Clean;
        public Value<decimal?> NonEscrowCostsYearly { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNonEscrowCostsYearly() => !NonEscrowCostsYearly.Clean;
        public Value<string> RealEstateTaxAddress { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRealEstateTaxAddress() => !RealEstateTaxAddress.Clean;
        public Value<decimal?> RealEstateTaxAmountLastPay { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRealEstateTaxAmountLastPay() => !RealEstateTaxAmountLastPay.Clean;
        public Value<decimal?> RealEstateTaxAmountNextDue { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRealEstateTaxAmountNextDue() => !RealEstateTaxAmountNextDue.Clean;
        public Value<string> RealEstateTaxCity { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRealEstateTaxCity() => !RealEstateTaxCity.Clean;
        public Value<string> RealEstateTaxContactName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRealEstateTaxContactName() => !RealEstateTaxContactName.Clean;
        public Value<DateTime?> RealEstateTaxDatePaid { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRealEstateTaxDatePaid() => !RealEstateTaxDatePaid.Clean;
        public Value<DateTime?> RealEstateTaxDelinquentDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRealEstateTaxDelinquentDate() => !RealEstateTaxDelinquentDate.Clean;
        public Value<string> RealEstateTaxEmail { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRealEstateTaxEmail() => !RealEstateTaxEmail.Clean;
        public Value<string> RealEstateTaxFax { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRealEstateTaxFax() => !RealEstateTaxFax.Clean;
        public Value<string> RealEstateTaxName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRealEstateTaxName() => !RealEstateTaxName.Clean;
        public Value<DateTime?> RealEstateTaxNextDueDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRealEstateTaxNextDueDate() => !RealEstateTaxNextDueDate.Clean;
        public Value<string> RealEstateTaxPaymentSchedule { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRealEstateTaxPaymentSchedule() => !RealEstateTaxPaymentSchedule.Clean;
        public Value<string> RealEstateTaxPhone { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRealEstateTaxPhone() => !RealEstateTaxPhone.Clean;
        public Value<string> RealEstateTaxPostalCode { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRealEstateTaxPostalCode() => !RealEstateTaxPostalCode.Clean;
        public Value<string> RealEstateTaxState { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRealEstateTaxState() => !RealEstateTaxState.Clean;
        public Value<int?> SchoolTaxesCushion { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSchoolTaxesCushion() => !SchoolTaxesCushion.Clean;
        public Value<string> ServicerAddress { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeServicerAddress() => !ServicerAddress.Clean;
        public Value<string> ServicerCity { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeServicerCity() => !ServicerCity.Clean;
        public Value<string> ServicerContactName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeServicerContactName() => !ServicerContactName.Clean;
        public Value<string> ServicerPhone { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeServicerPhone() => !ServicerPhone.Clean;
        public Value<string> ServicerPostalCode { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeServicerPostalCode() => !ServicerPostalCode.Clean;
        public Value<string> ServicerState { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeServicerState() => !ServicerState.Clean;
        public Value<decimal?> SingleLineAnalysis { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSingleLineAnalysis() => !SingleLineAnalysis.Clean;
        public Value<decimal?> StartingBalance { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeStartingBalance() => !StartingBalance.Clean;
        public Value<int?> TaxDisbCushion { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTaxDisbCushion() => !TaxDisbCushion.Clean;
        public Value<decimal?> TotalEscrowReserves { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalEscrowReserves() => !TotalEscrowReserves.Clean;
        public Value<decimal?> UsdaAnnualFee { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUsdaAnnualFee() => !UsdaAnnualFee.Clean;
        public Value<int?> UserDefinedCushion1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUserDefinedCushion1() => !UserDefinedCushion1.Clean;
        public Value<int?> UserDefinedCushion2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUserDefinedCushion2() => !UserDefinedCushion2.Clean;
        public Value<int?> UserDefinedCushion3 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUserDefinedCushion3() => !UserDefinedCushion3.Clean;
        public Value<decimal?> YearlyMortgageInsurance { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeYearlyMortgageInsurance() => !YearlyMortgageInsurance.Clean;
        public Value<decimal?> YearlyUsdaFee { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeYearlyUsdaFee() => !YearlyUsdaFee.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = AnnualCityTax.Clean
                    && AnnualFeeCushion.Clean
                    && AnnualFloodInsurance.Clean
                    && AnnualHazardInsurance.Clean
                    && AnnualMortgageInsurance.Clean
                    && AnnualTax.Clean
                    && AnnualUserEscrow1.Clean
                    && AnnualUserEscrow2.Clean
                    && AnnualUserEscrow3.Clean
                    && BiweeklyCityPropertyTaxes.Clean
                    && BiweeklyCountyTaxes.Clean
                    && BiweeklyFloodInsurance.Clean
                    && BiweeklyHazardInsurance.Clean
                    && BiweeklyMortgageInsurance.Clean
                    && BiweeklyPITI.Clean
                    && BiweeklyTotalBiweeklyPayment.Clean
                    && BiweeklyTotalBiweeklyPaymentToEscrow.Clean
                    && BiweeklyUSDAFee.Clean
                    && BiweeklyUserDefinedEscrowFee1.Clean
                    && BiweeklyUserDefinedEscrowFee2.Clean
                    && BiweeklyUserDefinedEscrowFee3.Clean
                    && CityPropertyTaxAddress.Clean
                    && CityPropertyTaxAmountLastPay.Clean
                    && CityPropertyTaxAmountNextDue.Clean
                    && CityPropertyTaxCity.Clean
                    && CityPropertyTaxContactName.Clean
                    && CityPropertyTaxDatePaid.Clean
                    && CityPropertyTaxDelinquentDate.Clean
                    && CityPropertyTaxEmail.Clean
                    && CityPropertyTaxFax.Clean
                    && CityPropertyTaxName.Clean
                    && CityPropertyTaxNextDueDate.Clean
                    && CityPropertyTaxPaymentSchedule.Clean
                    && CityPropertyTaxPhone.Clean
                    && CityPropertyTaxPostalCode.Clean
                    && CityPropertyTaxState.Clean
                    && EndingBalance.Clean
                    && EscrowFirstPaymentDate.Clean
                    && EscrowFirstPaymentDateType.Clean
                    && EscrowPayment.Clean
                    && EscrowPaymentYearly.Clean
                    && FloodInsDisbCushion.Clean
                    && HazInsDisbCushion.Clean
                    && Hud1EsDates.Clean
                    && Hud1EsDueDates.Clean
                    && Hud1EsItemizes.Clean
                    && Hud1EsItemizesTotalLines.Clean
                    && Hud1EsItemizesUseItemizeEscrowIndicator.Clean
                    && Hud1EsPayTos.Clean
                    && Hud1EsSetups.Clean
                    && Id.Clean
                    && MtgInsCushionTerminationIndicator.Clean
                    && MtgInsDisbCushion.Clean
                    && NonEscrowCostsYearly.Clean
                    && RealEstateTaxAddress.Clean
                    && RealEstateTaxAmountLastPay.Clean
                    && RealEstateTaxAmountNextDue.Clean
                    && RealEstateTaxCity.Clean
                    && RealEstateTaxContactName.Clean
                    && RealEstateTaxDatePaid.Clean
                    && RealEstateTaxDelinquentDate.Clean
                    && RealEstateTaxEmail.Clean
                    && RealEstateTaxFax.Clean
                    && RealEstateTaxName.Clean
                    && RealEstateTaxNextDueDate.Clean
                    && RealEstateTaxPaymentSchedule.Clean
                    && RealEstateTaxPhone.Clean
                    && RealEstateTaxPostalCode.Clean
                    && RealEstateTaxState.Clean
                    && SchoolTaxesCushion.Clean
                    && ServicerAddress.Clean
                    && ServicerCity.Clean
                    && ServicerContactName.Clean
                    && ServicerPhone.Clean
                    && ServicerPostalCode.Clean
                    && ServicerState.Clean
                    && SingleLineAnalysis.Clean
                    && StartingBalance.Clean
                    && TaxDisbCushion.Clean
                    && TotalEscrowReserves.Clean
                    && UsdaAnnualFee.Clean
                    && UserDefinedCushion1.Clean
                    && UserDefinedCushion2.Clean
                    && UserDefinedCushion3.Clean
                    && YearlyMortgageInsurance.Clean
                    && YearlyUsdaFee.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = AnnualCityTax; v0.Clean = value; AnnualCityTax = v0;
                var v1 = AnnualFeeCushion; v1.Clean = value; AnnualFeeCushion = v1;
                var v2 = AnnualFloodInsurance; v2.Clean = value; AnnualFloodInsurance = v2;
                var v3 = AnnualHazardInsurance; v3.Clean = value; AnnualHazardInsurance = v3;
                var v4 = AnnualMortgageInsurance; v4.Clean = value; AnnualMortgageInsurance = v4;
                var v5 = AnnualTax; v5.Clean = value; AnnualTax = v5;
                var v6 = AnnualUserEscrow1; v6.Clean = value; AnnualUserEscrow1 = v6;
                var v7 = AnnualUserEscrow2; v7.Clean = value; AnnualUserEscrow2 = v7;
                var v8 = AnnualUserEscrow3; v8.Clean = value; AnnualUserEscrow3 = v8;
                var v9 = BiweeklyCityPropertyTaxes; v9.Clean = value; BiweeklyCityPropertyTaxes = v9;
                var v10 = BiweeklyCountyTaxes; v10.Clean = value; BiweeklyCountyTaxes = v10;
                var v11 = BiweeklyFloodInsurance; v11.Clean = value; BiweeklyFloodInsurance = v11;
                var v12 = BiweeklyHazardInsurance; v12.Clean = value; BiweeklyHazardInsurance = v12;
                var v13 = BiweeklyMortgageInsurance; v13.Clean = value; BiweeklyMortgageInsurance = v13;
                var v14 = BiweeklyPITI; v14.Clean = value; BiweeklyPITI = v14;
                var v15 = BiweeklyTotalBiweeklyPayment; v15.Clean = value; BiweeklyTotalBiweeklyPayment = v15;
                var v16 = BiweeklyTotalBiweeklyPaymentToEscrow; v16.Clean = value; BiweeklyTotalBiweeklyPaymentToEscrow = v16;
                var v17 = BiweeklyUSDAFee; v17.Clean = value; BiweeklyUSDAFee = v17;
                var v18 = BiweeklyUserDefinedEscrowFee1; v18.Clean = value; BiweeklyUserDefinedEscrowFee1 = v18;
                var v19 = BiweeklyUserDefinedEscrowFee2; v19.Clean = value; BiweeklyUserDefinedEscrowFee2 = v19;
                var v20 = BiweeklyUserDefinedEscrowFee3; v20.Clean = value; BiweeklyUserDefinedEscrowFee3 = v20;
                var v21 = CityPropertyTaxAddress; v21.Clean = value; CityPropertyTaxAddress = v21;
                var v22 = CityPropertyTaxAmountLastPay; v22.Clean = value; CityPropertyTaxAmountLastPay = v22;
                var v23 = CityPropertyTaxAmountNextDue; v23.Clean = value; CityPropertyTaxAmountNextDue = v23;
                var v24 = CityPropertyTaxCity; v24.Clean = value; CityPropertyTaxCity = v24;
                var v25 = CityPropertyTaxContactName; v25.Clean = value; CityPropertyTaxContactName = v25;
                var v26 = CityPropertyTaxDatePaid; v26.Clean = value; CityPropertyTaxDatePaid = v26;
                var v27 = CityPropertyTaxDelinquentDate; v27.Clean = value; CityPropertyTaxDelinquentDate = v27;
                var v28 = CityPropertyTaxEmail; v28.Clean = value; CityPropertyTaxEmail = v28;
                var v29 = CityPropertyTaxFax; v29.Clean = value; CityPropertyTaxFax = v29;
                var v30 = CityPropertyTaxName; v30.Clean = value; CityPropertyTaxName = v30;
                var v31 = CityPropertyTaxNextDueDate; v31.Clean = value; CityPropertyTaxNextDueDate = v31;
                var v32 = CityPropertyTaxPaymentSchedule; v32.Clean = value; CityPropertyTaxPaymentSchedule = v32;
                var v33 = CityPropertyTaxPhone; v33.Clean = value; CityPropertyTaxPhone = v33;
                var v34 = CityPropertyTaxPostalCode; v34.Clean = value; CityPropertyTaxPostalCode = v34;
                var v35 = CityPropertyTaxState; v35.Clean = value; CityPropertyTaxState = v35;
                var v36 = EndingBalance; v36.Clean = value; EndingBalance = v36;
                var v37 = EscrowFirstPaymentDate; v37.Clean = value; EscrowFirstPaymentDate = v37;
                var v38 = EscrowFirstPaymentDateType; v38.Clean = value; EscrowFirstPaymentDateType = v38;
                var v39 = EscrowPayment; v39.Clean = value; EscrowPayment = v39;
                var v40 = EscrowPaymentYearly; v40.Clean = value; EscrowPaymentYearly = v40;
                var v41 = FloodInsDisbCushion; v41.Clean = value; FloodInsDisbCushion = v41;
                var v42 = HazInsDisbCushion; v42.Clean = value; HazInsDisbCushion = v42;
                var v43 = Hud1EsDates; v43.Clean = value; Hud1EsDates = v43;
                var v44 = Hud1EsDueDates; v44.Clean = value; Hud1EsDueDates = v44;
                var v45 = Hud1EsItemizes; v45.Clean = value; Hud1EsItemizes = v45;
                var v46 = Hud1EsItemizesTotalLines; v46.Clean = value; Hud1EsItemizesTotalLines = v46;
                var v47 = Hud1EsItemizesUseItemizeEscrowIndicator; v47.Clean = value; Hud1EsItemizesUseItemizeEscrowIndicator = v47;
                var v48 = Hud1EsPayTos; v48.Clean = value; Hud1EsPayTos = v48;
                var v49 = Hud1EsSetups; v49.Clean = value; Hud1EsSetups = v49;
                var v50 = Id; v50.Clean = value; Id = v50;
                var v51 = MtgInsCushionTerminationIndicator; v51.Clean = value; MtgInsCushionTerminationIndicator = v51;
                var v52 = MtgInsDisbCushion; v52.Clean = value; MtgInsDisbCushion = v52;
                var v53 = NonEscrowCostsYearly; v53.Clean = value; NonEscrowCostsYearly = v53;
                var v54 = RealEstateTaxAddress; v54.Clean = value; RealEstateTaxAddress = v54;
                var v55 = RealEstateTaxAmountLastPay; v55.Clean = value; RealEstateTaxAmountLastPay = v55;
                var v56 = RealEstateTaxAmountNextDue; v56.Clean = value; RealEstateTaxAmountNextDue = v56;
                var v57 = RealEstateTaxCity; v57.Clean = value; RealEstateTaxCity = v57;
                var v58 = RealEstateTaxContactName; v58.Clean = value; RealEstateTaxContactName = v58;
                var v59 = RealEstateTaxDatePaid; v59.Clean = value; RealEstateTaxDatePaid = v59;
                var v60 = RealEstateTaxDelinquentDate; v60.Clean = value; RealEstateTaxDelinquentDate = v60;
                var v61 = RealEstateTaxEmail; v61.Clean = value; RealEstateTaxEmail = v61;
                var v62 = RealEstateTaxFax; v62.Clean = value; RealEstateTaxFax = v62;
                var v63 = RealEstateTaxName; v63.Clean = value; RealEstateTaxName = v63;
                var v64 = RealEstateTaxNextDueDate; v64.Clean = value; RealEstateTaxNextDueDate = v64;
                var v65 = RealEstateTaxPaymentSchedule; v65.Clean = value; RealEstateTaxPaymentSchedule = v65;
                var v66 = RealEstateTaxPhone; v66.Clean = value; RealEstateTaxPhone = v66;
                var v67 = RealEstateTaxPostalCode; v67.Clean = value; RealEstateTaxPostalCode = v67;
                var v68 = RealEstateTaxState; v68.Clean = value; RealEstateTaxState = v68;
                var v69 = SchoolTaxesCushion; v69.Clean = value; SchoolTaxesCushion = v69;
                var v70 = ServicerAddress; v70.Clean = value; ServicerAddress = v70;
                var v71 = ServicerCity; v71.Clean = value; ServicerCity = v71;
                var v72 = ServicerContactName; v72.Clean = value; ServicerContactName = v72;
                var v73 = ServicerPhone; v73.Clean = value; ServicerPhone = v73;
                var v74 = ServicerPostalCode; v74.Clean = value; ServicerPostalCode = v74;
                var v75 = ServicerState; v75.Clean = value; ServicerState = v75;
                var v76 = SingleLineAnalysis; v76.Clean = value; SingleLineAnalysis = v76;
                var v77 = StartingBalance; v77.Clean = value; StartingBalance = v77;
                var v78 = TaxDisbCushion; v78.Clean = value; TaxDisbCushion = v78;
                var v79 = TotalEscrowReserves; v79.Clean = value; TotalEscrowReserves = v79;
                var v80 = UsdaAnnualFee; v80.Clean = value; UsdaAnnualFee = v80;
                var v81 = UserDefinedCushion1; v81.Clean = value; UserDefinedCushion1 = v81;
                var v82 = UserDefinedCushion2; v82.Clean = value; UserDefinedCushion2 = v82;
                var v83 = UserDefinedCushion3; v83.Clean = value; UserDefinedCushion3 = v83;
                var v84 = YearlyMortgageInsurance; v84.Clean = value; YearlyMortgageInsurance = v84;
                var v85 = YearlyUsdaFee; v85.Clean = value; YearlyUsdaFee = v85;
                _settingClean = 0;
            }
        }
    }
}