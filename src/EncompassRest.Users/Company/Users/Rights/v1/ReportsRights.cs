using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// ReportsRights
    /// </summary>
    public sealed class ReportsRights : DirtyExtensibleObject
    {
        /// <summary>
        /// ReportsRights BorrowerContactReports
        /// </summary>
        public bool? BorrowerContactReports { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// ReportsRights BusinessContactReports
        /// </summary>
        public bool? BusinessContactReports { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// ReportsRights DynamicReporting
        /// </summary>
        public bool? DynamicReporting { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// ReportsRights LoanReports
        /// </summary>
        [AllowNull]
        public LoanReportsRights LoanReports { get => GetEntity<LoanReportsRights>(); set => SetEntity(value); }

        /// <summary>
        /// ReportsRights ManagePersonalReports
        /// </summary>
        public bool? ManagePersonalReports { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// ReportsRights TPOSettingsReports
        /// </summary>
        public bool? TPOSettingsReports { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// ReportsRights TradeReports
        /// </summary>
        public bool? TradeReports { get => GetValue<bool?>(); set => SetValue(value); }
    }
}