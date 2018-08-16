using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// AdditionalStateDisclosure
    /// </summary>
    [Entity(PropertiesToAlwaysSerialize = nameof(DisclosureName) + "," + nameof(StateCode))]
    public sealed partial class AdditionalStateDisclosure : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<StringEnumValue<DisclosureName>> _disclosureName;
        /// <summary>
        /// AdditionalStateDisclosure DisclosureName
        /// </summary>
        public StringEnumValue<DisclosureName> DisclosureName { get => _disclosureName; set => SetField(ref _disclosureName, value); }
        private DirtyValue<string> _disclosureValue;
        /// <summary>
        /// AdditionalStateDisclosure DisclosureValue
        /// </summary>
        public string DisclosureValue { get => _disclosureValue; set => SetField(ref _disclosureValue, value); }
        private DirtyValue<string> _id;
        /// <summary>
        /// AdditionalStateDisclosure Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }
        private DirtyValue<StringEnumValue<State>> _stateCode;
        /// <summary>
        /// AdditionalStateDisclosure StateCode
        /// </summary>
        public StringEnumValue<State> StateCode { get => _stateCode; set => SetField(ref _stateCode, value); }
    }
}