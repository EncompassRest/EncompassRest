using System.Threading;

namespace EncompassRest.Settings.Templates
{
    public sealed class Templates : ApiObject
    {
        private LoanTemplateSet _loanTemplateSet;

        public LoanTemplateSet LoanTemplateSet
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