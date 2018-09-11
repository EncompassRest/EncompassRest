using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// NewYorkPrimaryLender
    /// </summary>
    [Entity(PropertiesToAlwaysSerialize = nameof(NewYorkPrimaryLenderIndex))]
    public sealed partial class NewYorkPrimaryLender : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<string> _address;
        /// <summary>
        /// NewYorkPrimaryLender Address
        /// </summary>
        public string Address { get => _address; set => SetField(ref _address, value); }
        private DirtyValue<string> _city;
        /// <summary>
        /// NewYorkPrimaryLender City
        /// </summary>
        public string City { get => _city; set => SetField(ref _city, value); }
        private DirtyValue<string> _comments;
        /// <summary>
        /// NewYorkPrimaryLender Comments
        /// </summary>
        public string Comments { get => _comments; set => SetField(ref _comments, value); }
        private DirtyValue<string> _id;
        /// <summary>
        /// NewYorkPrimaryLender Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }
        private DirtyValue<string> _name;
        /// <summary>
        /// NewYorkPrimaryLender Name
        /// </summary>
        public string Name { get => _name; set => SetField(ref _name, value); }
        private DirtyValue<int?> _newYorkPrimaryLenderIndex;
        /// <summary>
        /// NewYorkPrimaryLender NewYorkPrimaryLenderIndex
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"1\":\"1\",\"2\":\"2\",\"3\":\"3\"}")]
        public int? NewYorkPrimaryLenderIndex { get => _newYorkPrimaryLenderIndex; set => SetField(ref _newYorkPrimaryLenderIndex, value); }
        private DirtyValue<string> _postalCode;
        /// <summary>
        /// NewYorkPrimaryLender PostalCode
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
        public string PostalCode { get => _postalCode; set => SetField(ref _postalCode, value); }
        private DirtyValue<StringEnumValue<State>> _state;
        /// <summary>
        /// NewYorkPrimaryLender State
        /// </summary>
        public StringEnumValue<State> State { get => _state; set => SetField(ref _state, value); }
    }
}