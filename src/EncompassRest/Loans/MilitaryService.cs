using System;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// MilitaryService
    /// </summary>
    [Entity(PropertiesToAlwaysSerialize = nameof(MilitaryServiceIndex))]
    public sealed partial class MilitaryService : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<string> _branch;
        private DirtyValue<DateTime?> _endDate;
        private DirtyValue<string> _id;
        private DirtyValue<int?> _militaryServiceIndex;
        private DirtyValue<string> _name;
        private DirtyValue<StringEnumValue<OfficerOrEnlisted>> _officerOrEnlisted;
        private DirtyValue<string> _serviceNumber;
        private DirtyValue<string> _sSN;
        private DirtyValue<DateTime?> _startDate;

        /// <summary>
        /// MilitaryService Branch
        /// </summary>
        public string Branch { get => _branch; set => SetField(ref _branch, value); }

        /// <summary>
        /// MilitaryService EndDate
        /// </summary>
        public DateTime? EndDate { get => _endDate; set => SetField(ref _endDate, value); }

        /// <summary>
        /// MilitaryService Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }

        /// <summary>
        /// MilitaryService MilitaryServiceIndex
        /// </summary>
        public int? MilitaryServiceIndex { get => _militaryServiceIndex; set => SetField(ref _militaryServiceIndex, value); }

        /// <summary>
        /// MilitaryService Name
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string Name { get => _name; set => SetField(ref _name, value); }

        /// <summary>
        /// MilitaryService OfficerOrEnlisted
        /// </summary>
        public StringEnumValue<OfficerOrEnlisted> OfficerOrEnlisted { get => _officerOrEnlisted; set => SetField(ref _officerOrEnlisted, value); }

        /// <summary>
        /// MilitaryService ServiceNumber
        /// </summary>
        public string ServiceNumber { get => _serviceNumber; set => SetField(ref _serviceNumber, value); }

        /// <summary>
        /// MilitaryService SSN
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.SSN, ReadOnly = true)]
        public string SSN { get => _sSN; set => SetField(ref _sSN, value); }

        /// <summary>
        /// MilitaryService StartDate
        /// </summary>
        public DateTime? StartDate { get => _startDate; set => SetField(ref _startDate, value); }
    }
}