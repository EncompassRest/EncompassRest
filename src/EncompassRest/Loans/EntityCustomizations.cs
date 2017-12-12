namespace EncompassRest.Loans
{
    partial class Application
    {
        string IIdentifiable.Id { get => Id ?? ApplicationId; set { Id = value; ApplicationId = value; } }
    }
    
    partial class CustomField
    {
        [IdPropertyName(nameof(FieldName))]
        string IIdentifiable.Id { get => FieldName; set => FieldName = value; }
    }
}