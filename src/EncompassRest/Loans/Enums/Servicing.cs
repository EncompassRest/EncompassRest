using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum Servicing
    {
        [EnumMember(Value = "service your loan. If so, you will make your payments to us.")]
        ServiceYourLoanIfSoYouWillMakeYourPaymentsToUs = 0,
        [EnumMember(Value = "transfer servicing of your loan.")]
        TransferServicingOfYourLoan = 1
    }
}