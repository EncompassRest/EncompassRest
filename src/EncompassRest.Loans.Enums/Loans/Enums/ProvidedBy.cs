using System.ComponentModel;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// ProvidedBy
    /// </summary>
    public enum ProvidedBy
    {
        /// <summary>
        /// Broker
        /// </summary>
        Broker = 0,
        /// <summary>
        /// Lender
        /// </summary>
        Lender = 1,
        /// <summary>
        /// Correspondent Lender
        /// </summary>
        [Description("Correspondent Lender")]
        CorrespondentLender = 2
    }
}