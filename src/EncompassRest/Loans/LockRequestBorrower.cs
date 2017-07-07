using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

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
                var equifaxScore = _equifaxScore; equifaxScore.Clean = value; _equifaxScore = equifaxScore;
                var experianScore = _experianScore; experianScore.Clean = value; _experianScore = experianScore;
                var firstName = _firstName; firstName.Clean = value; _firstName = firstName;
                var id = _id; id.Clean = value; _id = id;
                var isEmpty = _isEmpty; isEmpty.Clean = value; _isEmpty = isEmpty;
                var lastName = _lastName; lastName.Clean = value; _lastName = lastName;
                var lrbIndex = _lrbIndex; lrbIndex.Clean = value; _lrbIndex = lrbIndex;
                var sSN = _sSN; sSN.Clean = value; _sSN = sSN;
                var transUnionScore = _transUnionScore; transUnionScore.Clean = value; _transUnionScore = transUnionScore;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
        [JsonConstructor]
        public LockRequestBorrower()
        {
            Clean = true;
        }
    }
}