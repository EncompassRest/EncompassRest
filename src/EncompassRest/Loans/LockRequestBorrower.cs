using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans
{
    public sealed partial class LockRequestBorrower : ExtensibleObject
    {
        private DirtyValue<string> _equifaxScore;
        public string EquifaxScore { get => _equifaxScore; set => _equifaxScore = value; }
        private DirtyValue<string> _experianScore;
        public string ExperianScore { get => _experianScore; set => _experianScore = value; }
        private DirtyValue<string> _firstName;
        public string FirstName { get => _firstName; set => _firstName = value; }
        private DirtyValue<string> _id;
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<bool?> _isEmpty;
        public bool? IsEmpty { get => _isEmpty; set => _isEmpty = value; }
        private DirtyValue<string> _lastName;
        public string LastName { get => _lastName; set => _lastName = value; }
        private DirtyValue<int?> _lrbIndex;
        public int? LrbIndex { get => _lrbIndex; set => _lrbIndex = value; }
        private DirtyValue<string> _sSN;
        public string SSN { get => _sSN; set => _sSN = value; }
        private DirtyValue<string> _transUnionScore;
        public string TransUnionScore { get => _transUnionScore; set => _transUnionScore = value; }
        internal override bool DirtyInternal
        {
            get
            {
                return _equifaxScore.Dirty
                    || _experianScore.Dirty
                    || _firstName.Dirty
                    || _id.Dirty
                    || _isEmpty.Dirty
                    || _lastName.Dirty
                    || _lrbIndex.Dirty
                    || _sSN.Dirty
                    || _transUnionScore.Dirty;
            }
            set
            {
                _equifaxScore.Dirty = value;
                _experianScore.Dirty = value;
                _firstName.Dirty = value;
                _id.Dirty = value;
                _isEmpty.Dirty = value;
                _lastName.Dirty = value;
                _lrbIndex.Dirty = value;
                _sSN.Dirty = value;
                _transUnionScore.Dirty = value;
            }
        }
    }
}