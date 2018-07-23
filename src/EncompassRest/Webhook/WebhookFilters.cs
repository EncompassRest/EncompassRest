using System.Collections.Generic;

namespace EncompassRest.Webhook
{
    public sealed class WebhookFilters : ExtensibleObject
    {
        private List<string> _attributes;
        public IList<string> Attributes { get => _attributes ?? (_attributes = new List<string>()); set => _attributes = value != null ? new List<string>(value) : null; }

        internal override bool DirtyInternal { get => true; set { } }
    }
}