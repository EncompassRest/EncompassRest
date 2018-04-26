using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// MilestoneTaskContact
    /// </summary>
    public sealed partial class MilestoneTaskContact : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<string> _address;
        /// <summary>
        /// MilestoneTaskContact Address
        /// </summary>
        public string Address { get => _address; set => _address = value; }
        private DirtyValue<string> _city;
        /// <summary>
        /// MilestoneTaskContact City
        /// </summary>
        public string City { get => _city; set => _city = value; }
        private DirtyValue<string> _contactId;
        /// <summary>
        /// MilestoneTaskContact ContactId
        /// </summary>
        public string ContactId { get => _contactId; set => _contactId = value; }
        private DirtyValue<string> _email;
        /// <summary>
        /// MilestoneTaskContact Email
        /// </summary>
        public string Email { get => _email; set => _email = value; }
        private DirtyValue<string> _guid;
        /// <summary>
        /// MilestoneTaskContact Guid
        /// </summary>
        public string Guid { get => _guid; set => _guid = value; }
        private DirtyValue<string> _id;
        /// <summary>
        /// MilestoneTaskContact Id
        /// </summary>
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<string> _name;
        /// <summary>
        /// MilestoneTaskContact Name
        /// </summary>
        public string Name { get => _name; set => _name = value; }
        private DirtyValue<string> _phone;
        /// <summary>
        /// MilestoneTaskContact Phone
        /// </summary>
        public string Phone { get => _phone; set => _phone = value; }
        private DirtyValue<string> _role;
        /// <summary>
        /// MilestoneTaskContact Role
        /// </summary>
        public string Role { get => _role; set => _role = value; }
        private DirtyValue<string> _state;
        /// <summary>
        /// MilestoneTaskContact State
        /// </summary>
        public string State { get => _state; set => _state = value; }
        private DirtyValue<string> _zip;
        /// <summary>
        /// MilestoneTaskContact Zip
        /// </summary>
        public string Zip { get => _zip; set => _zip = value; }
        internal override bool DirtyInternal
        {
            get => _address.Dirty
                || _city.Dirty
                || _contactId.Dirty
                || _email.Dirty
                || _guid.Dirty
                || _id.Dirty
                || _name.Dirty
                || _phone.Dirty
                || _role.Dirty
                || _state.Dirty
                || _zip.Dirty;
            set
            {
                _address.Dirty = value;
                _city.Dirty = value;
                _contactId.Dirty = value;
                _email.Dirty = value;
                _guid.Dirty = value;
                _id.Dirty = value;
                _name.Dirty = value;
                _phone.Dirty = value;
                _role.Dirty = value;
                _state.Dirty = value;
                _zip.Dirty = value;
            }
        }
    }
}