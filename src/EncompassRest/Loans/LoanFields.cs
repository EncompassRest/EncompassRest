using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Reflection;
using EncompassRest.Utilities;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed class LoanFields
    {
        public static LoanFieldMappings FieldMappings { get; }

        public static LoanFieldPatternMappings FieldPatternMappings { get; }

        internal static ModelPathContext ModelPathContext { get; } = new ModelPathContext(new[]
        {
            new KeyValuePair<string, ModelPathSettings>("Loan.ClosingCost.Gfe2010.Gfe2010Fees", new ModelPathSettings(new Dictionary<string, string> { { "Gfe2010FeeIndex", "0" }, { "Gfe2010FeeType", "Undefined" } })),
            new KeyValuePair<string, ModelPathSettings>("Loan.ClosingCost.Gfe2010.Gfe2010WholePocs", new ModelPathSettings(new Dictionary<string, string> { { "Gfe2010WholePocIndex", "0" } })),
            new KeyValuePair<string, ModelPathSettings>("Loan.ClosingCost.Gfe2010Page.Gfe2010FwbcFwscs", new ModelPathSettings(new Dictionary<string, string> { { "Gfe2010FwbcFwscIndex", "0" } })),
            new KeyValuePair<string, ModelPathSettings>("Loan.Gfe.GfeFees", new ModelPathSettings(new Dictionary<string, string> { { "GfeFeeIndex", "0" } })),
            new KeyValuePair<string, ModelPathSettings>("Loan.MilestoneTemplateLogs", new ModelPathSettings(0))
        }, 1);

        static LoanFields()
        {
            // Use embedded resource file for built-in field mappings to save assembly space
            using (var stream = typeof(LoanFields).GetTypeInfo().Assembly.GetManifestResourceStream("EncompassRest.LoanFields.zip"))
            {
                using (var zip = new ZipArchive(stream))
                {
                    using (var jsonStream = zip.GetEntry("LoanFields.json").Open())
                    {
                        using (var sr = new StreamReader(jsonStream))
                        {
                            using (var jr = new JsonTextReader(sr))
                            {
                                var dictionary = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
                                JsonHelper.DefaultPublicSerializer.Populate(jr, dictionary);
                                var concurrentDictionary = new ConcurrentDictionary<string, ModelPath>(dictionary.Select(p => new KeyValuePair<string, ModelPath>(p.Key, ModelPathContext.Create(p.Value))), StringComparer.OrdinalIgnoreCase);
                                FieldMappings = new LoanFieldMappings(concurrentDictionary);
                            }
                        }
                    }
                    using (var jsonStream = zip.GetEntry("LoanFieldPatterns.json").Open())
                    {
                        using (var sr = new StreamReader(jsonStream))
                        {
                            using (var jr = new JsonTextReader(sr))
                            {
                                var dictionary = new ConcurrentDictionary<string, string>(StringComparer.OrdinalIgnoreCase);
                                JsonHelper.DefaultPublicSerializer.Populate(jr, dictionary);
                                FieldPatternMappings = new LoanFieldPatternMappings(dictionary);
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
                
                if (fieldId.StartsWith("CX.", StringComparison.OrdinalIgnoreCase) || fieldId.StartsWith("CUST", StringComparison.OrdinalIgnoreCase))
                {
                    return new CustomLoanField(fieldId, _loan);
                }
                else
                {
                    if (!FieldMappings._dictionary.TryGetValue(fieldId, out var modelPath))
                    {
                        if (fieldId.Length >= 5 && ((int.TryParse(fieldId.Substring(fieldId.Length - 4, 2), NumberStyles.None, null, out var patternIndex) && patternIndex >= 1 && FieldPatternMappings.TryGetValue($"{fieldId.Substring(0, fieldId.Length - 4)}NN{fieldId.Substring(fieldId.Length - 2)}", out var path)) || (int.TryParse(fieldId.Substring(fieldId.Length - 5, 2), NumberStyles.None, null, out patternIndex) && patternIndex >= 1 && FieldPatternMappings.TryGetValue($"{fieldId.Substring(0, fieldId.Length - 5)}NN{fieldId.Substring(fieldId.Length - 3)}", out path))))
                        {
                            modelPath = ModelPathContext.Create(path.Replace("[NN]", $"[{patternIndex}]"));
                        }
                        else
                        {
                            var hashIndex = fieldId.LastIndexOf('#');
                            if (hashIndex < 0 || !int.TryParse(fieldId.Substring(hashIndex + 1), NumberStyles.None, null, out var bpIndex) || bpIndex < 1 || bpIndex > 6 || !FieldMappings.TryGetValue(fieldId.Substring(0, hashIndex), out path) || !path.StartsWith("Loan.CurrentApplication.", StringComparison.Ordinal))
                            {
                                throw new ArgumentException($"Could not find field {fieldId}");
                            }

                            modelPath = ModelPathContext.Create($"Loan.Applications[(ApplicationIndex == '{bpIndex - 1}')]{path.Substring(23)}");
                        }
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