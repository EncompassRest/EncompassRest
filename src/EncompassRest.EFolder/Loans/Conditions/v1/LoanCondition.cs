using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans.Conditions.v1
{
    /// <summary>
    /// LoanCondition
    /// </summary>
    [Entity(PropertiesToAlwaysSerialize = nameof(ForAllApplications) + "," + nameof(Application))]
    public abstract class LoanCondition : DirtyExtensibleObject, IIdentifiable
    {
        /// <summary>
        /// Unique identifier of a condition.
        /// </summary>
        public string? Id { get => GetValue<string?>(); set => SetValue(value); }

        /// <summary>
        /// The ID of the template used to create the condition.
        /// </summary>
        public string? TemplateId { get => GetValue<string?>(); set => SetValue(value); }

        /// <summary>
        /// Type of a condition.
        /// </summary>
        public StringEnumValue<ConditionType> ConditionType { get => GetValue<StringEnumValue<ConditionType>>(); set => SetValue(value); }

        /// <summary>
        /// Whether the condition's status is Removed.
        /// </summary>
        public bool? IsRemoved { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// Title of the document.
        /// </summary>
        public string? Title { get => GetValue<string?>(); set => SetValue(value); }

        /// <summary>
        /// Description of the document.
        /// </summary>
        public string? Description { get => GetValue<string?>(); set => SetValue(value); }

        /// <summary>
        /// Loan application to which to apply the condition. Required if applying condition to a specific application. If you want to apply the condition to all applications of the loan, set <see cref="ForAllApplications"/> to <c>true</c>.
        /// </summary>
        public EntityReference? Application { get => GetValue<EntityReference?>(); set => SetValue(value); }

        /// <summary>
        /// A value of <c>true</c> indicates the condition will be linked to all applications or only for a specified application. If linked to a specified application, the application ID must be provided.
        /// </summary>
        public bool? ForAllApplications { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// Source of the condition.
        /// </summary>
        public StringEnumValue<ConditionSource> Source { get => GetValue<StringEnumValue<ConditionSource>>(); set => SetValue(value); }

        /// <summary>
        /// Date and time the condition is waiting to be received by.
        /// </summary>
        public DateTime? ExpectedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

        /// <summary>
        /// Indicates the status of the condition.
        /// </summary>
        public StringEnumValue<ConditionStatus> Status { get => GetValue<StringEnumValue<ConditionStatus>>(); set => SetValue(value); }

        /// <summary>
        /// Date and time the condition's status was last changed.
        /// </summary>
        public DateTime? StatusDate { get => GetValue<DateTime?>(); set => SetValue(value); }

        /// <summary>
        /// Number of days for the condition to be received.
        /// </summary>
        public int? DaysToReceive { get => GetValue<int?>(); set => SetValue(value); }

        /// <summary>
        /// User who requested the condition.
        /// </summary>
        public string? RequestedFrom { get => GetValue<string?>(); set => SetValue(value); }

        /// <summary>
        /// Date and time the condition was created.
        /// </summary>
        public DateTime? CreatedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

        /// <summary>
        /// Information about the Encompass user who created the condition.
        /// </summary>
        public EntityReference? CreatedBy { get => GetValue<EntityReference?>(); set => SetValue(value); }

        /// <summary>
        /// Whether the condition's status is Requested.
        /// </summary>
        public bool? IsRequested { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// Date and time the condition was requested.
        /// </summary>
        public DateTime? RequestedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

        /// <summary>
        /// Information about the Encompass user who requested the condition.
        /// </summary>
        public EntityReference? RequestedBy { get => GetValue<EntityReference?>(); set => SetValue(value); }

        /// <summary>
        /// Whether the condition's status is Re-requested.
        /// </summary>
        public bool? IsRerequested { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// Date and time the condition was rerequested.
        /// </summary>
        public DateTime? RerequestedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

        /// <summary>
        /// Information about the Encompass user who re-requested the condition.
        /// </summary>
        public EntityReference? RerequestedBy { get => GetValue<EntityReference?>(); set => SetValue(value); }

        /// <summary>
        /// Whether the condition's status is Received.
        /// </summary>
        public bool? IsReceived { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// Date and time the condition was received.
        /// </summary>
        public DateTime? ReceivedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

        /// <summary>
        /// Information about the Encompass user who received the condition.
        /// </summary>
        public EntityReference? ReceivedBy { get => GetValue<EntityReference?>(); set => SetValue(value); }

        /// <summary>
        /// Whether the condition belongs to a condition set.
        /// </summary>
        public bool? IsAddedToConditionSet { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// Any comments for the condition.
        /// </summary>
        [AllowNull]
        public IList<Comment> Comments { get => GetList<Comment>(); set => SetList(value); }

        /// <summary>
        /// Any supporting documents.
        /// </summary>
        [AllowNull]
        public IList<EntityReference> Documents { get => GetList<EntityReference>(); set => SetList(value); }

        /// <summary>
        /// LoanCondition DescriptionDetails
        /// </summary>
        public string? DescriptionDetails { get => GetValue<string?>(); set => SetValue(value); }

        internal LoanCondition()
        {
        }
    }
}