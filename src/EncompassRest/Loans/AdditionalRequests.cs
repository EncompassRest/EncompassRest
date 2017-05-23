using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed partial class AdditionalRequests
    {
        public string AppraisalContactCellPhone { get; set; }
        public string AppraisalContactEmail { get; set; }
        public string AppraisalContactForEntry { get; set; }
        public string AppraisalContactHomePhone { get; set; }
        public string AppraisalContactName { get; set; }
        public string AppraisalContactWorkPhone { get; set; }
        public JsonNullable<DateTime?> AppraisalDateOrdered { get; set; }
        public string AppraisalDescription1 { get; set; }
        public string AppraisalDescription2 { get; set; }
        public string AppraisalDescription3 { get; set; }
        public JsonNullable<bool?> AppraisalKeyPickUp { get; set; }
        public JsonNullable<bool?> AppraisalLockBox { get; set; }
        public JsonNullable<bool?> AppraisalVacant { get; set; }
        public string FloodDescription1 { get; set; }
        public string FloodDescription2 { get; set; }
        public string FloodDescription3 { get; set; }
        public JsonNullable<bool?> FloodInsuranceEscrowed { get; set; }
        public string FloodReplacementValue { get; set; }
        public string HazardDescription1 { get; set; }
        public string HazardDescription2 { get; set; }
        public string HazardDescription3 { get; set; }
        public JsonNullable<bool?> HazardInsuranceEscrowed { get; set; }
        public string HazardReplacementValue { get; set; }
        public string Id { get; set; }
        public JsonNullable<decimal?> MaximumDeductibleFloodAmount { get; set; }
        public JsonNullable<decimal?> MaximumDeductibleFloodPercentage { get; set; }
        public JsonNullable<decimal?> MaximumDeductibleHazardAmount { get; set; }
        public JsonNullable<decimal?> MaximumDeductibleHazardPercentage { get; set; }
        public JsonNullable<bool?> TitleContract { get; set; }
        public string TitleDescription1 { get; set; }
        public string TitleDescription2 { get; set; }
        public string TitleDescription3 { get; set; }
        public JsonNullable<bool?> TitleInsRequirements { get; set; }
        public JsonNullable<bool?> TitleMailAway { get; set; }
        public JsonNullable<bool?> TitlePriorTitlePolicy { get; set; }
        public JsonNullable<bool?> TitleSurvey { get; set; }
        public string TitleTypeOfProperty { get; set; }
        public JsonNullable<bool?> TitleWarrantyDeed { get; set; }
    }
}