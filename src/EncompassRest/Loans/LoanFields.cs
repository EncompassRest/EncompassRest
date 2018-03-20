using System;
using System.Collections.Concurrent;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using EncompassRest.Utilities;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed class LoanFields
    {
        public static LoanFieldMappings FieldMappings { get; }

        static LoanFields()
        {
            // Use embedded resource file for built-in field mappings to save assembly space
            using (var stream = typeof(LoanFields).GetTypeInfo().Assembly.GetManifestResourceStream("EncompassRest.LoanFields.json.zip"))
            {
                using (var zip = new ZipArchive(stream))
                {
                    using (var jsonStream = zip.Entries[0].Open())
                    {
                        using (var sr = new StreamReader(jsonStream))
                        {
                            using (var jr = new JsonTextReader(sr))
                            {
                                FieldMappings = new LoanFieldMappings(JsonHelper.DefaultPublicSerializer.Deserialize<ConcurrentDictionary<string, ModelPath>>(jr));
                            }
                        }
                    }
                }
            }
        }

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
                    if (!FieldMappings._dictionary.TryGetValue(fieldId, out var modelPath))
                    {
                        var hashIndex = fieldId.LastIndexOf('#');
                        if (hashIndex < 0 || !int.TryParse(fieldId.Substring(hashIndex + 1), out var bpIndex) || bpIndex < 1 || bpIndex > 6 || !FieldMappings.TryGetValue(fieldId.Substring(0, hashIndex), out var path) || !path.StartsWith("Loan.CurrentApplication.", StringComparison.Ordinal))
                        {
                            throw new ArgumentException($"Could not find field {fieldId}");
                        }

                        modelPath = new ModelPath($"Loan.Applications[(ApplicationIndex == '{bpIndex - 1}')]{path.Substring(23)}");
                    }

                    return new LoanField(fieldId, _loan, modelPath);
                }
            }
        }

        internal LoanFields(Loan loan)
        {
            _loan = loan;
        }
    }
}