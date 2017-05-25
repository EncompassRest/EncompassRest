using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class LockRequestBorrower : IClean
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
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = _equifaxScore.Clean
                    && _experianScore.Clean
                    && _firstName.Clean
                    && _id.Clean
                    && _isEmpty.Clean
                    && _lastName.Clean
                    && _lrbIndex.Clean
                    && _sSN.Clean
                    && _transUnionScore.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = _equifaxScore; v0.Clean = value; _equifaxScore = v0;
                var v1 = _experianScore; v1.Clean = value; _experianScore = v1;
                var v2 = _firstName; v2.Clean = value; _firstName = v2;
                var v3 = _id; v3.Clean = value; _id = v3;
                var v4 = _isEmpty; v4.Clean = value; _isEmpty = v4;
                var v5 = _lastName; v5.Clean = value; _lastName = v5;
                var v6 = _lrbIndex; v6.Clean = value; _lrbIndex = v6;
                var v7 = _sSN; v7.Clean = value; _sSN = v7;
                var v8 = _transUnionScore; v8.Clean = value; _transUnionScore = v8;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
    }
}