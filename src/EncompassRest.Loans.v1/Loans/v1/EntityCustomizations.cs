using EncompassRest.Utilities;
using EncompassRest.v1;
using Newtonsoft.Json;

namespace EncompassRest.Loans.v1
{
    partial class Application
    {
        string? IIdentifiable.Id { get => Id ?? ApplicationId; set { Id = value; ApplicationId = value; } }
    }

    partial class CustomField
    {
        [IdPropertyName(nameof(FieldName))]
        string? IIdentifiable.Id { get => FieldName; set => FieldName = value; }
    }

    partial class FieldLockData
    {
        static FieldLockData()
        {
            TypeData<FieldLockData>.CustomStringComparer = new StringModelPathComparer();
        }

        [IdPropertyName(nameof(ModelPath))]
        string? IIdentifiable.Id { get => ModelPath; set => ModelPath = value; }
    }

    partial class Contact
    {
        /// <summary>
        /// Contact ContactValue
        /// </summary>
        [JsonProperty("contact")]
        public EntityReference? ContactValue { get => GetValue<EntityReference?>(); set => SetValue(value); }
    }
}