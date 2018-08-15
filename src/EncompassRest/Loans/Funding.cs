using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// Funding
    /// </summary>
    public sealed partial class Funding : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<DateTime?> _collateralSentDate;
        /// <summary>
        /// Funding Collateral Sent Date [1998]
        /// </summary>
        [LoanFieldProperty(Description = "Funding Collateral Sent Date")]
        public DateTime? CollateralSentDate { get => _collateralSentDate; set => SetField(ref _collateralSentDate, value); }
        private DirtyValue<string> _funderName;
        /// <summary>
        /// Funding Funder Name [1991]
        /// </summary>
        [LoanFieldProperty(Description = "Funding Funder Name")]
        public string FunderName { get => _funderName; set => SetField(ref _funderName, value); }
        private DirtyValue<string> _funderUrl;
        /// <summary>
        /// Funding Funder URL [2011]
        /// </summary>
        [LoanFieldProperty(Description = "Funding Funder URL")]
        public string FunderUrl { get => _funderUrl; set => SetField(ref _funderUrl, value); }
        private DirtyValue<string> _fundingClearedBy;
        /// <summary>
        /// Funding Cleared By [1995]
        /// </summary>
        [LoanFieldProperty(Description = "Funding Cleared By")]
        public string FundingClearedBy { get => _fundingClearedBy; set => SetField(ref _fundingClearedBy, value); }
        private DirtyValue<DateTime?> _fundingCloseDate;
        /// <summary>
        /// Funding Close Date [1994]
        /// </summary>
        [LoanFieldProperty(Description = "Funding Close Date")]
        public DateTime? FundingCloseDate { get => _fundingCloseDate; set => SetField(ref _fundingCloseDate, value); }
        private DirtyValue<string> _fundingFees;
        /// <summary>
        /// Funding Worksheet - Funding Fees [FUNDINGFEES]
        /// </summary>
        [LoanFieldProperty(Description = "Funding Worksheet - Funding Fees")]
        public string FundingFees { get => _fundingFees; set => SetField(ref _fundingFees, value); }
        private DirtyValue<DateTime?> _fundingOrderDate;
        /// <summary>
        /// Funding Funds Ordered Date [1996]
        /// </summary>
        [LoanFieldProperty(Description = "Funding Funds Ordered Date")]
        public DateTime? FundingOrderDate { get => _fundingOrderDate; set => SetField(ref _fundingOrderDate, value); }
        private DirtyValue<string> _fundingType;
        /// <summary>
        /// Funding Type [1993]
        /// </summary>
        [LoanFieldProperty(Description = "Funding Type")]
        public string FundingType { get => _fundingType; set => SetField(ref _fundingType, value); }
        private DirtyValue<DateTime?> _fundsReleasedDate;
        /// <summary>
        /// Funding Funds Released [1999]
        /// </summary>
        [LoanFieldProperty(Description = "Funding Funds Released")]
        public DateTime? FundsReleasedDate { get => _fundsReleasedDate; set => SetField(ref _fundsReleasedDate, value); }
        private DirtyValue<string> _fundsReleaseNumber;
        /// <summary>
        /// Funding Funds Release Number [2000]
        /// </summary>
        [LoanFieldProperty(Description = "Funding Funds Release Number")]
        public string FundsReleaseNumber { get => _fundsReleaseNumber; set => SetField(ref _fundsReleaseNumber, value); }
        private DirtyValue<DateTime?> _fundsSentDate;
        /// <summary>
        /// Funding Funds Sent Date [1997]
        /// </summary>
        [LoanFieldProperty(Description = "Funding Funds Sent Date")]
        public DateTime? FundsSentDate { get => _fundsSentDate; set => SetField(ref _fundsSentDate, value); }
        private DirtyValue<string> _fundsWireTo;
        /// <summary>
        /// Funding Wired To [2001]
        /// </summary>
        [LoanFieldProperty(Description = "Funding Wired To")]
        public string FundsWireTo { get => _fundsWireTo; set => SetField(ref _fundsWireTo, value); }
        private DirtyValue<string> _id;
        /// <summary>
        /// Funding Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }
        private DirtyValue<DateTime?> _sentToFunderDate;
        /// <summary>
        /// Funding Sent to Funder Date [1992]
        /// </summary>
        [LoanFieldProperty(Description = "Funding Sent to Funder Date")]
        public DateTime? SentToFunderDate { get => _sentToFunderDate; set => SetField(ref _sentToFunderDate, value); }
        private DirtyValue<string> _wiredToAbaNumber;
        /// <summary>
        /// Funding Wired To ABA Number [2008]
        /// </summary>
        [LoanFieldProperty(Description = "Funding Wired To ABA Number")]
        public string WiredToAbaNumber { get => _wiredToAbaNumber; set => SetField(ref _wiredToAbaNumber, value); }
        private DirtyValue<string> _wiredToAccountNumber;
        /// <summary>
        /// Funding Wired To Account Number [2009]
        /// </summary>
        [LoanFieldProperty(Description = "Funding Wired To Account Number")]
        public string WiredToAccountNumber { get => _wiredToAccountNumber; set => SetField(ref _wiredToAccountNumber, value); }
        private DirtyValue<string> _wiredToForCreditTo;
        /// <summary>
        /// Funding Wired To For Credit To [2010]
        /// </summary>
        [LoanFieldProperty(Description = "Funding Wired To For Credit To")]
        public string WiredToForCreditTo { get => _wiredToForCreditTo; set => SetField(ref _wiredToForCreditTo, value); }
        private DirtyValue<string> _wiredToForCreditTo1;
        /// <summary>
        /// Funding Wired To 1 - For Credit To [2004]
        /// </summary>
        [LoanFieldProperty(Description = "Funding Wired To 1 - For Credit To")]
        public string WiredToForCreditTo1 { get => _wiredToForCreditTo1; set => SetField(ref _wiredToForCreditTo1, value); }
        private DirtyValue<string> _wiredToForCreditTo2;
        /// <summary>
        /// Funding Wired To 2 - For Credit To [2007]
        /// </summary>
        [LoanFieldProperty(Description = "Funding Wired To 2 - For Credit To")]
        public string WiredToForCreditTo2 { get => _wiredToForCreditTo2; set => SetField(ref _wiredToForCreditTo2, value); }
        private DirtyValue<string> _wiredToForFurtherCreditTo1;
        /// <summary>
        /// Funding Wired To 1 - For Further Credit To [2002]
        /// </summary>
        [LoanFieldProperty(Description = "Funding Wired To 1 - For Further Credit To")]
        public string WiredToForFurtherCreditTo1 { get => _wiredToForFurtherCreditTo1; set => SetField(ref _wiredToForFurtherCreditTo1, value); }
        private DirtyValue<string> _wiredToForFurtherCreditTo2;
        /// <summary>
        /// Funding Wired To 2 - For Further Credit To [2003]
        /// </summary>
        [LoanFieldProperty(Description = "Funding Wired To 2 - For Further Credit To")]
        public string WiredToForFurtherCreditTo2 { get => _wiredToForFurtherCreditTo2; set => SetField(ref _wiredToForFurtherCreditTo2, value); }
    }
}