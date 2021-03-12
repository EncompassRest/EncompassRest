using System.Threading;

namespace EncompassApi.Settings.Templates
{
    /// <summary>
    /// The Templates Apis.
    /// </summary>
    public interface ITemplates : IApiObject
    {
        /// <summary>
        /// The Loan Template Set Apis.
        /// </summary>
        ILoanTemplateSet LoanTemplateSet { get; }
    }

    /// <summary>
    /// The Templates Apis.
    /// </summary>
    public sealed class Templates : ApiObject, ITemplates
    {
        private LoanTemplateSet? _loanTemplateSet;

        /// <summary>
        /// The Loan Template Set Apis.
        /// </summary>
        public LoanTemplateSet LoanTemplateSet
        {
            get
            {
                var loanTemplateSet = _loanTemplateSet;
                return loanTemplateSet ?? Interlocked.CompareExchange(ref _loanTemplateSet, (loanTemplateSet = new LoanTemplateSet(Client)), null) ?? loanTemplateSet;
            }
        }

        ILoanTemplateSet ITemplates.LoanTemplateSet => LoanTemplateSet;

        internal Templates(IEncompassApiClient client)
            : base(client, "encompass/v1/settings/templates")
        {
        }
    }
}