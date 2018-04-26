using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// MilitaryService
    /// </summary>
    public sealed partial class MilitaryService : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<string> _branch;
        /// <summary>
        /// MilitaryService Branch
        /// </summary>
        public string Branch { get => _branch; set => _branch = value; }
        private DirtyValue<DateTime?> _endDate;
        /// <summary>
        /// MilitaryService EndDate
        /// </summary>
        public DateTime? EndDate { get => _endDate; set => _endDate = value; }
        private DirtyValue<string> _id;
        /// <summary>
        /// MilitaryService Id
        /// </summary>
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<int?> _militaryServiceIndex;
        /// <summary>
        /// MilitaryService MilitaryServiceIndex
        /// </summary>
        public int? MilitaryServiceIndex { get => _militaryServiceIndex; set => _militaryServiceIndex = value; }
        private DirtyValue<string> _name;
        /// <summary>
        /// MilitaryService Name
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string Name { get => _name; set => _name = value; }
        private DirtyValue<StringEnumValue<OfficerOrEnlisted>> _officerOrEnlisted;
        /// <summary>
        /// MilitaryService OfficerOrEnlisted
        /// </summary>
        public StringEnumValue<OfficerOrEnlisted> OfficerOrEnlisted { get => _officerOrEnlisted; set => _officerOrEnlisted = value; }
        private DirtyValue<string> _serviceNumber;
        /// <summary>
        /// MilitaryService ServiceNumber
        /// </summary>
        public string ServiceNumber { get => _serviceNumber; set => _serviceNumber = value; }
        private DirtyValue<string> _sSN;
        /// <summary>
        /// MilitaryService SSN
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.SSN, ReadOnly = true)]
        public string SSN { get => _sSN; set => _sSN = value; }
        private DirtyValue<DateTime?> _startDate;
        /// <summary>
        /// MilitaryService StartDate
        /// </summary>
        public DateTime? StartDate { get => _startDate; set => _startDate = value; }
        internal override bool DirtyInternal
        {
            get => _branch.Dirty
                || _endDate.Dirty
                || _id.Dirty
                || _militaryServiceIndex.Dirty
                || _name.Dirty
                || _officerOrEnlisted.Dirty
                || _serviceNumber.Dirty
                || _sSN.Dirty
                || _startDate.Dirty;
            set
            {
                _branch.Dirty = value;
                _endDate.Dirty = value;
                _id.Dirty = value;
                _militaryServiceIndex.Dirty = value;
                _name.Dirty = value;
                _officerOrEnlisted.Dirty = value;
                _serviceNumber.Dirty = value;
                _sSN.Dirty = value;
                _startDate.Dirty = value;
            }
        }
    }
}