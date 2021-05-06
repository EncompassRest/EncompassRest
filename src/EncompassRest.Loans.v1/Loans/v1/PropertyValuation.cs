using System;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v1
{
    /// <summary>
    /// PropertyValuation
    /// </summary>
    [Entity(SerializeWholeListWhenDirty = true)]
    public sealed partial class PropertyValuation : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<string?>? _avmComplexityScore;
        private DirtyValue<string?>? _avmConfidenceScore;
        private DirtyValue<string?>? _avmConfidenceScoreAlt;
        private DirtyValue<string?>? _avmFsd;
        private DirtyValue<string?>? _avmProduct;
        private DirtyValue<string?>? _avmPropertyId;
        private DirtyValue<string?>? _avmPropertyValue;
        private DirtyValue<string?>? _avmProvider;
        private DirtyValue<string?>? _avmRangeHigh;
        private DirtyValue<string?>? _avmRangeLow;
        private DirtyValue<DateTime?>? _avmReportCompleteDate;
        private DirtyValue<string?>? _avmReportId;
        private DirtyValue<DateTime?>? _avmReportOrderedDate;
        private DirtyValue<DateTime?>? _avmRetroDate;
        private DirtyValue<string?>? _correspondentStatus;
        private DirtyValue<bool?>? _entityDeleted;
        private DirtyValue<string?>? _id;
        private DirtyValue<string?>? _orderType;
        private DirtyValue<string?>? _propertyValuationType;

        /// <summary>
        /// AVM Complexity Score [PVALNN09]
        /// </summary>
        public string? AvmComplexityScore { get => _avmComplexityScore; set => SetField(ref _avmComplexityScore, value); }

        /// <summary>
        /// AVM Confidence Score [PVALNN04]
        /// </summary>
        public string? AvmConfidenceScore { get => _avmConfidenceScore; set => SetField(ref _avmConfidenceScore, value); }

        /// <summary>
        /// AVM Confidence Score Alt [PVALNN05]
        /// </summary>
        public string? AvmConfidenceScoreAlt { get => _avmConfidenceScoreAlt; set => SetField(ref _avmConfidenceScoreAlt, value); }

        /// <summary>
        /// AVM FSD [PVALNN10]
        /// </summary>
        public string? AvmFsd { get => _avmFsd; set => SetField(ref _avmFsd, value); }

        /// <summary>
        /// AVM Product [PVALNN03]
        /// </summary>
        public string? AvmProduct { get => _avmProduct; set => SetField(ref _avmProduct, value); }

        /// <summary>
        /// AVM Property ID [PVALNN02]
        /// </summary>
        public string? AvmPropertyId { get => _avmPropertyId; set => SetField(ref _avmPropertyId, value); }

        /// <summary>
        /// AVM Property Value [PVALNN01]
        /// </summary>
        public string? AvmPropertyValue { get => _avmPropertyValue; set => SetField(ref _avmPropertyValue, value); }

        /// <summary>
        /// AVM Provider [PVALNN14]
        /// </summary>
        public string? AvmProvider { get => _avmProvider; set => SetField(ref _avmProvider, value); }

        /// <summary>
        /// AVM Range High [PVALNN07]
        /// </summary>
        public string? AvmRangeHigh { get => _avmRangeHigh; set => SetField(ref _avmRangeHigh, value); }

        /// <summary>
        /// AVM Range Low [PVALNN06]
        /// </summary>
        public string? AvmRangeLow { get => _avmRangeLow; set => SetField(ref _avmRangeLow, value); }

        /// <summary>
        /// AVM Report Complete Date/Time [PVALNN12]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? AvmReportCompleteDate { get => _avmReportCompleteDate; set => SetField(ref _avmReportCompleteDate, value); }

        /// <summary>
        /// AVM Report ID [PVALNN11]
        /// </summary>
        public string? AvmReportId { get => _avmReportId; set => SetField(ref _avmReportId, value); }

        /// <summary>
        /// AVM Report Ordered Date/Time [PVALNN13]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? AvmReportOrderedDate { get => _avmReportOrderedDate; set => SetField(ref _avmReportOrderedDate, value); }

        /// <summary>
        /// AVM Retro Date [PVALNN08]
        /// </summary>
        public DateTime? AvmRetroDate { get => _avmRetroDate; set => SetField(ref _avmRetroDate, value); }

        /// <summary>
        /// PropertyValuation CorrespondentStatus
        /// </summary>
        public string? CorrespondentStatus { get => _correspondentStatus; set => SetField(ref _correspondentStatus, value); }

        /// <summary>
        /// PropertyValuation EntityDeleted
        /// </summary>
        public bool? EntityDeleted { get => _entityDeleted; set => SetField(ref _entityDeleted, value); }

        /// <summary>
        /// PropertyValuation Id
        /// </summary>
        public string? Id { get => _id; set => SetField(ref _id, value); }

        /// <summary>
        /// Property Valuation Order Type [PVALNN16]
        /// </summary>
        public string? OrderType { get => _orderType; set => SetField(ref _orderType, value); }

        /// <summary>
        /// Property Valuation Type [PVALNN15]
        /// </summary>
        public string? PropertyValuationType { get => _propertyValuationType; set => SetField(ref _propertyValuationType, value); }
    }
}