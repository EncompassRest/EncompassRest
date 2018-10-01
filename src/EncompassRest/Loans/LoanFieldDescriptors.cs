using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using EncompassRest.Schema;
using EncompassRest.Utilities;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed class LoanFieldDescriptors : ApiObject
    {
        private static readonly ModelPathContext s_modelPathContext = new ModelPathContext(new[]
        {
            new KeyValuePair<string, ModelPathSettings>("Loan.ClosingCost.Gfe2010.Gfe2010Fees", new ModelPathSettings(new Dictionary<string, string> { { nameof(Gfe2010Fee.Gfe2010FeeIndex), "0" }, { nameof(Gfe2010Fee.Gfe2010FeeType), "Undefined" } })),
            new KeyValuePair<string, ModelPathSettings>("Loan.ClosingCost.Gfe2010.Gfe2010WholePocs", new ModelPathSettings(new Dictionary<string, string> { { nameof(Gfe2010WholePoc.Gfe2010WholePocIndex), "0" } })),
            new KeyValuePair<string, ModelPathSettings>("Loan.ClosingCost.Gfe2010Page.Gfe2010FwbcFwscs", new ModelPathSettings(new Dictionary<string, string> { { nameof(Gfe2010FwbcFwsc.Gfe2010FwbcFwscIndex), "0" } })),
            new KeyValuePair<string, ModelPathSettings>("Loan.Gfe.GfeFees", new ModelPathSettings(new Dictionary<string, string> { { nameof(GfeFee.GfeFeeIndex), "0" } })),
            new KeyValuePair<string, ModelPathSettings>("Loan.MilestoneTemplateLogs", new ModelPathSettings(0)),
            new KeyValuePair<string, ModelPathSettings>("Loan.CurrentApplication.Employment", new ModelPathSettings(new Dictionary<string, string> { { nameof(Employment.CurrentEmploymentIndicator), "true" } }))
        }, 1, name => JsonHelper.CamelCaseNamingStrategy.GetPropertyName(name.Replace("_", string.Empty), false));

        public static LoanFieldMappings FieldMappings { get; } = new LoanFieldMappings();

        public static LoanFieldPatternMappings FieldPatternMappings { get; } = new LoanFieldPatternMappings();

        public static ReadOnlyDictionary<string, FieldDescriptor> StandardFields { get; } = new ReadOnlyDictionary<string, FieldDescriptor>(new FieldDescriptors(FieldMappings._standardFields, FieldPatternMappings._standardFieldPatterns));

        public static ReadOnlyDictionary<string, FieldDescriptor> VirtualFields { get; } = new ReadOnlyDictionary<string, FieldDescriptor>(new FieldDescriptors(FieldMappings._virtualFields, FieldPatternMappings._virtualFieldPatterns));

        internal static ModelPath CreateModelPath(string modelPath)
        {
            Preconditions.NotNullOrEmpty(modelPath, nameof(modelPath));

            try
            {
                var path = new ModelPath(s_modelPathContext, modelPath);
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

        internal static FieldDescriptor GetFieldDescriptor(string fieldId, IDictionary<string, FieldDescriptor> customFields)
        {
            Preconditions.NotNullOrEmpty(fieldId, nameof(fieldId));

            if (!FieldMappings.TryGetDescriptor(fieldId, out var descriptor) && customFields?.TryGetValue(fieldId, out descriptor) != true && !FieldPatternMappings.TryGetDescriptorForFieldId(fieldId, out descriptor))
            {
                throw new ArgumentException($"Could not find field '{fieldId}'");
            }
            return descriptor;
        }

        static LoanFieldDescriptors()
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
                                var loanFields = JsonHelper.DefaultPublicSerializer.Deserialize<List<StandardFieldInfo>>(jr);
                                
                                foreach (var loanField in loanFields)
                                {
                                    var modelPath = loanField.ModelPath;
                                    var descriptor = new FieldDescriptor(loanField.FieldId, CreateModelPath(modelPath), modelPath, loanField.Description);
                                    FieldMappings.AddField(descriptor);
                                }
                            }
                        }
                    }

                    using (var jsonStream = zip.GetEntry("VirtualFields.json").Open())
                    {
                        using (var sr = new StreamReader(jsonStream))
                        {
                            using (var jr = new JsonTextReader(sr))
                            {
                                var virtualFields = JsonHelper.DefaultPublicSerializer.Deserialize<List<VirtualFieldInfo>>(jr);

                                foreach (var virtualField in virtualFields)
                                {
                                    var modelPath = $"Loan.VirtualFields['{virtualField.FieldId}']";
                                    var descriptor = new NonStandardFieldDescriptor(virtualField.FieldId, CreateModelPath(modelPath), modelPath, virtualField.Description, virtualField.Format, virtualField.Options, true);
                                    FieldMappings.AddField(descriptor);
                                }
                            }
                        }
                    }

                    using (var jsonStream = zip.GetEntry("LoanFieldPatterns.json").Open())
                    {
                        using (var sr = new StreamReader(jsonStream))
                        {
                            using (var jr = new JsonTextReader(sr))
                            {
                                var loanFieldPatterns = JsonHelper.DefaultPublicSerializer.Deserialize<List<StandardFieldInfo>>(jr);

                                foreach (var loanFieldPattern in loanFieldPatterns)
                                {
                                    var modelPathPattern = loanFieldPattern.ModelPath;
                                    var descriptor = new FieldDescriptor(loanFieldPattern.FieldId, CreateModelPath(string.Format(modelPathPattern, 1)), modelPathPattern, loanFieldPattern.Description, true);
                                    FieldPatternMappings.AddField(descriptor);
                                }
                            }
                        }
                    }

                    using (var jsonStream = zip.GetEntry("VirtualFieldPatterns.json").Open())
                    {
                        using (var sr = new StreamReader(jsonStream))
                        {
                            using (var jr = new JsonTextReader(sr))
                            {
                                var virtualFieldPatterns = JsonHelper.DefaultPublicSerializer.Deserialize<List<VirtualFieldInfo>>(jr);

                                foreach (var virtualFieldPattern in virtualFieldPatterns)
                                {
                                    var modelPathPattern = $"Loan.VirtualFields['{virtualFieldPattern.FieldId}']";
                                    var descriptor = new NonStandardFieldDescriptor(virtualFieldPattern.FieldId, CreateModelPath(string.Format(modelPathPattern, 1)), modelPathPattern, virtualFieldPattern.Description, virtualFieldPattern.Format, virtualFieldPattern.Options, true, true);
                                    FieldPatternMappings.AddField(descriptor);
                                }
                            }
                        }
                    }
                }
            }
        }

        public FieldDescriptor this[string fieldId] => GetFieldDescriptor(fieldId, CustomFields);

        public ReadOnlyDictionary<string, FieldDescriptor> CustomFields => Client.CommonCache.CustomFields;

        public DateTime? CustomFieldsLastRefreshedUtc => Client.CommonCache.CustomFieldsLastRefreshedUtc;

        internal LoanFieldDescriptors(EncompassRestClient client)
            : base(client, null)
        {
        }

        public Task RefreshCustomFieldsAsync(CancellationToken cancellationToken = default) => Client.CommonCache.RefreshCustomFieldsAsync(Client, cancellationToken);

        internal abstract class FieldInfo
        {
            public string FieldId { get; set; }

            public string Description { get; set; }
        }

        internal sealed class StandardFieldInfo : FieldInfo
        {
            public string ModelPath { get; set; }
        }

        internal sealed class VirtualFieldInfo : FieldInfo
        {
            public LoanFieldFormat Format { get; set; }

            [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
            public List<FieldOption> Options { get; set; }
        }
    }
}