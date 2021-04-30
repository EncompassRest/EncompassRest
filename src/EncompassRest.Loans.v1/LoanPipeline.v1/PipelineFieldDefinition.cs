using System.Collections.Generic;
using EncompassRest.Schema;
using EncompassRest.Schema.v1;

namespace EncompassRest.LoanPipeline.v1
{
#pragma warning disable CS8618 // Non-nullable field is uninitialized. Consider declaring as nullable.
    /// <summary>
    /// PipelineFieldDefinition
    /// </summary>
    public sealed class PipelineFieldDefinition : ExtensibleObject
    {
        /// <summary>
        /// PipelineFieldDefinition BorrowerPair
        /// </summary>
        public int BorrowerPair { get; set; }

        /// <summary>
        /// PipelineFieldDefinition IsLoanDataField
        /// </summary>
        public bool IsLoanDataField { get; set; }

        /// <summary>
        /// PipelineFieldDefinition Category
        /// </summary>
        public StringEnumValue<FieldDefinitionCategory> Category { get; set; }

        /// <summary>
        /// PipelineFieldDefinition FieldID
        /// </summary>
        public string FieldID { get; set; }

        /// <summary>
        /// PipelineFieldDefinition FieldDefinition
        /// </summary>
        public FieldDefinition? FieldDefinition { get; set; }

        /// <summary>
        /// PipelineFieldDefinition DataSource
        /// </summary>
        public int DataSource { get; set; }

        /// <summary>
        /// PipelineFieldDefinition Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// PipelineFieldDefinition Description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// PipelineFieldDefinition FieldType
        /// </summary>
        public int FieldType { get; set; }

        /// <summary>
        /// PipelineFieldDefinition Selectable
        /// </summary>
        public bool Selectable { get; set; }

        /// <summary>
        /// PipelineFieldDefinition CriterionFieldName
        /// </summary>
        public string? CriterionFieldName { get; set; }

        /// <summary>
        /// PipelineFieldDefinition SortTerm
        /// </summary>
        public SortTerm? SortTerm { get; set; }

        /// <summary>
        /// PipelineFieldDefinition IsDatabaseField
        /// </summary>
        public bool IsDatabaseField { get; set; }

        /// <summary>
        /// PipelineFieldDefinition ReportingDatabaseColumnType
        /// </summary>
        public int ReportingDatabaseColumnType { get; set; }

        /// <summary>
        /// PipelineFieldDefinition DisplayType
        /// </summary>
        public int? DisplayType { get; set; }

        /// <summary>
        /// PipelineFieldDefinition RelatedFields
        /// </summary>
        public List<string>? RelatedFields { get; set; }

        /// <summary>
        /// PipelineFieldDefinition IsVolatile
        /// </summary>
        public bool? IsVolatile { get; set; }
    }
#pragma warning restore CS8618 // Non-nullable field is uninitialized. Consider declaring as nullable.
}