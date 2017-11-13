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

namespace EncompassRest
{
    public static class EntityGenerator
    {
        private static readonly Dictionary<string, HashSet<string>> s_sharedEnums = new Dictionary<string, HashSet<string>>
        {
            { "YOrN", new HashSet<string> { "N", "Y" } },
            { "YNOrNA", new HashSet<string> { "Y", "N", "N/A" } },
            { "YesOrNo", new HashSet<string> { "Yes", "No" } },
            { "YesNoOrNA", new HashSet<string> { "Yes", "No", "N/A" } },
            { "TrueOrFalse", new HashSet<string> { "true", "false" } },
            { "AcceptOrReject", new HashSet<string> { "Accept", "Reject" } },
            { "IncreasedOrDecreased", new HashSet<string> { "Increased", "Decreased" } },
            { "UtilitiesDescription", new HashSet<string> { "Public", "Community", "Individual" } },
            { "TermType", new HashSet<string> { "Months", "Year", "Years" } },
            { "SignedByTyp", new HashSet<string> { "Loan Originator", "Loan Closer", "Lender Contact" } },
            { "TotalClosingCostRemark", new HashSet<string> { "Total Loan Costs (D)", "Total Other Costs (I)", "Total Loan Costs (D) and Total Other Costs (I)" } },
            { "PartyType", new HashSet<string> { "Lender", "Investor" } },
            { "AUS", new HashSet<string> { "DU", "LP", "TOTAL", "GUS", "Other", "Not applicable" } },
            { "AUSRecommendation", new HashSet<string> { "Approve/Eligible", "Approve/Ineligible", "Refer/Eligible", "Refer/Ineligible", "Refer with Caution", "Out of Scope", "Error", "Accept", "Caution", "Ineligible", "Incomplete", "Invalid", "Refer", "Eligible", "Unable to Determine", "Other", "Not applicable" } },
            { "BankruptcyForeclosureStatus", new HashSet<string> { "Discharged", "Dismissed" } },
            { "LicenseAuthType", new HashSet<string> { "Private", "Public Federal", "Public Local", "Public State" } },
            { "BorContingentLiabilitiesLiabilityDescription", new HashSet<string> { "FHA Assumed Mortgage Payment", "VA Assumed Mortgage Payment", "Conventional Assumed Mortgage Payment" } },
            { "BorrowerType", new HashSet<string> { "Individual", "Co-signer", "Title only", "Non Title Spouse", "Trustee", "Title Only Trustee", "Settlor Trustee", "Settlor", "Title Only Settlor Trustee", "Officer" } },
            { "ClosingCostFundsType", new HashSet<string> { "BridgeLoan", "CashOnHand", "CashOrOtherEquity", "CheckingSavings", "Contribution", "CreditCard", "EquityOnSubjectProperty", "GiftFunds", "Grant", "LifeInsuranceCashValue", "LotEquity", "Other", "PremiumFunds", "RentWithOptionToPurchase", "RetirementFunds", "SaleOfChattel", "SecuredLoan", "StocksAndBonds", "SweatEquity", "TradeEquity", "TrustFunds", "UnsecuredBorrowedFunds" } },
            { "FundsTypeDescription", new HashSet<string> { "AggregatedRemainingTypes", "SecondaryFinancingClosedEnd", "SecondaryFinancingHELOC" } },
            { "ClosingCostSourceType", new HashSet<string> { "Borrower", "CommunityNonProfit", "Employer", "FederalAgency", "Lender", "LocalAgency", "Other", "PropertySeller", "Relative", "ReligiousNonProfit", "StateAgency" } },
            { "SourceTypeDescription", new HashSet<string> { "AggregatedRemainingSourceTypes", "FHLBAffordableHousingProgram", "USDARuralHousing" } },
            { "DocsLoanProgramType", new HashSet<string> { "Opening", "Closing", "Both" } },
            { "ServicingType", new HashSet<string> { "Service Retained", "Service Released" } },
            { "CorrespondentOptionDesc", new HashSet<string> { "HailAndWindInsurance", "LavaInsurance", "EarthquakeInsurance", "SchoolTaxes", "OtherTaxes" } },
            { "CreditChargeType", new HashSet<string> { "Origination Charge", "Settlement Reduced", "Settlement Increased" } },
            { "DenialReason", new HashSet<string> { "Debt to Income Ratio", "Employment history", "Credit history", "Collateral", "Insufficient Cash", "Unverifiable Information", "Credit application Incomplete", "Mortgage insurance denied", "Other", "Not applicable" } },
            { "DisclosureMethod", new HashSet<string> { "U.S. Mail", "eFolder eDisclosures", "Fax", "In Person", "Other" } },
            { "DownPaymentSourceType", new HashSet<string> { "Borrower", "CommunityNonProfit", "Employer", "FederalAgency", "LocalAgency", "Other", "Relative", "ReligiousNonProfit", "StateAgency" } },
            { "YNOrOther", new HashSet<string> { "Y", "N", "Other" } },
            { "Hud1EsPayToFeeType", new HashSet<string> { "ForTax", "ForInsurance" } },
            { "RefundableType", new HashSet<string> { "NonRefundable", "Refundable", "NA" } },
            { "RecSamePtyTypeDesc", new HashSet<string> { "Lender Info Tab", "Title", "Escrow", "Encompass Prepared By", "Buyer's Attorney", "Investor", "User Input" } },
            { "FeddieBorrowerAlienStatus", new HashSet<string> { "Non Permanent Resident Alien", "Non Resident Alien" } },
            { "FreddieDownPaymentType", new HashSet<string> { "BridgeLoan", "CashOnHand", "CheckingSavings", "EquityOnSubjectProperty", "GiftFunds", "LifeInsuranceCashValue", "LotEquity", "OtherTypeOfDownPayment", "RentWithOptionToPurchase", "RetirementFunds", "SaleOfChattel", "SecuredBorrowedFunds", "StocksAndBonds", "SweatEquity", "TradeEquity", "TrustFunds", "UnsecuredBorrowedFunds" } },
            { "FullPrepaymentPenaltyOptionType", new HashSet<string> { "Hard", "Soft" } },
            { "ATRQMStatus", new HashSet<string> { "Meets Standard", "Not Meet", "Review Needed" } },
            { "ImpoundType", new HashSet<string> { "Taxes and Insurance", "Taxes only", "Insurance only", "No Impounds" } },
            { "ClosingCostImpoundType", new HashSet<string> { "Loan Amount", "Purchase Price", "Appraisal Value", "Base Loan Amount", "As Completed Purchase Price", "As Completed Appraised Value" } },
            { "ImpoundWaived", new HashSet<string> { "Waived", "Not Waived" } },
            { "IncludeOriginationPointsCreditType", new HashSet<string> { "Include Origination Points", "Include Origination Credit" } },
            { "InformationTypesWeCollect", new HashSet<string> { "Account balances", "Account transactions", "Assets", "Checking account information", "Credit-based insurance scores", "Credit card or other debt", "Credit history", "Credit scores", "Employment information", "Income", "Insurance claim history", "Investment experience", "Medical information", "Medical-related debts", "Mortgage rates and payments", "Overdraft history", "Payment history", "Purchase history", "Retirement assets", "Risk tolerance", "Transaction history", "Transaction or loss history", "Wire transfer instructions" } },
            { "ProjectType", new HashSet<string> { "A_IIICondominium", "B_IICondominium", "C_ICondominium", "OneCooperative", "TwoCooperative", "TCooperative", "E_PUD", "F_PUD", "T_PUD", "III PUD", "P_LimitedReviewNew", "Q_LimitedReviewEst", "R_ExpeditedNew", "S_ExpeditedEst", "T_FannieMaeReview", "U_FHAapproved", "V_RefiPlus", "DetachedProject", "2To4UnitProject", "ReciprocalReview", "Approved FHA/VA Condominium Project Or Spot Loan", "G_NotInAProjectOrDevelopment" } },
            { "MonthOrYear", new HashSet<string> { "Month", "Year" } },
            { "CanGoOrGoes", new HashSet<string> { "Can go", "Goes" } },
            { "OrgTyp", new HashSet<string> { "a Banking Corporation", "a Chartered Bank", "a Corporation", "a Federal Association", "a Federal Bank", "a Federal Credit Union", "a Federal Savings Association", "a Federal Savings Bank", "a Federally Chartered Thrift", "a Federally Chartered Savings Bank", "a General Partnership", "a Limited Liability Corporation", "a Limited Partnership", "a Mutual Savings Bank", "a National Association", "a National Bank", "a National Banking Association", "a Partnership", "a Professional Association", "a Professional Corporation", "a Proprietorship", "a Sole Proprietorship", "a Savings Bank", "a State Bank", "a State Banking Association", "a State Chartered Credit Union", "a State Chartered Bank", "a State Savings Bank", "a Sub S Corporation", "an S Corporation" } },
            { "IsOrIsNot", new HashSet<string> { "is", "is not" } },
            { "LimitSharing", new HashSet<string> { "Yes", "No", "We Don't Share" } },
            { "ScsrsClaus", new HashSet<string> { "Its Successors And/Or Assigns", "Its Successors And/Or Assigns, As Their Interest May Appear", "Its Successors And/Or Assigns, A.T.I.M.A." } },
            { "CanIncreaseOrIncreases", new HashSet<string> { "Can increase", "Increases" } },
            { "LoanAmountType", new HashSet<string> { "Total Loan", "Base Loan" } },
            { "LoanDocumentationType", new HashSet<string> { "Alternative", "FullDocumentation", "Reduced", "StreamlineRefinance", "NoDocumentation", "NoRatio", "LimitedDocumentation", "NoIncomeNoEmploymentNoAssetsOn1003", "NoDepositVerificationEmploymentVerificationOrIncomeVerification", "NoDepositVerification", "NoEmploymentVerificationOrIncomeVerification", "NoIncomeOn1003", "NoVerificationOfStatedIncomeEmploymentOrAssets", "NoVerificationOfStatedIncomeOrAssets", "NoVerificationOfStatedAssets", "NoVerificationOfStatedIncomeOrEmployment", "NoVerificationOfStatedIncome", "VerbalVerificationOfEmployment", "OnePaystub", "OnePaystubAndVerbalVerificationOfEmployment", "OnePaystubAndOneW2AndVerbalVerificationOfEmploymentOrOneYear1040", "NoIncomeon1003" } },
            { "LoanPurposeType", new HashSet<string> { "ConstructionToPermanent", "NoCash-Out Refinance", "Purchase", "ConstructionOnly", "Cash-Out Refinance", "Other" } },
            { "LoanType", new HashSet<string> { "Conventional", "VA", "FHA", "Other", "FarmersHomeAdministration", "HELOC" } },
            { "RefinancePurpose", new HashSet<string> { "CashOutDebtConsolidation", "CashOutHomeImprovement", "CashOutLimited", "CashOutOther", "CashOutOriginalLender", "ChangeInRateTerm", "NoCashOutOther", "NoCashOutFHAStreamlinedRefinance", "NoCashOutFREOwnedRefinance", "NoCashOutStreamlinedRefinance", "NoCashOutOriginalLender" } },
            { "PropertyType", new HashSet<string> { "Attached", "Condominium", "Cooperative", "Detached", "HighRiseCondominium", "ManufacturedHousing", "PUD", "DetachedCondo", "ManufacturedHomeCondoPUDCoOp", "MHSelect" } },
            { "LienType", new HashSet<string> { "FirstLien", "SecondLien" } },
            { "DoesOrDoesNot", new HashSet<string> { "Does", "Does not" } },
            { "DoesOrDoesNot2", new HashSet<string> { "does", "does not" } },
            { "OpenBankruptcy", new HashSet<string> { "None", "7", "11", "13" } },
            { "InterestRateImpactedStatus", new HashSet<string> { "Decreases Interest Rate", "Increases Interest Rate", "Has no impact on Loan Terms" } },
            { "FeePaidBy", new HashSet<string> { "Borrower", "Lender", "Seller", "Broker (Realtor)" } },
            { "Owner", new HashSet<string> { "Borrower", "CoBorrower", "Both" } },
            { "PaidBy", new HashSet<string> { "Broker", "Lender", "Other", "Seller" } },
            { "PaidType", new HashSet<string> { "Cash", "Other" } },
            { "PenaltyTerm", new HashSet<string> { "1 Year", "2 Years", "3 Years" } },
            { "OccupancyIntent", new HashSet<string> { "Will Occupy", "Will Not Occupy", "Currently Occupy" } },
            { "PrepaymentPenaltyBasedOn", new HashSet<string> { "Original Principal Amount", "Amount Prepaid", "Unpaid Balance" } },
            { "PropertyUsageType", new HashSet<string> { "PrimaryResidence", "SecondHome", "Investor" } },
            { "PTB", new HashSet<string> { "Broker", "Lender", "Seller", "Investor", "Affiliate", "Other" } },
            { "DaysInYear", new HashSet<string> { "360", "364", "365" } },
            { "TypeOfPurchaser", new HashSet<string> { "Loan was not originated", "FNMA", "GNMA", "FHLMC", "FAMC", "Private Securitization", "Savings Bank", "Credit union, mortgage company, or finance company", "Life Insurance Co.", "Affiliate Institution", "Other type of purchaser" } },
            { "RiskClassification", new HashSet<string> { "1", "2" } },
            { "RoundingMethod", new HashSet<string> { "To Nearest Cent", "To Nearest Dollar" } },
            { "SignatureType", new HashSet<string> { "AsApplicant", "ByName", "None" } },
            { "FinalSignatureType", new HashSet<string> { "esigned", "wetsigned", "other" } },
            { "SofDBorrowerAddressType", new HashSet<string> { "Present Address", "Mailing Address", "Subject Address" } },
            { "TimesToCollect", new HashSet<string> { "Apply for a lease", "Apply for a loan", "Apply for financing", "Apply for insurance", "Buy securities from us", "Deposit Money", "Direct us to buy securities", "Direct us to sell your securities", "Enter into an investment advisory contract", "File an insurance claim", "Give us your contact information", "Give us your employment history", "Give us your income information", "Give us your wage statements", "Make a wire transfer", "Make deposits or withdrawals from your account", "Order a commodity futures or option trade", "Open an account", "Pay insurance premiums", "Pay us by check", "Pay your bills", "Provide account information", "Provide employment information", "Provide your mortgage information", "Seek advice about your investments", "Seek financial or tax advice", "Sell securities to us", "Show your driver's license", "Show your government issued ID", "Tell us about your investment or retirement earnings", "Tell us about your investment or retirement portfolio", "Tell us where to send the money", "Tell us who receives the money", "Use your credit or debit card" } },
            { "TrstSamePtyTypDesc", new HashSet<string> { "Title", "Escrow", "Encompass Trustee", "Buyer's Attorney", "User Input" } },
            { "ProfitManagementItemType", new HashSet<string> { "Profit", "Loan" } },
            { "UCDPayoffType", new HashSet<string> { "BorrowerEstimatedTotalMonthlyLiabilityPayment", "CollectionsJudgmentsAndLiens", "DeferredStudentLoan", "DelinquentTaxes", "FirstPositionMortgageLien", "Garnishments", "HELOC", "HomeownersAssociationLien", "Installment", "LeasePayment", "MortgageLoan", "Open30DayChargeAccount", "Other", "PersonalLoan", "Revolving", "SecondPositionMortgageLien", "Taxes", "TaxLien", "ThirdPositionMortgageLien", "UnsecuredHomeImprovementLoanInstallment", "UnsecuredHomeImprovementLoanRevolving" } },
            { "UlddBorrowerType", new HashSet<string> { "Individual", "Legal Entity" } },
            { "VestingTrusteeOfType", new HashSet<string> { "Trust 1", "Trust 2" } },
            { "WholePocPaidByType", new HashSet<string> { "Broker", "Lender", "Other" } },
            { "AmortizationType", new HashSet<string> { "Fixed", "GraduatedPaymentMortgage", "AdjustableRate", "OtherAmortizationType" } },
            { "ApplicationTakenMethodType", new HashSet<string> { "FaceToFace", "Internet", "Mail", "Telephone" } },
            { "OtherPropertyType", new HashSet<string> { "1 Unit", "2-4 Units", "Condominium", "PUD", "Cooperative", "Manufactured Housing Single Wide", "Manufactured Housing Multiwide" } },
            { "RiskAssessmentType", new HashSet<string> { "Manual Underwriting", "DU", "LP", "LQA", "Other" } },
            { "ActionTaken", new HashSet<string> { "Loan Originated", "Application approved but not accepted", "Application denied", "Application withdrawn", "File Closed for incompleteness", "Loan purchased by your institution", "Preapproval request denied by financial institution", "Preapproval request approved but not accepted" } },
            { "IndexMargin", new HashSet<string> { "UST1YW", "UST3YW", "UST5YW", "UST7YW", "UST10YW", "UST20YW", "UST30YW", "UST1Y", "UST3Y", "UST5Y", "UST7Y", "UST10Y", "UST20Y", "UST30Y", "3MoCD(12MoAvg)", "6MCDW", "UST6M", "FRBCommercial3M", "FRBBankPrime", "FHLBSFCOFI", "CMR", "FHFB_NACMR", "FRBDiscount", "FHLMC30Y30D", "FHLMC30Y60D", "FHLMC30Y90D", "FHLMCLIBOR1M", "FHLMCLIBOR3M", "FHLMCLIBOR6M", "FHLMCLIBOR1Y", "FNMA12MAVG", "FNMA15Y60D", "FNMA30Y30D", "FNMA30Y60D", "FNMA30Y90D", "FNMALIBOR1M", "FNMALIBOR3M", "FNMALIBOR6M", "FNMALIBOR1Y", "LIBOR1M", "LIBOR3M", "LIBOR6M", "LIBOR12M", "MTA", "TNMax", "WSJPrime", "WSJPrimeWkly" } },
            { "PropertyFormType", new HashSet<string> { "Uniform Residential Appraisal Report", "Manufactured Home Appraisal Report", "Small Residential Income Property Appraisal Report", "Individual Condominium Unit Appraisal Report", "Exterior Only Inspection Individual Condominium Unit Appraisal Report", "One Unit Residential Appraisal Field Review Report", "Two To Four Unit Residential Appraisal", "Exterior Only Inspection Residential Appraisal Report", "Individual Cooperative Interest Appraisal Report", "Exterior Only Inspection Individual Cooperative Interest Appraisal Report", "Appraisal Update And Or Completion Report", "Desktop Underwriter Property Inspection Report", "Loan Prospector Condition And Marketability" } }
        };

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

        private static readonly HashSet<string> s_propertiesToNotGenerate = new HashSet<string> { "Loan.ElliUCDFields", "Loan.NonVols", "Loan.VirtualFields" };

        public static void Main(string[] args)
        {
            Console.ReadLine();

            try
            {
                Task.Run(async () =>
                {
                    using (var client = await TestBaseClass.GetTestClientAsync())
                    {
                        await GenerateClassFilesFromSchemaAsync(client, "Loans", "EncompassRest.Loans");
                    }
                }).Wait();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            Console.ReadLine();
        }

        public static async Task GenerateClassFilesFromSchemaAsync(EncompassRestClient client, string destinationPath, string @namespace)
        {
            Directory.CreateDirectory(destinationPath);
            var supportedEntities = new HashSet<string>(await client.Loans.GetSupportedEntitiesAsync().ConfigureAwait(false));
            var exceptions = new List<Exception>();
            var missingSchemaEntities = new HashSet<string> { "VirtualFields", "ElliUCDFields", "NonVols" };
            foreach (var entity in supportedEntities)
            {
                Exception exception;
                var tryCount = 0;
                do
                {
                    exception = null;
                    try
                    {
                        var loanSchema = await client.Schema.GetLoanSchemaAsync(true, entity).ConfigureAwait(false);

                        if (loanSchema.EntityTypes.TryGetValue(entity, out var entitySchema))
                        {
                            await GenerateClassFileFromSchemaAsync(destinationPath, @namespace, entity, entitySchema).ConfigureAwait(false);
                            if (missingSchemaEntities.Contains(entity))
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
                        if (!missingSchemaEntities.Contains(entity))
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
$@"using System;
using System.Collections.Generic;
using {@namespace}.Enums;
using Newtonsoft.Json;

namespace {@namespace}
{{
    [JsonConverter(typeof(PublicallySerializableConverter))]
    public sealed partial class {entityType} : IDirty
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
                    var fieldName = $"_{char.ToLower(propertyName[0])}{propertyName.Substring(1)}";
                    sb.AppendLine($"        private {(isEntity || isCollection || hasOptions ? propertyType : $"DirtyValue<{propertyType}>")} {fieldName};");
                    properties.Add((propertyName, fieldName, isEntity, isCollection));

                    sb.AppendLine($"        public {(isCollection ? $"IList<{elementType}>" : propertyType)} {propertyName} {{ get => {fieldName}{(isEntity || isCollection ? $" ?? ({fieldName} = new {propertyType}())" : string.Empty)}; set => {fieldName} = {(isCollection ? $"new {propertyType}(value)" : "value")}; }}");
                }
            }

            // Sorts non entity types first
            properties = properties.OrderBy(property => property.IsEntity || property.IsCollection).ToList();

            // Must ensure no circular cleaning
            sb.Append(
$@"        private DirtyDictionary<string, object> _extensionData;
        public IDictionary<string, object> ExtensionData {{ get => _extensionData ?? (_extensionData = new DirtyDictionary<string, object>()); set => _extensionData = new DirtyDictionary<string, object>(value); }}
        private bool _gettingDirty;
        private bool _settingDirty; 
        internal bool Dirty
        {{
            get
            {{
                if (_gettingDirty) return false;
                _gettingDirty = true;
                var dirty = {string.Join($"{Environment.NewLine}                    || ", properties.Select(property => $"{property.FieldName}{(property.IsEntity || property.IsCollection ? "?.Dirty == true" : ".Dirty")}"))}
                    || _extensionData?.Dirty == true;
                _gettingDirty = false;
                return dirty;
            }}
            set
            {{
                if (_settingDirty) return;
                _settingDirty = true;
                {string.Join($"{Environment.NewLine}                ", properties.Select(property =>
                    {
                        var propertyName = property.FieldName;
                        if (property.IsEntity || property.IsCollection)
                        {
                            return $"if ({propertyName} != null) {propertyName}.Dirty = value;";
                        }
                        return $"{propertyName}.Dirty = value;";
                    }))}
                if (_extensionData != null) _extensionData.Dirty = value;
                _settingDirty = false;
            }}
        }}
        bool IDirty.Dirty {{ get => Dirty; set => Dirty = value; }}
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
            switch (propertyType)
            {
                case "string":
                case "uuid":
                    return "string";
                case "decimal":
                case "NA<decimal>":
                case "bool":
                case "int":
                    return $"{propertyType}?";
                case "date":
                case "datetime":
                    return "DateTime?";
                case "set":
                case "list":
                    isCollection = true;
                    return propertySchema.ElementType;
                case "entity":
                    isEntity = true;
                    return propertySchema.EntityType;
                default:
                    return $"PROBLEM<{propertyType}>";
            }
        }

        private static string GetEnumName(string entityType, string propertyName) => s_enumPropertyNamesToUseEntityTypeInName.Contains(propertyName) ? $"{entityType}{propertyName}" : propertyName;
    }
}