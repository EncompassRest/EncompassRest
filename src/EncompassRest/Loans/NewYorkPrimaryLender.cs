using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// NewYorkPrimaryLender
    /// </summary>
    public sealed partial class NewYorkPrimaryLender : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<string> _address;
        /// <summary>
        /// NewYorkPrimaryLender Address
        /// </summary>
        public string Address { get => _address; set => _address = value; }
        private DirtyValue<string> _city;
        /// <summary>
        /// NewYorkPrimaryLender City
        /// </summary>
        public string City { get => _city; set => _city = value; }
        private DirtyValue<string> _comments;
        /// <summary>
        /// NewYorkPrimaryLender Comments
        /// </summary>
        public string Comments { get => _comments; set => _comments = value; }
        private DirtyValue<string> _id;
        /// <summary>
        /// NewYorkPrimaryLender Id
        /// </summary>
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<string> _name;
        /// <summary>
        /// NewYorkPrimaryLender Name
        /// </summary>
        public string Name { get => _name; set => _name = value; }
        private DirtyValue<int?> _newYorkPrimaryLenderIndex;
        /// <summary>
        /// NewYorkPrimaryLender NewYorkPrimaryLenderIndex
        /// </summary>
        public int? NewYorkPrimaryLenderIndex { get => _newYorkPrimaryLenderIndex; set => _newYorkPrimaryLenderIndex = value; }
        private DirtyValue<string> _postalCode;
        /// <summary>
        /// NewYorkPrimaryLender PostalCode
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
        public string PostalCode { get => _postalCode; set => _postalCode = value; }
        private DirtyValue<string> _state;
        /// <summary>
        /// NewYorkPrimaryLender State
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.STATE)]
        public string State { get => _state; set => _state = value; }
        internal override bool DirtyInternal
        {
            get => _address.Dirty
                || _city.Dirty
                || _comments.Dirty
                || _id.Dirty
                || _name.Dirty
                || _newYorkPrimaryLenderIndex.Dirty
                || _postalCode.Dirty
                || _state.Dirty;
            set
            {
                _address.Dirty = value;
                _city.Dirty = value;
                _comments.Dirty = value;
                _id.Dirty = value;
                _name.Dirty = value;
                _newYorkPrimaryLenderIndex.Dirty = value;
                _postalCode.Dirty = value;
                _state.Dirty = value;
            }
        }
    }
}