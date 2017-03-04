using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace EncompassREST.PipelineModels
{
    class FilterBoolean
    {
        public FilterBoolean()
        {
            terms = new List<PipelineModels.IFilter>();
        }

        [JsonProperty(PropertyName = "operator")]
        [JsonConverter(typeof(StringEnumConverter))]
        public OperatorType op { get; set; } //and / or

        public List<IFilter> terms { get; set; }
    }
}
