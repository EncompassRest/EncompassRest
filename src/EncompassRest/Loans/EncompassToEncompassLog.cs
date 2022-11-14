using System;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// EncompassToEncompassLog
    /// </summary>
    [Entity(SerializeWholeListWhenDirty = true)]
    public sealed partial class EncompassToEncompassLog : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<string?>? _ecReceivedFrom;
        private DirtyValue<string?>? _ecStatus;
        private DirtyValue<DateTime?>? _ecStatusUpdateDate;
        private DirtyValue<string?>? _ecSubmissionType;
        private DirtyValue<string?>? _id;

        /// <summary>
        /// Investor Connect EC Received From [INVESTORECNN01]
        /// </summary>
        public string? EcReceivedFrom { get => _ecReceivedFrom; set => SetField(ref _ecReceivedFrom, value); }

        /// <summary>
        /// Investor Connect EC Status [INVESTORECNN02]
        /// </summary>
        public string? EcStatus { get => _ecStatus; set => SetField(ref _ecStatus, value); }

        /// <summary>
        /// Investor Connect EC Status Update Date [INVESTORECNN03]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? EcStatusUpdateDate { get => _ecStatusUpdateDate; set => SetField(ref _ecStatusUpdateDate, value); }

        /// <summary>
        /// Investor Connect EC Submission Type [INVESTORECNN04]
        /// </summary>
        public string? EcSubmissionType { get => _ecSubmissionType; set => SetField(ref _ecSubmissionType, value); }

        /// <summary>
        /// EncompassToEncompassLog Id
        /// </summary>
        public string? Id { get => _id; set => SetField(ref _id, value); }
    }
}