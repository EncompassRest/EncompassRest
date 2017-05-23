using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed partial class ServicingDisclosure
    {
        public JsonNullable<decimal?> DisclosurePercent1 { get; set; }
        public JsonNullable<decimal?> DisclosurePercent2 { get; set; }
        public JsonNullable<decimal?> DisclosurePercent3 { get; set; }
        public string DisclosureYear1 { get; set; }
        public string DisclosureYear2 { get; set; }
        public string DisclosureYear3 { get; set; }
        public JsonNullable<bool?> FiftyOneTo75Indicator { get; set; }
        public string Id { get; set; }
        public JsonNullable<bool?> SeventySixTo100Indicator { get; set; }
        public string ThisEstimateType { get; set; }
        public string ThisInformationType { get; set; }
        public JsonNullable<bool?> ThisIsOurRecordOfTransferingIndicator { get; set; }
        public JsonNullable<bool?> TwentySixTo50Indicator { get; set; }
        public string WeAreAbleType { get; set; }
        public JsonNullable<bool?> WeDoNotSellMortgageLoansIndicator { get; set; }
        public JsonNullable<bool?> WeDoNotServiceMortgageLoansIndicator { get; set; }
        public JsonNullable<bool?> WeHaveNotServicedMortgLoansIn3YrsIndicator { get; set; }
        public JsonNullable<bool?> WeHavePreviouslyAssignedIndicator { get; set; }
        public JsonNullable<bool?> WeMayAssignIndicator { get; set; }
        public JsonNullable<bool?> ZeroTo25Indicator { get; set; }
    }
}