using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed class Hud1Es
    {
        public List<Hud1EsDate> Hud1EsDates { get; set; }
        public List<Hud1EsSetup> Hud1EsSetups { get; set; }
        public List<Hud1EsDueDate> Hud1EsDueDates { get; set; }
        public decimal? StartingBalance { get; set; }
        public decimal? EscrowPayment { get; set; }
        public decimal? TotalEscrowReserves { get; set; }
        public decimal? EndingBalance { get; set; }
        public int? TaxDisbCushion { get; set; }
        public int? HazInsDisbCushion { get; set; }
        public int? MtgInsDisbCushion { get; set; }
        public int? FloodInsDisbCushion { get; set; }
        public int? SchoolTaxesCushion { get; set; }
        public int? UserDefinedCushion1 { get; set; }
        public int? UserDefinedCushion2 { get; set; }
        public int? UserDefinedCushion3 { get; set; }
        public int? AnnualFeeCushion { get; set; }
        public decimal? SingleLineAnalysis { get; set; }
        public decimal? AnnualTax { get; set; }
        public decimal? AnnualHazardInsurance { get; set; }
        public decimal? AnnualMortgageInsurance { get; set; }
        public decimal? AnnualFloodInsurance { get; set; }
        public decimal? AnnualCityTax { get; set; }
        public decimal? AnnualUserEscrow1 { get; set; }
        public decimal? AnnualUserEscrow2 { get; set; }
        public decimal? AnnualUserEscrow3 { get; set; }
        public bool? MtgInsCushionTerminationIndicator { get; set; }
        public decimal? UsdaAnnualFee { get; set; }
        public decimal? BiweeklyPITI { get; set; }
        public decimal? BiweeklyCountyTaxes { get; set; }
        public decimal? BiweeklyHazardInsurance { get; set; }
        public decimal? BiweeklyMortgageInsurance { get; set; }
        public decimal? BiweeklyFloodInsurance { get; set; }
        public decimal? BiweeklyCityPropertyTaxes { get; set; }
        public decimal? BiweeklyUserDefinedEscrowFee1 { get; set; }
        public decimal? BiweeklyUserDefinedEscrowFee2 { get; set; }
        public decimal? BiweeklyUserDefinedEscrowFee3 { get; set; }
        public decimal? BiweeklyUSDAFee { get; set; }
        public decimal? BiweeklyTotalBiweeklyPayment { get; set; }
        public decimal? BiweeklyTotalBiweeklyPaymentToEscrow { get; set; }
        public decimal? EscrowPaymentYearly { get; set; }
        public decimal? NonEscrowCostsYearly { get; set; }
        public DateTime? EscrowFirstPaymentDate { get; set; }
        public string EscrowFirstPaymentDateType { get; set; }
        public int? Hud1EsItemizesTotalLines { get; set; }
        public bool? Hud1EsItemizesUseItemizeEscrowIndicator { get; set; }
        public List<Hud1EsItemize> Hud1EsItemizes { get; set; }
        public decimal? YearlyUsdaFee { get; set; }
        public decimal? YearlyMortgageInsurance { get; set; }
        public string ServicerContactName { get; set; }
        public string ServicerAddress { get; set; }
        public string ServicerCity { get; set; }
        public string ServicerState { get; set; }
        public string ServicerPostalCode { get; set; }
        public string ServicerPhone { get; set; }
        public string RealEstateTaxName { get; set; }
        public string RealEstateTaxAddress { get; set; }
        public string RealEstateTaxCity { get; set; }
        public string RealEstateTaxState { get; set; }
        public string RealEstateTaxPostalCode { get; set; }
        public string RealEstateTaxContactName { get; set; }
        public string RealEstateTaxPhone { get; set; }
        public string RealEstateTaxEmail { get; set; }
        public string RealEstateTaxFax { get; set; }
        public List<Hud1EsPayTo> Hud1EsPayTos { get; set; }
        public string RealEstateTaxPaymentSchedule { get; set; }
        public decimal? RealEstateTaxAmountLastPay { get; set; }
        public DateTime? RealEstateTaxDatePaid { get; set; }
        public decimal? RealEstateTaxAmountNextDue { get; set; }
        public DateTime? RealEstateTaxNextDueDate { get; set; }
        public DateTime? RealEstateTaxDelinquentDate { get; set; }
        public string CityPropertyTaxPaymentSchedule { get; set; }
        public decimal? CityPropertyTaxAmountLastPay { get; set; }
        public DateTime? CityPropertyTaxDatePaid { get; set; }
        public decimal? CityPropertyTaxAmountNextDue { get; set; }
        public DateTime? CityPropertyTaxNextDueDate { get; set; }
        public DateTime? CityPropertyTaxDelinquentDate { get; set; }
        public string CityPropertyTaxName { get; set; }
        public string CityPropertyTaxAddress { get; set; }
        public string CityPropertyTaxCity { get; set; }
        public string CityPropertyTaxState { get; set; }
        public string CityPropertyTaxPostalCode { get; set; }
        public string CityPropertyTaxContactName { get; set; }
        public string CityPropertyTaxPhone { get; set; }
        public string CityPropertyTaxEmail { get; set; }
        public string CityPropertyTaxFax { get; set; }
        public string Id { get; set; }
    }
}