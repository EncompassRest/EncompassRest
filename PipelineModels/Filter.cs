using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncompassREST.PipelineModels
{
    public class Filter
    {
        public Filter()
        {
            terms = new List<PipelineModels.IFilter>();
        }

        public List<IFilter> terms { get; set; }


    }
}
