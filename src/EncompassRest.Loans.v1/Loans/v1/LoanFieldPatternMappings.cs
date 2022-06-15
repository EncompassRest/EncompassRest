namespace EncompassRest.Loans.v1;

/// <summary>
/// LoanFieldPatternMappings
/// </summary>
public sealed class LoanFieldPatternMappings : LoanFieldPatternMappingsBase
{
    internal LoanFieldPatternMappings()
    {
    }

    internal override FieldDescriptorBase CreateFieldDescriptorInternal(string fieldPattern, string modelPathPattern) => new FieldDescriptor(fieldPattern, LoanFieldDescriptors.CreateModelPath(string.Format(modelPathPattern, 1))!, modelPathPattern, string.Empty);
}