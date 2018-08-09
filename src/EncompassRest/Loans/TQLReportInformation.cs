using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// TQLReportInformation
    /// </summary>
    public sealed partial class TQLReportInformation : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<string> _altId;
        /// <summary>
        /// TQL - Borrower 4506T Orders - ID [TQL4506TNN99]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "TQL - Borrower 4506T Orders - ID")]
        public string AltId { get => _altId; set => _altId = value; }
        private DirtyValue<string> _borrowerID1;
        /// <summary>
        /// TQL - Borrower 4506T Orders - Borrower ID 1 [TQL4506TNN21]
        /// </summary>
        [LoanFieldProperty(Description = "TQL - Borrower 4506T Orders - Borrower ID 1")]
        public string BorrowerID1 { get => _borrowerID1; set => _borrowerID1 = value; }
        private DirtyValue<string> _borrowerID2;
        /// <summary>
        /// TQL - Borrower 4506T Orders - Borrower ID 2 [TQL4506TNN31]
        /// </summary>
        [LoanFieldProperty(Description = "TQL - Borrower 4506T Orders - Borrower ID 2")]
        public string BorrowerID2 { get => _borrowerID2; set => _borrowerID2 = value; }
        private DirtyValue<string> _borrowerID3;
        /// <summary>
        /// TQL - Borrower 4506T Orders - Borrower ID 3 [TQL4506TNN41]
        /// </summary>
        [LoanFieldProperty(Description = "TQL - Borrower 4506T Orders - Borrower ID 3")]
        public string BorrowerID3 { get => _borrowerID3; set => _borrowerID3 = value; }
        private DirtyValue<string> _borrowerID4;
        /// <summary>
        /// TQL - Borrower 4506T Orders - Borrower ID 4 [TQL4506TNN51]
        /// </summary>
        [LoanFieldProperty(Description = "TQL - Borrower 4506T Orders - Borrower ID 4")]
        public string BorrowerID4 { get => _borrowerID4; set => _borrowerID4 = value; }
        private DirtyValue<DateTime?> _completedDate;
        /// <summary>
        /// TQL - Borrower 4506T Orders - Completed Date [TQL4506TNN03]
        /// </summary>
        [LoanFieldProperty(Description = "TQL - Borrower 4506T Orders - Completed Date")]
        public DateTime? CompletedDate { get => _completedDate; set => _completedDate = value; }
        private DirtyValue<string> _id;
        /// <summary>
        /// TQLReportInformation Id
        /// </summary>
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<string> _investor;
        /// <summary>
        /// TQL - Borrower 4506T Orders - Investor [TQL4506TNN06]
        /// </summary>
        [LoanFieldProperty(Description = "TQL - Borrower 4506T Orders - Investor")]
        public string Investor { get => _investor; set => _investor = value; }
        private DirtyValue<DateTime?> _orderDate;
        /// <summary>
        /// TQL - Borrower 4506T Orders - Order Date [TQL4506TNN02]
        /// </summary>
        [LoanFieldProperty(Description = "TQL - Borrower 4506T Orders - Order Date")]
        public DateTime? OrderDate { get => _orderDate; set => _orderDate = value; }
        private DirtyValue<string> _orderNumber;
        /// <summary>
        /// TQL - Borrower 4506T Orders - Order number [TQL4506TNN05]
        /// </summary>
        [LoanFieldProperty(Description = "TQL - Borrower 4506T Orders - Order number")]
        public string OrderNumber { get => _orderNumber; set => _orderNumber = value; }
        private DirtyValue<string> _orderStatus;
        /// <summary>
        /// TQL - Borrower 4506T Orders - Status [TQL4506TNN04]
        /// </summary>
        [LoanFieldProperty(Description = "TQL - Borrower 4506T Orders - Status")]
        public string OrderStatus { get => _orderStatus; set => _orderStatus = value; }
        private DirtyValue<decimal?> _percentVariance1;
        /// <summary>
        /// TQL - Borrower 4506T Orders - Percent Variance 1 [TQL4506TNN23]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "TQL - Borrower 4506T Orders - Percent Variance 1")]
        public decimal? PercentVariance1 { get => _percentVariance1; set => _percentVariance1 = value; }
        private DirtyValue<decimal?> _percentVariance2;
        /// <summary>
        /// TQL - Borrower 4506T Orders - Percent Variance 2 [TQL4506TNN33]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "TQL - Borrower 4506T Orders - Percent Variance 2")]
        public decimal? PercentVariance2 { get => _percentVariance2; set => _percentVariance2 = value; }
        private DirtyValue<decimal?> _percentVariance3;
        /// <summary>
        /// TQL - Borrower 4506T Orders - Percent Variance 3 [TQL4506TNN43]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "TQL - Borrower 4506T Orders - Percent Variance 3")]
        public decimal? PercentVariance3 { get => _percentVariance3; set => _percentVariance3 = value; }
        private DirtyValue<decimal?> _percentVariance4;
        /// <summary>
        /// TQL - Borrower 4506T Orders - Percent Variance 4 [TQL4506TNN53]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "TQL - Borrower 4506T Orders - Percent Variance 4")]
        public decimal? PercentVariance4 { get => _percentVariance4; set => _percentVariance4 = value; }
        private DirtyValue<string> _productsOrdered;
        /// <summary>
        /// TQL - Borrower 4506T Orders - Products Ordered [TQL4506TNN07]
        /// </summary>
        [LoanFieldProperty(Description = "TQL - Borrower 4506T Orders - Products Ordered")]
        public string ProductsOrdered { get => _productsOrdered; set => _productsOrdered = value; }
        private DirtyValue<string> _reportYear1;
        /// <summary>
        /// TQL - Borrower 4506T Orders - Report Year 1 [TQL4506TNN20]
        /// </summary>
        [LoanFieldProperty(Description = "TQL - Borrower 4506T Orders - Report Year 1")]
        public string ReportYear1 { get => _reportYear1; set => _reportYear1 = value; }
        private DirtyValue<string> _reportYear2;
        /// <summary>
        /// TQL - Borrower 4506T Orders - Report Year 2 [TQL4506TNN30]
        /// </summary>
        [LoanFieldProperty(Description = "TQL - Borrower 4506T Orders - Report Year 2")]
        public string ReportYear2 { get => _reportYear2; set => _reportYear2 = value; }
        private DirtyValue<string> _reportYear3;
        /// <summary>
        /// TQL - Borrower 4506T Orders - Report Year 3 [TQL4506TNN40]
        /// </summary>
        [LoanFieldProperty(Description = "TQL - Borrower 4506T Orders - Report Year 3")]
        public string ReportYear3 { get => _reportYear3; set => _reportYear3 = value; }
        private DirtyValue<string> _reportYear4;
        /// <summary>
        /// TQL - Borrower 4506T Orders - Report Year 4 [TQL4506TNN50]
        /// </summary>
        [LoanFieldProperty(Description = "TQL - Borrower 4506T Orders - Report Year 4")]
        public string ReportYear4 { get => _reportYear4; set => _reportYear4 = value; }
        private DirtyValue<decimal?> _totalIncome1;
        /// <summary>
        /// TQL - Borrower 4506T Orders - Total Income 1 [TQL4506TNN22]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "TQL - Borrower 4506T Orders - Total Income 1")]
        public decimal? TotalIncome1 { get => _totalIncome1; set => _totalIncome1 = value; }
        private DirtyValue<decimal?> _totalIncome2;
        /// <summary>
        /// TQL - Borrower 4506T Orders - Total Income 2 [TQL4506TNN32]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "TQL - Borrower 4506T Orders - Total Income 2")]
        public decimal? TotalIncome2 { get => _totalIncome2; set => _totalIncome2 = value; }
        private DirtyValue<decimal?> _totalIncome3;
        /// <summary>
        /// TQL - Borrower 4506T Orders - Total Income 3 [TQL4506TNN42]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "TQL - Borrower 4506T Orders - Total Income 3")]
        public decimal? TotalIncome3 { get => _totalIncome3; set => _totalIncome3 = value; }
        private DirtyValue<decimal?> _totalIncome4;
        /// <summary>
        /// TQL - Borrower 4506T Orders - Total Income 4 [TQL4506TNN52]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "TQL - Borrower 4506T Orders - Total Income 4")]
        public decimal? TotalIncome4 { get => _totalIncome4; set => _totalIncome4 = value; }
        private DirtyValue<string> _transcriptType;
        /// <summary>
        /// TQL - Borrower 4506T Orders - Transcript Type [TQL4506TNN08]
        /// </summary>
        [LoanFieldProperty(Description = "TQL - Borrower 4506T Orders - Transcript Type")]
        public string TranscriptType { get => _transcriptType; set => _transcriptType = value; }
        private DirtyValue<string> _userID;
        /// <summary>
        /// TQL - Borrower 4506T Orders - User ID [TQL4506TNN01]
        /// </summary>
        [LoanFieldProperty(Description = "TQL - Borrower 4506T Orders - User ID")]
        public string UserID { get => _userID; set => _userID = value; }
    }
}