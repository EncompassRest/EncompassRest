using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed class TQLReportInformation
    {
        public string UserID { get; set; }
        public DateTime? OrderDate { get; set; }
        public DateTime? CompletedDate { get; set; }
        public string OrderStatus { get; set; }
        public string OrderNumber { get; set; }
        public string Investor { get; set; }
        public string ProductsOrdered { get; set; }
        public string TranscriptType { get; set; }
        public string ReportYear1 { get; set; }
        public string BorrowerID1 { get; set; }
        public decimal? TotalIncome1 { get; set; }
        public decimal? PercentVariance1 { get; set; }
        public string ReportYear2 { get; set; }
        public string BorrowerID2 { get; set; }
        public decimal? TotalIncome2 { get; set; }
        public decimal? PercentVariance2 { get; set; }
        public string ReportYear3 { get; set; }
        public string BorrowerID3 { get; set; }
        public decimal? TotalIncome3 { get; set; }
        public decimal? PercentVariance3 { get; set; }
        public string ReportYear4 { get; set; }
        public string BorrowerID4 { get; set; }
        public decimal? TotalIncome4 { get; set; }
        public decimal? PercentVariance4 { get; set; }
        public string AltId { get; set; }
        public string Id { get; set; }
    }
}