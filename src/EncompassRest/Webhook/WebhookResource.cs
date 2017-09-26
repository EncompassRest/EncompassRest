using System;
using System.Collections.Generic;
using System.Text;

namespace EncompassRest.Webhook
{
    public sealed class WebhookResource
    {
        public string Description { get; set; }

        public List<string> Events { get; set; }

        public string Name { get; set; }

        public string Status { get; set; }
    }
}
