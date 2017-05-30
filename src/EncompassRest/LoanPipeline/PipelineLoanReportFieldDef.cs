using System.Collections.Generic;

namespace EncompassRest.LoanPipeline
{
    public sealed class PipelineLoanReportFieldDef
    {
        public int BorrowerPair { get; set; }
        public bool IsLoanDataField { get; set; }
        public string Category { get; set; }
        public string FieldID { get; set; }
        public FieldDefinition FieldDefinition { get; set; }
        public int DataSource { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int FieldType { get; set; }
        public bool Selectable { get; set; }
        public string CriterionFieldName { get; set; }
        public SortTerm SortTerm { get; set; }
        public bool IsDatabaseField { get; set; }
        public int ReportingDatabaseColumnType { get; set; }
        public int? DisplayType { get; set; }
        public List<string> RelatedFields { get; set; }
    }
}