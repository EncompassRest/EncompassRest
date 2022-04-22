using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Webhook.v1
{
    /// <summary>
    /// WebhookFilters
    /// </summary>
    public sealed class WebhookFilters : ExtensibleObject, IDirty
    {
        private IList<string>? _attributes;

        /// <summary>
        /// List of attribute paths to which to subscribe.
        /// </summary>
        [AllowNull]
        public IList<string> Attributes { get => _attributes ??= new List<string>(); set => _attributes = value; }

        bool IDirty.Dirty { get => true; set { } }
    }
}