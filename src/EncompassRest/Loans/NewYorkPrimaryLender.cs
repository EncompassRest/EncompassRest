using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed partial class NewYorkPrimaryLender
    {
        public string Address { get; set; }
        public string City { get; set; }
        public string Comments { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
        public int? NewYorkPrimaryLenderIndex { get; set; }
        public string PostalCode { get; set; }
        public string State { get; set; }
    }
}