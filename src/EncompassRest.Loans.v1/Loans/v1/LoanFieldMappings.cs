namespace EncompassRest.Loans.v1;

/// <summary>
/// LoanFieldMappings
/// </summary>
public sealed class LoanFieldMappings : LoanFieldMappingsBase
{
    internal LoanFieldMappings()
    {
    }

    internal override ModelPath? CreateModelPath(string modelPath) => LoanFieldDescriptors.CreateModelPath(modelPath);

    internal override FieldDescriptorBase CreateFieldDescriptor(string fieldId, ModelPath path, string modelPath) => new FieldDescriptor(fieldId, path, modelPath, string.Empty);
}