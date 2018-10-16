using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// Servicing
    /// </summary>
    public enum Servicing
    {
        /// <summary>
        /// service your loan. If so, you will make your payments to us.
        /// </summary>
        [EnumMember(Value = "service your loan. If so, you will make your payments to us.")]
        ServiceYourLoanIfSoYouWillMakeYourPaymentsToUs = 0,
        /// <summary>
        /// transfer servicing of your loan.
        /// </summary>
        [EnumMember(Value = "transfer servicing of your loan.")]
        TransferServicingOfYourLoan = 1
    }
}