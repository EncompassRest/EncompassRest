using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// PersonalTemplatesRights
    /// </summary>
    public sealed class PersonalTemplatesRights : ParentAccessRights
    {
        /// <summary>
        /// PersonalTemplatesRights AffiliatedBusinessArrangementTemplates
        /// </summary>
        public bool? AffiliatedBusinessArrangementTemplates { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// PersonalTemplatesRights ClosingCosts
        /// </summary>
        public bool? ClosingCosts { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// PersonalTemplatesRights CustomPrintForms
        /// </summary>
        public bool? CustomPrintForms { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// PersonalTemplatesRights DataTemplates
        /// </summary>
        public bool? DataTemplates { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// PersonalTemplatesRights DocumentSets
        /// </summary>
        public bool? DocumentSets { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// PersonalTemplatesRights InputFormSets
        /// </summary>
        public bool? InputFormSets { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// PersonalTemplatesRights LoanPrograms
        /// </summary>
        [AllowNull]
        public LoanProgramsRights LoanPrograms { get => GetEntity<LoanProgramsRights>(); set => SetEntity(value); }

        /// <summary>
        /// PersonalTemplatesRights LoanTemplateSets
        /// </summary>
        public bool? LoanTemplateSets { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// PersonalTemplatesRights PrintFormGroups
        /// </summary>
        public bool? PrintFormGroups { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// PersonalTemplatesRights SettlementServiceProviders
        /// </summary>
        public bool? SettlementServiceProviders { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// PersonalTemplatesRights TaskSets
        /// </summary>
        public bool? TaskSets { get => GetValue<bool?>(); set => SetValue(value); }
    }
}