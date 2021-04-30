using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using EncompassRest.Company;

namespace EncompassRest.Organizations
{
    /// <summary>
    /// Object containing licensing information for the organization.
    /// </summary>
    /// <remarks>
    /// This licensing information is used when running compliance testing on a loan file.
    /// </remarks>
    public sealed class LicenseInformation : ParentInformation
    {
        private DirtyValue<StringEnumValue<AtrExemptCreditors>>? _atrExemptCreditors;
        private DirtyValue<StringEnumValue<AtrSmallCreditors>>? _atrSmallCreditors;
        private DirtyValue<bool?>? _dontApplyIntRateExportation;
        private DirtyValue<StringEnumValue<State>>? _homeState;
        private DirtyValue<string?>? _lenderType;
        private DirtyValue<StringEnumValue<StatutoryStatusKansasType>>? _statutoryStatusKansasType;
        private DirtyValue<StringEnumValue<StatutoryStatusMarylandType>>? _statutoryStatusMarylandType;
        private DirtyValue<bool?>? _useCustomLenderProfileForECS;
        private DirtyList<StateLicenseExtType>? _stateLicenseExtTypes;

        /// <summary>
        /// Indicates the organization qualifies as an exempt creditor and displays a description.
        /// </summary>
        public StringEnumValue<AtrExemptCreditors> AtrExemptCreditors { get => _atrExemptCreditors; set => SetField(ref _atrExemptCreditors, value); }

        /// <summary>
        /// Indicates whether the organization qualifies as a Small Creditor or Rural Small Creditor.
        /// </summary>
        public StringEnumValue<AtrSmallCreditors> AtrSmallCreditors { get => _atrSmallCreditors; set => SetField(ref _atrSmallCreditors, value); }

        /// <summary>
        /// LicenseInformation DontApplyIntRateExportation
        /// </summary>
        public bool? DontApplyIntRateExportation { get => _dontApplyIntRateExportation; set => SetField(ref _dontApplyIntRateExportation, value); }

        /// <summary>
        /// The home state code where the organization's main (or home) office is located.
        /// </summary>
        public StringEnumValue<State> HomeState { get => _homeState; set => SetField(ref _homeState, value); }

        /// <summary>
        /// The type of licenses used by the organization (or its branches) in one or more states.
        /// </summary>
        public string? LenderType { get => _lenderType; set => SetField(ref _lenderType, value); }

        /// <summary>
        /// If the organization does business in Kansas, this attribute is can be set to NoStatutoryElection or UCCCElectionForAllLoans.
        /// </summary>
        public StringEnumValue<StatutoryStatusKansasType> StatutoryStatusKansasType { get => _statutoryStatusKansasType; set => SetField(ref _statutoryStatusKansasType, value); }

        /// <summary>
        /// If the organization does business in Maryland, this attribute is can be set to NoStatutoryElection or CreditGrantorLawElection.
        /// </summary>
        public StringEnumValue<StatutoryStatusMarylandType> StatutoryStatusMarylandType { get => _statutoryStatusMarylandType; set => SetField(ref _statutoryStatusMarylandType, value); }

        /// <summary>
        /// Whether the organization's theory of lending (including custom rules) is to be applied when running Encompass Compliance Service (ECS) compliance tests on a loan file.
        /// </summary>
        public bool? UseCustomLenderProfileForECS { get => _useCustomLenderProfileForECS; set => SetField(ref _useCustomLenderProfileForECS, value); }

        /// <summary>
        /// Objects containing the licenses that apply to your organization.
        /// </summary>
        [AllowNull]
        public IList<StateLicenseExtType> StateLicenseExtTypes { get => GetField(ref _stateLicenseExtTypes); set => SetField(ref _stateLicenseExtTypes, value); }
    }
}