using System.Threading;

namespace EncompassRest.Settings
{
    public sealed class Settings : ApiObject
    {
        private Templates.Templates _templates;

        public Templates.Templates Templates
        {
            get
            {
                var templates = _templates;
                return templates ?? Interlocked.CompareExchange(ref _templates, (templates = new Templates.Templates(Client)), null) ?? templates;
            }
        }

        internal Settings(EncompassRestClient client)
            : base(client, "encompass/v1/settings")
        {
        }
    }
}