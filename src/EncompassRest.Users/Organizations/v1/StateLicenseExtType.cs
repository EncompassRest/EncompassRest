using System;
using Newtonsoft.Json;

namespace EncompassRest.Organizations.v1
{
    /// <summary>
    /// Object containing the licenses that apply to your organization.
    /// </summary>
    public sealed class StateLicenseExtType : DirtyExtensibleObject
    {
        /// <summary>
        /// The State code for which the license applies.
        /// </summary>
        [JsonProperty("stateAbbrevation")]
        public StringEnumValue<State> StateAbbreviation { get => GetValue<StringEnumValue<State>>(); set => SetValue(value); }

        /// <summary>
        /// The type of license.
        /// </summary>
        public string? LicenseType { get => GetValue<string?>(); set => SetValue(value); }

        /// <summary>
        /// Indicates whether the state license is exempt.
        /// </summary>
        /// <remarks>
        /// When a license is exempt, the Encompass Compliance Service does not apply any license or compliance rules associated with that license in the property state.
        /// </remarks>
        public bool? IsExempted { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// The license number.
        /// </summary>
        public string? LicenseNo { get => GetValue<string?>(); set => SetValue(value); }

        /// <summary>
        /// The date the license is issued to the loan officer.
        /// </summary>
        public DateTime? IssueDate { get => GetValue<DateTime?>(); set => SetValue(value); }

        /// <summary>
        /// The Start Date is the date that the loan officer’s license becomes associated with the company and they can start taking loan applications on behalf of the company. In most states this is referred to as the Sponsorship Date (not required in all states).
        /// </summary>
        public DateTime? StartDate { get => GetValue<DateTime?>(); set => SetValue(value); }

        /// <summary>
        /// The expiration date of the license, type the expiration date.
        /// </summary>
        /// <remarks>
        /// When a state license expires, loan team members will not be able to assign loans in that state to the loan officer.If a loan has already been assigned to the loan officer and their license subsequently expires (or if the loan officer tries to originate a new loan after their license expires) they will not be able to enter the Subject Property State in the loan file.If the End Date field is left blank, Encompass assumes the license never expires.
        /// </remarks>
        public DateTime? EndDate { get => GetValue<DateTime?>(); set => SetValue(value); }

        /// <summary>
        /// The status of the license.
        /// </summary>
        public StringEnumValue<LicenseStatus> LicenseStatus { get => GetValue<StringEnumValue<LicenseStatus>>(); set => SetValue(value); }

        /// <summary>
        /// The date that the status is in effect.
        /// </summary>
        public DateTime? StatusDate { get => GetValue<DateTime?>(); set => SetValue(value); }

        /// <summary>
        /// Indicates whether the license is approved.
        /// </summary>
        public bool? IsApproved { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// The date that the license was last checked.
        /// </summary>
        public DateTime? LastChecked { get => GetValue<DateTime?>(); set => SetValue(value); }

        /// <summary>
        /// Indicates whether the license is selected for this organization.
        /// </summary>
        public bool? IsSelected { get => GetValue<bool?>(); set => SetValue(value); }
    }
}