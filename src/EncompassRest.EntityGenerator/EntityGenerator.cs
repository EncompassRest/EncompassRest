using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Elli.Api.Loans.Model;
using EncompassRest.Loans;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;
using EncompassRest.Tests;
using EnumsNET;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

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
                typeof(StateDisclosureFeePaidBy),
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
                typeof(HmdaLoanPurpose),
                typeof(PaidToOrBy),
                typeof(BorrowerOrCoBorrower),
                typeof(NonVolAdjustmentType),
                typeof(HudLoanDataResidencyType),
                typeof(LienPosition),
                typeof(HelocCalcSign),
                typeof(HelocPaymentBasis),
                typeof(HelocBalance),
                typeof(MortgageType),
                typeof(RefinanceType),
                typeof(PerDiemCalculationMethodType),
                typeof(UnitType),
                typeof(HmdaCreditScoreForDecisionMaking),
                typeof(HmdaCreditScoringModel),
                typeof(YNOrExempt),
                typeof(RefinanceCashOutDeterminationType),
                typeof(GovernmentRefinanceType),
                typeof(ConstructionToPermanentClosingType),
                typeof(AssetType),
                typeof(OtherAssetType),
                typeof(CounselingFormatType),
                typeof(Description),
                typeof(JointAssetLiabilityReportingIndicator),
                typeof(IncreaseOrDecrease),
                typeof(PaymentBasisType),
                typeof(ReoPropertyUsageType),
                typeof(AdditionalLoanLienPosition),
                typeof(BuydownContributor)
            };
            s_sharedEnums = new Dictionary<string, HashSet<string>>(StringComparer.OrdinalIgnoreCase);
            foreach (var sharedEnumType in sharedEnumTypes)
            {
                s_sharedEnums.Add(sharedEnumType.Name, new HashSet<string>(Enums.GetMembers(sharedEnumType).Select(m => m.AsString(EnumFormat.EnumMemberValue, EnumFormat.Name))));
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
            "AdjustsTermType",
            "PrepaymentPenaltyPayOffInDateType",
            "LogDUPropertyType",
            "ClosingCost2FundsTypeOtherDescription",
            "ClosingCost3FundsTypeOtherDescription",
            "ClosingCost4FundsTypeOtherDescription",
            "ClosingCostFundsTypeOtherDescription",
            "DownPaymentOtherTypeDescription",
            "HmdaCreditScoreForDecisionMaking",
            "HmdaCreditScoringModel",
            "GovernmentRefinanceType",
            "PropertyFormType",
            "InsuranceProjectType",
            "LogLPPropertyType"
        };

        private static readonly HashSet<string> s_enumPropertyNamesToUseEntityTypeInName = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
        {
            "PurposeOfLoan",
            "LoanType",
            "PropertyType",
            "FeeType",
            "RiskClass",
            "LoanPurpose",
            "BorrowerType",
            "MortgageOriginator",
            "AppraisalType",
            "MortgageType",
            "RefinanceType",
            "AssetType",
            "Description",
            "CounselingFormatType",
            "Source"
        };

        private static readonly Dictionary<string, string> s_explicitStringEnumValues = new Dictionary<string, string>
        {
            { "LoanAssociate.LoanAssociateType", nameof(LoanAssociateType) },
            { "AdditionalStateDisclosure.StateCode", nameof(State) },
            { "LoanAssociate.EnableWriteAccess", nameof(YOrN) },
            { "FreddieMac.CondoClass", nameof(CondoClass) },
            { "MilestoneTaskContact.State", nameof(State) },
            { "Miscellaneous.State", nameof(State) }
        };

        private static readonly HashSet<string> s_stringDictionaryProperties = new HashSet<string> { "Loan.VirtualFields", "DocumentOrderLog.DocumentFields", "ElliUCDDetail.CDFields", "ElliUCDDetail.LEFields" };

        private static readonly HashSet<string> s_propertiesToNotGenerate = new HashSet<string> { "Contact.Contact", "Loan.CurrentApplication", "Borrower.Application", "Uldd.ENoteIndicator", "GoodFaithFeeVarianceCureLog.GffVAlertTriggerFieldLog", "VaLoanData.VaEemIncludedinBaseLoanAmountIndicator", "VaLoanData.VaEnergyEfficientImprovementsFinancedAmount", "VaLoanData.VaFinancedClosingCostsToExcludeAmount", "VaLoanData.VaRateReducedSolelybyDiscountPointsIndicator", "VaLoanData.VaStatutoryClosingCosts", "VaLoanData.VaStatutoryMonthlyPayment", "VaLoanData.VaStatutoryMonthlyReduction", "VaLoanData.VaStatutoryRecoupmentMonths" };

        private static readonly HashSet<string> s_propertiesWithInternalFields = new HashSet<string> { "CustomField.DateValue", "CustomField.NumericValue", "CustomField.StringValue", "FieldLockData.ModelPath" };

        private static readonly Dictionary<string, Dictionary<string, string>> s_propertiesToRename = new Dictionary<string, Dictionary<string, string>>
        {
            { "AlertChangeCircumstance", new Dictionary<string, string> { { "AlertTriggerFielDID", "AlertTriggerFieldID" } } },
            { "ExportLogServiceType", new Dictionary<string, string> { { "name", "Name" } } }
        };

        private static readonly Dictionary<string, EntitySchema> s_explicitSchemas = new Dictionary<string, EntitySchema>
        {
            { "ElliUCDDetail", new EntitySchema { Properties = new Dictionary<string, PropertySchema> { { "CDFields", new PropertySchema { Type = PropertySchemaType.String } }, { "LEFields", new PropertySchema { Type = PropertySchemaType.String } } } } },
            { "DocumentAudit", new EntitySchema { Properties = new Dictionary<string, PropertySchema> { { "ReportKey", new PropertySchema { Type = PropertySchemaType.String } }, { "TimeStamp", new PropertySchema { Type = PropertySchemaType.DateTime } }, { "Alerts", new PropertySchema { Type = PropertySchemaType.List, ElementType = "DocumentAuditAlert" } } } } },
            { "DocumentAuditAlert", new EntitySchema { Properties = new Dictionary<string, PropertySchema> { { "Source", new PropertySchema { Type = PropertySchemaType.String } }, { "Type", new PropertySchema { Type = PropertySchemaType.String } }, { "Text", new PropertySchema { Type = PropertySchemaType.String } }, { "Fields", new PropertySchema { Type = PropertySchemaType.List, ElementType = "string" } } } } },
            { "EmailDocument", new EntitySchema { Properties = new Dictionary<string, PropertySchema> { { "DocId", new PropertySchema { Type = PropertySchemaType.String } }, { "DocTitle", new PropertySchema { Type = PropertySchemaType.String } } } } },
            { "OrderedDocument", new EntitySchema { Properties = new Dictionary<string, PropertySchema> { { "Id", new PropertySchema { Type = PropertySchemaType.String } }, { "Title", new PropertySchema { Type = PropertySchemaType.String } }, { "Type", new PropertySchema { Type = PropertySchemaType.String } }, { "Category", new PropertySchema { Type = PropertySchemaType.String } }, { "SignatureType", new PropertySchema { Type = PropertySchemaType.String } }, { "PairId", new PropertySchema { Type = PropertySchemaType.String } }, { "DataKey", new PropertySchema { Type = PropertySchemaType.String } }, { "Size", new PropertySchema { Type = PropertySchemaType.Int } }, { "TemplateId", new PropertySchema { Type = PropertySchemaType.String } }, { "DocumentServiceId", new PropertySchema { Type = PropertySchemaType.String } }, { "OverflowDataKey", new PropertySchema { Type = PropertySchemaType.String } }, { "Overflows", new PropertySchema { Type = PropertySchemaType.List, ElementType = "OrderedDocumentOverflow" } } } } },
            { "OrderedDocumentOverflow", new EntitySchema { Properties = new Dictionary<string, PropertySchema> { { "CoordinateBottom", new PropertySchema { Type = PropertySchemaType.String } }, { "CoordinateTop", new PropertySchema { Type = PropertySchemaType.String } }, { "CoordinateLeft", new PropertySchema { Type = PropertySchemaType.String } }, { "CoordinateRight", new PropertySchema { Type = PropertySchemaType.String } }, { "OriginalText", new PropertySchema { Type = PropertySchemaType.String } }, { "PageNumber", new PropertySchema { Type = PropertySchemaType.Int } }, { "TemplateFieldName", new PropertySchema { Type = PropertySchemaType.String } } } } }
        };

        private static readonly Dictionary<string, Dictionary<string, PropertySchema>> s_explicitPropertySchemas = new Dictionary<string, Dictionary<string, PropertySchema>>
        {
            { "NonVol", new Dictionary<string, PropertySchema> { { "Id", new PropertySchema { Type = PropertySchemaType.String } }, { "NonVolIndex", new PropertySchema { Type = PropertySchemaType.Int } }, { "NonVolId", new PropertySchema { Type = PropertySchemaType.String } } } },
            { "CrmLog", new Dictionary<string, PropertySchema> { { "Alerts", new PropertySchema { Type = PropertySchemaType.List, ElementType = LoanEntity.LogAlert } }, { "CommentList", new PropertySchema { Type = PropertySchemaType.List, ElementType = LoanEntity.LogComment } }, { "Comments", new PropertySchema { Type = PropertySchemaType.String } }, { "DateUtc", new PropertySchema { Type = PropertySchemaType.DateTime } }, { "FileAttachmentsMigrated", new PropertySchema { Type = PropertySchemaType.Bool } }, { "Guid", new PropertySchema { Type = PropertySchemaType.String } }, { "IsSystemSpecificIndicator", new PropertySchema { Type = PropertySchemaType.Bool } }, { "LogRecordIndex", new PropertySchema { Type = PropertySchemaType.Int } } } },
            { "DocumentOrderLog", new Dictionary<string, PropertySchema> { { "OrderedDocuments", new PropertySchema { Type = PropertySchemaType.List, ElementType = "OrderedDocument" } } } },
            { "FundingFee", new Dictionary<string, PropertySchema> { { "Amount", new PropertySchema { Type = PropertySchemaType.Decimal } }, { "PocAmount", new PropertySchema { Type = PropertySchemaType.Decimal } }, { "PtcAmount", new PropertySchema { Type = PropertySchemaType.Decimal } }, { "PocBorrower2015", new PropertySchema { Type = PropertySchemaType.Decimal } }, { "PocSeller2015", new PropertySchema { Type = PropertySchemaType.Decimal } }, { "PocBroker2015", new PropertySchema { Type = PropertySchemaType.Decimal } }, { "PocOther2015", new PropertySchema { Type = PropertySchemaType.Decimal } }, { "PacBroker2015", new PropertySchema { Type = PropertySchemaType.Decimal } }, { "PacLender2015", new PropertySchema { Type = PropertySchemaType.Decimal } }, { "PacOther2015", new PropertySchema { Type = PropertySchemaType.Decimal } }, { "PocLender2015", new PropertySchema { Type = PropertySchemaType.Decimal } }, } },
            { "HtmlEmailLog", new Dictionary<string, PropertySchema> { { "DocList", new PropertySchema { Type = PropertySchemaType.List, ElementType = "EmailDocument" } } } },
            { "SelfEmployedIncome", new Dictionary<string, PropertySchema> { { "FieldValue", new PropertySchema { Type = PropertySchemaType.String, FieldInstances = new Dictionary<string, List<string>>
                {
                    { "FM1084.X105", new List<string> { "Application_SelfEmployedIncomes_Form1065_OwnershipPercent" } },
                    { "FM1084.X114", new List<string> { "Application_SelfEmployedIncomes_Form1120S_OwnershipPercent" } },
                    { "FM1084.X127", new List<string> { "Application_SelfEmployedIncomes_Form1120_OwnershipPercent" } },
                    { "FM1084.X134", new List<string> { "Application_SelfEmployedIncomes_None_Year2_FormB" } },
                    { "FM1084.X50", new List<string> { "Application_SelfEmployedIncomes_None_Year2_FormA" } },
                    { "FM1084.X6", new List<string> { "Application_SelfEmployedIncomes_None_Year1_FormA" } },
                    { "FM1084.X96", new List<string> { "Application_SelfEmployedIncomes_None_Year1_FormB" } }
                } } } } }
        };

        private static readonly HashSet<string> s_explicitDateTimeProperties = new HashSet<string> { "DisclosureTracking2015Log.ActualFulfillmentDate", "DisclosureTracking2015Log.ApplicationDate", "DisclosureTracking2015Log.BorrowerActualReceivedDate", "DisclosureTracking2015Log.BorrowerPresumedReceivedDate", "DisclosureTracking2015Log.CDDateIssued", "DisclosureTracking2015Log.ClosingDate", "DisclosureTracking2015Log.CoBorrowerActualReceivedDate", "DisclosureTracking2015Log.CoBorrowerPresumedReceivedDate", "DisclosureTracking2015Log.DisclosedDate", "DisclosureTracking2015Log.IntentToProceedDate", "DisclosureTracking2015Log.LockedBorrowerPresumedReceivedDate", "DisclosureTracking2015Log.LockedCoBorrowerPresumedReceivedDate", "DisclosureTracking2015Log.LockedDisclosedDateField", "DisclosureTracking2015Log.LockedDisclosedReceivedDate", "DisclosureTracking2015Log.PresumedFulfillmentDate", "DisclosureTracking2015Log.ReceivedDate", "DisclosureTracking2015Log.RevisedDueDate", "DisclosureTracking2015Log.ChangesReceivedDate" };

        private static readonly HashSet<string> s_explicitNADecimalProperties = new HashSet<string>
        {
            "Hmda.CLTV",
            "Hmda.DebtToIncomeRatio",
            "Hmda.DiscountPoints",
            "Hmda.InterestRate",
            "Hmda.LenderCredits",
            "Hmda.PropertyValue",
            "Hmda.RateSpread"
        };

        private static readonly Dictionary<string, HashSet<string>> s_enumOptionsToIgnore = new Dictionary<string, HashSet<string>>
        {
            { "LoanDocumentationType", new HashSet<string> { "NoIncomeon1003" } }
        };

        private static readonly HashSet<string> s_ignoredEntities = new HashSet<string> { };

        private static readonly Dictionary<string, List<string>> s_mergeEntities = new Dictionary<string, List<string>> { { "NonBorrowingOwner", new List<string> { "NonBorrowingOwnerContract" } }, { "AlertChangeCircumstance", new List<string> { "AlertChangeCircumstanceContract" } }, { "OtherIncomeSource", new List<string> { "OtherIncomeSourceContract" } } };

        private static readonly string s_encompassSDKFolder = Path.Combine(Directory.EnumerateDirectories("C:\\SmartClientCache\\Apps\\UAC\\Ellie Mae\\").First(), "Encompass360");

        public static Task Main()
        {
            AppDomain.CurrentDomain.AssemblyResolve += CurrentDomain_AssemblyResolve;

            return RunAsync();
        }

        private static Assembly CurrentDomain_AssemblyResolve(object sender, ResolveEventArgs args) => Assembly.LoadFrom(Path.Combine(s_encompassSDKFolder, $"{args.Name.Substring(0, args.Name.IndexOf(","))}.dll"));

        public static async Task RunAsync()
        {
            try
            {
                Dictionary<string, EntitySchema> entityTypes;
                using (var client = await TestBaseClass.GetTestClientAsync().ConfigureAwait(false))
                {
                    entityTypes = (await client.Schema.GetLoanSchemaAsync(true).ConfigureAwait(false)).EntityTypes;
                }

                foreach (var pair in s_mergeEntities)
                {
                    var properties = entityTypes[pair.Key].Properties;
                    foreach (var entityToMerge in pair.Value)
                    {
                        var entityTypeToMerge = entityTypes[entityToMerge];
                        foreach (var p in entityTypeToMerge.Properties)
                        {
                            var name = p.Key;
                            if (!properties.ContainsKey(name))
                            {
                                properties.Add(name, p.Value);
                                Console.WriteLine($"Merged {entityToMerge}.{name} into {pair.Key}");
                            }
                        }
                        entityTypes.Remove(entityToMerge);
                    }
                }

                foreach (var pair in s_explicitSchemas)
                {
                    var entityName = pair.Key;
                    if (entityTypes.ContainsKey(entityName))
                    {
                        Console.WriteLine($"Can now retrieve schema for {entityName}");
                        entityTypes[entityName] = pair.Value;
                    }
                    else
                    {
                        entityTypes.Add(entityName, pair.Value);
                    }
                }

                foreach (var pair in s_explicitPropertySchemas)
                {
                    var entityName = pair.Key;
                    var properties = entityTypes[entityName].Properties;
                    foreach (var p in pair.Value)
                    {
                        var propertyName = p.Key;
                        if (properties.ContainsKey(propertyName))
                        {
                            Console.WriteLine($"Can now retrieve schema property {entityName}.{propertyName}");
                            properties[propertyName] = p.Value;
                        }
                        else
                        {
                            properties.Add(propertyName, p.Value);
                        }
                    }
                }

                foreach (var pair in entityTypes)
                {
                    if (s_propertiesToRename.TryGetValue(pair.Key, out var propertiesToRename))
                    {
                        var properties = pair.Value.Properties;
                        foreach (var p in propertiesToRename)
                        {
                            var property = properties[p.Key];
                            properties.Remove(p.Key);
                            properties.Add(p.Value, property);
                        }
                    }
                }

                var destinationPath = "Loans";
                var @namespace = "EncompassRest.Loans";
                Directory.CreateDirectory(destinationPath);

                var loanEntitySchema = entityTypes["Loan"];
                var fields = new Dictionary<string, LoanFieldDescriptors.StandardFieldInfo>(StringComparer.OrdinalIgnoreCase);
                var fieldPatterns = new Dictionary<string, LoanFieldDescriptors.StandardFieldInfo>(StringComparer.OrdinalIgnoreCase)
                {
                    { "CX.{0}", new LoanFieldDescriptors.StandardFieldInfo("CX.{0}", "Loan.CustomFields[(FieldName == 'CX.{0}')].StringValue") },
                    { "CUST{0:00}FV", new LoanFieldDescriptors.StandardFieldInfo("CUST{0:00}FV", "Loan.CustomFields[(FieldName == 'CUST{0:00}FV')].StringValue") }
                };

                var otherEnums = new Dictionary<string, Dictionary<string, string>>();

                LoanFieldDescriptors.PopulateFieldMappings("Loan", "Loan", typeof(LoanContract), loanEntitySchema, null, entityTypes, fields, fieldPatterns, extendedFieldInfo: false, (string entityName, Type ellieType, EntitySchema entitySchema, HashSet<string> requiredProperties, bool serializeWholeList) => GenerateClassFileFromSchema(destinationPath, @namespace, entityName, ellieType, entitySchema, otherEnums, requiredProperties, serializeWholeList), fieldId => EllieMae.Encompass.BusinessObjects.Loans.FieldDescriptors.StandardFields[fieldId].Description, Console.Out);

                entityTypes.Remove("Loan");

                foreach (var pair in entityTypes)
                {
                    var entityName = pair.Key;
                    if (!s_ignoredEntities.Contains(entityName))
                    {
                        Console.WriteLine($"{entityName} is not connected to the Loan schema");
                        GenerateClassFileFromSchema(destinationPath, @namespace, entityName, null, pair.Value, otherEnums, null, false);
                    }
                }

                var orderedFields = fields.Values.OrderBy(p => p.ModelPath.Substring(0, p.ModelPath.LastIndexOfAny(new[] { '.', '[' }))).ThenBy(p => p.ModelPath).ToList();

                var orderedFieldPatterns = fieldPatterns.Values.OrderBy(p => p.ModelPath.Substring(0, p.ModelPath.LastIndexOf('.'))).ThenBy(p => p.ModelPath).ToList();

                foreach (var field in orderedFields)
                {
                    if (field.NonSerializedFormat == LoanFieldFormat.YN)
                    {
                        var sdkDescriptor = EllieMae.Encompass.BusinessObjects.Loans.FieldDescriptors.StandardFields[field.FieldId];
                        if (sdkDescriptor != null && sdkDescriptor.Format != EllieMae.Encompass.BusinessObjects.Loans.LoanFieldFormat.YN && sdkDescriptor.Options.Count > 0 && (sdkDescriptor.Options.Count != 2 || (sdkDescriptor.Options[0].Value != "Y" && sdkDescriptor.Options[0].Value != "N") || (sdkDescriptor.Options[1].Value != "Y" && sdkDescriptor.Options[1].Value != "N")))
                        {
                            field.Format = (LoanFieldFormat)sdkDescriptor.Format;
                            field.Options = sdkDescriptor.Options.Cast<EllieMae.Encompass.BusinessObjects.Loans.FieldOption>().Select(o => new FieldOption(o.Value, o.Text)).ToList();
                            if (field.Options.Count > 1 && field.Options[1].Value.StartsWith("Y", StringComparison.OrdinalIgnoreCase))
                            {
                                field.Options.Reverse();
                            }
                            field.ReadOnly = sdkDescriptor.ReadOnly;
                            Console.WriteLine($"{field.FieldId} {sdkDescriptor.Format} != {field.NonSerializedFormat}");
                        }
                    }
                }

                using (var fs = new FileStream("LoanFields.json", FileMode.Create))
                {
                    using (var sw = new StreamWriter(fs))
                    {
                        JsonSerializer.Create(new JsonSerializerSettings { Formatting = Formatting.Indented }).Serialize(sw, orderedFields);
                    }
                }

                using (var fs = new FileStream("LoanFieldPatterns.json", FileMode.Create))
                {
                    using (var sw = new StreamWriter(fs))
                    {
                        JsonSerializer.Create(new JsonSerializerSettings { Formatting = Formatting.Indented }).Serialize(sw, orderedFieldPatterns);
                    }
                }

                var virtualFields = new List<LoanFieldDescriptors.VirtualFieldInfo>();
                var virtualFieldPatterns = new List<LoanFieldDescriptors.VirtualFieldInfo>();
                foreach (var virtualField in EllieMae.Encompass.BusinessObjects.Loans.FieldDescriptors.VirtualFields.Cast<EllieMae.Encompass.BusinessObjects.Loans.FieldDescriptor>())
                {
                    LoanFieldDescriptors.VirtualFieldInfo virtualFieldInfo;
                    if (virtualField.MultiInstance)
                    {
                        virtualFieldInfo = new LoanFieldDescriptors.VirtualFieldInfo($"{virtualField.FieldID}.{{0}}");
                        var instanceField = virtualField.GetInstanceDescriptor(virtualField.InstanceSpecifierType == EllieMae.Encompass.BusinessObjects.Loans.MultiInstanceSpecifierType.Index ? (object)1 : "1");
                        var instanceFieldId = instanceField.FieldID;
                        var instanceFieldId2 = string.Format(virtualFieldInfo.FieldId, 1);
                        if (instanceFieldId != instanceFieldId2)
                        {
                            Console.WriteLine($"{instanceFieldId} != {instanceFieldId2}");
                        }
                        var description = instanceField.Description;
                        description = description.Replace(" - 1", " - {0}");
                        virtualFieldInfo.Description = description;
                        virtualFieldPatterns.Add(virtualFieldInfo);
                    }
                    else
                    {
                        virtualFieldInfo = new LoanFieldDescriptors.VirtualFieldInfo(virtualField.FieldID);
                        virtualFieldInfo.Description = virtualField.Description;
                        virtualFields.Add(virtualFieldInfo);
                    }
                    if (virtualField.Options.Count > 0)
                    {
                        virtualFieldInfo.Options = new List<FieldOption>();
                        foreach (var option in virtualField.Options.Cast<EllieMae.Encompass.BusinessObjects.Loans.FieldOption>())
                        {
                            virtualFieldInfo.Options.Add(new FieldOption(option.Value, option.Text));
                        }
                    }
                    virtualFieldInfo.Format = (LoanFieldFormat)virtualField.Format;
                }

                var orderedVirtualFields = virtualFields.OrderBy(v => v.FieldId).ToList();
                var orderedVirtualFieldPatterns = virtualFieldPatterns.OrderBy(v => v.FieldId).ToList();

                using (var fs = new FileStream("VirtualFields.json", FileMode.Create))
                {
                    using (var sw = new StreamWriter(fs))
                    {
                        JsonSerializer.Create(new JsonSerializerSettings { Formatting = Formatting.Indented }).Serialize(sw, orderedVirtualFields);
                    }
                }

                using (var fs = new FileStream("VirtualFieldPatterns.json", FileMode.Create))
                {
                    using (var sw = new StreamWriter(fs))
                    {
                        JsonSerializer.Create(new JsonSerializerSettings { Formatting = Formatting.Indented }).Serialize(sw, orderedVirtualFieldPatterns);
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
                            serializer.Serialize(sw, orderedFields);
                        }

                        var loanFieldPatternsEntry = zip.CreateEntry("LoanFieldPatterns.json", CompressionLevel.Optimal);
                        using (var sw = new StreamWriter(loanFieldPatternsEntry.Open()))
                        {
                            serializer.Serialize(sw, orderedFieldPatterns);
                        }

                        var virtualFieldsEntry = zip.CreateEntry("VirtualFields.json", CompressionLevel.Optimal);
                        using (var sw = new StreamWriter(virtualFieldsEntry.Open()))
                        {
                            serializer.Serialize(sw, orderedVirtualFields);
                        }

                        var virtualFieldPatternsEntry = zip.CreateEntry("VirtualFieldPatterns.json", CompressionLevel.Optimal);
                        using (var sw = new StreamWriter(virtualFieldPatternsEntry.Open()))
                        {
                            serializer.Serialize(sw, orderedVirtualFieldPatterns);
                        }
                    }
                }

                var otherEnumsAsHashSet = otherEnums.ToDictionary(p => p.Key, p => new HashSet<string>(p.Value.Keys));

                foreach (var enumPair in s_sharedEnums.Concat(otherEnumsAsHashSet))
                {
                    foreach (var innerEnumPair in otherEnumsAsHashSet)
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
                foreach (var pair in s_sharedEnums.ToDictionary(p => p.Key, p => p.Value.ToDictionary(s => s, s => (string)null)).Concat(otherEnums))
                {
                    GenerateEnumFileFromOptions(enumsPath, $"{@namespace}.Enums", pair.Key, pair.Value);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            Console.Write("Press Enter to End.");
            Console.ReadLine();
        }

        private static void GenerateClassesFromJson(string destinationPath, string @namespace, string entityName, JObject jObject, HashSet<string> names, string nameSuffix = null)
        {
            var systemNamespace = false;
            var collectionsNamespace = false;
            var newtonsoftNamespace = false;

            var fields = new StringBuilder();
            var properties = new StringBuilder();
            var entities = new List<(string entityName, JObject jObject)>();

            foreach (var property in jObject.Properties().OrderBy(p => p.Name, StringComparer.OrdinalIgnoreCase))
            {
                var name = property.Name;
                var cleanName = new string(name.Where(c => char.IsLetterOrDigit(c)).ToArray());
                var fieldName = $"_{cleanName}";
                var propertyName = $"{char.ToUpper(cleanName[0])}{cleanName.Substring(1)}";
                string fieldType;
                string propertyType;
                var getter = fieldName;
                switch (property.Value.Type)
                {
                    case JTokenType.Boolean:
                        propertyType = "bool?";
                        fieldType = "DirtyValue<bool?>";
                        break;
                    case JTokenType.Date:
                        propertyType = "DateTime?";
                        fieldType = "DirtyValue<DateTime?>";
                        systemNamespace = true;
                        break;
                    case JTokenType.Float:
                        propertyType = "decimal?";
                        fieldType = "DirtyValue<decimal?>";
                        break;
                    case JTokenType.Guid:
                    case JTokenType.String:
                        propertyType = "string?";
                        fieldType = "DirtyValue<string?>";
                        break;
                    case JTokenType.Object:
                        propertyType = $"{propertyName}{nameSuffix}?";
                        if (!names.Add(propertyType))
                        {
                            propertyType = $"{entityName.Substring(0, entityName.Length - nameSuffix?.Length ?? 0)}{propertyName}{nameSuffix}?";
                            if (!names.Add(propertyType))
                            {
                                propertyType = $"{propertyName}Class{nameSuffix}?";
                                if (!names.Add(propertyType))
                                {
                                    propertyType = $"{entityName.Substring(0, entityName.Length - nameSuffix?.Length ?? 0)}{propertyName}Class{nameSuffix}?";
                                    if (!names.Add(propertyType))
                                    {
                                        throw new InvalidOperationException();
                                    }
                                }
                            }
                        }
                        fieldType = propertyType;
                        entities.Add((propertyType, (JObject)property.Value));
                        getter = $"GetField(ref {fieldName})";
                        break;
                    default:
                        // Need to handle the array case
                        throw new NotSupportedException();
                }

                fields.AppendLine($"        private {fieldType} {fieldName};");
                properties.AppendLine($@"        /// <summary>
        /// {entityName} {propertyName}
        /// </summary>");
                if (cleanName != name)
                {
                    properties.AppendLine($"        [JsonProperty(\"{name}\")]");
                    newtonsoftNamespace = true;
                }
                properties.AppendLine($"        public {propertyType} {propertyName} {{ get => {getter}; set => SetField(ref {fieldName}, value); }}")
                    .AppendLine();
            }

            fields.Length -= Environment.NewLine.Length;
            properties.Length -= 2 * Environment.NewLine.Length;

            using (var sw = new StreamWriter(Path.Combine(destinationPath, entityName + ".cs")))
            {
                sw.Write($@"{(systemNamespace ? @"using System;
" : string.Empty)}{(collectionsNamespace ? @"using System.Collections.Generic;
" : string.Empty)}{(newtonsoftNamespace ? @"using Newtonsoft.Json;
" : string.Empty)}{(systemNamespace || collectionsNamespace || newtonsoftNamespace ? Environment.NewLine : string.Empty)}namespace {@namespace}
{{
    /// <summary>
    /// {entityName}
    /// </summary>
    public sealed class {entityName} : DirtyExtensibleObject
    {{
{fields}

{properties}
    }}
}}");
            }

            foreach (var entity in entities)
            {
                GenerateClassesFromJson(destinationPath, @namespace, entity.entityName, entity.jObject, names, nameSuffix);
            }
        }

        private static void GenerateClassFileFromSchema(string destinationPath, string @namespace, string entityName, Type ellieType, EntitySchema entitySchema, Dictionary<string, Dictionary<string, string>> otherEnums, HashSet<string> requiredProperties, bool serializeWholeList)
        {
            var sb = new StringBuilder();

            var entityArguments = string.Empty;
            if (requiredProperties?.Count > 0)
            {
                entityArguments = $"PropertiesToAlwaysSerialize = nameof({string.Join(") + \",\" + nameof(", requiredProperties.OrderBy(p => p))})";
            }
            if (serializeWholeList)
            {
                entityArguments += $"{(entityArguments.Length > 0 ? ", " : string.Empty)}SerializeWholeListWhenDirty = true";
            }

            var systemNamespace = false;
            var collectionsNamespace = false;
            var enumsNamespace = false;
            var schemaNamespace = false;
            var codeAnalysisNamespace = false;

            if (ellieType != null)
            {
                foreach (var property in ellieType.GetProperties())
                {
                    if (!entitySchema.Properties.Any(p => string.Equals(p.Key.Replace("_", string.Empty), property.Name.Replace("_", string.Empty), StringComparison.OrdinalIgnoreCase)))
                    {
                        Console.WriteLine($"EncompassRest missing {ellieType.Name}.{property.Name} on {entityName}");
                    }
                }
            }

            var fields = new StringBuilder();
            var properties = new StringBuilder();

            foreach (var pair in entitySchema.Properties.OrderBy(pair => pair.Key, StringComparer.OrdinalIgnoreCase))
            {
                var propertyName = pair.Key.Replace("_", string.Empty);
                var entityPropertyName = $"{entityName}.{propertyName}";
                if (ellieType != null)
                {
                    var ellieProperty = ellieType.GetProperties().FirstOrDefault(p => string.Equals(propertyName, p.Name.Replace("_", string.Empty), StringComparison.OrdinalIgnoreCase));
                    var elliePropertyType = ellieProperty?.PropertyType;
                    if (ellieProperty == null)
                    {
                        Console.WriteLine($"Ellie missing {entityName}.{propertyName}");
                    }
                }
                if (!s_propertiesToNotGenerate.Contains(entityPropertyName))
                {
                    var propertySchema = pair.Value;
                    var attributeProperties = new List<string>();
                    var isField = !string.IsNullOrEmpty(propertySchema.FieldId) || propertySchema.FieldInstances?.Count > 0 || propertySchema.FieldPatterns?.Count > 0;
                    if (!string.IsNullOrEmpty(propertySchema.Format))
                    {
                        if (propertySchema.Format.EnumValue != LoanFieldFormat.STATE)
                        {
                            attributeProperties.Add($"Format = LoanFieldFormat.{propertySchema.Format.EnumValue?.GetName()}");
                            schemaNamespace = isField;
                        }
                    }
                    else
                    {
                        switch (propertySchema.Type.EnumValue)
                        {
                            case PropertySchemaType.DateTime:
                                attributeProperties.Add($"Format = LoanFieldFormat.DATETIME");
                                schemaNamespace = isField;
                                break;
                        }
                    }
                    if (propertySchema.ReadOnly == true)
                    {
                        attributeProperties.Add($"ReadOnly = true");
                    }
                    var propertyType = GetPropertyOrElementType(propertySchema, out var isEntity, out var isList);
                    if (s_explicitStringEnumValues.TryGetValue(entityPropertyName, out var enumName))
                    {
                        propertyType = $"StringEnumValue<{enumName}>";
                    }
                    else if (s_explicitDateTimeProperties.Contains(entityPropertyName))
                    {
                        propertyType = "DateTime?";
                    }
                    else if (s_explicitNADecimalProperties.Contains(entityPropertyName))
                    {
                        propertyType = "NA<decimal>";
                    }
                    else if (propertySchema.AllowedValues?.Count > 0)
                    {
                        if (propertyType == "string?")
                        {
                            var optionValues = propertySchema.AllowedValues.Where(o => !string.IsNullOrEmpty(o.Value) || !string.IsNullOrEmpty(o.Text)).Distinct().ToDictionary(o => o.Value, o => o.Text);
                            if (s_enumOptionsToIgnore.TryGetValue(propertyName, out var ignoredOptions))
                            {
                                foreach (var ignoredOption in ignoredOptions)
                                {
                                    optionValues.Remove(ignoredOption);
                                }
                            }
                            foreach (var enumPair in s_sharedEnums)
                            {
                                var setEquals = enumPair.Value.SetEquals(optionValues.Keys);
                                if (setEquals || (s_enumPropertyNamesToUseNotExactSharedEnum.Contains(propertyName) && enumPair.Value.IsSupersetOf(optionValues.Keys)))
                                {
                                    if (!setEquals)
                                    {
                                        var missingOptions = enumPair.Value.Except(optionValues.Keys);
                                        attributeProperties.Add($@"MissingOptionsJson = ""{JsonConvert.SerializeObject(missingOptions).Replace("\\", "\\\\").Replace("\"", "\\\"")}""");
                                    }
                                    enumName = enumPair.Key;
                                    var existingEnumType = typeof(EncompassRestClient).Assembly.GetType($"{@namespace}.Enums.{enumName}");
                                    foreach (var member in Enums.GetMembers(existingEnumType))
                                    {
                                        var existingText = member.AsString(EnumFormat.Description, EnumFormat.EnumMemberValue, EnumFormat.Name);
                                        var value = member.AsString(EnumFormat.EnumMemberValue, EnumFormat.Name);
                                        if (optionValues.TryGetValue(value, out var text) && string.Equals(existingText, text, StringComparison.Ordinal))
                                        {
                                            optionValues.Remove(value);
                                        }
                                    }
                                    if (optionValues.Count > 0)
                                    {
                                        attributeProperties.Add($@"OptionsJson = ""{JsonConvert.SerializeObject(optionValues).Replace("\\", "\\\\").Replace("\"", "\\\"")}""");
                                    }
                                    break;
                                }
                            }
                            if (enumName == null)
                            {
                                enumName = GetEnumName(entityName, propertyName);
                                if (otherEnums.TryGetValue(enumName, out var enumValues))
                                {
                                    Console.WriteLine($"{entityName} Duplicate {enumName}: `{string.Join(", ", optionValues.Keys)}` - `{string.Join(", ", enumValues.Keys)}`");
                                }
                                else if (s_sharedEnums.TryGetValue(enumName, out var sharedEnumValues))
                                {
                                    Console.WriteLine($"{entityName} Shared Duplicate {enumName}: `{string.Join(", ", optionValues.Keys)}` - `{string.Join(", ", sharedEnumValues)}`");
                                }
                                else
                                {
                                    otherEnums.Add(enumName, optionValues);
                                }
                            }
                            propertyType = $"StringEnumValue<{enumName}>";
                        }
                        else if (propertyType == "bool?")
                        {
                            var optionValues = propertySchema.AllowedValues.Where(o => !string.IsNullOrEmpty(o.Text) && ((string.Equals(o.Value, "true", StringComparison.Ordinal) && !string.Equals(o.Text, "Yes", StringComparison.Ordinal)) || (string.Equals(o.Value, "false", StringComparison.Ordinal) && !string.Equals(o.Text, "No", StringComparison.Ordinal)))).ToDictionary(o => string.Equals(o.Value, "true", StringComparison.Ordinal) ? "Y" : "N", o => o.Text);
                            if (optionValues.Count > 0)
                            {
                                attributeProperties.Add($@"OptionsJson = ""{JsonConvert.SerializeObject(optionValues).Replace("\\", "\\\\").Replace("\"", "\\\"")}""");
                            }
                        }
                        else
                        {
                            var optionValues = propertySchema.AllowedValues.Where(o => !string.IsNullOrEmpty(o.Value) || !string.IsNullOrEmpty(o.Text)).ToDictionary(o => o.Value, o => o.Text);
                            if (optionValues.Count > 0)
                            {
                                attributeProperties.Add($@"OptionsJson = ""{JsonConvert.SerializeObject(optionValues).Replace("\\", "\\\\").Replace("\"", "\\\"")}""");
                            }
                        }
                    }
                    if (propertyType.StartsWith("StringEnumValue<"))
                    {
                        if (propertyType != "StringEnumValue<State>")
                        {
                            enumsNamespace = true;
                        }
                    }
                    else if (propertyType == "DateTime?")
                    {
                        systemNamespace = true;
                    }
                    var elementType = propertyType;
                    var isStringDictionary = s_stringDictionaryProperties.Contains(entityPropertyName);
                    if (isStringDictionary)
                    {
                        propertyType = "DirtyDictionary<string, string?>?";
                        collectionsNamespace = true;
                    }
                    else if (isList)
                    {
                        propertyType = $"DirtyList<{elementType}>?";
                        collectionsNamespace = true;
                    }
                    var fieldName = $"_{char.ToLower(propertyName[0])}{propertyName.Substring(1)}";
                    var isNullable = propertySchema.Nullable == true;
                    fields.AppendLine($"        {(s_propertiesWithInternalFields.Contains(entityPropertyName) ? "internal" : "private")} {(isEntity && !isNullable ? $"{propertyType}?" : (isList || isStringDictionary ? propertyType : $"DirtyValue<{propertyType}>?"))} {fieldName};");
                    properties.AppendLine($@"        /// <summary>
        /// {(string.IsNullOrEmpty(propertySchema.Description) ? $"{entityName} {propertyName}" : propertySchema.Description.Replace("&", "&amp;"))}{(string.IsNullOrEmpty(propertySchema.FieldId) ? (propertySchema.FieldInstances?.Count == 1 ? $" [{propertySchema.FieldInstances.First().Key}]" : (propertySchema.FieldPatterns?.Count == 1 ? $" [{propertySchema.FieldPatterns.First().Key}]" : string.Empty)) : $" [{propertySchema.FieldId}]")}{(isNullable ? " (Nullable)" : string.Empty)}
        /// </summary>");
                    if ((isEntity && !isNullable) || isList || isStringDictionary)
                    {
                        properties.AppendLine($"        [AllowNull]");
                        codeAnalysisNamespace = true;
                    }
                    if (isField && attributeProperties.Count > 0)
                    {
                        properties.AppendLine($"        [LoanFieldProperty({string.Join(", ", attributeProperties)})]");
                    }
                    properties.AppendLine($"        public {(isStringDictionary ? $"IDictionary<string, string?>" : (isList ? $"IList<{elementType}>" : propertyType))} {propertyName} {{ get => {((isEntity && !isNullable) || isList || isStringDictionary ? $"GetField(ref {fieldName})" : fieldName)}; set => SetField(ref {fieldName}, value); }}").AppendLine();
                }
            }

            fields.Length -= Environment.NewLine.Length;
            properties.Length -= 2 * Environment.NewLine.Length;

            using (var sw = new StreamWriter(Path.Combine(destinationPath, entityName + ".cs")))
            {
                sw.Write($@"{(systemNamespace ? @"using System;
" : string.Empty)}{(collectionsNamespace ? @"using System.Collections.Generic;
" : string.Empty)}{(codeAnalysisNamespace ? @"using System.Diagnostics.CodeAnalysis;
" : string.Empty)}{(enumsNamespace ? $@"using {@namespace}.Enums;
" : string.Empty)}{(schemaNamespace ? @"using EncompassRest.Schema;
" : string.Empty)}{(systemNamespace || collectionsNamespace || enumsNamespace || schemaNamespace ? Environment.NewLine : string.Empty)}namespace {@namespace}
{{
    /// <summary>
    /// {entityName}
    /// </summary>
    {(entityArguments.Length > 0 ? $@"[Entity({entityArguments})]
    " : string.Empty)}public sealed partial class {entityName} : DirtyExtensibleObject, IIdentifiable
    {{
{fields}

{properties}
    }}
}}");
            }
        }

        private static void GenerateEnumFileFromOptions(string destinationPath, string @namespace, string enumName, Dictionary<string, string> options)
        {
            var componentModelNamespace = false;
            var serializationNamespace = false;

            var members = new StringBuilder();

            var enumMemberNames = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
            var existingEnumType = typeof(EncompassRestClient).Assembly.GetType($"{@namespace}.{enumName}");
            var existingEnumValues = new HashSet<int>();
            var first = true;
            if (existingEnumType != null)
            {
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
                    members.AppendLine($@"        /// <summary>
        /// {(text ?? value ?? name).Replace("&", "&amp;")}
        /// </summary>");

                    if (!string.IsNullOrEmpty(text) && !string.Equals(text, value ?? name, StringComparison.Ordinal))
                    {
                        members.AppendLine($@"        [Description(""{text.Replace("\\", "\\\\").Replace("\"", "\\\"")}"")]");
                        componentModelNamespace = true;
                    }
                    if (value != null && !string.Equals(value, name, StringComparison.Ordinal))
                    {
                        members.AppendLine($@"        [EnumMember(Value = ""{value.Replace("\\", "\\\\").Replace("\"", "\\\"")}"")]");
                        serializationNamespace = true;
                    }
                    enumMemberNames.Add(name);
                    options.Remove(value ?? name);
                    var intValue = member.ToInt32();
                    existingEnumValues.Add(intValue);
                    members.Append($"        {name} = {intValue}");
                    first = false;
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
                    members.AppendLine($@"        /// <summary>
        /// {(text ?? value).Replace("&", "&amp;")}
        /// </summary>");
                    if (!string.IsNullOrEmpty(text) && !string.Equals(value, text, StringComparison.Ordinal))
                    {
                        members.AppendLine($@"        [Description(""{text.Replace("\\", "\\\\").Replace("\"", "\\\"")}"")]");
                        componentModelNamespace = true;
                    }
                    if (!string.Equals(value, name, StringComparison.Ordinal))
                    {
                        members.AppendLine($@"        [EnumMember(Value = ""{value.Replace("\\", "\\\\").Replace("\"", "\\\"")}"")]");
                        serializationNamespace = true;
                    }
                    members.Append($"        {name} = {i}");
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
" : string.Empty)}{(componentModelNamespace || serializationNamespace ? Environment.NewLine : string.Empty)}namespace {@namespace}
{{
    /// <summary>
    /// {enumName}
    /// </summary>
    public enum {enumName}
    {{
{members}
    }}
}}");
            }
        }

        private static string GetPropertyOrElementType(PropertySchema propertySchema, out bool isEntity, out bool isList)
        {
            isEntity = false;
            isList = false;
            if (propertySchema.Format.EnumValue == LoanFieldFormat.STATE)
            {
                return "StringEnumValue<State>";
            }

            var propertyType = propertySchema.Type;
            switch (propertyType.EnumValue)
            {
                case PropertySchemaType.String:
                case PropertySchemaType.Uuid:
                    return "string?";
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
                    isList = true;
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