using System.Collections.Generic;

namespace EncompassApi.LoanPipeline
{
    /// <summary>
    /// Loan pipeline cursor.
    /// </summary>
    public interface ILoanPipelineCursor : ICursor<LoanPipelineData>
    {
    }

    /// <summary>
    /// Loan pipeline cursor.
    /// </summary>
    public sealed class LoanPipelineCursor : Cursor<LoanPipelineData>, ILoanPipelineCursor
    {
        internal LoanPipelineCursor(IEncompassApiClient client, string? cursorId, int count, IEnumerable<string>? fields)
            : base((ApiObject)client.Pipeline, client, cursorId, count, fields)
        {
        }
    }
}