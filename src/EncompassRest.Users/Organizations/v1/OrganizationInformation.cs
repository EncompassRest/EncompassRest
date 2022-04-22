using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using EncompassRest.Company.v1;

namespace EncompassRest.Organizations.v1
{
    /// <summary>
    /// OrganizationInformation
    /// </summary>
    public sealed class OrganizationInformation : ParentInformation
    {
        /// <summary>
        /// Object containing the organization's address information.
        /// </summary>
        [AllowNull]
        public Address Address { get => GetEntity<Address>(); set => SetEntity(value); }

        /// <summary>
        /// The organization's phone number.
        /// </summary>
        public string? Phone { get => GetValue<string?>(); set => SetValue(value); }

        /// <summary>
        /// The organization's fax number.
        /// </summary>
        public string? Fax { get => GetValue<string?>(); set => SetValue(value); }

        /// <summary>
        /// The contact email for the organization.
        /// </summary>
        public string? Email { get => GetValue<string?>(); set => SetValue(value); }

        /// <summary>
        /// The alpha-numeric value used by the Auto Loan Numbering feature. The code displays at the beginning of the loan number when a loan is started by a user who is a member of the organization.
        /// </summary>
        public string? OrgCode { get => GetValue<string?>(); set => SetValue(value); }

        /// <summary>
        /// Contains DBA list (string) that states the name under which the organization does business (Doing Business As).
        /// </summary>
        [AllowNull]
        public IList<string> Dba { get => GetList<string>(); set => SetList(value); }

        /// <summary>
        /// OrganizationInformation Name
        /// </summary>
        public string? Name { get => GetValue<string?>(); set => SetValue(value); }
    }
}