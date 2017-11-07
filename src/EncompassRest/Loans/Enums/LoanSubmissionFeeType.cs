using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum LoanSubmissionFeeType
    {
        Undefined = 0,
        AppraisalFee = 1,
        CreditReportFee = 2,
        DocumentFee = 3,
        LoanDiscountFee = 4,
        LoanOriginationFee = 5,
        ProcessingFee = 6,
        TaxServiceFee = 7,
        UnderwritingFee = 8,
        UserDefined1 = 9,
        UserDefined2 = 10,
        UserDefined3 = 11,
        UserDefined4 = 12,
        UserDefined5 = 13,
        UserDefined6 = 14
    }
}