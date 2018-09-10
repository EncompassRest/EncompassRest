using System.Collections.Generic;

namespace EncompassRest.Webhook
{
    public sealed class WebhookFilters : DirtyExtensibleObject, IDirty
    {
        private IList<string> _attributes;
        public IList<string> Attributes { get => _attributes ?? (_attributes = new List<string>()); set => SetField(ref _attributes, value); }

        bool IDirty.Dirty { get => true; set { } }
    }
}