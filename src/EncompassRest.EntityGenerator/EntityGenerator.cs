using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EncompassRest.Schema;
using EncompassRest.Tests;
using EnumsNET;
using EnumsNET.NonGeneric;
using EncompassRest.Loans.Enums;
using Newtonsoft.Json;
using System.IO.Compression;
using System.Globalization;

namespace EncompassRest
{
    public static class EntityGenerator
    {
        static EntityGenerator()
        {
            var sharedEnumTypes = new[]
            {
                typeof(YOrN),
                typeof(YNOrNA),
                typeof(YesOrNo),
                typeof(YesNoOrNA),
                typeof(TrueOrFalse),
                typeof(AcceptOrReject),
                typeof(IncreasedOrDecreased),
                typeof(UtilitiesDescription),
                typeof(TermType),
                typeof(SignedByTyp),
                typeof(TotalClosingCostRemark),
                typeof(PartyType),
                typeof(AUS),
                typeof(AUSRecommendation),
                typeof(BankruptcyForeclosureStatus),
                typeof(LicenseAuthType),
                typeof(BorContingentLiabilitiesLiabilityDescription),
                typeof(BorrowerType),
                typeof(ClosingCostFundsType),
                typeof(FundsTypeDescription),
                typeof(ClosingCostSourceType),
                typeof(SourceTypeDescription),
                typeof(DocsLoanProgramType),
                typeof(ServicingType),
                typeof(CorrespondentOptionDesc),
                typeof(CreditChargeType),
                typeof(DenialReason),
                typeof(DisclosureMethod),
                typeof(DownPaymentSourceType),
                typeof(YNOrOther),
                typeof(Hud1EsPayToFeeType),
                typeof(RefundableType),
                typeof(RecSamePtyTypeDesc),
                typeof(FeddieBorrowerAlienStatus),
                typeof(FreddieDownPaymentType),
                typeof(FullPrepaymentPenaltyOptionType),
                typeof(ATRQMStatus),
                typeof(ImpoundType),
                typeof(ClosingCostImpoundType),
                typeof(ImpoundWaived),
                typeof(IncludeOriginationPointsCreditType),
                typeof(InformationTypesWeCollect),
                typeof(ProjectType),
                typeof(MonthOrYear),
                typeof(CanGoOrGoes),
                typeof(OrgTyp),
                typeof(IsOrIsNot),
                typeof(LimitSharing),
                typeof(ScsrsClaus),
                typeof(CanIncreaseOrIncreases),
                typeof(LoanAmountType),
                typeof(LoanDocumentationType),
                typeof(LoanPurposeType),
                typeof(LoanType),
                typeof(RefinancePurpose),
                typeof(PropertyType),
                typeof(LienType),
                typeof(DoesOrDoesNot),
                typeof(DoesOrDoesNot2),
                typeof(OpenBankruptcy),
                typeof(InterestRateImpactedStatus),
                typeof(FeePaidBy),
                typeof(Owner),
                typeof(PaidBy),
                typeof(PaidType),
                typeof(PenaltyTerm),
                typeof(OccupancyIntent),
                typeof(PrepaymentPenaltyBasedOn),
                typeof(PropertyUsageType),
                typeof(PTB),
                typeof(DaysInYear),
                typeof(TypeOfPurchaser),
                typeof(RiskClassification),
                typeof(RoundingMethod),
                typeof(SignatureType),
                typeof(FinalSignatureType),
                typeof(SofDBorrowerAddressType),
                typeof(TimesToCollect),
                typeof(TrstSamePtyTypDesc),
                typeof(ProfitManagementItemType),
                typeof(UCDPayoffType),
                typeof(UlddBorrowerType),
                typeof(VestingTrusteeOfType),
                typeof(WholePocPaidByType),
                typeof(AmortizationType),
                typeof(ApplicationTakenMethodType),
                typeof(OtherPropertyType),
                typeof(RiskAssessmentType),
                typeof(ActionTaken),
                typeof(IndexMargin),
                typeof(PropertyFormType),
                typeof(Conversion),
                typeof(HmdaLoanPurpose)
            };
            s_sharedEnums = new Dictionary<string, HashSet<string>>();
            foreach (var sharedEnumType in sharedEnumTypes)
            {
                s_sharedEnums.Add(sharedEnumType.Name, new HashSet<string>(NonGenericEnums.GetMembers(sharedEnumType).Select(m => m.AsString(EnumFormat.EnumMemberValue, EnumFormat.Name))));
            }
        }

        private static readonly Dictionary<string, HashSet<string>> s_sharedEnums;

        private static readonly HashSet<string> s_enumPropertyNamesToUseNotExactSharedEnum = new HashSet<string>
        {
            "AUS2",
            "AUS3",
            "AUS4",
            "AUS5",
            "AUSRecommendation2",
            "AUSRecommendation3",
            "AUSRecommendation4",
            "AUSRecommendation5",
            "DenialReason2",
            "DenialReason3",
            "DenialReason4",
            "OriginationFeePaidBy",
            "ServicingFeePaidBy",
            "TransferFeePaidBy",
            "YSPPaidBy",
            "MIPremiumSourceType"
        };

        private static readonly HashSet<string> s_enumPropertyNamesToUseEntityTypeInName = new HashSet<string>
        {
            "PurposeOfLoan",
            "LoanType",
            "PropertyType",
            "FeeType",
            "RiskClass",
            "LoanPurpose",
            "BorrowerType",
            "MortgageOriginator",
            "AppraisalType"
        };

        private static readonly Dictionary<string, HashSet<string>> s_otherEnums = new Dictionary<string, HashSet<string>>();

        private static readonly HashSet<string> s_propertiesToNotGenerate = new HashSet<string> { "Loan.ElliUCDFields", "Loan.VirtualFields", "DocumentOrderLog.DocumentAudit", "Contact.Contact" };

        private static readonly HashSet<string> s_missingSchemaEntities = new HashSet<string> { "VirtualFields", "ElliUCDFields", "NonVols", "DocumentAudit" };

        private static readonly Dictionary<string, HashSet<string>> s_enumOptionsToIgnore = new Dictionary<string, HashSet<string>>
        {
            { "LoanDocumentationType", new HashSet<string> { "NoIncomeon1003" } }
        };

        public static void Main(string[] args)
        {
            try
            {
                Task.Run(async () =>
                {
                    using (var client = await TestBaseClass.GetTestClientAsync())
                    {
                        await GenerateFieldMappingsAsync(client, "Loans");
                        await GenerateClassFilesFromSchemaAsync(client, "Loans", "EncompassRest.Loans");
                    }
                }).Wait();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            Console.Write("Press Enter to End.");
            Console.ReadLine();
        }

        public static async Task GenerateFieldMappingsAsync(EncompassRestClient client, string destinationPath)
        {
            var loanSchema = await client.Schema.GetLoanSchemaAsync(true);
            var loanEntitySchema = loanSchema.EntityTypes["Loan"];
            var fields = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
            var fieldPatterns = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
            PopulateFieldMappings("Loan", loanEntitySchema, null, loanSchema, fields, fieldPatterns);

            var orderedFields = fields.OrderBy(p => p.Value.Substring(0, p.Value.LastIndexOfAny(new[] { '.', '[' }))).ThenBy(p => p.Value).ToList();
            fields = new Dictionary<string, string>();
            foreach (var pair in orderedFields)
            {
                fields[pair.Key] = pair.Value;
            }

            var orderedFieldPatterns = fieldPatterns.OrderBy(p => p.Value.Substring(0, p.Value.LastIndexOf('.'))).ThenBy(p => p.Value).ToList();
            fieldPatterns = new Dictionary<string, string>();
            foreach (var pair in orderedFieldPatterns)
            {
                fieldPatterns[pair.Key] = pair.Value;
            }

            using (var fs = new FileStream("LoanFields.json", FileMode.Create))
            {
                using (var sw = new StreamWriter(fs))
                {
                    JsonSerializer.Create(new JsonSerializerSettings { Formatting = Formatting.Indented }).Serialize(sw, fields);
                }
            }

            using (var fs = new FileStream("LoanFieldPatterns.json", FileMode.Create))
            {
                using (var sw = new StreamWriter(fs))
                {
                    JsonSerializer.Create(new JsonSerializerSettings { Formatting = Formatting.Indented }).Serialize(sw, fieldPatterns);
                }
            }

            using (var fs = new FileStream("LoanFields.zip", FileMode.Create))
            {
                using (var zip = new ZipArchive(fs, ZipArchiveMode.Create))
                {
                    var serializer = JsonSerializer.Create();

                    var loanFieldsEntry = zip.CreateEntry("LoanFields.json", CompressionLevel.Optimal);
                    using (var sw = new StreamWriter(loanFieldsEntry.Open()))
                    {
                        serializer.Serialize(sw, fields);
                    }

                    var loanFieldPatternsEntry = zip.CreateEntry("LoanFieldPatterns.json", CompressionLevel.Optimal);
                    using (var sw = new StreamWriter(loanFieldPatternsEntry.Open()))
                    {
                        serializer.Serialize(sw, fieldPatterns);
                    }

                    var virtualFieldsEntry = zip.CreateEntry("VirtualFields.json", CompressionLevel.Optimal);
                    using (var sw = new StreamWriter(virtualFieldsEntry.Open()))
                    {
                        using (var virtualFieldsFs = new FileStream("VirtualFields.json", FileMode.Open))
                        {
                            using (var sr = new StreamReader(virtualFieldsFs))
                            {
                                using (var jr = new JsonTextReader(sr))
                                {
                                    var virtualFields = serializer.Deserialize<List<string>>(jr);
                                    serializer.Serialize(sw, virtualFields);
                                }
                            }
                        }
                    }

                    var virtualFieldPatternsEntry = zip.CreateEntry("VirtualFieldPatterns.json", CompressionLevel.Optimal);
                    using (var sw = new StreamWriter(virtualFieldPatternsEntry.Open()))
                    {
                        using (var virtualFieldPatternsFs = new FileStream("VirtualFieldPatterns.json", FileMode.Open))
                        {
                            using (var sr = new StreamReader(virtualFieldPatternsFs))
                            {
                                using (var jr = new JsonTextReader(sr))
                                {
                                    var virtualFieldPatterns = serializer.Deserialize<List<string>>(jr);
                                    serializer.Serialize(sw, virtualFieldPatterns);
                                }
                            }
                        }
                    }
                }
            }
        }

        private static void PopulateFieldMappings(string currentPath, EntitySchema entitySchema, EntitySchema previousEntitySchema, LoanSchema loanSchema, Dictionary<string, string> fields, Dictionary<string, string> fieldPatterns)
        {
            foreach (var pair in entitySchema.Properties)
            {
                var propertyName = pair.Key;
                var propertySchema = pair.Value;
                if (!string.IsNullOrEmpty(propertySchema.FieldId))
                {
                    fields.Add(propertySchema.FieldId, $"{currentPath}.{propertyName}");
                }
                else if (propertySchema.Type == PropertySchemaType.Entity && loanSchema.EntityTypes.TryGetValue(propertySchema.EntityType, out var nestedEntitySchema))
                {
                    loanSchema.EntityTypes.Remove(propertySchema.EntityType);
                    PopulateFieldMappings($"{currentPath}.{propertyName}", nestedEntitySchema, entitySchema, loanSchema, fields, fieldPatterns);
                }
                else if ((propertySchema.Type == PropertySchemaType.List || propertySchema.Type == PropertySchemaType.Set) && loanSchema.EntityTypes.TryGetValue(propertySchema.ElementType, out var elementEntitySchema))
                {
                    loanSchema.EntityTypes.Remove(propertySchema.ElementType);
                    PopulateFieldMappings($"{currentPath}.{propertyName}", elementEntitySchema, entitySchema, loanSchema, fields, fieldPatterns);
                }
                else
                {
                    if (propertySchema.FieldInstances != null)
                    {
                        foreach (var fieldInstancePair in propertySchema.FieldInstances)
                        {
                            var fieldId = fieldInstancePair.Key;
                            if (fieldInstancePair.Value.Count != 1)
                            {
                                Console.WriteLine($"There must be just one field instance value for {fieldId}");
                            }
                            var fieldInstancePath = fieldInstancePair.Value[0];
                            if (fieldInstancePath == "Borrower" || fieldInstancePath == "Coborrower")
                            {
                                fields.Add(fieldId, $"{currentPath.Substring(0, currentPath.LastIndexOf('.'))}.{fieldInstancePath}.{propertyName}");
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
                                                Console.WriteLine($"There must be just one int list instance value for {fieldInstancePath}");
                                            }
                                            fields.Add(fieldId, $"{currentPath}[{intListInstance[0]}].{propertyName}");
                                            break;
                                        case StringListInstance stringListInstance:
                                            fields.Add(fieldId, $"{currentPath}[({string.Join(" && ", stringListInstance.Select((s, i) => (s, i)).Where(t => !string.IsNullOrEmpty(t.s)).Select(t => $"{listPropertySchema.KeyProperties[t.i]} == '{t.s}'"))})].{propertyName}");
                                            break;
                                        case StringDictionaryInstance stringDictionaryInstance:
                                            fields.Add(fieldId, $"{currentPath}[({string.Join(" && ", stringDictionaryInstance.Select(p => $"{p.Key} == '{p.Value}'"))})].{propertyName}");
                                            break;
                                        default:
                                            Console.WriteLine($"Bad instance type for {fieldInstancePath}");
                                            break;
                                    }
                                }
                                else
                                {
                                    var colonIndex = fieldInstancePath.LastIndexOf(':');
                                    var index = 0;
                                    InstancePattern instancePattern = null;
                                    if (colonIndex < 0 || !int.TryParse(fieldInstancePath.Substring(colonIndex + 1), NumberStyles.None, null, out index) || listPropertySchema.InstancePatterns?.TryGetValue(fieldInstancePath.Substring(0, colonIndex), out instancePattern) != true)
                                    {
                                        Console.WriteLine($"[{fieldId}]: {fieldInstancePath}");
                                    }

                                    fields.Add(fieldId, $"{currentPath.Substring(0, currentPath.LastIndexOf('.'))}.{listPropertyName}{(instancePattern.Match != null ? $"[({string.Join(" && ", instancePattern.Match.Select(p => $"{p.Key} == '{p.Value}'"))})]" : string.Empty)}[{index}].{propertyName}");
                                }
                            }
                        }
                    }
                    if (propertySchema.FieldPatterns != null)
                    {
                        foreach (var fieldPatternPair in propertySchema.FieldPatterns)
                        {
                            var fieldPattern = fieldPatternPair.Key;
                            if (!fieldPattern.StartsWith("DDNN") && !fieldPattern.StartsWith("FBENN") && !fieldPattern.StartsWith("FCENN") && !fieldPattern.StartsWith("CUSTNN"))
                            {
                                if (fieldPatternPair.Value.Count != 1)
                                {
                                    Console.WriteLine($"There must be just one field pattern value for {fieldPattern}");
                                }
                                var fieldPatternPath = fieldPatternPair.Value[0];

                                var firstUnderscore = fieldPatternPath.IndexOf('_');
                                var secondUnderscore = fieldPatternPath.IndexOf('_', firstUnderscore + 1);
                                var listPropertyName = fieldPatternPath.Substring(firstUnderscore + 1, secondUnderscore - firstUnderscore - 1);

                                var listPropertySchema = previousEntitySchema.Properties[listPropertyName];

                                var instancePattern = listPropertySchema.InstancePatterns[fieldPatternPath];

                                fieldPatterns.Add(fieldPattern.Replace("NN", "{0:00}"), $"{currentPath.Substring(0, currentPath.LastIndexOf('.'))}.{listPropertyName}{(instancePattern.Match != null ? $"[({string.Join(" && ", instancePattern.Match.Select(p => $"{p.Key} == '{p.Value}'"))})]" : string.Empty)}[{{0}}].{propertyName}");
                            }
                        }
                    }
                }
            }
        }

        public static async Task GenerateClassFilesFromSchemaAsync(EncompassRestClient client, string destinationPath, string @namespace)
        {
            Directory.CreateDirectory(destinationPath);
            var supportedEntities = new HashSet<string>((await client.Loans.GetSupportedEntitiesAsync().ConfigureAwait(false)).Select(e => e.Value))
            {
                "NonVol",
                "DocumentAudit"
            };
            var exceptions = new List<Exception>();
            foreach (var entity in supportedEntities)
            {
                Exception exception;
                var tryCount = 0;
                do
                {
                    exception = null;
                    try
                    {
                        var loanSchema = await client.Schema.GetLoanSchemaAsync(true, new[] { entity }).ConfigureAwait(false);

                        if (loanSchema.EntityTypes.TryGetValue(entity, out var entitySchema))
                        {
                            await GenerateClassFileFromSchemaAsync(destinationPath, @namespace, entity, entitySchema).ConfigureAwait(false);
                            if (s_missingSchemaEntities.Contains(entity))
                            {
                                Console.WriteLine($"Schema for {entity} can now be retrieved");
                            }
                        }
                        else
                        {
                            Console.WriteLine($"Failed to retrieve entity of type {entity}");
                        }
                    }
                    catch (Exception ex)
                    {
                        if (!s_missingSchemaEntities.Contains(entity))
                        {
                            exception = new Exception(entity, ex);
                        }
                    }
                    ++tryCount;
                } while (exception != null && tryCount < 3);
                if (exception != null)
                {
                    exceptions.Add(exception);
                }
            }
            foreach (var enumPair in s_sharedEnums.Concat(s_otherEnums))
            {
                foreach (var innerEnumPair in s_otherEnums)
                {
                    if (enumPair.Key != innerEnumPair.Key && innerEnumPair.Value.IsSubsetOf(enumPair.Value))
                    {
                        if (innerEnumPair.Value.SetEquals(enumPair.Value))
                        {
                            Console.WriteLine($"{enumPair.Key} and {innerEnumPair.Key} are equal");
                        }
                        else
                        {
                            var diff = enumPair.Value.Except(innerEnumPair.Value).ToList();
                            if (diff.Count <= 2)
                            {
                                Console.WriteLine($"{enumPair.Key} contains all members of {innerEnumPair.Key} but adds {string.Join(", ", diff)}");
                            }
                        }
                    }
                }
            }
            var enumsPath = $"{destinationPath}\\Enums";
            Directory.CreateDirectory(enumsPath);
            foreach (var pair in s_sharedEnums.Concat(s_otherEnums))
            {
                await GenerateEnumFileFromOptions(enumsPath, $"{@namespace}.Enums", pair.Key, pair.Value).ConfigureAwait(false);
            }
            if (exceptions.Count > 0)
            {
                throw new AggregateException(exceptions);
            }
        }

        private static async Task GenerateClassFileFromSchemaAsync(string destinationPath, string @namespace, string entityType, EntitySchema entitySchema)
        {
            var sb = new StringBuilder();
            sb.Append(
$@"#pragma warning disable 1591
using System;
using System.Collections.Generic;
using {@namespace}.Enums;

namespace {@namespace}
{{
    public sealed partial class {entityType} : ExtensibleObject, IIdentifiable
    {{
");

            var properties = new List<(string Name, string FieldName, bool IsEntity, bool IsCollection)>();

            foreach (var pair in entitySchema.Properties.OrderBy(pair => pair.Key, StringComparer.OrdinalIgnoreCase))
            {
                var propertyName = pair.Key;
                var entityPropertyName = $"{entityType}.{propertyName}";
                if (!s_propertiesToNotGenerate.Contains(entityPropertyName))
                {
                    var propertySchema = pair.Value;
                    var propertyType = GetPropertyOrElementType(entityType, propertyName, propertySchema, out var isEntity, out var isCollection);
                    var hasOptions = propertyType == "string" && propertySchema.AllowedValues?.Count > 0;
                    if (hasOptions)
                    {
                        var optionValues = new HashSet<string>(propertySchema.AllowedValues.Select(o => o.Value).Where(v => !string.IsNullOrEmpty(v)));
                        if (s_enumOptionsToIgnore.TryGetValue(propertyName, out var ignoredOptions))
                        {
                            optionValues.ExceptWith(ignoredOptions);
                        }
                        string enumName = null;
                        foreach (var enumPair in s_sharedEnums)
                        {
                            if (s_enumPropertyNamesToUseNotExactSharedEnum.Contains(propertyName) ? optionValues.IsSubsetOf(enumPair.Value) : optionValues.SetEquals(enumPair.Value))
                            {
                                enumName = enumPair.Key;
                                break;
                            }
                        }
                        if (enumName == null)
                        {
                            enumName = GetEnumName(entityType, propertyName);
                            if (s_otherEnums.TryGetValue(enumName, out var enumValues))
                            {
                                Console.WriteLine($"{entityType} Duplicate {enumName}: `{string.Join(", ", optionValues)}` - `{string.Join(", ", enumValues)}`");
                            }
                            else if (s_sharedEnums.TryGetValue(enumName, out enumValues))
                            {
                                Console.WriteLine($"{entityType} Shared Duplicate {enumName}: `{string.Join(", ", optionValues)}` - `{string.Join(", ", enumValues)}`");
                            }
                            else
                            {
                                s_otherEnums.Add(enumName, optionValues);
                            }
                        }
                        propertyType = $"StringEnumValue<{enumName}>";
                    }
                    var elementType = propertyType;
                    if (isCollection)
                    {
                        propertyType = $"DirtyList<{elementType}>";
                    }
                    var isModelPath = propertyName == "ModelPath";
                    var fieldName = $"_{char.ToLower(propertyName[0])}{propertyName.Substring(1)}";
                    if (isModelPath)
                    {
                        sb.AppendLine("        internal ModelPath _modelPathInternal;");
                    }
                    sb.AppendLine($"        {(isModelPath ? "internal" : "private")} {(isEntity || isCollection ? propertyType : $"DirtyValue<{propertyType}>")} {fieldName};");
                    properties.Add((propertyName, fieldName, isEntity, isCollection));
                    sb.AppendLine($"        public {(isCollection ? $"IList<{elementType}>" : propertyType)} {propertyName} {{ get => {fieldName}{(isEntity || isCollection ? $" ?? ({fieldName} = new {propertyType}())" : string.Empty)}; set {(isModelPath ? "{ _modelPath = value; _modelPathInternal = LoanFields.CreateModelPath(value); }" : $"=> {fieldName} = {(isCollection ? $"new {propertyType}(value)" : "value")};")} }}");
                }
            }

            // Sorts non entity types first
            properties = properties.OrderBy(property => property.IsEntity || property.IsCollection).ToList();

            sb.Append(
$@"        internal override bool DirtyInternal
        {{
            get
            {{
                return {string.Join($"{Environment.NewLine}                    || ", properties.Select(property => $"{property.FieldName}{(property.IsEntity || property.IsCollection ? "?.Dirty == true" : ".Dirty")}"))};
            }}
            set
            {{
                {string.Join($"{Environment.NewLine}                ", properties.Select(property =>
                    {
                        var propertyName = property.FieldName;
                        if (property.IsEntity || property.IsCollection)
                        {
                            return $"if ({propertyName} != null) {propertyName}.Dirty = value;";
                        }
                        return $"{propertyName}.Dirty = value;";
                    }))}
            }}
        }}
    }}
}}");
            using (var sw = new StreamWriter(Path.Combine(destinationPath, entityType + ".cs")))
            {
                await sw.WriteAsync(sb.ToString()).ConfigureAwait(false);
            }
        }

        private static async Task GenerateEnumFileFromOptions(string destinationPath, string @namespace, string enumName, IEnumerable<string> options)
        {
            var sb = new StringBuilder();
            sb.AppendLine(
$@"using System.Runtime.Serialization;

namespace {@namespace}
{{
    public enum {enumName}
    {{");

            var enumMemberNames = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
            var existingEnumType = typeof(EncompassRestClient).Assembly.GetType($"{@namespace}.{enumName}");
            var existingEnumValues = new HashSet<int>();
            var optionsSet = new HashSet<string>(options);
            var first = true;
            if (existingEnumType != null)
            {
                foreach (var member in NonGenericEnums.GetMembers(existingEnumType))
                {
                    if (!first)
                    {
                        sb.AppendLine(",");
                    }
                    var enumMemberValue = member.AsString(EnumFormat.EnumMemberValue);
                    if (enumMemberValue != null)
                    {
                        sb.AppendLine($@"        [EnumMember(Value = ""{enumMemberValue.Replace("\"", "\\\"")}"")]");
                    }
                    var name = member.Name;
                    enumMemberNames.Add(name);
                    optionsSet.Remove(enumMemberValue ?? name);
                    var intValue = member.ToInt32();
                    existingEnumValues.Add(intValue);
                    sb.Append($"        {name} = {intValue}");
                    first = false;
                }
            }
            var i = 0;
            foreach (var option in optionsSet)
            {
                while (existingEnumValues.Contains(i))
                {
                    ++i;
                }
                if (!first)
                {
                    sb.AppendLine(",");
                }
                var nameBuilder = new StringBuilder(option.Length);
                var startWord = true;
                for (var j = 0; j < option.Length; ++j)
                {
                    var c = option[j];
                    if (j == 0 && char.IsDigit(c))
                    {
                        nameBuilder.Append('n');
                    }
                    if (!char.IsLetterOrDigit(c))
                    {
                        if (!startWord && c != '\'')
                        {
                            startWord = true;
                        }
                    }
                    else
                    {
                        if (startWord)
                        {
                            c = char.ToUpper(c);
                            startWord = false;
                        }
                        nameBuilder.Append(c);
                    }
                }
                var name = nameBuilder.ToString();
                if (name.Length > 0 && enumMemberNames.Add(name))
                {
                    if (name != option)
                    {
                        sb.AppendLine($@"        [EnumMember(Value = ""{option.Replace("\"", "\\\"")}"")]");
                    }
                    sb.Append($"        {name} = {i}");
                    first = false;
                    ++i;
                }
                else if (i > 0)
                {
                    sb.Length -= 1 + Environment.NewLine.Length;
                }
            }
            sb.AppendLine();

            sb.Append(
@"    }
}");
            using (var sw = new StreamWriter(Path.Combine(destinationPath, enumName + ".cs")))
            {
                await sw.WriteAsync(sb.ToString()).ConfigureAwait(false);
            }
        }

        private static string GetPropertyOrElementType(string entityType, string propertyName, PropertySchema propertySchema, out bool isEntity, out bool isCollection)
        {
            isEntity = false;
            isCollection = false;
            var propertyType = propertySchema.Type;
            switch (propertyType.EnumValue)
            {
                case PropertySchemaType.String:
                case PropertySchemaType.Uuid:
                    return "string";
                case PropertySchemaType.NADecimal:
                    return "NA<decimal>";
                case PropertySchemaType.Decimal:
                case PropertySchemaType.Bool:
                case PropertySchemaType.Int:
                    return $"{propertyType}?";
                case PropertySchemaType.Date:
                case PropertySchemaType.DateTime:
                    return "DateTime?";
                case PropertySchemaType.Set:
                case PropertySchemaType.List:
                    isCollection = true;
                    return propertySchema.ElementType;
                case PropertySchemaType.Entity:
                    isEntity = true;
                    var propertyEntityType = propertySchema.EntityType.Value;
                    return propertyEntityType == "EntityRefContract" ? "EntityReference" : propertyEntityType;
                default:
                    return $"PROBLEM<{propertyType}>";
            }
        }

        private static string GetEnumName(string entityType, string propertyName) => s_enumPropertyNamesToUseEntityTypeInName.Contains(propertyName) ? $"{entityType}{propertyName}" : propertyName;
    }
}