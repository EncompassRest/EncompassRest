using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// LockRequestBorrower
    /// </summary>
    public sealed partial class LockRequestBorrower : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<string> _equifaxScore;
        /// <summary>
        /// LockRequestBorrower EquifaxScore
        /// </summary>
        public string EquifaxScore { get => _equifaxScore; set => _equifaxScore = value; }
        private DirtyValue<string> _experianScore;
        /// <summary>
        /// LockRequestBorrower ExperianScore
        /// </summary>
        public string ExperianScore { get => _experianScore; set => _experianScore = value; }
        private DirtyValue<string> _firstName;
        /// <summary>
        /// LockRequestBorrower FirstName
        /// </summary>
        public string FirstName { get => _firstName; set => _firstName = value; }
        private DirtyValue<string> _id;
        /// <summary>
        /// LockRequestBorrower Id
        /// </summary>
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<bool?> _isEmpty;
        /// <summary>
        /// LockRequestBorrower IsEmpty
        /// </summary>
        public bool? IsEmpty { get => _isEmpty; set => _isEmpty = value; }
        private DirtyValue<string> _lastName;
        /// <summary>
        /// LockRequestBorrower LastName
        /// </summary>
        public string LastName { get => _lastName; set => _lastName = value; }
        private DirtyValue<int?> _lrbIndex;
        /// <summary>
        /// LockRequestBorrower LrbIndex
        /// </summary>
        public int? LrbIndex { get => _lrbIndex; set => _lrbIndex = value; }
        private DirtyValue<string> _sSN;
        /// <summary>
        /// LockRequestBorrower SSN
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.SSN)]
        public string SSN { get => _sSN; set => _sSN = value; }
        private DirtyValue<string> _transUnionScore;
        /// <summary>
        /// LockRequestBorrower TransUnionScore
        /// </summary>
        public string TransUnionScore { get => _transUnionScore; set => _transUnionScore = value; }
    }
}