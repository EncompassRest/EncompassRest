using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EncompassRest.Loans;
using EncompassRest.Loans.Enums;
using EncompassRest.Loans.v3;
using EncompassRest.Schema;
using EncompassRest.Schema.v3;
using EncompassRest.Tests;
using EnumsNET;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace EncompassRest;

public static class EntityGenerator
{
    private static readonly Dictionary<string, HashSet<string>> _ignoredProperties = new()
    {
        { nameof(FundingFee), new() { "tag" } },
        { nameof(CustomField), new() { "value" } },
        { nameof(AdditionalStateDisclosure), new() { "disclosureValue" } }
    };

    private static readonly HashSet<string> _ignoredEntities = new()
    {
        "Entity",
        "Primitive",
        "NaDecimal"
    };

    private static readonly Dictionary<string, Dictionary<string, HashSet<string>>> _enumOptionsToRemove = new()
    {
        { nameof(DownPayment), new() { { nameof(DownPayment.DownPaymentType), new() { "DepositOnSales Contract" } } } },
        { nameof(LoanProductData), new() { { nameof(LoanProductData.LoanDocumentationType), new() { "NoIncomeon1003" } } } },
        { nameof(RateLock), new() { { nameof(RateLock.LoanDocumentationType), new() { "NoIncomeon1003" } } } }
    };

    private static readonly Dictionary<string, HashSet<string>> _enumPropertyNamesToUseNotExactSharedEnum = new(StringComparer.OrdinalIgnoreCase)
    {
        { nameof(Hmda), new() { nameof(Hmda.Aus2), nameof(Hmda.Aus3), nameof(Hmda.Aus4), nameof(Hmda.Aus5), nameof(Hmda.AusRecommendation2), nameof(Hmda.AusRecommendation3), nameof(Hmda.AusRecommendation4), nameof(Hmda.AusRecommendation5), nameof(Hmda.DenialReason2), nameof(Hmda.DenialReason3), nameof(Hmda.DenialReason4) } },
        { nameof(AdditionalStateDisclosure), new() { nameof(AdditionalStateDisclosure.StateCode) } },
        { nameof(Asset), new() { nameof(Asset.AssetType) } },
        { nameof(AusTracking), new() { nameof(AusTracking.DuPropertyType), nameof(AusTracking.LpPropertyType) } },
        { nameof(Borrower), new() { nameof(Borrower.HmdaCreditScoreForDecisionMaking), nameof(Borrower.HmdaCreditScoringModel) } },
        { nameof(Contact), new() { nameof(Contact.InsuranceProjectType) } },
        { nameof(CustomField), new() { nameof(CustomField.Format) } },
        { nameof(EntityReference), new() { nameof(EntityReference.EntityType) } },
        { nameof(Gfe2010Fee), new() { nameof(Gfe2010Fee.Gfe2010FeeType) } },
        { nameof(LoanAssociate), new() { nameof(LoanAssociate.LoanAssociateType) } },
        { nameof(LoanEstimate1), new() { nameof(LoanEstimate1.AdjustsTermType), nameof(LoanEstimate1.PrepaymentPenaltyPayOffInDateType) } },
        { nameof(Property), new() { nameof(Property.PropertyRightsType) } },
        { nameof(Tsum), new() { nameof(Tsum.PropertyFormType) } },
        { nameof(Uldd), new() { nameof(Uldd.ClosingCostFundsTypeOtherDescription), nameof(Uldd.ClosingCost2FundsTypeOtherDescription), nameof(Uldd.ClosingCost3FundsTypeOtherDescription), nameof(Uldd.ClosingCost4FundsTypeOtherDescription), nameof(Uldd.DownPaymentOtherTypeDescription), nameof(Uldd.FreddieMortgageType), nameof(Uldd.FannieMortgageType) } },
        { nameof(VodItem), new() { nameof(VodItem.Type) } },
        { nameof(Vol), new() { nameof(Vol.LiabilityType), nameof(Vol.MortgageType) } }
    };

    private static readonly Dictionary<string, HashSet<string>> _enumPropertyNamesToIgnoreSharedEnums = new(StringComparer.OrdinalIgnoreCase)
    {
    };

    private static readonly HashSet<string> _entityReferenceProperties = new(typeof(EntityReference).GetProperties().Select(p => p.Name), StringComparer.OrdinalIgnoreCase);

    private static readonly HashSet<string> _enumPropertyNamesToUseEntityTypeInName = new(StringComparer.OrdinalIgnoreCase)
    {
    };

    private static readonly Dictionary<string, Dictionary<string, Type>> s_explicitStringEnumValues = new()
    {
        { nameof(MilestoneTaskContact), new() { { nameof(MilestoneTaskContact.State), typeof(State) } } },
        { nameof(Miscellaneous), new() { { nameof(Miscellaneous.State), typeof(State) } } },
        { nameof(Correspondent), new() { { nameof(Correspondent.ProjectClass), typeof(ProjectType) } } },
        { nameof(Valuation), new() { { nameof(Valuation.StatedPropertyType), typeof(PropertyType) } } },
        { nameof(Document), new() { { nameof(Document.Status), typeof(DocumentStatus) } } }
    };

    public static async Task Main()
    {
        try
        {
            EntitySchema loanSchema;
            var standardFields = new List<StandardFieldSchema>();
            using (var client = await TestBaseClass.GetTestClientAsync().ConfigureAwait(false))
            {
                loanSchema = await client.Schema.GetLoanSchemaAsync(true).ConfigureAwait(false);
                int start;
                const int limit = 10000;
                do
                {
                    start = standardFields.Count;
                    var newFields = await client.Schema.GetStandardFieldSchemaAsync(null, start, limit);
                    standardFields.AddRange(newFields);
                } while (standardFields.Count > start);
            }

            foreach (var pair in s_explicitStringEnumValues)
            {
                var entity = loanSchema.Definitions.TryGetValue(pair.Key, out var s) || loanSchema.Definitions.TryGetValue(pair.Key + "Contract", out s) ? s : null;
                if (entity == null)
                {
                    Console.WriteLine($"Could not find {pair.Key} for setting an explicit StringEnumValue property");
                    continue;
                }
                foreach (var p in pair.Value)
                {
                    var prop = entity.Properties[$"{char.ToLower(p.Key[0])}{p.Key.Substring(1)}"];
                    if (prop.Enum?.Count > 0)
                    {
                        Console.WriteLine($"Already found some enum values for {pair.Key}.{p.Key}");
                    }
                    prop.Enum = Enums.GetMembers(p.Value).Select(m => m.AsString(EnumFormat.EnumMemberValue, EnumFormat.Name)).ToList();
                }
            }

            loanSchema.Definitions["ApplicationReferenceContract"].Title = "ApplicationReference";
            loanSchema.Definitions.Remove("LogSnapshotField");
            loanSchema.Properties.Add("currentApplication", new() { Ref = "#/definitions/ApplicationContract" });
            loanSchema.Definitions["EmploymentContract"].Properties.Add("owner", new() { Type = new() { SchemaType.String, SchemaType.Null }, Enum = new() { "Borrower", "CoBorrower" } });
            loanSchema.Definitions["ResidenceContract"].Properties.Add("applicantType", new() { Type = new() { SchemaType.String, SchemaType.Null }, Enum = new() { "Borrower", "CoBorrower" } });

            foreach (var field in standardFields)
            {
                var lastPeriodIndex = field.ContractPath.LastIndexOf('.');
                var propertyName = field.ContractPath.Substring(lastPeriodIndex + 1);
                var entity = loanSchema;
                var path = field.ContractPath.Substring(5, lastPeriodIndex - 4);
                while (path.Length > 0)
                {
                    var endOfPnameIndex = path.IndexOfAny(new[] { '.', '[' });
                    var propName = path.Substring(0, endOfPnameIndex);
                    if (!entity!.Properties.TryGetValue(propName, out var prop))
                    {
                        entity = null;
                        Console.WriteLine($"Could not find field [{field.Id}] path {field.ContractPath}");
                        break;
                    }
                    var @ref = prop.Ref;
                    if (string.IsNullOrEmpty(@ref))
                    {
                        @ref = prop.Items!.Ref;
                    }
                    var defName = @ref!.Substring(@ref.LastIndexOf('/') + 1);
                    entity = loanSchema.Definitions.TryGetValue(defName, out var s) || loanSchema.Definitions.TryGetValue(defName + "Contract", out s) ? s : null;
                    if (entity == null)
                    {
                        entity = null;
                        Console.WriteLine($"Could not find field [{field.Id}] path {field.ContractPath}");
                        break;
                    }
                    path = path.Substring(path.IndexOf('.', endOfPnameIndex) + 1);
                }
                if (entity?.Properties.TryGetValue(propertyName, out var property) != true)
                {
                    Console.WriteLine($"Could not find field [{field.Id}] path {field.ContractPath}");
                    continue;
                }
                if (!property.ExtensionData.TryGetValue("Fields", out var fields))
                {
                    fields = new List<StandardFieldSchema>();
                    property.ExtensionData.Add("Fields", fields);
                }
                ((List<StandardFieldSchema>)fields!).Add(field);
            }

            loanSchema.Properties.Remove("currentApplication");

            var destinationPath = "Generated\\Loans\\v3";
            var @namespace = "EncompassRest.Loans.v3";
            Directory.CreateDirectory(destinationPath);
            Directory.CreateDirectory("Generated\\Loans\\Enums");

            GenerateEnumFileFromOptions(destinationPath, @namespace, "LoanEntityFilterKey", standardFields.Select(f => f.EntitiesFilterKey.Value).Distinct().Where(v => v != null).Concat(new[] { "loan" }).OrderBy(v => v).ToDictionary(v => v!, v => v!));

            var enumTypes = typeof(ActionTaken).Assembly.GetTypes()
                .Concat(typeof(ConditionStatus).Assembly.GetTypes())
                .Where(t => t.IsPublic && t.IsEnum && t.Namespace == "EncompassRest.Loans.Enums")
                .Concat(new[] { typeof(State), typeof(LoanFieldFormat), typeof(EntityType), typeof(DocumentStatus) })
                .Select(e =>
                    new KeyValuePair<Type, HashSet<string>>(e, new HashSet<string>(
                        Enums.GetMembers(e).Select(m => m.AsString(EnumFormat.EnumMemberValue, EnumFormat.Name)!))))
                .ToDictionary(p => p.Key, p => p.Value);

            foreach (var p1 in enumTypes)
            {
                foreach (var p2 in enumTypes)
                {
                    if (p1.Key.Name.CompareTo(p2.Key.Name) > 0 && p1.Value.SetEquals(p2.Value))
                    {
                        Console.WriteLine($"{p1.Key} is identical to {p2.Key}");
                    }
                }
            }

            var entityNames = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
            var definitions = loanSchema.Definitions.Concat(new[] { new KeyValuePair<string, EntitySchema>("Loan", loanSchema) }).ToDictionary(p => p.Key, p => p.Value);
            foreach (var definition in definitions)
            {
                GenerateClass(definition.Key, definition.Value, definitions, destinationPath, @namespace, entityNames, enumTypes);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
        }
        Console.Write("Press Enter to End.");
        Console.ReadLine();
    }

    private static void GenerateClass(string key, EntitySchema entitySchema, Dictionary<string, EntitySchema> definitions, string destinationPath, string @namespace, HashSet<string> entityNames, Dictionary<Type, HashSet<string>> enumTypes)
    {
        var fields = new StringBuilder();
        var properties = new StringBuilder();
        var entityName = GetEntityName(key, entitySchema);

        if (_ignoredEntities.Contains(entityName))
        {
            return;
        }

        // Check for duplicate entity names
        if (!entityNames.Add(entityName))
        {
            Console.WriteLine($"Duplicate {entityName}");
        }

        if (entitySchema.Type.First() != SchemaType.Object)
        {
            Console.WriteLine($"First type of {entityName} is {entitySchema.Type.First()}");
        }

        var entityReferenceDerived = false;
        var isEntityReference = false;
        var isFileAttachmentReference = false;
        if (entityName.EndsWith("Reference"))
        {
            entityReferenceDerived = entityName != "EntityReference";
            isEntityReference = !entityReferenceDerived;
            isFileAttachmentReference = entityName == "FileAttachmentReference";
        }

        var serializeWholeList = false;

        var systemNamespace = false;
        var collectionsNamespace = false;
        var enumsNamespace = false;
        var schemaNamespace = false;
        var codeAnalysisNamespace = false;

        if (entitySchema.Properties != null)
        {
            _ignoredProperties.TryGetValue(entityName, out var ignoredProperties);
            foreach (var pair in entitySchema.Properties.OrderBy(p => p.Key, StringComparer.OrdinalIgnoreCase))
            {
                if (ignoredProperties?.Contains(pair.Key) != true && (!entityReferenceDerived || !_entityReferenceProperties.Contains(pair.Key)))
                {
                    var propertyName = $"{char.ToUpper(pair.Key[0])}{pair.Key.Substring(1)}";
                    var propertySchema = pair.Value;
                    var standardFields = propertySchema.ExtensionData.TryGetValue("Fields", out var f) ? (List<StandardFieldSchema>)f! : null;
                    var type = GetPropertyOrElementType(pair.Value, definitions, out var isEntity, out var isList);
                    var attributeProperties = new List<string>();

                    var defaultField = standardFields?.FirstOrDefault();
                    Dictionary<string, string>? optionValues = null;
                    if (standardFields != null)
                    {
                        optionValues = new Dictionary<string, string>();
                        foreach (var field in standardFields)
                        {
                            if (field.ContractPath.Contains("%"))
                            {
                                serializeWholeList = true;
                            }
                            if (field.Options != null)
                            {
                                foreach (var option in field.Options)
                                {
                                    optionValues[option.Value] = option.Text;
                                }
                            }
                        }
                        if (optionValues.Count == 0)
                        {
                            optionValues = null;
                        }
                    }

                    if (standardFields?.All(f => f.Format.Value == defaultField!.Format.Value) == true)
                    {
                        if (defaultField!.Format.EnumValue is not LoanFieldFormat.STATE and not LoanFieldFormat.DECIMAL_2 and not LoanFieldFormat.DATE and not LoanFieldFormat.INTEGER and not LoanFieldFormat.STRING and not LoanFieldFormat.YN)
                        {
                            attributeProperties.Add($"Format = LoanFieldFormat.{defaultField.Format.EnumValue?.GetName()}");
                            schemaNamespace = true;
                        }
                    }

                    if (type == "DateTime?")
                    {
                        systemNamespace = true;
                    }
                    else if (optionValues != null || propertySchema.Enum?.Count > 0)
                    {
                        var enumValues = new List<string>();
                        if (optionValues != null)
                        {
                            foreach (var p in optionValues)
                            {
                                if ((!string.IsNullOrEmpty(p.Key) || !string.IsNullOrEmpty(p.Value)) && !(_enumOptionsToRemove.TryGetValue(entityName, out var props) && props.TryGetValue(propertyName, out var optionsToRemove) && optionsToRemove.Contains(p.Key)))
                                {
                                    enumValues.Add(p.Key);
                                }
                            }
                        }
                        else
                        {
                            enumValues = propertySchema.Enum.ToList()!;
                            enumValues.Remove(null!);
                        }
                        if (type == "string?")
                        {
                            var matchingEnums = new List<Type>();
                            foreach (var p in enumTypes)
                            {
                                if (p.Value.SetEquals(enumValues))
                                {
                                    matchingEnums.Add(p.Key);
                                }
                            }
                            if (matchingEnums.Count > 0)
                            {
                                Type? match = matchingEnums.Count == 1 ? matchingEnums[0] : null;
                                if (matchingEnums.Count > 1)
                                {
                                    foreach (var matchingEnum in matchingEnums)
                                    {
                                        if (propertyName.IndexOf(matchingEnum.Name, StringComparison.OrdinalIgnoreCase) >= 0 || matchingEnum.Name.IndexOf(propertyName, StringComparison.OrdinalIgnoreCase) >= 0)
                                        {
                                            match = matchingEnum;
                                            break;
                                        }
                                    }
                                    if (match == null)
                                    {
                                        Console.WriteLine($"Could not find a default matching enum for {entityName}.{propertyName} between {string.Join(", ", matchingEnums.Select(t => t.Name))} so using the first {matchingEnums[0].Name}");
                                        match = matchingEnums[0];
                                    }
                                }
                                type = $"StringEnumValue<{match!.Name}>";
                                if ("EncompassRest.Loans.Enums" == match.Namespace)
                                {
                                    enumsNamespace = true;
                                }
                                else if ("EncompassRest.Schema" == match.Namespace)
                                {
                                    schemaNamespace = true;
                                }
                            }
                            if (type == "string?" && (!_enumPropertyNamesToIgnoreSharedEnums.TryGetValue(entityName, out var ignored) || !ignored.Contains(propertyName)))
                            {
                                KeyValuePair<Type, HashSet<string>>? foundEnum = null;
                                foreach (var p in enumTypes)
                                {
                                    if (p.Value.IsSupersetOf(enumValues) && (foundEnum?.Value.Count ?? int.MaxValue) > p.Value.Count)
                                    {
                                        foundEnum = p;
                                    }
                                }

                                if (foundEnum != null)
                                {
                                    var p = foundEnum.GetValueOrDefault();
                                    type = $"StringEnumValue<{p.Key.Name}>";
                                    if ("EncompassRest.Loans.Enums" == p.Key.Namespace)
                                    {
                                        enumsNamespace = true;
                                    }
                                    else if ("EncompassRest.Schema" == p.Key.Namespace)
                                    {
                                        schemaNamespace = true;
                                    }
                                    var missingOptions = p.Value.Except(enumValues);
                                    attributeProperties.Add($@"MissingOptionsJson = ""{JsonConvert.SerializeObject(missingOptions).Replace("\\", "\\\\").Replace("\"", "\\\"")}""");
                                    if (optionValues != null)
                                    {
                                        foreach (var member in Enums.GetMembers(p.Key))
                                        {
                                            var existingText = member.AsString(EnumFormat.Description, EnumFormat.EnumMemberValue, EnumFormat.Name);
                                            var value = member.AsString(EnumFormat.EnumMemberValue, EnumFormat.Name)!;
                                            if (optionValues.TryGetValue(value, out var text) && string.Equals(existingText, text, StringComparison.Ordinal))
                                            {
                                                optionValues.Remove(value);
                                            }
                                        }
                                        if (optionValues.Count > 0)
                                        {
                                            attributeProperties.Add($@"OptionsJson = ""{JsonConvert.SerializeObject(optionValues).Replace("\\", "\\\\").Replace("\"", "\\\"")}""");
                                        }
                                    }
                                    if (!_enumPropertyNamesToUseNotExactSharedEnum.TryGetValue(entityName, out var props) || !props.Contains(propertyName))
                                    {
                                        Console.WriteLine($"Found inexact enum match for {key}.{pair.Key}");
                                    }
                                }
                            }
                            if (type == "string?")
                            {
                                var enumName = GetEnumName(entityName, propertyName);
                                GenerateEnumFileFromOptions("Generated\\Loans\\Enums", "EncompassRest.Loans.Enums", enumName, optionValues ?? enumValues.ToDictionary(v => v, v => v));
                                Console.WriteLine($"Failed to find existing enum for {key}.{pair.Key}");
                            }
                        }
                        else if (type == "bool?" && optionValues != null)
                        {
                            optionValues = optionValues.Where(o => !string.IsNullOrEmpty(o.Value) && ((string.Equals(o.Key, "true", StringComparison.Ordinal) && !string.Equals(o.Value, "Yes", StringComparison.Ordinal)) || (string.Equals(o.Key, "false", StringComparison.Ordinal) && !string.Equals(o.Value, "No", StringComparison.Ordinal)))).ToDictionary(o => string.Equals(o.Key, "true", StringComparison.Ordinal) ? "Y" : "N", o => o.Value);
                            if (optionValues.Count > 0)
                            {
                                attributeProperties.Add($@"OptionsJson = ""{JsonConvert.SerializeObject(optionValues).Replace("\\", "\\\\").Replace("\"", "\\\"")}""");
                            }
                        }
                        else if (optionValues != null)
                        {
                            optionValues = optionValues.Where(o => !string.IsNullOrEmpty(o.Key) || !string.IsNullOrEmpty(o.Value)).ToDictionary(o => o.Key, o => o.Value);
                            if (optionValues.Count > 0)
                            {
                                attributeProperties.Add($@"OptionsJson = ""{JsonConvert.SerializeObject(optionValues).Replace("\\", "\\\\").Replace("\"", "\\\"")}""");
                            }
                        }
                    }

                    if (standardFields?.All(f => f.ReadOnly) == true)
                    {
                        attributeProperties.Add($"ReadOnly = true");
                    }
                    
                    if (isList)
                    {
                        collectionsNamespace = true;
                    }
                    var fieldName = $"_{pair.Key}";
                    fields.AppendLine($"    private {(isEntity ? $"{type}?" : (isList ? $"DirtyList<{type}>?" : $"DirtyValue<{type}>?"))} {fieldName};");
                    var summary = $"{key} {propertyName}";
                    if (standardFields?.Count == 1)
                    {
                        summary = $"{standardFields[0].Description.Replace("&", "&amp;")} [{standardFields[0].Id}]";
                    }
                    else if (standardFields?.Count == 2)
                    {
                        summary += $" [{standardFields[0].Id}], [{standardFields[1].Id}]";
                    }
                    properties
                        .AppendLine()
                        .AppendLine($"    /// <summary>")
                        .AppendLine($"    /// {summary}")
                        .AppendLine($"    /// </summary>");
                    if (isEntity || isList)
                    {
                        codeAnalysisNamespace = true;
                        properties.AppendLine("    [AllowNull]");
                    }
                    if (attributeProperties.Count > 0 && standardFields?.Count > 0)
                    {
                        properties.AppendLine($"    [LoanFieldProperty({string.Join(", ", attributeProperties)})]");
                    }
                    properties.AppendLine($@"    public {(isList ? $"IList<{type}>" : type)} {propertyName} {{ get => {(isEntity || isList ? $"GetField(ref {fieldName})" : fieldName)}; set => SetField(ref {fieldName}, value); }}");
                }
            }
        }
        if (properties.Length == 0)
        {
            Console.WriteLine($"There are no properties on {entityName}");
        }

        var entityArguments = string.Empty;
        if (entitySchema.Required?.Count > 0)
        {
            var required = entitySchema.Required.ToList();
            required.Remove("id");
            required.Remove("entityId");
            required.Remove("formName");
            required.Remove("fieldName");
            if (required.Count > 0)
            {
                entityArguments = $"PropertiesToAlwaysSerialize = nameof({string.Join(") + \",\" + nameof(", required.Select(p => $"{char.ToUpper(p[0])}{p.Substring(1)}").OrderBy(p => p))})";
            }
        }
        if (serializeWholeList)
        {
            entityArguments += $"{(entityArguments.Length > 0 ? ", " : string.Empty)}SerializeWholeListWhenDirty = true";
        }

        using (var sw = new StreamWriter(Path.Combine(isEntityReference ? "Generated" : (isFileAttachmentReference ? "Generated\\Loans" : destinationPath), entityName + ".cs")))
        {
            sw.Write($@"{(systemNamespace ? @"using System;
" : string.Empty)}{(collectionsNamespace ? @"using System.Collections.Generic;
" : string.Empty)}{(codeAnalysisNamespace ? @"using System.Diagnostics.CodeAnalysis;
" : string.Empty)}{(enumsNamespace ? $@"using EncompassRest.Loans.Enums;
" : string.Empty)}{(schemaNamespace ? @"using EncompassRest.Schema;
" : string.Empty)}{(systemNamespace || collectionsNamespace || enumsNamespace || schemaNamespace ? Environment.NewLine : string.Empty)}namespace {(isEntityReference ? "EncompassRest" : (isFileAttachmentReference ? "EncompassRest.Loans" : @namespace))};

/// <summary>
/// {entityName}
/// </summary>
{(entityArguments.Length > 0 ? $@"[Entity({entityArguments})]
" : string.Empty)}public {(isEntityReference ? string.Empty : "sealed ")}partial class {entityName} : {(entityReferenceDerived ? "EntityReference" : "DirtyExtensibleObject")}, IIdentifiable
{{
{fields}{properties}}}");
        }
    }

    private static void GenerateEnumFileFromOptions(string destinationPath, string @namespace, string enumName, Dictionary<string, string> options)
    {
        var componentModelNamespace = false;
        var serializationNamespace = false;

        var members = new StringBuilder();

        var enumMemberNames = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
        var typesOfAssembliesToCheck = new[]
        {
            typeof(Loan),
            typeof(ActionTaken),
            typeof(EncompassRestClient)
        };
        Type? existingEnumType = null;
        foreach (var type in typesOfAssembliesToCheck)
        {
            existingEnumType = type.Assembly.GetType($"{@namespace}.{enumName}");
            if (existingEnumType != null)
            {
                break;
            }
        }
        var existingEnumValues = new HashSet<int>();
        var first = true;
        if (existingEnumType != null)
        {
            var existingMembersNowMissing = new List<EnumMember>();
            foreach (var member in Enums.GetMembers(existingEnumType))
            {
                if (!first)
                {
                    members.AppendLine(",");
                }
                var name = member.Name;
                var value = member.AsString(EnumFormat.EnumMemberValue);
                var text = member.AsString(EnumFormat.Description);
                if (options.TryGetValue(value ?? name, out var optionText) && optionText != null)
                {
                    text = optionText;
                }
                members.AppendLine($@"    /// <summary>
    /// {(text ?? value ?? name).Replace("&", "&amp;")}
    /// </summary>");

                if (!string.IsNullOrEmpty(text) && !string.Equals(text, value ?? name, StringComparison.Ordinal))
                {
                    members.AppendLine($@"    [Description(""{text!.Replace("\\", "\\\\").Replace("\"", "\\\"")}"")]");
                    componentModelNamespace = true;
                }
                if (value != null && !string.Equals(value, name, StringComparison.Ordinal))
                {
                    members.AppendLine($@"    [EnumMember(Value = ""{value.Replace("\\", "\\\\").Replace("\"", "\\\"")}"")]");
                    serializationNamespace = true;
                }
                enumMemberNames.Add(name);
                if (!options.Remove(value ?? name))
                {
                    existingMembersNowMissing.Add(member);
                }
                var intValue = member.ToInt32();
                existingEnumValues.Add(intValue);
                members.Append($"    {name} = {intValue}");
                first = false;
            }
            if (existingMembersNowMissing.Count > 0)
            {
                Console.WriteLine($"{existingEnumType} is now missing the existing members {string.Join(", ", existingMembersNowMissing)}");
            }
        }
        var i = 0;
        foreach (var pair in options)
        {
            while (existingEnumValues.Contains(i))
            {
                ++i;
            }
            if (!first)
            {
                members.AppendLine(",");
            }
            var value = pair.Key;
            var text = pair.Value;
            var option = value;
            if (string.IsNullOrEmpty(option))
            {
                option = text;
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
                members.AppendLine($@"    /// <summary>
    /// {(text ?? value).Replace("&", "&amp;")}
    /// </summary>");
                if (!string.IsNullOrEmpty(text) && !string.Equals(value, text, StringComparison.Ordinal))
                {
                    members.AppendLine($@"    [Description(""{text!.Replace("\\", "\\\\").Replace("\"", "\\\"")}"")]");
                    componentModelNamespace = true;
                }
                if (!string.Equals(value, name, StringComparison.Ordinal))
                {
                    members.AppendLine($@"    [EnumMember(Value = ""{value.Replace("\\", "\\\\").Replace("\"", "\\\"")}"")]");
                    serializationNamespace = true;
                }
                members.Append($"    {name} = {i}");
                first = false;
                ++i;
            }
            else if (i > 0)
            {
                members.Length -= 1 + Environment.NewLine.Length;
            }
        }

        using (var sw = new StreamWriter(Path.Combine(destinationPath, enumName + ".cs")))
        {
            sw.Write($@"{(componentModelNamespace ? @"using System.ComponentModel;
" : string.Empty)}{(serializationNamespace ? @"using System.Runtime.Serialization;
" : string.Empty)}{(componentModelNamespace || serializationNamespace ? Environment.NewLine : string.Empty)}namespace {@namespace};

/// <summary>
/// {enumName}
/// </summary>
public enum {enumName}
{{
{members}
}}");
        }
    }

    private static string GetPropertyOrElementType(SchemaBase propertySchema, Dictionary<string, EntitySchema> definitions, out bool isEntity, out bool isList)
    {
        isEntity = false;
        isList = false;

        if (propertySchema is PropertySchema p)
        {
            if (p.Format.EnumValue is PropertyFormat.Date or PropertyFormat.DateTime)
            {
                return "DateTime?";
            }
        }
        else
        {
            p = null!;
        }

        var propertyType = propertySchema.Type?.FirstOrDefault();
        switch (propertyType?.EnumValue)
        {
            case SchemaType.String:
                return "string?";
            case SchemaType.Number:
                return "decimal?";
            case SchemaType.Boolean:
                return "bool?";
            case SchemaType.Integer:
                return "int?";
            case SchemaType.Object:
                return "object?";
            case SchemaType.Array:
                isList = true;
                var elementType = GetPropertyOrElementType(p.Items!, definitions, out _, out _);
                return elementType;
            default:
                if (propertySchema.Ref != null)
                {
                    var defName = propertySchema.Ref.Substring(propertySchema.Ref.LastIndexOf('/') + 1);
                    var entityName = GetEntityName(defName, definitions.TryGetValue(defName, out var s) ? s : definitions[defName + "Contract"]);
                    switch (entityName)
                    {
                        case "Primitive":
                            return "object?";
                        case "NaDecimal":
                            return "NA<decimal>";
                        default:
                            isEntity = true;
                            return entityName;
                    };
                }
                return $"PROBLEM<{propertyType}>";
        }
    }

    private static string GetEntityName(string key, EntitySchema schema)
    {
        key = RemoveContract(key)!;
        var title = RemoveContract(schema.Title);
        return string.IsNullOrEmpty(title) || title == $"{key}s" || (title!.EndsWith("ies") && key.EndsWith("y") && title == $"{key.Substring(0, key.Length - 1)}ies") ? key : title!;
    }

    private static string? RemoveContract(string? name) => name?.EndsWith("Contract") == true ? name.Substring(0, name.Length - 8) : name;

    private static string GetEnumName(string entityType, string propertyName)
    {
        if (!_enumPropertyNamesToUseEntityTypeInName.Contains(propertyName))
        {
            return propertyName;
        }
        var firstWord = propertyName;
        var camelCasedName = new CamelCaseNamingStrategy().GetPropertyName(propertyName, false);
        for (var i = 1; i < camelCasedName.Length; ++i)
        {
            if (!char.IsLower(camelCasedName[i]))
            {
                firstWord = propertyName.Substring(0, i);
                break;
            }
        }
        if (entityType.EndsWith(firstWord))
        {
            return $"{entityType.Substring(0, entityType.Length - firstWord.Length)}{propertyName}";
        }
        return $"{entityType}{propertyName}";
    }
}