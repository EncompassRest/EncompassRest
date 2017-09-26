using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class LockRequestBorrower : IDirty
    {
        private Value<string> _equifaxScore;
        public string EquifaxScore { get { return _equifaxScore; } set { _equifaxScore = value; } }
        private Value<string> _experianScore;
        public string ExperianScore { get { return _experianScore; } set { _experianScore = value; } }
        private Value<string> _firstName;
        public string FirstName { get { return _firstName; } set { _firstName = value; } }
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private Value<bool?> _isEmpty;
        public bool? IsEmpty { get { return _isEmpty; } set { _isEmpty = value; } }
        private Value<string> _lastName;
        public string LastName { get { return _lastName; } set { _lastName = value; } }
        private Value<int?> _lrbIndex;
        public int? LrbIndex { get { return _lrbIndex; } set { _lrbIndex = value; } }
        private Value<string> _sSN;
        public string SSN { get { return _sSN; } set { _sSN = value; } }
        private Value<string> _transUnionScore;
        public string TransUnionScore { get { return _transUnionScore; } set { _transUnionScore = value; } }
        private int _gettingDirty;
        private int _settingDirty; 
        internal bool Dirty
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingDirty, 1, 0) != 0) return false;
                var dirty = _equifaxScore.Dirty
                    || _experianScore.Dirty
                    || _firstName.Dirty
                    || _id.Dirty
                    || _isEmpty.Dirty
                    || _lastName.Dirty
                    || _lrbIndex.Dirty
                    || _sSN.Dirty
                    || _transUnionScore.Dirty;
                _gettingDirty = 0;
                return dirty;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingDirty, 1, 0) != 0) return;
                _equifaxScore.Dirty = value;
                _experianScore.Dirty = value;
                _firstName.Dirty = value;
                _id.Dirty = value;
                _isEmpty.Dirty = value;
                _lastName.Dirty = value;
                _lrbIndex.Dirty = value;
                _sSN.Dirty = value;
                _transUnionScore.Dirty = value;
                _settingDirty = 0;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}