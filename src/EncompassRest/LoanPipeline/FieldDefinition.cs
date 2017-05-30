using System.Collections.Generic;
using EncompassRest.Schema;
using Newtonsoft.Json;

namespace EncompassRest.LoanPipeline
{
    public sealed class FieldDefinition
    {
        public string Description { get; set; }
        public string FieldID { get; set; }
        public int Format { get; set; }
        public bool AllowInReportingDatabase { get; set; }
        public int ReportingDatabaseColumnSize { get; set; }
        public int Category { get; set; }
        public int MaxLength { get; set; }
        public int ReportingDatabaseColumnType { get; set; }
        public bool IsNumeric { get; set; }
        [JsonProperty(ItemConverterType = typeof(FieldOptionConverter))]
        public List<FieldOption> FieldOptions { get; set; }
        public bool? EnforceMaxLengthDuringValidation { get; set; }
        public bool? IsDateValued { get; set; }
    }
}