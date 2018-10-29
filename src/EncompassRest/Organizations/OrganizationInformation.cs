using System.Collections.Generic;
using EncompassRest.Company;

namespace EncompassRest.Organizations
{
    /// <summary>
    /// OrganizationInformation
    /// </summary>
    public sealed class OrganizationInformation : ParentInformation
    {
        private Address _address;
        private DirtyValue<string> _phone;
        private DirtyValue<string> _fax;
        private DirtyValue<string> _email;
        private DirtyValue<string> _orgCode;
        private DirtyList<string> _dba;
        private DirtyValue<string> _name;

        /// <summary>
        /// Object containing the organization's address information.
        /// </summary>
        public Address Address { get => GetField(ref _address); set => SetField(ref _address, value); }

        /// <summary>
        /// The organization's phone number.
        /// </summary>
        public string Phone { get => _phone; set => SetField(ref _phone, value); }

        /// <summary>
        /// The organization's fax number.
        /// </summary>
        public string Fax { get => _fax; set => SetField(ref _fax, value); }

        /// <summary>
        /// The contact email for the organization.
        /// </summary>
        public string Email { get => _email; set => SetField(ref _email, value); }

        /// <summary>
        /// The alpha-numeric value used by the Auto Loan Numbering feature. The code displays at the beginning of the loan number when a loan is started by a user who is a member of the organization.
        /// </summary>
        public string OrgCode { get => _orgCode; set => SetField(ref _orgCode, value); }

        /// <summary>
        /// Contains DBA list (string) that states the name under which the organization does business (Doing Business As).
        /// </summary>
        public IList<string> Dba { get => GetField(ref _dba); set => SetField(ref _dba, value); }

        /// <summary>
        /// OrganizationInformation Name
        /// </summary>
        public string Name { get => _name; set => SetField(ref _name, value); }
    }
}