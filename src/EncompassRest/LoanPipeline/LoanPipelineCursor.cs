using System.Collections.Generic;

namespace EncompassRest.LoanPipeline
{
    /// <summary>
    /// Loan pipeline cursor.
    /// </summary>
    public sealed class LoanPipelineCursor : Cursor<LoanPipelineData>
    {
        internal LoanPipelineCursor(EncompassRestClient client, string cursorId, int count, IEnumerable<string> fields)
            : base(client.Pipeline, client, cursorId, count, fields)
        {
        }
    }
}