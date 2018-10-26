using System.Collections.Generic;

namespace EncompassRest.Organizations
{
    public sealed class OrganizationInformation : ParentInformation
    {
        private Address _address;
        private DirtyList<string> _dba;
        private DirtyValue<string> _email;
        private DirtyValue<string> _fax;
        private DirtyValue<string> _name;
        private DirtyValue<string> _orgCode;
        private DirtyValue<string> _phone;

        public Address Address { get => GetField(ref _address); set => SetField(ref _address, value); }

        public IList<string> Dba { get => GetField(ref _dba); set => SetField(ref _dba, value); }

        public string Email { get => _email; set => SetField(ref _email, value); }

        public string Fax { get => _fax; set => SetField(ref _fax, value); }

        public string Name { get => _name; set => SetField(ref _name, value); }

        public string OrgCode { get => _orgCode; set => SetField(ref _orgCode, value); }

        public string Phone { get => _phone; set => SetField(ref _phone, value); }
    }
}