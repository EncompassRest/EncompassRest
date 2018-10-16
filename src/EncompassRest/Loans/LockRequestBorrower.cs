using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// LockRequestBorrower
    /// </summary>
    [Entity(SerializeWholeListWhenDirty = true)]
    public sealed partial class LockRequestBorrower : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<string> _equifaxScore;
        private DirtyValue<string> _experianScore;
        private DirtyValue<string> _firstName;
        private DirtyValue<string> _id;
        private DirtyValue<bool?> _isEmpty;
        private DirtyValue<string> _lastName;
        private DirtyValue<int?> _lrbIndex;
        private DirtyValue<string> _sSN;
        private DirtyValue<string> _transUnionScore;

        /// <summary>
        /// LockRequestBorrower EquifaxScore
        /// </summary>
        public string EquifaxScore { get => _equifaxScore; set => SetField(ref _equifaxScore, value); }

        /// <summary>
        /// LockRequestBorrower ExperianScore
        /// </summary>
        public string ExperianScore { get => _experianScore; set => SetField(ref _experianScore, value); }

        /// <summary>
        /// LockRequestBorrower FirstName
        /// </summary>
        public string FirstName { get => _firstName; set => SetField(ref _firstName, value); }

        /// <summary>
        /// LockRequestBorrower Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }

        /// <summary>
        /// LockRequestBorrower IsEmpty
        /// </summary>
        public bool? IsEmpty { get => _isEmpty; set => SetField(ref _isEmpty, value); }

        /// <summary>
        /// LockRequestBorrower LastName
        /// </summary>
        public string LastName { get => _lastName; set => SetField(ref _lastName, value); }

        /// <summary>
        /// LockRequestBorrower LrbIndex
        /// </summary>
        public int? LrbIndex { get => _lrbIndex; set => SetField(ref _lrbIndex, value); }

        /// <summary>
        /// LockRequestBorrower SSN
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.SSN)]
        public string SSN { get => _sSN; set => SetField(ref _sSN, value); }

        /// <summary>
        /// LockRequestBorrower TransUnionScore
        /// </summary>
        public string TransUnionScore { get => _transUnionScore; set => SetField(ref _transUnionScore, value); }
    }
}