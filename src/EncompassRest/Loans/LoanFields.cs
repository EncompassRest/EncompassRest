using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
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
            new KeyValuePair<string, ModelPathSettings>("Loan.ClosingCost.Gfe2010.Gfe2010Fees", new ModelPathSettings(new Dictionary<string, string> { { nameof(Gfe2010Fee.Gfe2010FeeIndex), "0" }, { nameof(Gfe2010Fee.Gfe2010FeeType), "Undefined" } })),
            new KeyValuePair<string, ModelPathSettings>("Loan.ClosingCost.Gfe2010.Gfe2010WholePocs", new ModelPathSettings(new Dictionary<string, string> { { nameof(Gfe2010WholePoc.Gfe2010WholePocIndex), "0" } })),
            new KeyValuePair<string, ModelPathSettings>("Loan.ClosingCost.Gfe2010Page.Gfe2010FwbcFwscs", new ModelPathSettings(new Dictionary<string, string> { { nameof(Gfe2010FwbcFwsc.Gfe2010FwbcFwscIndex), "0" } })),
            new KeyValuePair<string, ModelPathSettings>("Loan.Gfe.GfeFees", new ModelPathSettings(new Dictionary<string, string> { { nameof(GfeFee.GfeFeeIndex), "0" } })),
            new KeyValuePair<string, ModelPathSettings>("Loan.MilestoneTemplateLogs", new ModelPathSettings(0))
        }, 1, name => JsonHelper.CamelCaseNamingStrategy.GetPropertyName(name.Replace("_", string.Empty), false));

        internal static ModelPath CreateModelPath(string modelPath)
        {
            Preconditions.NotNullOrEmpty(modelPath, nameof(modelPath));

            try
            {
                var path = new ModelPath(ModelPathContext, modelPath);
                if (string.Equals(path.RootObjectName, "Loan", StringComparison.OrdinalIgnoreCase))
                {
                    return path;
                }
            }
            catch
            {
            }
            return null;
        }

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
                                using (var virtualFieldsStream = zip.GetEntry("VirtualFields.json").Open())
                                {
                                    using (var sr2 = new StreamReader(virtualFieldsStream))
                                    {
                                        using (var jr2 = new JsonTextReader(sr2))
                                        {
                                            var virtualFields = JsonHelper.DefaultPublicSerializer.Deserialize<List<string>>(jr2);
                                            foreach (var virtualField in virtualFields)
                                            {
                                                dictionary.Add(virtualField, $"Loan.VirtualFields['{virtualField}']");
                                            }
                                        }
                                    }
                                }
                                var concurrentDictionary = new ConcurrentDictionary<string, ModelPath>(dictionary.Select(p => new KeyValuePair<string, ModelPath>(p.Key, CreateModelPath(p.Value))), StringComparer.OrdinalIgnoreCase);
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
                                var dictionary = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
                                JsonHelper.DefaultPublicSerializer.Populate(jr, dictionary);
                                using (var virtualFieldPatternsStream = zip.GetEntry("VirtualFieldPatterns.json").Open())
                                {
                                    using (var sr2 = new StreamReader(virtualFieldPatternsStream))
                                    {
                                        using (var jr2 = new JsonTextReader(sr2))
                                        {
                                            var virtualFieldPatterns = JsonHelper.DefaultIndentedPublicSerializer.Deserialize<List<string>>(jr2);
                                            foreach (var virtualFieldPattern in virtualFieldPatterns)
                                            {
                                                dictionary.Add(virtualFieldPattern, $"Loan.VirtualFields['{virtualFieldPattern}']");
                                            }
                                        }
                                    }
                                }
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
                    return new CustomLoanField(fieldId.ToUpper(), _loan);
                }

                string instanceSpecifier = null;
                int? borrowerPairIndex = null;
                if (!FieldMappings._dictionary.TryGetValue(fieldId, out var modelPath) && !FieldPatternMappings.TryGetModelPathForFieldId(fieldId, out modelPath, out instanceSpecifier))
                {
                    var hasHash = fieldId.Length > 1 && fieldId[fieldId.Length - 2] == '#';
                    char lastChar;
                    if (!hasHash || !char.IsDigit((lastChar = fieldId[fieldId.Length - 1])) || lastChar - '0' > 6 || lastChar == '0' || !FieldMappings.TryGetValue(fieldId.Substring(0, fieldId.Length - 2), out var path) || !path.StartsWith("Loan.CurrentApplication.", StringComparison.OrdinalIgnoreCase))
                    {
                        throw new ArgumentException($"Could not find field {fieldId}");
                    }

                    borrowerPairIndex = lastChar - '1';
                    modelPath = CreateModelPath($"Loan.Applications[(ApplicationIndex == '{borrowerPairIndex}')]{path.Substring(23)}");
                }
                else
                {
                    var path = modelPath.ToString();
                    if (path.StartsWith("Loan.VirtualFields", StringComparison.OrdinalIgnoreCase))
                    {
                        return new VirtualLoanField(fieldId, _loan, instanceSpecifier);
                    }
                    else if (path.StartsWith("Loan.CurrentApplication.", StringComparison.OrdinalIgnoreCase))
                    {
                        borrowerPairIndex = -1;
                    }
                }

                return new LoanField(fieldId, _loan, modelPath, borrowerPairIndex, instanceSpecifier);
            }
        }

        internal LoanFields(Loan loan)
        {
            _loan = loan;
        }
    }
}