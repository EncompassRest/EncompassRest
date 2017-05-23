using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed partial class TQLReportInformation
    {
        public string AltId { get; set; }
        public string BorrowerID1 { get; set; }
        public string BorrowerID2 { get; set; }
        public string BorrowerID3 { get; set; }
        public string BorrowerID4 { get; set; }
        public JsonNullable<DateTime?> CompletedDate { get; set; }
        public string Id { get; set; }
        public string Investor { get; set; }
        public JsonNullable<DateTime?> OrderDate { get; set; }
        public string OrderNumber { get; set; }
        public string OrderStatus { get; set; }
        public JsonNullable<decimal?> PercentVariance1 { get; set; }
        public JsonNullable<decimal?> PercentVariance2 { get; set; }
        public JsonNullable<decimal?> PercentVariance3 { get; set; }
        public JsonNullable<decimal?> PercentVariance4 { get; set; }
        public string ProductsOrdered { get; set; }
        public string ReportYear1 { get; set; }
        public string ReportYear2 { get; set; }
        public string ReportYear3 { get; set; }
        public string ReportYear4 { get; set; }
        public JsonNullable<decimal?> TotalIncome1 { get; set; }
        public JsonNullable<decimal?> TotalIncome2 { get; set; }
        public JsonNullable<decimal?> TotalIncome3 { get; set; }
        public JsonNullable<decimal?> TotalIncome4 { get; set; }
        public string TranscriptType { get; set; }
        public string UserID { get; set; }
    }
}