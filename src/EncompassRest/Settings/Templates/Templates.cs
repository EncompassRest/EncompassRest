using System.Threading;

namespace EncompassRest.Settings.Templates
{
    public sealed class Templates : ApiObject
    {
        private LoanTemplates _loanTemplates;

        public LoanTemplates LoanTemplates
        {
            get
            {
                var loanTemplates = _loanTemplates;
                return loanTemplates ?? Interlocked.CompareExchange(ref _loanTemplates, (loanTemplates = new LoanTemplates(Client)), null) ?? loanTemplates;
            }
        }

        internal Templates(EncompassRestClient client)
            : base(client, "encompass/v1/settings/templates")
        {
        }
    }
}