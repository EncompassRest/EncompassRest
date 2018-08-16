using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// LockRequestBorrower
    /// </summary>
    [Entity(SerializeWholeListWhenDirty = true)]
    public sealed partial class LockRequestBorrower : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<string> _equifaxScore;
        /// <summary>
        /// LockRequestBorrower EquifaxScore
        /// </summary>
        public string EquifaxScore { get => _equifaxScore; set => SetField(ref _equifaxScore, value); }
        private DirtyValue<string> _experianScore;
        /// <summary>
        /// LockRequestBorrower ExperianScore
        /// </summary>
        public string ExperianScore { get => _experianScore; set => SetField(ref _experianScore, value); }
        private DirtyValue<string> _firstName;
        /// <summary>
        /// LockRequestBorrower FirstName
        /// </summary>
        public string FirstName { get => _firstName; set => SetField(ref _firstName, value); }
        private DirtyValue<string> _id;
        /// <summary>
        /// LockRequestBorrower Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }
        private DirtyValue<bool?> _isEmpty;
        /// <summary>
        /// LockRequestBorrower IsEmpty
        /// </summary>
        public bool? IsEmpty { get => _isEmpty; set => SetField(ref _isEmpty, value); }
        private DirtyValue<string> _lastName;
        /// <summary>
        /// LockRequestBorrower LastName
        /// </summary>
        public string LastName { get => _lastName; set => SetField(ref _lastName, value); }
        private DirtyValue<int?> _lrbIndex;
        /// <summary>
        /// LockRequestBorrower LrbIndex
        /// </summary>
        public int? LrbIndex { get => _lrbIndex; set => SetField(ref _lrbIndex, value); }
        private DirtyValue<string> _sSN;
        /// <summary>
        /// LockRequestBorrower SSN
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.SSN)]
        public string SSN { get => _sSN; set => SetField(ref _sSN, value); }
        private DirtyValue<string> _transUnionScore;
        /// <summary>
        /// LockRequestBorrower TransUnionScore
        /// </summary>
        public string TransUnionScore { get => _transUnionScore; set => SetField(ref _transUnionScore, value); }
    }
}