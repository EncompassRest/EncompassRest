using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncompassRest.PipelineModels
{
    public class FilterTerm : IFilter
    {
        [JsonIgnore]
        private CanonicalNameValues cName;


        public string canonicalName
        {
            get { return "Loan." + cName.ToString(); }
            set
            {
                string s = value.Replace("Loan.", "");
                cName = (CanonicalNameValues)Enum.Parse(typeof(CanonicalNameValues), s);
            }
        }
        public object value { get; set; }
        public string matchType { get; set; }
    }
}
