using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum ClosingEntityType
    {
        Undefined = 0,
        Beneficiary = 1,
        Lender = 2,
        LossPayee = 3,
        PayoffPayee = 4,
        RecordableDocumentReturnTo = 5,
        RecordableDocumentTrustee = 6,
        Seller = 7,
        Trustee = 8
    }
}