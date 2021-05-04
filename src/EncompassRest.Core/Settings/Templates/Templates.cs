using System.Threading;

namespace EncompassRest.Settings.Templates
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

    internal sealed class Templates : ApiObject, ITemplates
    {
        private LoanTemplateSet? _loanTemplateSet;

        public ILoanTemplateSet LoanTemplateSet
        {
            get
            {
                var loanTemplateSet = _loanTemplateSet;
                return loanTemplateSet ?? Interlocked.CompareExchange(ref _loanTemplateSet, (loanTemplateSet = new LoanTemplateSet(Client)), null) ?? loanTemplateSet;
            }
        }

        internal Templates(EncompassRestClient client)
            : base(client, "encompass/v1/settings/templates")
        {
        }
    }
}