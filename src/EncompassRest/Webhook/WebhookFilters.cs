using System.Collections.Generic;
using System.Linq;

namespace EncompassRest.Webhook
{
    public sealed class WebhookFilters : DirtyExtensibleObject, IDirty
    {
        private List<string> _attributes;

        public IList<string> Attributes { get => GetField(ref _attributes); set => SetField(ref _attributes, value?.ToList()); }

        bool IDirty.Dirty { get => true; set { } }
    }
}