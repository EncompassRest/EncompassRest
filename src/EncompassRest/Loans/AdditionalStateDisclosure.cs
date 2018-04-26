using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// AdditionalStateDisclosure
    /// </summary>
    public sealed partial class AdditionalStateDisclosure : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<string> _disclosureName;
        /// <summary>
        /// AdditionalStateDisclosure DisclosureName
        /// </summary>
        public string DisclosureName { get => _disclosureName; set => _disclosureName = value; }
        private DirtyValue<string> _disclosureValue;
        /// <summary>
        /// AdditionalStateDisclosure DisclosureValue
        /// </summary>
        public string DisclosureValue { get => _disclosureValue; set => _disclosureValue = value; }
        private DirtyValue<string> _id;
        /// <summary>
        /// AdditionalStateDisclosure Id
        /// </summary>
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<string> _stateCode;
        /// <summary>
        /// AdditionalStateDisclosure StateCode
        /// </summary>
        public string StateCode { get => _stateCode; set => _stateCode = value; }
        internal override bool DirtyInternal
        {
            get => _disclosureName.Dirty
                || _disclosureValue.Dirty
                || _id.Dirty
                || _stateCode.Dirty;
            set
            {
                _disclosureName.Dirty = value;
                _disclosureValue.Dirty = value;
                _id.Dirty = value;
                _stateCode.Dirty = value;
            }
        }
    }
}