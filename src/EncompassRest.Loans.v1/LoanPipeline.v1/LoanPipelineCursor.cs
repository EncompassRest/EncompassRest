using System.Collections.Generic;

namespace EncompassRest.LoanPipeline.v1
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
        internal LoanPipelineCursor(PipelineV1 pipelineV1, string? cursorId, int count, IEnumerable<string>? fields)
            : base(pipelineV1, pipelineV1.Client, cursorId, count, fields)
        {
        }
    }
}