using EncompassRest.Utilities;
using EnumsNET;

namespace EncompassRest.Schema.v1
{
    /// <summary>
    /// FieldDefinition
    /// </summary>
    public class FieldDefinition : ExtensibleObject
    {
        /// <summary>
        /// FieldDefinition Description
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// FieldDefinition FieldID
        /// </summary>
#pragma warning disable CS8618 // Non-nullable field is uninitialized. Consider declaring as nullable.
        public string FieldID { get; set; }
#pragma warning restore CS8618 // Non-nullable field is uninitialized. Consider declaring as nullable.

        /// <summary>
        /// FieldDefinition Format
        /// </summary>
        [EnumFormat(EnumFormat.DecimalValue)]
        public LoanFieldFormat Format { get; set; }

        /// <summary>
        /// FieldDefinition ParentField
        /// </summary>
        public FieldDefinition? ParentField { get; set; }

        /// <summary>
        /// FieldDefinition InstanceSpecifier
        /// </summary>
        public string? InstanceSpecifier { get; set; }

        /// <summary>
        /// FieldDefinition IsInstance
        /// </summary>
        public bool IsInstance { get; set; }

        /// <summary>
        /// FieldDefinition AllowInReportingDatabase
        /// </summary>
        public bool AllowInReportingDatabase { get; set; }

        /// <summary>
        /// FieldDefinition ReportingDatabaseColumnSize
        /// </summary>
        public int ReportingDatabaseColumnSize { get; set; }

        /// <summary>
        /// FieldDefinition Category
        /// </summary>
        public int Category { get; set; }

        /// <summary>
        /// FieldDefinition MaxLength
        /// </summary>
        public int MaxLength { get; set; }

        /// <summary>
        /// FieldDefinition ReportingDatabaseColumnType
        /// </summary>
        public int ReportingDatabaseColumnType { get; set; }

        /// <summary>
        /// FieldDefinition IsDateValued
        /// </summary>
        public bool IsDateValued { get; set; }

        /// <summary>
        /// FieldDefinition FieldOptions
        /// </summary>
        public FieldOptions? FieldOptions { get; set; }

        /// <summary>
        /// FieldDefinition AllowEdit
        /// </summary>
        public bool? AllowEdit { get; set; }

        /// <summary>
        /// FieldDefinition EnforceMaxLengthDuringValidation
        /// </summary>
        public bool? EnforceMaxLengthDuringValidation { get; set; }

        /// <summary>
        /// FieldDefinition RequiresBorrowerPredicate
        /// </summary>
        public bool? RequiresBorrowerPredicate { get; set; }

        /// <summary>
        /// FieldDefinition IsNumeric
        /// </summary>
        public bool? IsNumeric { get; set; }

        /// <summary>
        /// FieldDefinition RequiresExclusiveLock
        /// </summary>
        public bool? RequiresExclusiveLock { get; set; }

        /// <summary>
        /// PipelineFieldDefinition MultiInstance
        /// </summary>
        public bool? MultiInstance { get; set; }

        /// <summary>
        /// PipelineFieldDefinition InstanceSpecifierType
        /// </summary>
        public int? InstanceSpecifierType { get; set; }
    }
}