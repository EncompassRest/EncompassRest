using System;
using EncompassApi.Schema;

namespace EncompassApi.Loans
{
    /// <summary>
    /// EarlyCheck
    /// </summary>
    [Entity(SerializeWholeListWhenDirty = true)]
    public sealed partial class EarlyCheck : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<decimal?>? _ecAppraisalValue;
        private DirtyValue<string?>? _ecDocumentFileId;
        private DirtyValue<DateTime?>? _ecUcdpLastSubmissionDateTimeEarly;
        private DirtyValue<string?>? _id;

        /// <summary>
        /// Early Check Appraisal Value [ECNN02]
        /// </summary>
        public decimal? EcAppraisalValue { get => _ecAppraisalValue; set => SetField(ref _ecAppraisalValue, value); }

        /// <summary>
        /// Early Check Document File Id [ECNN03]
        /// </summary>
        public string? EcDocumentFileId { get => _ecDocumentFileId; set => SetField(ref _ecDocumentFileId, value); }

        /// <summary>
        /// Early Check UCDP Last Submission Date Time Early [ECNN01]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? EcUcdpLastSubmissionDateTimeEarly { get => _ecUcdpLastSubmissionDateTimeEarly; set => SetField(ref _ecUcdpLastSubmissionDateTimeEarly, value); }

        /// <summary>
        /// EarlyCheck Id
        /// </summary>
        public string? Id { get => _id; set => SetField(ref _id, value); }
    }
}