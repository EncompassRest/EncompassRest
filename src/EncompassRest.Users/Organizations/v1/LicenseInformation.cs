using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using EncompassRest.Company.v1;

namespace EncompassRest.Organizations.v1
{
    /// <summary>
    /// Object containing licensing information for the organization.
    /// </summary>
    /// <remarks>
    /// This licensing information is used when running compliance testing on a loan file.
    /// </remarks>
    public sealed class LicenseInformation : ParentInformation
    {
        /// <summary>
        /// Indicates the organization qualifies as an exempt creditor and displays a description.
        /// </summary>
        public StringEnumValue<AtrExemptCreditors> AtrExemptCreditors { get => GetValue<StringEnumValue<AtrExemptCreditors>>(); set => SetValue(value); }

        /// <summary>
        /// Indicates whether the organization qualifies as a Small Creditor or Rural Small Creditor.
        /// </summary>
        public StringEnumValue<AtrSmallCreditors> AtrSmallCreditors { get => GetValue<StringEnumValue<AtrSmallCreditors>>(); set => SetValue(value); }

        /// <summary>
        /// LicenseInformation DontApplyIntRateExportation
        /// </summary>
        public bool? DontApplyIntRateExportation { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// The home state code where the organization's main (or home) office is located.
        /// </summary>
        public StringEnumValue<State> HomeState { get => GetValue<StringEnumValue<State>>(); set => SetValue(value); }

        /// <summary>
        /// The type of licenses used by the organization (or its branches) in one or more states.
        /// </summary>
        public string? LenderType { get => GetValue<string?>(); set => SetValue(value); }

        /// <summary>
        /// If the organization does business in Kansas, this attribute is can be set to NoStatutoryElection or UCCCElectionForAllLoans.
        /// </summary>
        public StringEnumValue<StatutoryStatusKansasType> StatutoryStatusKansasType { get => GetValue<StringEnumValue<StatutoryStatusKansasType>>(); set => SetValue(value); }

        /// <summary>
        /// If the organization does business in Maryland, this attribute is can be set to NoStatutoryElection or CreditGrantorLawElection.
        /// </summary>
        public StringEnumValue<StatutoryStatusMarylandType> StatutoryStatusMarylandType { get => GetValue<StringEnumValue<StatutoryStatusMarylandType>>(); set => SetValue(value); }

        /// <summary>
        /// Whether the organization's theory of lending (including custom rules) is to be applied when running Encompass Compliance Service (ECS) compliance tests on a loan file.
        /// </summary>
        public bool? UseCustomLenderProfileForECS { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// Objects containing the licenses that apply to your organization.
        /// </summary>
        [AllowNull]
        public IList<StateLicenseExtType> StateLicenseExtTypes { get => GetList<StateLicenseExtType>(); set => SetList(value); }
    }
}