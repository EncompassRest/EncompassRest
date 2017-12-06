#pragma warning disable 1591
using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans
{
    public sealed partial class NewYorkPrimaryLender : ExtensibleObject
    {
        private DirtyValue<string> _address;
        public string Address { get => _address; set => _address = value; }
        private DirtyValue<string> _city;
        public string City { get => _city; set => _city = value; }
        private DirtyValue<string> _comments;
        public string Comments { get => _comments; set => _comments = value; }
        private DirtyValue<string> _id;
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<string> _name;
        public string Name { get => _name; set => _name = value; }
        private DirtyValue<int?> _newYorkPrimaryLenderIndex;
        public int? NewYorkPrimaryLenderIndex { get => _newYorkPrimaryLenderIndex; set => _newYorkPrimaryLenderIndex = value; }
        private DirtyValue<string> _postalCode;
        public string PostalCode { get => _postalCode; set => _postalCode = value; }
        private DirtyValue<string> _state;
        public string State { get => _state; set => _state = value; }
        internal override bool DirtyInternal
        {
            get
            {
                return _address.Dirty
                    || _city.Dirty
                    || _comments.Dirty
                    || _id.Dirty
                    || _name.Dirty
                    || _newYorkPrimaryLenderIndex.Dirty
                    || _postalCode.Dirty
                    || _state.Dirty;
            }
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