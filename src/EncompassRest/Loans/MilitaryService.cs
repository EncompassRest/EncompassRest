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
        public string Branch { get => _branch; set => SetField(ref _branch, value); }
        private DirtyValue<DateTime?> _endDate;
        /// <summary>
        /// MilitaryService EndDate
        /// </summary>
        public DateTime? EndDate { get => _endDate; set => SetField(ref _endDate, value); }
        private DirtyValue<string> _id;
        /// <summary>
        /// MilitaryService Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }
        private DirtyValue<int?> _militaryServiceIndex;
        /// <summary>
        /// MilitaryService MilitaryServiceIndex
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"1\":\"1\",\"2\":\"2\",\"3\":\"3\",\"4\":\"4\",\"5\":\"5\",\"6\":\"6\",\"7\":\"7\"}")]
        public int? MilitaryServiceIndex { get => _militaryServiceIndex; set => SetField(ref _militaryServiceIndex, value); }
        private DirtyValue<string> _name;
        /// <summary>
        /// MilitaryService Name
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string Name { get => _name; set => SetField(ref _name, value); }
        private DirtyValue<StringEnumValue<OfficerOrEnlisted>> _officerOrEnlisted;
        /// <summary>
        /// MilitaryService OfficerOrEnlisted
        /// </summary>
        public StringEnumValue<OfficerOrEnlisted> OfficerOrEnlisted { get => _officerOrEnlisted; set => SetField(ref _officerOrEnlisted, value); }
        private DirtyValue<string> _serviceNumber;
        /// <summary>
        /// MilitaryService ServiceNumber
        /// </summary>
        public string ServiceNumber { get => _serviceNumber; set => SetField(ref _serviceNumber, value); }
        private DirtyValue<string> _sSN;
        /// <summary>
        /// MilitaryService SSN
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.SSN, ReadOnly = true)]
        public string SSN { get => _sSN; set => SetField(ref _sSN, value); }
        private DirtyValue<DateTime?> _startDate;
        /// <summary>
        /// MilitaryService StartDate
        /// </summary>
        public DateTime? StartDate { get => _startDate; set => SetField(ref _startDate, value); }
    }
}