using System.Diagnostics.CodeAnalysis;

namespace EncompassApi.Company.Users.Rights
{
    /// <summary>
    /// ReportsRights
    /// </summary>
    public sealed class ReportsRights : DirtyExtensibleObject
    {
        private DirtyValue<bool?>? _borrowerContactReports;
        private DirtyValue<bool?>? _businessContactReports;
        private DirtyValue<bool?>? _dynamicReporting;
        private LoanReportsRights? _loanReports;
        private DirtyValue<bool?>? _managePersonalReports;
        private DirtyValue<bool?>? _tPOSettingsReports;
        private DirtyValue<bool?>? _tradeReports;

        /// <summary>
        /// ReportsRights BorrowerContactReports
        /// </summary>
        public bool? BorrowerContactReports { get => _borrowerContactReports; set => SetField(ref _borrowerContactReports, value); }

        /// <summary>
        /// ReportsRights BusinessContactReports
        /// </summary>
        public bool? BusinessContactReports { get => _businessContactReports; set => SetField(ref _businessContactReports, value); }

        /// <summary>
        /// ReportsRights DynamicReporting
        /// </summary>
        public bool? DynamicReporting { get => _dynamicReporting; set => SetField(ref _dynamicReporting, value); }

        /// <summary>
        /// ReportsRights LoanReports
        /// </summary>
        [AllowNull]
        public LoanReportsRights LoanReports { get => GetField(ref _loanReports); set => SetField(ref _loanReports, value); }

        /// <summary>
        /// ReportsRights ManagePersonalReports
        /// </summary>
        public bool? ManagePersonalReports { get => _managePersonalReports; set => SetField(ref _managePersonalReports, value); }

        /// <summary>
        /// ReportsRights TPOSettingsReports
        /// </summary>
        public bool? TPOSettingsReports { get => _tPOSettingsReports; set => SetField(ref _tPOSettingsReports, value); }

        /// <summary>
        /// ReportsRights TradeReports
        /// </summary>
        public bool? TradeReports { get => _tradeReports; set => SetField(ref _tradeReports, value); }
    }
}