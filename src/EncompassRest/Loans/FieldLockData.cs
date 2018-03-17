#pragma warning disable 1591
using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans
{
    public sealed partial class FieldLockData : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<bool?> _lockRemoved;
        public bool? LockRemoved { get => _lockRemoved; set => _lockRemoved = value; }
        internal ModelPath _modelPathInternal;
        internal DirtyValue<string> _modelPath;
        public string ModelPath { get => _modelPath; set { _modelPath = value; _modelPathInternal = EncompassRest.ModelPath.Create(value); } }
        private DirtyValue<string> _value;
        public string Value { get => _value; set => _value = value; }
        internal override bool DirtyInternal
        {
            get
            {
                return _lockRemoved.Dirty
                    || _modelPath.Dirty
                    || _value.Dirty;
            }
            set
            {
                _lockRemoved.Dirty = value;
                _modelPath.Dirty = value;
                _value.Dirty = value;
            }
        }
    }
}