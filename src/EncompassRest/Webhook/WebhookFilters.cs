using System.Collections.Generic;

namespace EncompassRest.Webhook
{
    public sealed class WebhookFilters : ExtensibleObject, IDirty
    {
        private List<string> _attributes;
        public IList<string> Attributes { get => _attributes ?? (_attributes = new List<string>()); set => _attributes = value != null ? new List<string>(value) : null; }

        bool IDirty.Dirty { get => true; set { } }
    }
}