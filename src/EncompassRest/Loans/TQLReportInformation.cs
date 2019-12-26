using System;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// TQLReportInformation
    /// </summary>
    [Entity(SerializeWholeListWhenDirty = true)]
    public sealed partial class TQLReportInformation : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<string?>? _altId;
        private DirtyValue<string?>? _borrowerID1;
        private DirtyValue<string?>? _borrowerID2;
        private DirtyValue<string?>? _borrowerID3;
        private DirtyValue<string?>? _borrowerID4;
        private DirtyValue<DateTime?>? _completedDate;
        private DirtyValue<string?>? _id;
        private DirtyValue<string?>? _investor;
        private DirtyValue<DateTime?>? _orderDate;
        private DirtyValue<string?>? _orderNumber;
        private DirtyValue<string?>? _orderStatus;
        private DirtyValue<decimal?>? _percentVariance1;
        private DirtyValue<decimal?>? _percentVariance2;
        private DirtyValue<decimal?>? _percentVariance3;
        private DirtyValue<decimal?>? _percentVariance4;
        private DirtyValue<string?>? _productsOrdered;
        private DirtyValue<string?>? _reportYear1;
        private DirtyValue<string?>? _reportYear2;
        private DirtyValue<string?>? _reportYear3;
        private DirtyValue<string?>? _reportYear4;
        private DirtyValue<decimal?>? _totalIncome1;
        private DirtyValue<decimal?>? _totalIncome2;
        private DirtyValue<decimal?>? _totalIncome3;
        private DirtyValue<decimal?>? _totalIncome4;
        private DirtyValue<string?>? _transcriptType;
        private DirtyValue<string?>? _userID;

        /// <summary>
        /// TQL - Borrower 4506T Orders - ID [TQL4506TNN99]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string? AltId { get => _altId; set => SetField(ref _altId, value); }

        /// <summary>
        /// TQL - Borrower 4506T Orders - Borrower ID 1 [TQL4506TNN21]
        /// </summary>
        public string? BorrowerID1 { get => _borrowerID1; set => SetField(ref _borrowerID1, value); }

        /// <summary>
        /// TQL - Borrower 4506T Orders - Borrower ID 2 [TQL4506TNN31]
        /// </summary>
        public string? BorrowerID2 { get => _borrowerID2; set => SetField(ref _borrowerID2, value); }

        /// <summary>
        /// TQL - Borrower 4506T Orders - Borrower ID 3 [TQL4506TNN41]
        /// </summary>
        public string? BorrowerID3 { get => _borrowerID3; set => SetField(ref _borrowerID3, value); }

        /// <summary>
        /// TQL - Borrower 4506T Orders - Borrower ID 4 [TQL4506TNN51]
        /// </summary>
        public string? BorrowerID4 { get => _borrowerID4; set => SetField(ref _borrowerID4, value); }

        /// <summary>
        /// TQL - Borrower 4506T Orders - Completed Date [TQL4506TNN03]
        /// </summary>
        public DateTime? CompletedDate { get => _completedDate; set => SetField(ref _completedDate, value); }

        /// <summary>
        /// TQLReportInformation Id
        /// </summary>
        public string? Id { get => _id; set => SetField(ref _id, value); }

        /// <summary>
        /// TQL - Borrower 4506T Orders - Investor [TQL4506TNN06]
        /// </summary>
        public string? Investor { get => _investor; set => SetField(ref _investor, value); }

        /// <summary>
        /// TQL - Borrower 4506T Orders - Order Date [TQL4506TNN02]
        /// </summary>
        public DateTime? OrderDate { get => _orderDate; set => SetField(ref _orderDate, value); }

        /// <summary>
        /// TQL - Borrower 4506T Orders - Order number [TQL4506TNN05]
        /// </summary>
        public string? OrderNumber { get => _orderNumber; set => SetField(ref _orderNumber, value); }

        /// <summary>
        /// TQL - Borrower 4506T Orders - Status [TQL4506TNN04]
        /// </summary>
        public string? OrderStatus { get => _orderStatus; set => SetField(ref _orderStatus, value); }

        /// <summary>
        /// TQL - Borrower 4506T Orders - Percent Variance 1 [TQL4506TNN23]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? PercentVariance1 { get => _percentVariance1; set => SetField(ref _percentVariance1, value); }

        /// <summary>
        /// TQL - Borrower 4506T Orders - Percent Variance 2 [TQL4506TNN33]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? PercentVariance2 { get => _percentVariance2; set => SetField(ref _percentVariance2, value); }

        /// <summary>
        /// TQL - Borrower 4506T Orders - Percent Variance 3 [TQL4506TNN43]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? PercentVariance3 { get => _percentVariance3; set => SetField(ref _percentVariance3, value); }

        /// <summary>
        /// TQL - Borrower 4506T Orders - Percent Variance 4 [TQL4506TNN53]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? PercentVariance4 { get => _percentVariance4; set => SetField(ref _percentVariance4, value); }

        /// <summary>
        /// TQL - Borrower 4506T Orders - Products Ordered [TQL4506TNN07]
        /// </summary>
        public string? ProductsOrdered { get => _productsOrdered; set => SetField(ref _productsOrdered, value); }

        /// <summary>
        /// TQL - Borrower 4506T Orders - Report Year 1 [TQL4506TNN20]
        /// </summary>
        public string? ReportYear1 { get => _reportYear1; set => SetField(ref _reportYear1, value); }

        /// <summary>
        /// TQL - Borrower 4506T Orders - Report Year 2 [TQL4506TNN30]
        /// </summary>
        public string? ReportYear2 { get => _reportYear2; set => SetField(ref _reportYear2, value); }

        /// <summary>
        /// TQL - Borrower 4506T Orders - Report Year 3 [TQL4506TNN40]
        /// </summary>
        public string? ReportYear3 { get => _reportYear3; set => SetField(ref _reportYear3, value); }

        /// <summary>
        /// TQL - Borrower 4506T Orders - Report Year 4 [TQL4506TNN50]
        /// </summary>
        public string? ReportYear4 { get => _reportYear4; set => SetField(ref _reportYear4, value); }

        /// <summary>
        /// TQL - Borrower 4506T Orders - Total Income 1 [TQL4506TNN22]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? TotalIncome1 { get => _totalIncome1; set => SetField(ref _totalIncome1, value); }

        /// <summary>
        /// TQL - Borrower 4506T Orders - Total Income 2 [TQL4506TNN32]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? TotalIncome2 { get => _totalIncome2; set => SetField(ref _totalIncome2, value); }

        /// <summary>
        /// TQL - Borrower 4506T Orders - Total Income 3 [TQL4506TNN42]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? TotalIncome3 { get => _totalIncome3; set => SetField(ref _totalIncome3, value); }

        /// <summary>
        /// TQL - Borrower 4506T Orders - Total Income 4 [TQL4506TNN52]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? TotalIncome4 { get => _totalIncome4; set => SetField(ref _totalIncome4, value); }

        /// <summary>
        /// TQL - Borrower 4506T Orders - Transcript Type [TQL4506TNN08]
        /// </summary>
        public string? TranscriptType { get => _transcriptType; set => SetField(ref _transcriptType, value); }

        /// <summary>
        /// TQL - Borrower 4506T Orders - User ID [TQL4506TNN01]
        /// </summary>
        public string? UserID { get => _userID; set => SetField(ref _userID, value); }
    }
}