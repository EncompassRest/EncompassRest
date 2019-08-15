using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
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
    /// <summary>
    /// LoanFieldDescriptors
    /// </summary>
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

        /// <summary>
        /// All basic field mappings. e.g. fields 2, VEND.X263, etc.
        /// </summary>
        public static LoanFieldMappings FieldMappings { get; } = new LoanFieldMappings();

        /// <summary>
        /// All field pattern mappings. e.g. fields HUDNN01, BENN05, etc.
        /// </summary>
        public static LoanFieldPatternMappings FieldPatternMappings { get; } = new LoanFieldPatternMappings();

        /// <summary>
        /// The standard fields. These are statically populated.
        /// </summary>
        public static ReadOnlyDictionary<string, FieldDescriptor> StandardFields { get; } = new ReadOnlyDictionary<string, FieldDescriptor>(new FieldDescriptors(FieldMappings._standardFields, FieldPatternMappings._standardFieldPatterns));

        /// <summary>
        /// The virtual fields. These are statically populated.
        /// </summary>
        public static ReadOnlyDictionary<string, FieldDescriptor> VirtualFields { get; } = new ReadOnlyDictionary<string, FieldDescriptor>(new FieldDescriptors(FieldMappings._virtualFields, FieldPatternMappings._virtualFieldPatterns));

        /// <summary>
        /// The utc date and time standard fields were last refreshed.
        /// </summary>
        public static DateTime? StandardFieldsLastRefreshedUtc { get; private set; }

        static LoanFieldDescriptors()
        {
            // Use embedded resource file for built-in field mappings to save assembly space
            using (var stream = typeof(LoanFieldDescriptors).GetTypeInfo().Assembly.GetManifestResourceStream("EncompassRest.LoanFields.zip"))
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
                                    var modelPathString = loanField.ModelPath;
                                    var modelPath = CreateModelPath(modelPathString);
                                    modelPathString = modelPath.ToString();
                                    FieldDescriptor descriptor;
                                    if (loanField.Format.HasValue)
                                    {
                                        descriptor = new NonStandardFieldDescriptor(loanField.FieldId, modelPath, modelPathString, loanField.Description, loanField.Format, loanField.Options, loanField.ReadOnly ?? false);
                                    }
                                    else
                                    {
                                        descriptor = new FieldDescriptor(loanField.FieldId, modelPath, modelPathString, loanField.Description);
                                    }
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
                                    var descriptor = new NonStandardFieldDescriptor(virtualField.FieldId, CreateModelPath(modelPath), modelPath, virtualField.Description, virtualField.Format, virtualField.Options, readOnly: true);
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
                                    var descriptor = new FieldDescriptor(loanFieldPattern.FieldId, CreateModelPath(string.Format(modelPathPattern, 1)), modelPathPattern, loanFieldPattern.Description, multiInstance: true);
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
                                    var descriptor = new NonStandardFieldDescriptor(virtualFieldPattern.FieldId, CreateModelPath(string.Format(modelPathPattern, 1)), modelPathPattern, virtualFieldPattern.Description, virtualFieldPattern.Format, virtualFieldPattern.Options, readOnly: true, multiInstance: true);
                                    FieldPatternMappings.AddField(descriptor);
                                }
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Refreshes the standard fields cache.
        /// </summary>
        /// <param name="client">The client to use to retrieve the standard fields.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static async Task RefreshStandardFieldsAsync(EncompassRestClient client, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNull(client, nameof(client));

            var entityTypes = (await client.Schema.GetLoanSchemaAsync(includeFieldExtensions: true, cancellationToken).ConfigureAwait(false)).EntityTypes;
            var loanEntitySchema = entityTypes["Loan"];
            var fields = new Dictionary<string, StandardFieldInfo>(StringComparer.OrdinalIgnoreCase);
            var fieldPatterns = new Dictionary<string, StandardFieldInfo>(StringComparer.OrdinalIgnoreCase)
            {
                { "CX.{0}", new StandardFieldInfo { FieldId = "CX.{0}", ModelPath = "Loan.CustomFields[(FieldName == 'CX.{0}')].StringValue", Format = LoanFieldFormat.STRING } },
                { "CUST{0:00}FV", new StandardFieldInfo { FieldId = "CUST{0:00}FV", ModelPath = "Loan.CustomFields[(FieldName == 'CUST{0:00}FV')].StringValue", Format = LoanFieldFormat.STRING } }
            };
            PopulateFieldMappings("Loan", "Loan", null, loanEntitySchema, null, entityTypes, fields, fieldPatterns, extendedFieldInfo: true, null, null, null);

            foreach (var pair in FieldMappings._standardFields)
            {
                var fieldId = pair.Key;
                var currentDescriptor = pair.Value;
                if (fields.TryGetValue(fieldId, out var fieldInfo))
                {
                    fields.Remove(fieldId);
                    if (!string.Equals(currentDescriptor.ModelPath, fieldInfo.ModelPath, StringComparison.OrdinalIgnoreCase) || (!string.IsNullOrEmpty(fieldInfo.Description) && currentDescriptor.Description != fieldInfo.Description) || currentDescriptor.ReadOnly != (fieldInfo.ReadOnly == true))
                    {
                        var modelPath = string.Equals(currentDescriptor.ModelPath, fieldInfo.ModelPath, StringComparison.OrdinalIgnoreCase) ? currentDescriptor.ModelPath : fieldInfo.ModelPath;
                        var descriptor = new NonStandardFieldDescriptor(fieldInfo.FieldId, CreateModelPath(modelPath), modelPath, fieldInfo.Description, fieldInfo.Format, fieldInfo.Options, fieldInfo.ReadOnly == true);
                        FieldMappings._standardFields[fieldId] = descriptor;
                    }
                }
                else if (!currentDescriptor._userAdded)
                {
                    FieldMappings._standardFields.TryRemove(fieldId, out _);
                }
            }

            foreach (var pair in fields)
            {
                var fieldInfo = pair.Value;
                var modelPath = fieldInfo.ModelPath;
                var descriptor = new NonStandardFieldDescriptor(fieldInfo.FieldId, CreateModelPath(modelPath), modelPath, fieldInfo.Description, fieldInfo.Format, fieldInfo.Options, fieldInfo.ReadOnly == true);
                FieldMappings.AddField(descriptor);
            }

            foreach (var pair in FieldPatternMappings._standardFieldPatterns)
            {
                var fieldPattern = pair.Key;
                var currentDescriptor = pair.Value;
                if (fieldPatterns.TryGetValue(fieldPattern, out var fieldInfo))
                {
                    fieldPatterns.Remove(fieldPattern);
                    if (!string.Equals(currentDescriptor.ModelPath, fieldInfo.ModelPath, StringComparison.OrdinalIgnoreCase) || currentDescriptor.ReadOnly != (fieldInfo.ReadOnly == true))
                    {
                        var modelPathPattern = string.Equals(currentDescriptor.ModelPath, fieldInfo.ModelPath, StringComparison.OrdinalIgnoreCase) ? currentDescriptor.ModelPath : fieldInfo.ModelPath;
                        var descriptor = new NonStandardFieldDescriptor(fieldInfo.FieldId, CreateModelPath(string.Format(modelPathPattern, 1)), modelPathPattern, currentDescriptor.Description, fieldInfo.Format, fieldInfo.Options, fieldInfo.ReadOnly == true, multiInstance: true);
                        FieldPatternMappings._standardFieldPatterns[fieldPattern] = descriptor;
                    }
                }
                else if (!currentDescriptor._userAdded)
                {
                    FieldPatternMappings._standardFieldPatterns.TryRemove(fieldPattern, out _);
                }
            }

            foreach (var pair in fieldPatterns)
            {
                var fieldInfo = pair.Value;
                var modelPathPattern = fieldInfo.ModelPath;
                var descriptor = new NonStandardFieldDescriptor(fieldInfo.FieldId, CreateModelPath(string.Format(modelPathPattern, 1)), modelPathPattern, fieldInfo.Description, fieldInfo.Format, fieldInfo.Options, fieldInfo.ReadOnly == true, multiInstance: true);
                FieldPatternMappings.AddField(descriptor);
            }

            StandardFieldsLastRefreshedUtc = DateTime.UtcNow;
        }

        internal delegate void PopulateFieldMappingsAction(string entityName, Type ellieType, EntitySchema entitySchema, HashSet<string> requiredProperties, bool serializeWholeList);

        internal static void PopulateFieldMappings(string entityName, string currentPath, Type ellieType, EntitySchema entitySchema, EntitySchema previousEntitySchema, Dictionary<string, EntitySchema> entityTypes, Dictionary<string, StandardFieldInfo> fields, Dictionary<string, StandardFieldInfo> fieldPatterns, bool extendedFieldInfo, PopulateFieldMappingsAction action, Func<string, string> descriptionRetriever, TextWriter output)
        {
            var requiredProperties = new HashSet<string>();
            var serializeWholeList = false;

            var properties = entitySchema.Properties;
            foreach (var pair in properties)
            {
                var propertyName = pair.Key;
                var propertySchema = pair.Value;
                var description = propertySchema.Description;
                var ellieProperty = ellieType?.GetTypeInfo().GetDeclaredProperty(propertyName);
                var elliePropertyType = ellieProperty?.PropertyType;
                var fieldId = propertySchema.FieldId;
                if (!string.IsNullOrEmpty(fieldId))
                {
                    if (string.IsNullOrEmpty(description) && descriptionRetriever != null)
                    {
                        try
                        {
                            description = descriptionRetriever(fieldId);
                        }
                        catch
                        {
                        }
                    }
                    var fieldInfo = new StandardFieldInfo { FieldId = fieldId, ModelPath = $"{currentPath}.{propertyName}", Description = description };
                    fieldInfo.NonSerializedFormat = GetFormat(propertySchema);
                    if (extendedFieldInfo)
                    {
                        fieldInfo.Format = fieldInfo.NonSerializedFormat;
                        fieldInfo.Options = GetOptions(propertySchema);
                        fieldInfo.ReadOnly = propertySchema.ReadOnly == true;
                    }
                    fields.Add(fieldId, fieldInfo);
                }
                else if (propertySchema.Type == PropertySchemaType.Entity && entityTypes.TryGetValue(propertySchema.EntityType, out var nestedEntitySchema))
                {
                    if (currentPath != "Loan.CurrentApplication" || propertyName != "ATRQMBorrower")
                    {
                        entityTypes.Remove(propertySchema.EntityType);
                        if (ellieType?.Name == "LoanContract" && propertyName == "CurrentApplication")
                        {
                            elliePropertyType = ellieType.GetTypeInfo().GetDeclaredProperty("Applications").PropertyType.GetTypeInfo().ImplementedInterfaces.First(i => i.Name == "IEnumerable`1").GenericTypeArguments[0];
                        }
                        else if (ellieType != null && elliePropertyType == null)
                        {
                            output?.WriteLine($"Did not get ellie type for {currentPath}.{propertyName} of type {propertySchema.EntityType.Value}");
                        }
                        PopulateFieldMappings(propertySchema.EntityType, $"{currentPath}.{propertyName}", elliePropertyType, nestedEntitySchema, entitySchema, entityTypes, fields, fieldPatterns, extendedFieldInfo, action, descriptionRetriever, output);
                    }
                }
                else if ((propertySchema.Type == PropertySchemaType.List || propertySchema.Type == PropertySchemaType.Set) && entityTypes.TryGetValue(propertySchema.ElementType, out var elementEntitySchema))
                {
                    if (currentPath != "Loan" || propertyName != "Applications")
                    {
                        entityTypes.Remove(propertySchema.ElementType);
                        if (ellieProperty != null)
                        {
                            elliePropertyType = elliePropertyType.GetTypeInfo().ImplementedInterfaces.First(i => i.Name == "IEnumerable`1").GenericTypeArguments[0];
                        }
                        else if (ellieType != null)
                        {
                            output?.WriteLine($"Did not get ellie type for {currentPath}.{propertyName} of type {propertySchema.ElementType.Value}");
                        }
                        PopulateFieldMappings(propertySchema.ElementType, $"{currentPath}.{propertyName}", elliePropertyType, elementEntitySchema, entitySchema, entityTypes, fields, fieldPatterns, extendedFieldInfo, action, descriptionRetriever, output);
                    }
                }
                else
                {
                    if (propertySchema.FieldInstances != null)
                    {
                        foreach (var fieldInstancePair in propertySchema.FieldInstances)
                        {
                            fieldId = fieldInstancePair.Key;
                            if (descriptionRetriever != null)
                            {
                                try
                                {
                                    description = descriptionRetriever(fieldId);
                                }
                                catch
                                {
                                }
                            }
                            string modelPath = null;
                            if (fieldInstancePair.Value.Count != 1)
                            {
                                output?.WriteLine($"There must be just one field instance value for {fieldId}");
                            }
                            var fieldInstancePath = fieldInstancePair.Value[0];
                            if (fieldInstancePath == "Borrower" || fieldInstancePath == "Coborrower")
                            {
                                modelPath = $"{currentPath.Substring(0, currentPath.LastIndexOf('.'))}.{fieldInstancePath}.{propertyName}";
                            }
                            else
                            {
                                var firstUnderscore = fieldInstancePath.IndexOf('_');
                                var secondUnderscore = fieldInstancePath.IndexOf('_', firstUnderscore + 1);
                                var listPropertyName = fieldInstancePath.Substring(firstUnderscore + 1, secondUnderscore - firstUnderscore - 1);

                                var listPropertySchema = previousEntitySchema.Properties[listPropertyName];

                                Instance instance = null;
                                if (listPropertySchema.Instances?.TryGetValue(fieldInstancePath, out instance) == true)
                                {
                                    switch (instance)
                                    {
                                        case IntListInstance intListInstance:
                                            if (intListInstance.Count != 1)
                                            {
                                                output?.WriteLine($"There must be just one int list instance value for {fieldInstancePath}");
                                            }
                                            serializeWholeList = true;
                                            modelPath = $"{currentPath}[{intListInstance[0]}].{propertyName}";
                                            break;
                                        case StringListInstance stringListInstance:
                                            var index = 0;
                                            foreach (var s in stringListInstance)
                                            {
                                                var keyPropertyName = listPropertySchema.KeyProperties[index];
                                                requiredProperties.Add(keyPropertyName);
                                                var property = properties[keyPropertyName];
                                                var allowedValues = property.AllowedValues;
                                                if (allowedValues == null)
                                                {
                                                    allowedValues = new List<FieldOption>();
                                                    property.AllowedValues = allowedValues;
                                                }
                                                var option = new FieldOption(s);
                                                if (!allowedValues.Contains(option))
                                                {
                                                    allowedValues.Add(option);
                                                }
                                                ++index;
                                            }

                                            var tuples = stringListInstance.Select((s, i) => Tuple.Create(s, i)).Where(t => !string.IsNullOrEmpty(t.Item1));
                                            var pairs = tuples.OrderBy(t => listPropertySchema.KeyProperties[t.Item2]).Select(t => $"{listPropertySchema.KeyProperties[t.Item2]} == '{t.Item1}'");
                                            if (currentPath == "Loan.CurrentApplication.Income")
                                            {
                                                pairs = pairs.Concat(new[] { $"Id == '{string.Join("_", tuples.Select(t => t.Item1 == "OtherIncome" ? "Other" : t.Item1))}'" });
                                            }
                                            modelPath = $"{currentPath}[({string.Join(" && ", pairs)})].{propertyName}";
                                            break;
                                        case StringDictionaryInstance stringDictionaryInstance:
                                            foreach (var p in stringDictionaryInstance)
                                            {
                                                var keyPropertyName = p.Key;
                                                requiredProperties.Add(keyPropertyName);
                                                var property = properties[keyPropertyName];
                                                var allowedValues = property.AllowedValues;
                                                if (allowedValues == null)
                                                {
                                                    allowedValues = new List<FieldOption>();
                                                    property.AllowedValues = allowedValues;
                                                }
                                                var option = new FieldOption(p.Value);
                                                if (!allowedValues.Contains(option))
                                                {
                                                    allowedValues.Add(option);
                                                }
                                            }

                                            modelPath = $"{currentPath}[({string.Join(" && ", stringDictionaryInstance.OrderBy(p => p.Key).Select(p => $"{p.Key} == '{p.Value}'"))})].{propertyName}";
                                            break;
                                        default:
                                            output?.WriteLine($"Bad instance type for {fieldInstancePath}");
                                            break;
                                    }
                                }
                                else
                                {
                                    serializeWholeList = true;
                                    var colonIndex = fieldInstancePath.LastIndexOf(':');
                                    var index = 0;
                                    InstancePattern instancePattern = null;
                                    if (colonIndex < 0 || !int.TryParse(fieldInstancePath.Substring(colonIndex + 1), NumberStyles.None, null, out index) || listPropertySchema.InstancePatterns?.TryGetValue(fieldInstancePath.Substring(0, colonIndex), out instancePattern) != true)
                                    {
                                        output?.WriteLine($"[{fieldId}]: {fieldInstancePath}");
                                    }

                                    if (instancePattern.Match != null)
                                    {
                                        foreach (var p in instancePattern.Match)
                                        {
                                            var keyPropertyName = p.Key;
                                            requiredProperties.Add(keyPropertyName);
                                            var property = properties[keyPropertyName];
                                            var allowedValues = property.AllowedValues;
                                            if (allowedValues == null)
                                            {
                                                allowedValues = new List<FieldOption>();
                                                property.AllowedValues = allowedValues;
                                            }
                                            var option = new FieldOption(p.Value);
                                            if (!allowedValues.Contains(option))
                                            {
                                                allowedValues.Add(option);
                                            }
                                        }
                                    }

                                    modelPath = $"{currentPath.Substring(0, currentPath.LastIndexOf('.'))}.{listPropertyName}{(instancePattern.Match != null ? $"[({string.Join(" && ", instancePattern.Match.OrderBy(p => p.Key).Select(p => $"{p.Key} == '{p.Value}'"))})]" : string.Empty)}[{index}].{propertyName}";
                                }
                            }
                            var fieldInfo = new StandardFieldInfo { FieldId = fieldId, Description = description, ModelPath = modelPath };
                            fieldInfo.NonSerializedFormat = GetFormat(propertySchema);
                            if (extendedFieldInfo)
                            {
                                fieldInfo.Format = fieldInfo.NonSerializedFormat;
                                fieldInfo.Options = GetOptions(propertySchema);
                                fieldInfo.ReadOnly = propertySchema.ReadOnly == true;
                            }
                            fields.Add(fieldId, fieldInfo);
                        }
                    }
                    if (propertySchema.FieldPatterns != null)
                    {
                        var i = 1;
                        foreach (var fieldPatternPair in propertySchema.FieldPatterns)
                        {
                            var fieldPattern = fieldPatternPair.Key;
                            if (fieldPattern != "URLAROLNN06" && !fieldPattern.StartsWith("CUSTNN"))
                            {
                                serializeWholeList = true;
                                if (fieldPatternPair.Value.Count != 1)
                                {
                                    output?.WriteLine($"There must be just one field pattern value for {fieldPattern}");
                                }
                                var fieldPatternPath = fieldPatternPair.Value[0];

                                var firstUnderscore = fieldPatternPath.IndexOf('_');
                                var secondUnderscore = fieldPatternPath.IndexOf('_', firstUnderscore + 1);
                                var listPropertyName = fieldPatternPath.Substring(firstUnderscore + 1, secondUnderscore - firstUnderscore - 1);

                                var listPropertySchema = previousEntitySchema.Properties[listPropertyName];

                                var instancePattern = listPropertySchema.InstancePatterns[fieldPatternPath];

                                if (instancePattern.Match != null)
                                {
                                    foreach (var p in instancePattern.Match)
                                    {
                                        var keyPropertyName = p.Key;
                                        requiredProperties.Add(keyPropertyName);
                                        var property = properties[keyPropertyName];
                                        var allowedValues = property.AllowedValues;
                                        if (allowedValues == null)
                                        {
                                            allowedValues = new List<FieldOption>();
                                            property.AllowedValues = allowedValues;
                                        }
                                        var option = new FieldOption(p.Value);
                                        if (!allowedValues.Contains(option))
                                        {
                                            allowedValues.Add(option);
                                        }
                                    }
                                }

                                fieldId = fieldPattern.StartsWith("NBOCNB") ? fieldPattern.Replace("NBOCNB", "NBOC{0:00}") : fieldPattern.Replace("NN", "{0:00}");

                                if (descriptionRetriever != null)
                                {
                                    try
                                    {
                                        description = descriptionRetriever(string.Format(fieldId, 1));
                                        description = description.Replace(" #11", " #{0}").Replace(" #1", " #{0}");
                                    }
                                    catch
                                    {
                                    }
                                }

                                string modelPath;
                                if (fieldPatternPath == "Application_Assets_NN")
                                {
                                    modelPath = $"Loan.CurrentApplication.Assets[(VodIndex == '{{0}}')]{(propertySchema.FieldPatterns.Count == 4 ? $"[{i}]" : string.Empty)}.{propertyName}";
                                    requiredProperties.Add(nameof(Asset.VodIndex));
                                }
                                else
                                {
                                    modelPath = $"{currentPath.Substring(0, currentPath.LastIndexOf('.'))}.{listPropertyName}{(instancePattern.Match != null ? $"[({string.Join(" && ", instancePattern.Match.OrderBy(p => p.Key).Select(p => $"{p.Key} == '{p.Value}'"))})]" : string.Empty)}[{{0}}].{propertyName}";
                                }

                                var fieldInfo = new StandardFieldInfo { FieldId = fieldId, Description = description, ModelPath = modelPath };
                                fieldInfo.NonSerializedFormat = GetFormat(propertySchema);
                                if (extendedFieldInfo)
                                {
                                    fieldInfo.Format = fieldInfo.NonSerializedFormat;
                                    fieldInfo.Options = GetOptions(propertySchema);
                                    fieldInfo.ReadOnly = propertySchema.ReadOnly == true;
                                }
                                fieldPatterns.Add(fieldId, fieldInfo);
                            }
                            ++i;
                        }
                    }
                }
            }

            action?.Invoke(entityName, ellieType, entitySchema, requiredProperties, serializeWholeList);
        }

        private static LoanFieldFormat? GetFormat(PropertySchema propertySchema)
        {
            if (propertySchema.Format.EnumValue.HasValue)
            {
                return propertySchema.Format;
            }
            switch (propertySchema.Type.EnumValue)
            {
                case PropertySchemaType.Bool:
                    return LoanFieldFormat.YN;
                case PropertySchemaType.DateTime:
                    return LoanFieldFormat.DATETIME;
                case PropertySchemaType.Date:
                    return LoanFieldFormat.DATE;
                case PropertySchemaType.Int:
                    return LoanFieldFormat.INTEGER;
                case PropertySchemaType.String:
                case PropertySchemaType.Uuid:
                    return LoanFieldFormat.STRING;
                default:
                    return null;
            }
        }

        private static List<FieldOption> GetOptions(PropertySchema propertySchema)
        {
            return propertySchema.AllowedValues?.Where(o => !string.IsNullOrEmpty(o.Text) || !string.IsNullOrEmpty(o.Value)).Select(o => o.Value == "true" || o.Value == "false" ? new FieldOption(o.Value == "true" ? "Y" : "N", o.Text) : o).Distinct().ToList();
        }

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

        internal static FieldDescriptor GetFieldDescriptor(string fieldId, IDictionary<string, FieldDescriptor> customFields, UndefinedCustomFieldHandling undefinedCustomFieldHandling)
        {
            Preconditions.NotNullOrEmpty(fieldId, nameof(fieldId));

            if (!FieldMappings.TryGetDescriptor(fieldId, out var descriptor) && customFields?.TryGetValue(fieldId, out descriptor) != true && (!FieldPatternMappings.TryGetDescriptorForFieldId(fieldId, out descriptor) || (descriptor.Type == LoanFieldType.Custom && (undefinedCustomFieldHandling == UndefinedCustomFieldHandling.Error || (undefinedCustomFieldHandling == UndefinedCustomFieldHandling.ErrorIfCustomFieldsInitialized && (customFields?.Count ?? 0) != 0)))))
            {
                throw new ArgumentException($"Could not find field '{fieldId}'");
            }
            return descriptor;
        }

        /// <summary>
        /// Retrieves the field descriptor for the specified field id.
        /// </summary>
        /// <param name="fieldId">The field id of the field descriptor to get.</param>
        /// <returns></returns>
        public FieldDescriptor this[string fieldId] => GetFieldDescriptor(fieldId, CustomFields, Client.UndefinedCustomFieldHandling);

        /// <summary>
        /// The custom fields cache. To retrieve the Standard and Virtual fields use the static properties <see cref="StandardFields"/> and <see cref="VirtualFields"/> respectively.
        /// </summary>
        public ReadOnlyDictionary<string, FieldDescriptor> CustomFields => Client.CommonCache.CustomFields;

        /// <summary>
        /// The utc date and time custom fields were last refreshed.
        /// </summary>
        public DateTime? CustomFieldsLastRefreshedUtc => Client.CommonCache.CustomFieldsLastRefreshedUtc;

        internal LoanFieldDescriptors(EncompassRestClient client)
            : base(client, null)
        {
        }

        /// <summary>
        /// Refreshes the custom fields cache.
        /// </summary>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task RefreshCustomFieldsAsync(CancellationToken cancellationToken = default) => Client.CommonCache.RefreshCustomFieldsAsync(Client, cancellationToken);

        internal abstract class FieldInfo
        {
            [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
            public LoanFieldFormat? Format { get; set; }

            [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
            public List<FieldOption> Options { get; set; }

            public string FieldId { get; set; }

            public string Description { get; set; }
        }

        internal sealed class StandardFieldInfo : FieldInfo
        {
            public string ModelPath { get; set; }

            [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
            public bool? ReadOnly { get; set; }

            [JsonIgnore]
            public LoanFieldFormat? NonSerializedFormat { get; set; }
        }

        internal sealed class VirtualFieldInfo : FieldInfo
        {
        }
    }
}