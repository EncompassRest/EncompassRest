
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncompassRest.Data
{
    public class Hud1Es
    {
        public List<Hud1EsDate> hud1EsDates { get; set; }
        public List<Hud1EsSetup> hud1EsSetups { get; set; }
        public List<Hud1EsDueDate> hud1EsDueDates { get; set; }
        public decimal? startingBalance { get; set; }
        public decimal? escrowPayment { get; set; }
        public decimal? totalEscrowReserves { get; set; }
        public decimal? endingBalance { get; set; }
        public int? taxDisbCushion { get; set; }
        public int? hazInsDisbCushion { get; set; }
        public int? mtgInsDisbCushion { get; set; }
        public int? floodInsDisbCushion { get; set; }
        public int? schoolTaxesCushion { get; set; }
        public int? userDefinedCushion1 { get; set; }
        public int? userDefinedCushion2 { get; set; }
        public int? userDefinedCushion3 { get; set; }
        public int? annualFeeCushion { get; set; }
        public decimal? singleLineAnalysis { get; set; }
        public decimal? annualTax { get; set; }
        public decimal? annualHazardInsurance { get; set; }
        public decimal? annualMortgageInsurance { get; set; }
        public decimal? annualFloodInsurance { get; set; }
        public decimal? annualCityTax { get; set; }
        public decimal? annualUserEscrow1 { get; set; }
        public decimal? annualUserEscrow2 { get; set; }
        public decimal? annualUserEscrow3 { get; set; }
        public bool? mtgInsCushionTerminationIndicator { get; set; }
        public decimal? usdaAnnualFee { get; set; }
        public decimal? biweeklyPITI { get; set; }
        public decimal? biweeklyCountyTaxes { get; set; }
        public decimal? biweeklyHazardInsurance { get; set; }
        public decimal? biweeklyMortgageInsurance { get; set; }
        public decimal? biweeklyFloodInsurance { get; set; }
        public decimal? biweeklyCityPropertyTaxes { get; set; }
        public decimal? biweeklyUserDefinedEscrowFee1 { get; set; }
        public decimal? biweeklyUserDefinedEscrowFee2 { get; set; }
        public decimal? biweeklyUserDefinedEscrowFee3 { get; set; }
        public decimal? biweeklyUSDAFee { get; set; }
        public decimal? biweeklyTotalBiweeklyPayment { get; set; }
        public decimal? biweeklyTotalBiweeklyPaymentToEscrow { get; set; }
        public decimal? escrowPaymentYearly { get; set; }
        public decimal? nonEscrowCostsYearly { get; set; }
        public DateTime? escrowFirstPaymentDate { get; set; }
        public string escrowFirstPaymentDateType { get; set; }
        public int? hud1EsItemizesTotalLines { get; set; }
        public bool? hud1EsItemizesUseItemizeEscrowIndicator { get; set; }
        public List<Hud1EsItemize> hud1EsItemizes { get; set; }
        public decimal? yearlyUsdaFee { get; set; }
        public decimal? yearlyMortgageInsurance { get; set; }
        public string servicerContactName { get; set; }
        public string servicerAddress { get; set; }
        public string servicerCity { get; set; }
        public string servicerState { get; set; }
        public string servicerPostalCode { get; set; }
        public string servicerPhone { get; set; }
        public string realEstateTaxName { get; set; }
        public string realEstateTaxAddress { get; set; }
        public string realEstateTaxCity { get; set; }
        public string realEstateTaxState { get; set; }
        public string realEstateTaxPostalCode { get; set; }
        public string realEstateTaxContactName { get; set; }
        public string realEstateTaxPhone { get; set; }
        public string realEstateTaxEmail { get; set; }
        public string realEstateTaxFax { get; set; }
        public List<Hud1EsPayTo> hud1EsPayTos { get; set; }
        public string realEstateTaxPaymentSchedule { get; set; }
        public decimal? realEstateTaxAmountLastPay { get; set; }
        public DateTime? realEstateTaxDatePaid { get; set; }
        public decimal? realEstateTaxAmountNextDue { get; set; }
        public DateTime? realEstateTaxNextDueDate { get; set; }
        public DateTime? realEstateTaxDelinquentDate { get; set; }
        public string cityPropertyTaxPaymentSchedule { get; set; }
        public decimal? cityPropertyTaxAmountLastPay { get; set; }
        public DateTime? cityPropertyTaxDatePaid { get; set; }
        public decimal? cityPropertyTaxAmountNextDue { get; set; }
        public DateTime? cityPropertyTaxNextDueDate { get; set; }
        public DateTime? cityPropertyTaxDelinquentDate { get; set; }
        public string cityPropertyTaxName { get; set; }
        public string cityPropertyTaxAddress { get; set; }
        public string cityPropertyTaxCity { get; set; }
        public string cityPropertyTaxState { get; set; }
        public string cityPropertyTaxPostalCode { get; set; }
        public string cityPropertyTaxContactName { get; set; }
        public string cityPropertyTaxPhone { get; set; }
        public string cityPropertyTaxEmail { get; set; }
        public string cityPropertyTaxFax { get; set; }
        public string id { get; set; }

    }
}