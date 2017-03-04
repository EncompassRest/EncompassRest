using EncompassREST.PipelineModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncompassREST
{
    public class Pipeline
    {
        private Session _session;


        public Session Session
        {
            get { return _session; }
        }

        public Pipeline(Session Session)
        {
            _session = Session;
        }


        public async Task<string> postPipelineQueryAsync(Filter filter,List<SortOrderItem> sortItem,List<string> fields)
        {

            return "";
        }

    }
}
