using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncompassREST.PipelineModels
{
    enum OperatorType
    {
        and,
        or
    }

    enum CanonicalNameValues
    {
        Address1,
        Address2,
        BorrowerName,
        City,
        CurrentMilestoneID,
        DateCompleted,
        DateCreated,
        Guid,
        LoanAmount,
        LoanFolder,
        LastModified,
        LoanName,
        LoanNumber,
        LoanOfficerId,
        LoanProcessorId,
        LoanType,
        NextMilestoneID,
        State,
        TPOLOID,
        TPOLPID,
        Zip
    }
}
