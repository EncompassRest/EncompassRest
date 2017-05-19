using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed class ServicingDisclosure
    {
        public bool? WeMayAssignIndicator { get; set; }
        public bool? ZeroTo25Indicator { get; set; }
        public bool? TwentySixTo50Indicator { get; set; }
        public bool? FiftyOneTo75Indicator { get; set; }
        public bool? SeventySixTo100Indicator { get; set; }
        public string ThisInformationType { get; set; }
        public string WeAreAbleType { get; set; }
        public bool? WeHavePreviouslyAssignedIndicator { get; set; }
        public bool? ThisIsOurRecordOfTransferingIndicator { get; set; }
        public string DisclosureYear1 { get; set; }
        public decimal? DisclosurePercent1 { get; set; }
        public string DisclosureYear2 { get; set; }
        public decimal? DisclosurePercent2 { get; set; }
        public string DisclosureYear3 { get; set; }
        public decimal? DisclosurePercent3 { get; set; }
        public bool? WeDoNotSellMortgageLoansIndicator { get; set; }
        public bool? WeDoNotServiceMortgageLoansIndicator { get; set; }
        public bool? WeHaveNotServicedMortgLoansIn3YrsIndicator { get; set; }
        public string ThisEstimateType { get; set; }
        public string Id { get; set; }
    }
}