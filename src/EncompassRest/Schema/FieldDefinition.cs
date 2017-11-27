using EncompassRest.Utilities;
using EnumsNET;
using System.Collections.Generic;

namespace EncompassRest.Schema
{
    public class FieldDefinition
    {
        public string Description { get; set; }
        public string FieldID { get; set; }
        [EnumFormat(EnumFormat.DecimalValue)]
        public LoanFieldFormat Format { get; set; }
        public ParentFieldDefinition ParentField { get; set; }
        public string InstanceSpecifier { get; set; }
        public bool IsInstance { get; set; }
        public bool AllowInReportingDatabase { get; set; }
        public int ReportingDatabaseColumnSize { get; set; }
        public int Category { get; set; }
        public int MaxLength { get; set; }
        public int ReportingDatabaseColumnType { get; set; }
        public bool IsDateValued { get; set; }
        public FieldOptions FieldOptions { get; set; }
        public bool? AllowEdit { get; set; }
        public bool? EnforceMaxLengthDuringValidation { get; set; }
        public bool? RequiresBorrowerPredicate { get; set; }
        public bool? IsNumeric { get; set; }
        public bool? RequiresExclusiveLock { get; set; }

        private DirtyDictionary<string, object> _extensionData;
        public IDictionary<string, object> ExtensionData { get => _extensionData ?? (_extensionData = new DirtyDictionary<string, object>()); set => _extensionData = new DirtyDictionary<string, object>(value); }
    }
}