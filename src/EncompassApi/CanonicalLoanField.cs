namespace EncompassApi
{
    /// <summary>
    /// CanonicalLoanField
    /// </summary>
    public enum CanonicalLoanField
    {
        /// <summary>
        /// Loan.ActionTakenDate
        /// </summary>
        ActionTakenDate = 0,
        /// <summary>
        /// Loan.ARMAdjustmentDate
        /// </summary>
        ARMAdjustmentDate = 1,
        /// <summary>
        /// Loan.CurrentMilestoneDate
        /// </summary>
        CurrentMilestoneDate = 2,
        /// <summary>
        /// Loan.DateApprovalReceived
        /// </summary>
        DateApprovalReceived = 3,
        /// <summary>
        /// Loan.DateCompleted
        /// </summary>
        DateCompleted = 4,
        /// <summary>
        /// Loan.DateCreated
        /// </summary>
        DateCreated = 5,
        /// <summary>
        /// Loan.DateDocsSigned
        /// </summary>
        DateDocsSigned = 6,
        /// <summary>
        /// Loan.DateFileOpened
        /// </summary>
        DateFileOpened = 7,
        /// <summary>
        /// Loan.DateFunded
        /// </summary>
        DateFunded = 8,
        /// <summary>
        /// Loan.DateOfEstimatedCompletion
        /// </summary>
        DateOfEstimatedCompletion = 9,
        /// <summary>
        /// Loan.DateOfFinalAction
        /// </summary>
        DateOfFinalAction = 10,
        /// <summary>
        /// Loan.DatePurchased
        /// </summary>
        DatePurchased = 11,
        /// <summary>
        /// Loan.DateSentToProcessing
        /// </summary>
        DateSentToProcessing = 12,
        /// <summary>
        /// Loan.DateShipped
        /// </summary>
        DateShipped = 13,
        /// <summary>
        /// Loan.DateSubmittedToLender
        /// </summary>
        DateSubmittedToLender = 14,
        /// <summary>
        /// Loan.InvestorStatusDate
        /// </summary>
        InvestorStatusDate = 15,
        /// <summary>
        /// Loan.ISLatePaymentDate
        /// </summary>
        ISLatePaymentDate = 16,
        /// <summary>
        /// Loan.ISPaymentDue
        /// </summary>
        ISPaymentDue = 17,
        /// <summary>
        /// Loan.ISStatementDue
        /// </summary>
        ISStatementDue = 18,
        /// <summary>
        /// Loan.LastModified
        /// </summary>
        LastModified = 19,
        /// <summary>
        /// Loan.LockExpirationDate
        /// </summary>
        LockExpirationDate = 20,
        /// <summary>
        /// Loan.LockRequestDate
        /// </summary>
        LockRequestDate = 21,
        /// <summary>
        /// Loan.NextMilestoneDate
        /// </summary>
        NextMilestoneDate = 22,
        /// <summary>
        /// Loan.PrevMilestoneGroupDate
        /// </summary>
        PrevMilestoneGroupDate = 23,
        /// <summary>
        /// Loan.ProcessorReviewed
        /// </summary>
        ProcessorReviewed = 24,
        /// <summary>
        /// Loan.TPORegisterDate
        /// </summary>
        TPORegisterDate = 25,
        /// <summary>
        /// Loan.TPOSubmitDate
        /// </summary>
        TPOSubmitDate = 26,
        /// <summary>
        /// Loan.UnderWriterApprovalDate
        /// </summary>
        UnderWriterApprovalDate = 27,
        /// <summary>
        /// Loan.UnderWriterDeniedDate
        /// </summary>
        UnderWriterDeniedDate = 28,
        /// <summary>
        /// Loan.UnderWriterDifferentApprovedDate
        /// </summary>
        UnderWriterDifferentApprovedDate = 29,
        /// <summary>
        /// Loan.UnderWriterSuspendedDate
        /// </summary>
        UnderWriterSuspendedDate = 30,
        /// <summary>
        /// Loan.AppraisedValue
        /// </summary>
        AppraisedValue = 100,
        /// <summary>
        /// Loan.ARMFirstRateAdjCap
        /// </summary>
        ARMFirstRateAdjCap = 101,
        /// <summary>
        /// Loan.ARMFloorRate
        /// </summary>
        ARMFloorRate = 102,
        /// <summary>
        /// Loan.ARMLifeCap
        /// </summary>
        ARMLifeCap = 103,
        /// <summary>
        /// Loan.ARMMargin
        /// </summary>
        ARMMargin = 104,
        /// <summary>
        /// Loan.CLTV
        /// </summary>
        CLTV = 105,
        /// <summary>
        /// Loan.CreditScore
        /// </summary>
        CreditScore = 106,
        /// <summary>
        /// Loan.DownPayment
        /// </summary>
        DownPayment = 107,
        /// <summary>
        /// Loan.DTIBottom
        /// </summary>
        DTIBottom = 108,
        /// <summary>
        /// Loan.DTITop
        /// </summary>
        DTITop = 109,
        /// <summary>
        /// Loan.LOAdditionalCommission
        /// </summary>
        LOAdditionalCommission = 110,
        /// <summary>
        /// Loan.LoanAmount
        /// </summary>
        LoanAmount = 111,
        /// <summary>
        /// Loan.LoanBrokerProfit
        /// </summary>
        LoanBrokerProfit = 112,
        /// <summary>
        /// Loan.LoanOfficerProfit
        /// </summary>
        LoanOfficerProfit = 113,
        /// <summary>
        /// Loan.LoanProcessorProfit
        /// </summary>
        LoanProcessorProfit = 114,
        /// <summary>
        /// Loan.LoanRate
        /// </summary>
        LoanRate = 115,
        /// <summary>
        /// Loan.LockDays
        /// </summary>
        LockDays = 116,
        /// <summary>
        /// Loan.LOCommissionByLoan
        /// </summary>
        LOCommissionByLoan = 117,
        /// <summary>
        /// Loan.LOCommissionByProfit
        /// </summary>
        LOCommissionByProfit = 118,
        /// <summary>
        /// Loan.LTV
        /// </summary>
        LTV = 119,
        /// <summary>
        /// Loan.ManagerProfit
        /// </summary>
        ManagerProfit = 120,
        /// <summary>
        /// Loan.NetBuyPrice
        /// </summary>
        NetBuyPrice = 121,
        /// <summary>
        /// Loan.NetProfit
        /// </summary>
        NetProfit = 122,
        /// <summary>
        /// Loan.NetSellPrice
        /// </summary>
        NetSellPrice = 123,
        /// <summary>
        /// Loan.OtherProfit
        /// </summary>
        OtherProfit = 124,
        /// <summary>
        /// Loan.Term
        /// </summary>
        Term = 125,
        /// <summary>
        /// Loan.TotalAdditionalCommission
        /// </summary>
        TotalAdditionalCommission = 126,
        /// <summary>
        /// Loan.TotalBuyPrice
        /// </summary>
        TotalBuyPrice = 127,
        /// <summary>
        /// Loan.TotalCommissionByLoan
        /// </summary>
        TotalCommissionByLoan = 128,
        /// <summary>
        /// Loan.TotalCommissionByProfit
        /// </summary>
        TotalCommissionByProfit = 129,
        /// <summary>
        /// Loan.TotalLoanAmount
        /// </summary>
        TotalLoanAmount = 130,
        /// <summary>
        /// Loan.TotalSellPrice
        /// </summary>
        TotalSellPrice = 131,
        /// <summary>
        /// Loan.ActionTaken
        /// </summary>
        ActionTaken = 200,
        /// <summary>
        /// Loan.Active
        /// </summary>
        Active = 201,
        /// <summary>
        /// Loan.Address1
        /// </summary>
        Address1 = 202,
        /// <summary>
        /// Loan.Address2
        /// </summary>
        Address2 = 203,
        /// <summary>
        /// Loan.Adverse
        /// </summary>
        Adverse = 204,
        /// <summary>
        /// Loan.Amortization
        /// </summary>
        Amortization = 205,
        /// <summary>
        /// Loan.AppraisalVendor
        /// </summary>
        AppraisalVendor = 206,
        /// <summary>
        /// Loan.BorrowerEthnicity
        /// </summary>
        BorrowerEthnicity = 207,
        /// <summary>
        /// Loan.BorrowerFirstName
        /// </summary>
        BorrowerFirstName = 208,
        /// <summary>
        /// Loan.BorrowerLastName
        /// </summary>
        BorrowerLastName = 209,
        /// <summary>
        /// Loan.BorrowerName
        /// </summary>
        BorrowerName = 210,
        /// <summary>
        /// Loan.BorrowerRace
        /// </summary>
        BorrowerRace = 211,
        /// <summary>
        /// Loan.BorrowerSex
        /// </summary>
        BorrowerSex = 212,
        /// <summary>
        /// Loan.Broker
        /// </summary>
        Broker = 213,
        /// <summary>
        /// Loan.BuySideCommited
        /// </summary>
        BuySideCommited = 214,
        /// <summary>
        /// Loan.CensusTract
        /// </summary>
        CensusTract = 215,
        /// <summary>
        /// Loan.City
        /// </summary>
        City = 216,
        /// <summary>
        /// Loan.CoBorrowerEthnicity
        /// </summary>
        CoBorrowerEthnicity = 217,
        /// <summary>
        /// Loan.CoBorrowerFirstName
        /// </summary>
        CoBorrowerFirstName = 218,
        /// <summary>
        /// Loan.CoBorrowerLastName
        /// </summary>
        CoBorrowerLastName = 219,
        /// <summary>
        /// Loan.CoBorrowerName
        /// </summary>
        CoBorrowerName = 220,
        /// <summary>
        /// Loan.CoBorrowerRace
        /// </summary>
        CoBorrowerRace = 221,
        /// <summary>
        /// Loan.CoBorrowerSex
        /// </summary>
        CoBorrowerSex = 222,
        /// <summary>
        /// Loan.Completed
        /// </summary>
        Completed = 223,
        /// <summary>
        /// Loan.CreditVendor
        /// </summary>
        CreditVendor = 224,
        /// <summary>
        /// Loan.CurrentMilestoneId
        /// </summary>
        CurrentMilestoneId = 225,
        /// <summary>
        /// Loan.CurrentMilestoneName
        /// </summary>
        CurrentMilestoneName = 226,
        /// <summary>
        /// Loan.DocPrepVendor
        /// </summary>
        DocPrepVendor = 227,
        /// <summary>
        /// Loan.EscrowVendor
        /// </summary>
        EscrowVendor = 228,
        /// <summary>
        /// Loan.EscrowWaived
        /// </summary>
        EscrowWaived = 229,
        /// <summary>
        /// Loan.FloodVendor
        /// </summary>
        FloodVendor = 230,
        /// <summary>
        /// Loan.Guid
        /// </summary>
        Guid = 231,
        /// <summary>
        /// Loan.HazardInsuranceVendor
        /// </summary>
        HazardInsuranceVendor = 232,
        /// <summary>
        /// Loan.Investor
        /// </summary>
        Investor = 233,
        /// <summary>
        /// Loan.InvestorStatus
        /// </summary>
        InvestorStatus = 234,
        /// <summary>
        /// Loan.ISStatus
        /// </summary>
        ISStatus = 235,
        /// <summary>
        /// Loan.LeinPosition
        /// </summary>
        LeinPosition = 236,
        /// <summary>
        /// Loan.Lender
        /// </summary>
        Lender = 237,
        /// <summary>
        /// Loan.LinkGUID
        /// </summary>
        LinkGUID = 238,
        /// <summary>
        /// Loan.LoanCloserId
        /// </summary>
        LoanCloserId = 239,
        /// <summary>
        /// Loan.LoanCloserName
        /// </summary>
        LoanCloserName = 240,
        /// <summary>
        /// Loan.LoanFolder
        /// </summary>
        LoanFolder = 241,
        /// <summary>
        /// Loan.LoanName
        /// </summary>
        LoanName = 242,
        /// <summary>
        /// Loan.LoanNumber
        /// </summary>
        LoanNumber = 243,
        /// <summary>
        /// Loan.LoanOfficerId
        /// </summary>
        LoanOfficerId = 244,
        /// <summary>
        /// Loan.LoanOfficerName
        /// </summary>
        LoanOfficerName = 245,
        /// <summary>
        /// Loan.LoanProcessorId
        /// </summary>
        LoanProcessorId = 246,
        /// <summary>
        /// Loan.LoanProcessorName
        /// </summary>
        LoanProcessorName = 247,
        /// <summary>
        /// Loan.LoanProgram
        /// </summary>
        LoanProgram = 248,
        /// <summary>
        /// Loan.LoanPurpose
        /// </summary>
        LoanPurpose = 249,
        /// <summary>
        /// Loan.LoanSource
        /// </summary>
        LoanSource = 250,
        /// <summary>
        /// Loan.LoanType
        /// </summary>
        LoanType = 251,
        /// <summary>
        /// Loan.LockAndRequestStatus
        /// </summary>
        LockAndRequestStatus = 252,
        /// <summary>
        /// Loan.LockCommitment
        /// </summary>
        LockCommitment = 253,
        /// <summary>
        /// Loan.LockRequested
        /// </summary>
        LockRequested = 254,
        /// <summary>
        /// Loan.LockRequestPending
        /// </summary>
        LockRequestPending = 255,
        /// <summary>
        /// Loan.LockStatus
        /// </summary>
        LockStatus = 256,
        /// <summary>
        /// Loan.MortgageInsuranceVendor
        /// </summary>
        MortgageInsuranceVendor = 257,
        /// <summary>
        /// Loan.MSA
        /// </summary>
        MSA = 258,
        /// <summary>
        /// Loan.NextMilestoneId
        /// </summary>
        NextMilestoneId = 259,
        /// <summary>
        /// Loan.NextMilestoneName
        /// </summary>
        NextMilestoneName = 260,
        /// <summary>
        /// Loan.OccupancyStatus
        /// </summary>
        OccupancyStatus = 261,
        /// <summary>
        /// Loan.PropertyType
        /// </summary>
        PropertyType = 262,
        /// <summary>
        /// Loan.RateIsLocked
        /// </summary>
        RateIsLocked = 263,
        /// <summary>
        /// Loan.ReferralSource
        /// </summary>
        ReferralSource = 264,
        /// <summary>
        /// Loan.SecondMortgage
        /// </summary>
        SecondMortgage = 265,
        /// <summary>
        /// Loan.SellSideCommitted
        /// </summary>
        SellSideCommitted = 266,
        /// <summary>
        /// Loan.State
        /// </summary>
        State = 267,
        /// <summary>
        /// Loan.Status
        /// </summary>
        Status = 268,
        /// <summary>
        /// Loan.TitleVendor
        /// </summary>
        TitleVendor = 269,
        /// <summary>
        /// Loan.TPOArchived
        /// </summary>
        TPOArchived = 270,
        /// <summary>
        /// Loan.TPOBranchID
        /// </summary>
        TPOBranchID = 271,
        /// <summary>
        /// Loan.TPOBranchName
        /// </summary>
        TPOBranchName = 272,
        /// <summary>
        /// Loan.TPOCompanyID
        /// </summary>
        TPOCompanyID = 273,
        /// <summary>
        /// Loan.TPOCompanyName
        /// </summary>
        TPOCompanyName = 274,
        /// <summary>
        /// Loan.TPOLOID
        /// </summary>
        TPOLOID = 275,
        /// <summary>
        /// Loan.TPOLOName
        /// </summary>
        TPOLOName = 276,
        /// <summary>
        /// Loan.TPOLPID
        /// </summary>
        TPOLPID = 277,
        /// <summary>
        /// Loan.TPOLPName
        /// </summary>
        TPOLPName = 278,
        /// <summary>
        /// Loan.TPOSiteID
        /// </summary>
        TPOSiteID = 279,
        /// <summary>
        /// Loan.TradeGuid
        /// </summary>
        TradeGuid = 280,
        /// <summary>
        /// Loan.TradeNumber
        /// </summary>
        TradeNumber = 281,
        /// <summary>
        /// Loan.UnderwriterVendor
        /// </summary>
        UnderwriterVendor = 282,
        /// <summary>
        /// Loan.Zip
        /// </summary>
        Zip = 283
    }
}