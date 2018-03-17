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
                typeof(PropertyFormType)
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

        private static readonly HashSet<string> s_propertiesToNotGenerate = new HashSet<string> { "Loan.ElliUCDFields", "Loan.VirtualFields" };

        private static readonly HashSet<string> s_missingSchemaEntities = new HashSet<string> { "VirtualFields", "ElliUCDFields", "NonVols", "DocumentOrderLog" };

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
            var fields = new Dictionary<string, string>();
            PopulateFieldMappings("Loan", loanEntitySchema, null, loanSchema, fields);

            var orderedFields = fields.OrderBy(p => p.Value.Substring(0, p.Value.LastIndexOf('.'))).ThenBy(p => p.Value).ToList();
            fields = new Dictionary<string, string>();
            foreach (var pair in orderedFields)
            {
                fields[pair.Key] = pair.Value.Substring(5);
            }

            using (var fs = new FileStream("LoanFields.json", FileMode.Create))
            {
                using (var sw = new StreamWriter(fs))
                {
                    JsonSerializer.Create(new JsonSerializerSettings { Formatting = Formatting.Indented }).Serialize(sw, fields);
                }
            }

            using (var fs = new FileStream("LoanFields.json.zip", FileMode.Create))
            {
                using (var zip = new ZipArchive(fs, ZipArchiveMode.Create))
                {
                    var entry = zip.CreateEntry("LoanFields.json", CompressionLevel.Optimal);
                    using (var sw = new StreamWriter(entry.Open()))
                    {
                        JsonSerializer.Create().Serialize(sw, fields);
                    }
                }
            }
        }

        private static void PopulateFieldMappings(string currentPath, EntitySchema entitySchema, EntitySchema previousEntitySchema, LoanSchema loanSchema, Dictionary<string, string> fields, bool isList = false)
        {
            foreach (var pair in entitySchema.Properties)
            {
                var propertyName = pair.Key;
                var propertySchema = pair.Value;
                if (!string.IsNullOrEmpty(propertySchema.FieldId))
                {
                    fields.Add(propertySchema.FieldId.ToUpper(), $"{currentPath}.{propertyName}");
                }
                else if (propertySchema.FieldInstances != null)
                {
                    foreach (var fieldInstancePair in propertySchema.FieldInstances)
                    {
                        var fieldId = fieldInstancePair.Key.ToUpper();
                        var fieldInstancePath = fieldInstancePair.Value.First();
                        if (previousEntitySchema.Properties.Any(p => string.Equals(p.Key, fieldInstancePath, StringComparison.Ordinal)))
                        {
                            fields.Add(fieldId, $"{currentPath.Substring(0, currentPath.LastIndexOf('.'))}.{fieldInstancePath}.{propertyName}");
                        }
                        else if (fieldInstancePath.StartsWith("Loan_Fees_"))
                        {
                            fields.Add(fieldId, $"{currentPath}[(FeeType == '{fieldInstancePath.Substring(10)}')].{propertyName}");
                        }
                        else if (fieldInstancePath.StartsWith("RegulationZ_RegulationZPayments_"))
                        {
                            fields.Add(fieldId, $"{currentPath}[(RegulationZPaymentIndex == '{fieldInstancePath.Substring(fieldInstancePath.LastIndexOf('_') + 1)}')].{propertyName}");
                        }
                        else if (fieldInstancePath.StartsWith("RegulationZ_RegulationZInterestRatePeriods_"))
                        {
                            fields.Add(fieldId, $"{currentPath}[(RegulationZInterestRatePeriodType == '{fieldInstancePath.Substring(fieldInstancePath.LastIndexOf('_') + 1)}')].{propertyName}");
                        }
                        else if (fieldInstancePath.StartsWith("FhaVaLoan_EnergyEfficientMortgageItems_"))
                        {
                            fields.Add(fieldId, $"{currentPath}[{fieldInstancePath.Substring(fieldInstancePath.LastIndexOf('_') + 1)}].{propertyName}");
                        }
                        else if (fieldInstancePath.StartsWith("Application_Income_"))
                        {
                            if (char.IsDigit(fieldInstancePath[fieldInstancePath.Length - 1]))
                            {
                                fields.Add(fieldId, $"{currentPath}[(IncomeType == 'OtherIncome' && OtherIncomeIndex == '{fieldInstancePath.Substring(fieldInstancePath.LastIndexOf('_') + 1)}')].{propertyName}");
                            }
                            else
                            {
                                var lastUnderscore = fieldInstancePath.LastIndexOf('_');
                                var borrowerStart = fieldInstancePath.LastIndexOf('_', lastUnderscore - 1) + 1;
                                fields.Add(fieldId, $"{currentPath}[(Owner == '{fieldInstancePath.Substring(borrowerStart, lastUnderscore - borrowerStart)}' && IncomeType == '{fieldInstancePath.Substring(lastUnderscore + 1)}')].{propertyName}");
                            }
                        }
                        else if (fieldInstancePath.StartsWith("Application_Assets_"))
                        {
                            var lastUnderscore = fieldInstancePath.LastIndexOf('_');
                            var assetTypeStart = fieldInstancePath.LastIndexOf('_', lastUnderscore - 1) + 1;
                            fields.Add(fieldId, $"{currentPath}[(AssetType == '{fieldInstancePath.Substring(assetTypeStart, lastUnderscore - assetTypeStart)}')][{fieldInstancePath.Substring(fieldInstancePath.LastIndexOf(':') + 1)}].{propertyName}");
                        }
                        else if (fieldInstancePath.StartsWith("Application_Liabilities_"))
                        {
                            var lastUnderscore = fieldInstancePath.LastIndexOf('_');
                            if (char.IsDigit(fieldInstancePath[fieldInstancePath.Length - 1]))
                            {
                                var liabilityTypeStart = fieldInstancePath.LastIndexOf('_', lastUnderscore - 1) + 1;
                                fields.Add(fieldId, $"{currentPath}[(LiabilityType == '{fieldInstancePath.Substring(liabilityTypeStart, lastUnderscore - liabilityTypeStart)}')][{fieldInstancePath.Substring(fieldInstancePath.LastIndexOf(':') + 1)}].{propertyName}");
                            }
                            else
                            {
                                fields.Add(fieldId, $"{currentPath}[(LiabilityType == '{fieldInstancePath.Substring(lastUnderscore + 1)}')].{propertyName}");
                            }
                        }
                        else if (fieldInstancePath.StartsWith("Application_Residences_"))
                        {
                            var lastUnderscore = fieldInstancePath.LastIndexOf('_');
                            var secondLastUnderscore = fieldInstancePath.LastIndexOf('_', lastUnderscore - 1);
                            int thirdLastUnderscore;
                            switch (fieldInstancePath.Count(c => c == '_'))
                            {
                                case 3:
                                    fields.Add(fieldId, $"{currentPath}[(ApplicantType == '{fieldInstancePath.Substring(secondLastUnderscore + 1, lastUnderscore - secondLastUnderscore - 1)}' && MailingAddressIndicator == '{fieldInstancePath.Substring(lastUnderscore + 1)}')][1].{propertyName}");
                                    break;
                                case 4:
                                    thirdLastUnderscore = fieldInstancePath.LastIndexOf('_', secondLastUnderscore - 1);
                                    fields.Add(fieldId, $"{currentPath}[(ApplicantType == '{fieldInstancePath.Substring(thirdLastUnderscore + 1, secondLastUnderscore - thirdLastUnderscore - 1)}' && MailingAddressIndicator == '{fieldInstancePath.Substring(secondLastUnderscore + 1, lastUnderscore - secondLastUnderscore - 1)}' && ResidencyType == '{fieldInstancePath.Substring(lastUnderscore + 1)}')][1].{propertyName}");
                                    break;
                                default:
                                    thirdLastUnderscore = fieldInstancePath.LastIndexOf('_', secondLastUnderscore - 1);
                                    var fourthLastUnderscore = fieldInstancePath.LastIndexOf('_', thirdLastUnderscore - 1);
                                    fields.Add(fieldId, $"{currentPath}[(ApplicantType == '{fieldInstancePath.Substring(fourthLastUnderscore + 1, thirdLastUnderscore - fourthLastUnderscore - 1)}' && MailingAddressIndicator == '{fieldInstancePath.Substring(thirdLastUnderscore + 1, secondLastUnderscore - thirdLastUnderscore - 1)}' && ResidencyType == '{fieldInstancePath.Substring(secondLastUnderscore + 1, lastUnderscore - secondLastUnderscore - 1)}')][{fieldInstancePath.Substring(fieldInstancePath.LastIndexOf(':') + 1)}].{propertyName}");
                                    break;
                            }
                        }
                        else if (fieldInstancePath.StartsWith("Application_Employment_"))
                        {
                            var lastUnderscore = fieldInstancePath.LastIndexOf('_');
                            var ownerStart = fieldInstancePath.LastIndexOf('_', lastUnderscore - 1) + 1;
                            fields.Add(fieldId, $"{currentPath}[(Owner == '{fieldInstancePath.Substring(ownerStart, lastUnderscore - ownerStart)}' && CurrentEmploymentIndicator == '{fieldInstancePath.Substring(lastUnderscore + 1)}')].{propertyName}");
                        }
                        else if (fieldInstancePath.StartsWith("Application_SelfEmployedIncomes_"))
                        {
                            switch (fieldInstancePath.Count(c => c == '_'))
                            {
                                case 2:
                                    fields.Add(fieldId, $"{currentPath}[(FormType == '{fieldInstancePath.Substring(fieldInstancePath.LastIndexOf('_') + 1)}')].{propertyName}");
                                    break;
                                default:
                                    var secondUnderscore = 31;
                                    var thirdUnderscore = fieldInstancePath.IndexOf('_', secondUnderscore + 1);
                                    fields.Add(fieldId, $"{currentPath}[(FormType == '{fieldInstancePath.Substring(secondUnderscore + 1, thirdUnderscore - secondUnderscore - 1)}' && FieldName == '{fieldInstancePath.Substring(thirdUnderscore + 1)}')].{propertyName}");
                                    break;
                            }
                            
                        }
                        else if (fieldInstancePath.StartsWith("Application_Tax4506s_"))
                        {
                            var lastUnderscore = fieldInstancePath.LastIndexOf('_');
                            var tax4506TIndicatorStart = fieldInstancePath.LastIndexOf('_', lastUnderscore - 1) + 1;
                            fields.Add(fieldId, $"{currentPath}[(Tax4506TIndicator == '{fieldInstancePath.Substring(tax4506TIndicatorStart, lastUnderscore - tax4506TIndicatorStart)}' && HistoryIndicator == '{fieldInstancePath.Substring(lastUnderscore + 1)}')].{propertyName}");
                        }
                        else if (fieldInstancePath.StartsWith("Application_AUSTrackingLogs_"))
                        {
                            fields.Add(fieldId, $"{currentPath}[{fieldInstancePath.Substring(fieldInstancePath.LastIndexOf('_') + 1)}].{propertyName}");
                        }
                        else if (fieldInstancePath.StartsWith("Application_ATRQMBorrowers_"))
                        {
                            fields.Add(fieldId, $"{currentPath}[{fieldInstancePath.Substring(fieldInstancePath.LastIndexOf('_') + 1)}].{propertyName}");
                        }
                        else if (fieldInstancePath.StartsWith("Loan_Contacts_"))
                        {
                            var colonIndex = fieldInstancePath.LastIndexOf(':');
                            if (colonIndex >= 0)
                            {
                                fields.Add(fieldId, $"{currentPath}[(ContactType == 'CUSTOM')][{fieldInstancePath.Substring(colonIndex + 1)}].{propertyName}");
                            }
                            else
                            {
                                fields.Add(fieldId, $"{currentPath}[(ContactType == '{fieldInstancePath.Substring(14)}')].{propertyName}");
                            }
                        }
                        else if (fieldInstancePath.StartsWith("Loan_PurchaseCredits_"))
                        {
                            fields.Add(fieldId, $"{currentPath}[{fieldInstancePath.Substring(fieldInstancePath.LastIndexOf('_') + 1)}].{propertyName}");
                        }
                        else if (fieldInstancePath.StartsWith("LoanSubmission_LoanSubmissionFees_"))
                        {
                            fields.Add(fieldId, $"{currentPath}[(LoanSubmissionFeeType == '{fieldInstancePath.Substring(fieldInstancePath.LastIndexOf('_') + 1)}')].{propertyName}");
                        }
                        else if (fieldInstancePath.StartsWith("VaLoanData_MilitaryServices_"))
                        {
                            fields.Add(fieldId, $"{currentPath}[(MilitaryServiceIndex == '{fieldInstancePath.Substring(fieldInstancePath.LastIndexOf('_') + 1)}')].{propertyName}");
                        }
                        else if (fieldInstancePath.StartsWith("VaLoanData_PreviousVaLoans_"))
                        {
                            fields.Add(fieldId, $"{currentPath}[(PreviousVaLoanIndex == '{fieldInstancePath.Substring(fieldInstancePath.LastIndexOf('_') + 1)}')].{propertyName}");
                        }
                        else if (fieldInstancePath.StartsWith("LoanProductData_Buydowns_"))
                        {
                            fields.Add(fieldId, $"{currentPath}[{fieldInstancePath.Substring(fieldInstancePath.LastIndexOf('_') + 1)}].{propertyName}");
                        }
                        else if (fieldInstancePath.StartsWith("LoanProductData_PrepaymentPenalties_"))
                        {
                            fields.Add(fieldId, $"{currentPath}[{fieldInstancePath.Substring(fieldInstancePath.LastIndexOf('_') + 1)}].{propertyName}");
                        }
                        else if (fieldInstancePath.StartsWith("Gfe_GfeFees_"))
                        {
                            var lastUnderscore = fieldInstancePath.LastIndexOf('_');
                            var firstStart = fieldInstancePath.LastIndexOf('_', lastUnderscore - 1) + 1;
                            var gfeFeeType = fieldInstancePath.Substring(firstStart, lastUnderscore - firstStart);
                            fields.Add(fieldId, $"{currentPath}[(GfeFeeType == '{gfeFeeType}'{(gfeFeeType != "UserDefined1" ? $" && GfeFeeIndex == '{fieldInstancePath.Substring(lastUnderscore + 1)}'" : string.Empty)})].{propertyName}");
                        }
                        else if (fieldInstancePath.StartsWith("Gfe_GfePayoffs_"))
                        {
                            fields.Add(fieldId, $"{currentPath}[(GfePayoffIndex == '{fieldInstancePath.Substring(fieldInstancePath.LastIndexOf('_') + 1)}')].{propertyName}");
                        }
                        else if (fieldInstancePath.StartsWith("Gfe_GfeLiens_"))
                        {
                            var lastUnderscore = fieldInstancePath.LastIndexOf('_');
                            var firstStart = 13;
                            fields.Add(fieldId, $"{currentPath}[(GfeLienType == '{fieldInstancePath.Substring(firstStart, lastUnderscore - firstStart)}' && GfeLienIndex == '{fieldInstancePath.Substring(lastUnderscore + 1)}')].{propertyName}");
                        }
                        else if (fieldInstancePath.StartsWith("Gfe_GfePayments_"))
                        {
                            fields.Add(fieldId, $"{currentPath}[(GfePaymentIndex == '{fieldInstancePath.Substring(fieldInstancePath.LastIndexOf('_') + 1)}')].{propertyName}");
                        }
                        else if (fieldInstancePath.StartsWith("Gfe2010_Gfe2010Fees_"))
                        {
                            var lastUnderscore = fieldInstancePath.LastIndexOf('_');
                            var nextLastUnderscore = fieldInstancePath.LastIndexOf('_', lastUnderscore - 1);
                            var firstStart = fieldInstancePath.LastIndexOf('_', nextLastUnderscore - 1) + 1;
                            var gfe2010FeeParentType = fieldInstancePath.Substring(firstStart, nextLastUnderscore - firstStart);
                            var gfe2010FeeType = fieldInstancePath.Substring(nextLastUnderscore + 1, lastUnderscore - nextLastUnderscore - 1);
                            var gfe2010FeeIndex = fieldInstancePath.Substring(lastUnderscore + 1);
                            fields.Add(fieldId, $"{currentPath}[(Gfe2010FeeParentType == '{gfe2010FeeParentType}'{(gfe2010FeeType != "Undefined" || gfe2010FeeParentType == "Section800BrokerCompensation" ? $" && Gfe2010FeeType == '{gfe2010FeeType}'" : string.Empty)}{(gfe2010FeeIndex != "0" || gfe2010FeeType == "Line801" ? $" && Gfe2010FeeIndex == '{gfe2010FeeIndex}'" : string.Empty)})].{propertyName}");
                        }
                        else if (fieldInstancePath.StartsWith("Gfe2010_Gfe2010WholePocs_"))
                        {
                            var lastUnderscore = fieldInstancePath.LastIndexOf('_');
                            var firstStart = fieldInstancePath.LastIndexOf('_', lastUnderscore - 1) + 1;
                            var wholePocIndex = fieldInstancePath.Substring(lastUnderscore + 1);
                            fields.Add(fieldId, $"{currentPath}[(LineNumber == '{fieldInstancePath.Substring(firstStart, lastUnderscore - firstStart)}'{(wholePocIndex != "0" ? $" && Gfe2010WholePocIndex == '{wholePocIndex}'" : string.Empty)})].{propertyName}");
                        }
                        else if (fieldInstancePath.StartsWith("Gfe2010Page_Gfe2010GfeCharges_"))
                        {
                            var lastUnderscore = fieldInstancePath.LastIndexOf('_');
                            var firstStart = fieldInstancePath.LastIndexOf('_', lastUnderscore - 1) + 1;
                            fields.Add(fieldId, $"{currentPath}[(ChargeBelow10Indicator == '{fieldInstancePath.Substring(firstStart, lastUnderscore - firstStart)}' && Gfe2010GfeChargeIndex == '{fieldInstancePath.Substring(lastUnderscore + 1)}')].{propertyName}");
                        }
                        else if (fieldInstancePath.StartsWith("Gfe2010Page_Gfe2010FwbcFwscs_"))
                        {
                            if (char.IsLetter(fieldInstancePath[fieldInstancePath.Length - 1]))
                            {
                                var lastUnderscore = fieldInstancePath.LastIndexOf('_');
                                var secondLastUnderscore = fieldInstancePath.LastIndexOf('_', lastUnderscore - 1);
                                var thirdLastUnderscore = fieldInstancePath.LastIndexOf('_', secondLastUnderscore - 1);
                                var lineNumber = fieldInstancePath.Substring(thirdLastUnderscore + 1, secondLastUnderscore - thirdLastUnderscore - 1);
                                fields.Add(fieldId, $"{currentPath}[(LineNumber == '{lineNumber}' && LineLetter == '{fieldInstancePath.Substring(lastUnderscore + 1)}'{(lineNumber == "1102" ? $" && Gfe2010FwbcFwscIndex == '{fieldInstancePath.Substring(secondLastUnderscore + 1, lastUnderscore - secondLastUnderscore - 1)}'" : string.Empty)})].{propertyName}");
                            }
                            else
                            {
                                var lastUnderscore = fieldInstancePath.LastIndexOf('_');
                                var firstStart = fieldInstancePath.LastIndexOf('_', lastUnderscore - 1) + 1;
                                fields.Add(fieldId, $"{currentPath}[(LineNumber == '{fieldInstancePath.Substring(firstStart, lastUnderscore - firstStart)}' && Gfe2010FwbcFwscIndex == '{fieldInstancePath.Substring(lastUnderscore + 1)}')].{propertyName}");
                            }
                        }
                        else if (fieldInstancePath.StartsWith("ClosingDisclosure3_UCDDetails_"))
                        {
                            var lastUnderscore = fieldInstancePath.LastIndexOf('_');
                            var nextLastUnderscore = fieldInstancePath.LastIndexOf('_', lastUnderscore - 1);
                            var firstStart = fieldInstancePath.LastIndexOf('_', nextLastUnderscore - 1) + 1;
                            fields.Add(fieldId, $"{currentPath}[(Section == '{fieldInstancePath.Substring(firstStart, nextLastUnderscore - firstStart)}' && LineNumber == '{fieldInstancePath.Substring(nextLastUnderscore + 1, lastUnderscore - nextLastUnderscore - 1)}' && FeeIndex == '{fieldInstancePath.Substring(lastUnderscore + 1)}')].{propertyName}");
                        }
                        else if (fieldInstancePath.StartsWith("ClosingCost_FeeVariances_"))
                        {
                            var lastUnderscore = fieldInstancePath.LastIndexOf('_');
                            var firstStart = fieldInstancePath.LastIndexOf('_', lastUnderscore - 1) + 1;
                            fields.Add(fieldId, $"{currentPath}[(FeeVarianceFeeType == '{fieldInstancePath.Substring(firstStart, lastUnderscore - firstStart)}' && FeeVarianceChargeIndex == '{fieldInstancePath.Substring(lastUnderscore + 1)}')].{propertyName}");
                        }
                        else if (fieldInstancePath.StartsWith("ClosingDocument_ClosingEntities_"))
                        {
                            fields.Add(fieldId, $"{currentPath}[(ClosingEntityType == '{fieldInstancePath.Substring(fieldInstancePath.LastIndexOf('_') + 1)}')].{propertyName}");
                        }
                        else if (fieldInstancePath.StartsWith("ClosingDocument_AdditionalStateDisclosures_"))
                        {
                            var firstStart = 43;
                            var underscore = fieldInstancePath.IndexOf('_', firstStart);
                            fields.Add(fieldId, $"{currentPath}[(StateCode == '{fieldInstancePath.Substring(firstStart, underscore - firstStart)}' && DisclosureName == '{fieldInstancePath.Substring(underscore + 1)}')].{propertyName}");
                        }
                        else if (fieldInstancePath.StartsWith("ClosingDocument_RespaHudDetails_"))
                        {
                            fields.Add(fieldId, $"{currentPath}[(LineNumber == '{fieldInstancePath.Substring(fieldInstancePath.LastIndexOf('_') + 1)}')].{propertyName}");
                        }
                        else if (fieldInstancePath.StartsWith("ClosingDocument_StateLicenses_"))
                        {
                            fields.Add(fieldId, $"{currentPath}[(StateLicenseType == '{fieldInstancePath.Substring(fieldInstancePath.LastIndexOf('_') + 1)}')].{propertyName}");
                        }
                        else if (fieldInstancePath.StartsWith("ClosingDocument_AntiSteeringLoanOptions_"))
                        {
                            fields.Add(fieldId, $"{currentPath}[(AntiSteeringLoanOptionIndex == '{fieldInstancePath.Substring(fieldInstancePath.LastIndexOf('_') + 1)}')].{propertyName}");
                        }
                        else if (fieldInstancePath.StartsWith("HudLoanData_SecondaryFinancingProviders_"))
                        {
                            fields.Add(fieldId, $"{currentPath}[(SecondaryFinancingProviderType == '{fieldInstancePath.Substring(fieldInstancePath.LastIndexOf('_') + 1)}')].{propertyName}");
                        }
                        else if (fieldInstancePath.StartsWith("Shipping_ShippingContacts_"))
                        {
                            fields.Add(fieldId, $"{currentPath}[(ShippingContactType == '{fieldInstancePath.Substring(fieldInstancePath.LastIndexOf('_') + 1)}')].{propertyName}");
                        }
                        else if (fieldInstancePath.StartsWith("Loan_SettlementServiceCharges_"))
                        {
                            fields.Add(fieldId, $"{currentPath}[{fieldInstancePath.Substring(fieldInstancePath.LastIndexOf('_') + 1)}].{propertyName}");
                        }
                        else if (fieldInstancePath.StartsWith("StateDisclosure_NewYorkPrimaryLenders_"))
                        {
                            fields.Add(fieldId, $"{currentPath}[(NewYorkPrimaryLenderIndex == '{fieldInstancePath.Substring(fieldInstancePath.LastIndexOf('_') + 1)}')].{propertyName}");
                        }
                        else if (fieldInstancePath.StartsWith("Hud1Es_Hud1EsPayTos_"))
                        {
                            fields.Add(fieldId, $"{currentPath}[(Hud1EsPayToIndex == '{fieldInstancePath.Substring(fieldInstancePath.LastIndexOf('_') + 1)}')].{propertyName}");
                        }
                        else if (fieldInstancePath.StartsWith("ProfitManagement_ProfitManagementItems_"))
                        {
                            fields.Add(fieldId, $"{currentPath}[(ProfitManagementItemIndex == '{fieldInstancePath.Substring(fieldInstancePath.LastIndexOf('_') + 1)}')].{propertyName}");
                        }
                        else if (fieldInstancePath.StartsWith("Prequalification_PrequalificationScenarios_"))
                        {
                            fields.Add(fieldId, $"{currentPath}[{fieldInstancePath.Substring(fieldInstancePath.LastIndexOf('_') + 1)}].{propertyName}");
                        }
                        else if (fieldInstancePath.StartsWith("Usda_UsdaHouseholdIncomes_"))
                        {
                            fields.Add(fieldId, $"{currentPath}[(UsdaHouseholdIncomeIndex == '{fieldInstancePath.Substring(fieldInstancePath.LastIndexOf('_') + 1)}')].{propertyName}");
                        }
                        else if (fieldInstancePath.StartsWith("Loan_MilestoneTemplateLogs_"))
                        {
                            fields.Add(fieldId, $"{currentPath}[1].{propertyName}");
                        }
                        else if (fieldInstancePath.StartsWith("RateLock_") && fieldInstancePath.Contains("Adjustments_"))
                        {
                            var firstUnderscore = fieldInstancePath.IndexOf('_');
                            var secondUnderscore = fieldInstancePath.IndexOf('_', firstUnderscore + 1);
                            var thirdUnderscore = fieldInstancePath.IndexOf('_', secondUnderscore + 1);
                            var fourthUnderscore = fieldInstancePath.IndexOf('_', thirdUnderscore + 1);
                            fields.Add(fieldId, $"{currentPath.Substring(0, currentPath.LastIndexOf('.'))}.{fieldInstancePath.Substring(firstUnderscore + 1, secondUnderscore - firstUnderscore - 1)}[(PriceAdjustmentType == '{fieldInstancePath.Substring(secondUnderscore + 1, thirdUnderscore - secondUnderscore - 1)}' && AdjustmentType == '{fieldInstancePath.Substring(thirdUnderscore + 1, fourthUnderscore - thirdUnderscore - 1)}')][{fieldInstancePath.Substring(fieldInstancePath.LastIndexOf(':') + 1)}].{propertyName}");
                        }
                        else if (fieldInstancePath.StartsWith("RateLock_PurchaseAdvicePayouts_"))
                        {
                            fields.Add(fieldId, $"{currentPath}[{fieldInstancePath.Substring(fieldInstancePath.LastIndexOf('_') + 1)}].{propertyName}");
                        }
                        else if (fieldInstancePath.StartsWith("RateLock_LockRequestBorrowers_"))
                        {
                            fields.Add(fieldId, $"{currentPath}[{fieldInstancePath.Substring(fieldInstancePath.LastIndexOf('_') + 1)}].{propertyName}");
                        }
                        else if (fieldInstancePath.StartsWith("RateLock_ExtraPayments_"))
                        {
                            fields.Add(fieldId, $"{currentPath}[(LineNumber == '{fieldInstancePath.Substring(fieldInstancePath.LastIndexOf('_') + 1)}')].{propertyName}");
                        }
                        else
                        {
                            Console.WriteLine($"[{fieldId}]: {fieldInstancePath}");
                        }
                    }
                }
                else if (propertySchema.Type == PropertySchemaType.Entity && loanSchema.EntityTypes.TryGetValue(propertySchema.EntityType, out var nestedEntitySchema))
                {
                    loanSchema.EntityTypes.Remove(propertySchema.EntityType);
                    PopulateFieldMappings($"{currentPath}.{propertyName}", nestedEntitySchema, entitySchema, loanSchema, fields);
                }
                else if ((propertySchema.Type == PropertySchemaType.List || propertySchema.Type == PropertySchemaType.Set) && loanSchema.EntityTypes.TryGetValue(propertySchema.ElementType, out var elementEntitySchema))
                {
                    loanSchema.EntityTypes.Remove(propertySchema.ElementType);
                    PopulateFieldMappings($"{currentPath}.{propertyName}", elementEntitySchema, entitySchema, loanSchema, fields, true);
                }
            }
        }

        public static async Task GenerateClassFilesFromSchemaAsync(EncompassRestClient client, string destinationPath, string @namespace)
        {
            Directory.CreateDirectory(destinationPath);
            var supportedEntities = new HashSet<string>((await client.Loans.GetSupportedEntitiesAsync().ConfigureAwait(false)).Select(e => e.Value))
            {
                "NonVol"
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
                    sb.AppendLine($"        public {(isCollection ? $"IList<{elementType}>" : propertyType)} {propertyName} {{ get => {fieldName}{(isEntity || isCollection ? $" ?? ({fieldName} = new {propertyType}())" : string.Empty)}; set {(isModelPath ? "{ _modelPath = value; _modelPathInternal = EncompassRest.ModelPath.Create(value); }" : $"=> {fieldName} = {(isCollection ? $"new {propertyType}(value)" : "value")};")} }}");
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
                    return propertySchema.EntityType;
                default:
                    return $"PROBLEM<{propertyType}>";
            }
        }

        private static string GetEnumName(string entityType, string propertyName) => s_enumPropertyNamesToUseEntityTypeInName.Contains(propertyName) ? $"{entityType}{propertyName}" : propertyName;
    }
}