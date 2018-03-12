using System;
using System.Linq;
using EncompassRest.Utilities;
using Newtonsoft.Json.Serialization;

namespace EncompassRest.Loans
{
    public sealed partial class LoanFields
    {
        private readonly Loan _loan;

        public LoanField this[string fieldId]
        {
            get
            {
                Preconditions.NotNullOrEmpty(fieldId, nameof(fieldId));

                fieldId = fieldId.ToUpper();
                if (fieldId.StartsWith("CX.", StringComparison.Ordinal) || fieldId.StartsWith("CUST", StringComparison.Ordinal))
                {
                    return new CustomLoanField(fieldId, _loan);
                }
                else
                {
                    var resolver = JsonHelper.InternalPrivateContractResolver;
                    JsonObjectContract currentContract;
                    var startIndex = 0;
                    object target;
                    if (!FieldMappings.TryGetValue(fieldId, out var modelPath))
                    {
                        var hashIndex = fieldId.LastIndexOf('#');
                        if (hashIndex < 0 || !int.TryParse(fieldId.Substring(hashIndex + 1), out var bpIndex) || bpIndex < 1 || bpIndex > 6 || !FieldMappings.TryGetValue(fieldId.Substring(0, hashIndex), out modelPath) || !modelPath.StartsWith("CurrentApplication.", StringComparison.Ordinal))
                        {
                            throw new ArgumentException($"Could not find field {fieldId}");
                        }

                        --bpIndex;
                        var borrowerPair = _loan.Applications.FirstOrDefault(a => a.ApplicationIndex == bpIndex);
                        if (borrowerPair == null)
                        {
                            borrowerPair = new Application { ApplicationIndex = bpIndex };
                            _loan.Applications.Add(borrowerPair);
                        }
                        target = borrowerPair;
                        currentContract = (JsonObjectContract)resolver.ResolveContract(TypeData<Application>.Type);
                        startIndex = 1;
                        modelPath = $"Applications[(ApplicationIndex == {bpIndex})]{modelPath.Substring(18)}";
                    }
                    else
                    {
                        target = _loan;
                        currentContract = (JsonObjectContract)resolver.ResolveContract(TypeData<Loan>.Type);
                    }

                    var propertyNames = modelPath.Split('.');
                    for (var i = startIndex + 1; i < propertyNames.Length; ++i)
                    {
                        var property = currentContract.Properties.GetClosestMatchProperty(propertyNames[i - 1]);
                        target = property.ValueProvider.GetValue(target);
                        currentContract = (JsonObjectContract)resolver.ResolveContract(property.PropertyType);
                    }
                    var modelProperty = currentContract.Properties.GetClosestMatchProperty(propertyNames[propertyNames.Length - 1]);
                    return new LoanField(fieldId, _loan, $"Loan.{modelPath}", modelProperty, target);
                }
            }
        }

        internal LoanFields(Loan loan)
        {
            _loan = loan;
        }
    }
}