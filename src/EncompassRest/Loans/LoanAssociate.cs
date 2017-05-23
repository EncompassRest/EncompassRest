using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed partial class LoanAssociate
    {
        public string CellPhone { get; set; }
        public string Email { get; set; }
        public string Fax { get; set; }
        public string Id { get; set; }
        public string IdString { get; set; }
        public string LoanAssociateType { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public int? RoleId { get; set; }
        public string RoleName { get; set; }
        public string WriteAccess { get; set; }
    }
}