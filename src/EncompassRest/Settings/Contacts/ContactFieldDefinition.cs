using System.Collections.Generic;
using EncompassRest.Schema;

namespace EncompassRest.Settings.Contacts
{
    public sealed class ContactFieldDefinition : ExtensibleObject
    {
        public bool FilterOnly { get; set; }

        public StringEnumValue<FieldDefinitionCategory> Category { get; set; }

        public string Description { get; set; }

        public string CanonicalName { get; set; }

        public StringEnumValue<LoanFieldFormat> DataType { get; set; }

        public StringEnumValue<FieldDefinitionDataSource> DataSource { get; set; }

        public List<string> Options { get; set; }

        public int? MaxLength { get; set; }
    }
}