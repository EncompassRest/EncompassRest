using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed partial class Hud1Es
    {
        public JsonNullable<decimal?> AnnualCityTax { get; set; }
        public JsonNullable<int?> AnnualFeeCushion { get; set; }
        public JsonNullable<decimal?> AnnualFloodInsurance { get; set; }
        public JsonNullable<decimal?> AnnualHazardInsurance { get; set; }
        public JsonNullable<decimal?> AnnualMortgageInsurance { get; set; }
        public JsonNullable<decimal?> AnnualTax { get; set; }
        public JsonNullable<decimal?> AnnualUserEscrow1 { get; set; }
        public JsonNullable<decimal?> AnnualUserEscrow2 { get; set; }
        public JsonNullable<decimal?> AnnualUserEscrow3 { get; set; }
        public JsonNullable<decimal?> BiweeklyCityPropertyTaxes { get; set; }
        public JsonNullable<decimal?> BiweeklyCountyTaxes { get; set; }
        public JsonNullable<decimal?> BiweeklyFloodInsurance { get; set; }
        public JsonNullable<decimal?> BiweeklyHazardInsurance { get; set; }
        public JsonNullable<decimal?> BiweeklyMortgageInsurance { get; set; }
        public JsonNullable<decimal?> BiweeklyPITI { get; set; }
        public JsonNullable<decimal?> BiweeklyTotalBiweeklyPayment { get; set; }
        public JsonNullable<decimal?> BiweeklyTotalBiweeklyPaymentToEscrow { get; set; }
        public JsonNullable<decimal?> BiweeklyUSDAFee { get; set; }
        public JsonNullable<decimal?> BiweeklyUserDefinedEscrowFee1 { get; set; }
        public JsonNullable<decimal?> BiweeklyUserDefinedEscrowFee2 { get; set; }
        public JsonNullable<decimal?> BiweeklyUserDefinedEscrowFee3 { get; set; }
        public string CityPropertyTaxAddress { get; set; }
        public JsonNullable<decimal?> CityPropertyTaxAmountLastPay { get; set; }
        public JsonNullable<decimal?> CityPropertyTaxAmountNextDue { get; set; }
        public string CityPropertyTaxCity { get; set; }
        public string CityPropertyTaxContactName { get; set; }
        public JsonNullable<DateTime?> CityPropertyTaxDatePaid { get; set; }
        public JsonNullable<DateTime?> CityPropertyTaxDelinquentDate { get; set; }
        public string CityPropertyTaxEmail { get; set; }
        public string CityPropertyTaxFax { get; set; }
        public string CityPropertyTaxName { get; set; }
        public JsonNullable<DateTime?> CityPropertyTaxNextDueDate { get; set; }
        public string CityPropertyTaxPaymentSchedule { get; set; }
        public string CityPropertyTaxPhone { get; set; }
        public string CityPropertyTaxPostalCode { get; set; }
        public string CityPropertyTaxState { get; set; }
        public JsonNullable<decimal?> EndingBalance { get; set; }
        public JsonNullable<DateTime?> EscrowFirstPaymentDate { get; set; }
        public string EscrowFirstPaymentDateType { get; set; }
        public JsonNullable<decimal?> EscrowPayment { get; set; }
        public JsonNullable<decimal?> EscrowPaymentYearly { get; set; }
        public JsonNullable<int?> FloodInsDisbCushion { get; set; }
        public JsonNullable<int?> HazInsDisbCushion { get; set; }
        public JsonNullable<List<Hud1EsDate>> Hud1EsDates { get; set; }
        public JsonNullable<List<Hud1EsDueDate>> Hud1EsDueDates { get; set; }
        public JsonNullable<List<Hud1EsItemize>> Hud1EsItemizes { get; set; }
        public JsonNullable<int?> Hud1EsItemizesTotalLines { get; set; }
        public JsonNullable<bool?> Hud1EsItemizesUseItemizeEscrowIndicator { get; set; }
        public JsonNullable<List<Hud1EsPayTo>> Hud1EsPayTos { get; set; }
        public JsonNullable<List<Hud1EsSetup>> Hud1EsSetups { get; set; }
        public string Id { get; set; }
        public JsonNullable<bool?> MtgInsCushionTerminationIndicator { get; set; }
        public JsonNullable<int?> MtgInsDisbCushion { get; set; }
        public JsonNullable<decimal?> NonEscrowCostsYearly { get; set; }
        public string RealEstateTaxAddress { get; set; }
        public JsonNullable<decimal?> RealEstateTaxAmountLastPay { get; set; }
        public JsonNullable<decimal?> RealEstateTaxAmountNextDue { get; set; }
        public string RealEstateTaxCity { get; set; }
        public string RealEstateTaxContactName { get; set; }
        public JsonNullable<DateTime?> RealEstateTaxDatePaid { get; set; }
        public JsonNullable<DateTime?> RealEstateTaxDelinquentDate { get; set; }
        public string RealEstateTaxEmail { get; set; }
        public string RealEstateTaxFax { get; set; }
        public string RealEstateTaxName { get; set; }
        public JsonNullable<DateTime?> RealEstateTaxNextDueDate { get; set; }
        public string RealEstateTaxPaymentSchedule { get; set; }
        public string RealEstateTaxPhone { get; set; }
        public string RealEstateTaxPostalCode { get; set; }
        public string RealEstateTaxState { get; set; }
        public JsonNullable<int?> SchoolTaxesCushion { get; set; }
        public string ServicerAddress { get; set; }
        public string ServicerCity { get; set; }
        public string ServicerContactName { get; set; }
        public string ServicerPhone { get; set; }
        public string ServicerPostalCode { get; set; }
        public string ServicerState { get; set; }
        public JsonNullable<decimal?> SingleLineAnalysis { get; set; }
        public JsonNullable<decimal?> StartingBalance { get; set; }
        public JsonNullable<int?> TaxDisbCushion { get; set; }
        public JsonNullable<decimal?> TotalEscrowReserves { get; set; }
        public JsonNullable<decimal?> UsdaAnnualFee { get; set; }
        public JsonNullable<int?> UserDefinedCushion1 { get; set; }
        public JsonNullable<int?> UserDefinedCushion2 { get; set; }
        public JsonNullable<int?> UserDefinedCushion3 { get; set; }
        public JsonNullable<decimal?> YearlyMortgageInsurance { get; set; }
        public JsonNullable<decimal?> YearlyUsdaFee { get; set; }
    }
}