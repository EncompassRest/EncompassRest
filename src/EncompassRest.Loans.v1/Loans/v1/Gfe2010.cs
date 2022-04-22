using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v1;

/// <summary>
/// Gfe2010
/// </summary>
public sealed partial class Gfe2010 : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// Fees Adj Orig Chrgs Applied to GFE [NEWHUD.X16]
    /// </summary>
    public decimal? AdjustedOriginationCharges { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// HUD-All Other Settlement Services [NEWHUD.X92]
    /// </summary>
    public decimal? AllOtherServiceAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Application Fees Applied to GFE [NEWHUD.X702]
    /// </summary>
    public decimal? ApplicationFees { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 1309 Borr Selects [NEWHUD.X115]
    /// </summary>
    public bool? BorrowerSelectIndicator10 { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 1310 Borr Selects [NEWHUD.X116]
    /// </summary>
    public bool? BorrowerSelectIndicator11 { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 1311 Borr Selects [NEWHUD.X117]
    /// </summary>
    public bool? BorrowerSelectIndicator12 { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Gfe2010 BorrowerSelectIndicator13
    /// </summary>
    public bool? BorrowerSelectIndicator13 { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Borr Selects Homeowner Ins - Line 1 [NEWHUD.X119]
    /// </summary>
    public bool? BorrowerSelectIndicator14 { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Borr Selects Homeowner Ins - Line 2 [NEWHUD.X120]
    /// </summary>
    public bool? BorrowerSelectIndicator15 { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Borr Selects Homeowner Ins - Line 3 [NEWHUD.X121]
    /// </summary>
    public bool? BorrowerSelectIndicator16 { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Borr Selects Homeowner Ins - Line 4 [NEWHUD.X122]
    /// </summary>
    public bool? BorrowerSelectIndicator17 { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Borr Selects Homeowner Ins - Line 5 [NEWHUD.X123]
    /// </summary>
    public bool? BorrowerSelectIndicator18 { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Borr Selects Homeowner Ins - Line 6 [NEWHUD.X124]
    /// </summary>
    public bool? BorrowerSelectIndicator19 { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 1103 Borr Selects [NEWHUD.X107]
    /// </summary>
    public bool? BorrowerSelectIndicator2 { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Homeowner Ins 7 Borr Select [NEWHUD.X655]
    /// </summary>
    public bool? BorrowerSelectIndicator20 { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 1302 Borr Selects [NEWHUD.X108]
    /// </summary>
    public bool? BorrowerSelectIndicator3 { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 1303 Borr Selects [NEWHUD.X109]
    /// </summary>
    public bool? BorrowerSelectIndicator4 { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 1304 Borr Selects [NEWHUD.X110]
    /// </summary>
    public bool? BorrowerSelectIndicator5 { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 1305 Borr Selects [NEWHUD.X111]
    /// </summary>
    public bool? BorrowerSelectIndicator6 { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 1306 Borr Selects [NEWHUD.X112]
    /// </summary>
    public bool? BorrowerSelectIndicator7 { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 1307 Borr Selects [NEWHUD.X113]
    /// </summary>
    public bool? BorrowerSelectIndicator8 { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 1308 Borr Selects [NEWHUD.X114]
    /// </summary>
    public bool? BorrowerSelectIndicator9 { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Broker Additional Fees [NEWHUD.X706]
    /// </summary>
    public decimal? BrokerAdditionalFees { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Broker Fees Applied to GFE [NEWHUD.X707]
    /// </summary>
    public decimal? BrokerFees { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Broker Fees Percent [NEWHUD.X705]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? BrokerFeesPercentage { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Borr Charge Amt for Points - Itemization [NEWHUD.X720]
    /// </summary>
    public decimal? ChargeAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Borr Charge Amt for Points - GFE [NEWHUD.X722]
    /// </summary>
    public decimal? ChargeAmountForPrint { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// HUD Copy from Itemization 1 [NEWHUD.X522]
    /// </summary>
    public bool? CopyFromGfeIndicator1 { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// HUD Copy from Itemization 10 [NEWHUD.X531]
    /// </summary>
    public bool? CopyFromGfeIndicator10 { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// HUD Copy from Itemization 11 [NEWHUD.X532]
    /// </summary>
    public bool? CopyFromGfeIndicator11 { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// HUD Copy from Itemization 12 [NEWHUD.X533]
    /// </summary>
    public bool? CopyFromGfeIndicator12 { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// HUD Copy from Itemization 13 [NEWHUD.X534]
    /// </summary>
    public bool? CopyFromGfeIndicator13 { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// HUD Copy from Itemization 14 [NEWHUD.X535]
    /// </summary>
    public bool? CopyFromGfeIndicator14 { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// HUD Copy from Itemization 15 [NEWHUD.X536]
    /// </summary>
    public bool? CopyFromGfeIndicator15 { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// HUD Copy from Itemization 16 [NEWHUD.X537]
    /// </summary>
    public bool? CopyFromGfeIndicator16 { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// HUD Copy from Itemization 17 [NEWHUD.X538]
    /// </summary>
    public bool? CopyFromGfeIndicator17 { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// HUD Copy from Itemization 18 [NEWHUD.X539]
    /// </summary>
    public bool? CopyFromGfeIndicator18 { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// HUD Copy from Itemization 19 [NEWHUD.X540]
    /// </summary>
    public bool? CopyFromGfeIndicator19 { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// HUD Copy from Itemization 2 [NEWHUD.X523]
    /// </summary>
    public bool? CopyFromGfeIndicator2 { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// HUD Copy from Itemization 20 [NEWHUD.X541]
    /// </summary>
    public bool? CopyFromGfeIndicator20 { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// HUD Copy from Itemization 21 [NEWHUD.X542]
    /// </summary>
    public bool? CopyFromGfeIndicator21 { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// HUD Copy from Itemization 22 [NEWHUD.X543]
    /// </summary>
    public bool? CopyFromGfeIndicator22 { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// HUD Copy from Itemization 23 [NEWHUD.X544]
    /// </summary>
    public bool? CopyFromGfeIndicator23 { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// HUD Copy from Itemization 24 [NEWHUD.X545]
    /// </summary>
    public bool? CopyFromGfeIndicator24 { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// HUD Copy from Itemization 25 [NEWHUD.X546]
    /// </summary>
    public bool? CopyFromGfeIndicator25 { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// HUD Copy from Itemization 26 [NEWHUD.X547]
    /// </summary>
    public bool? CopyFromGfeIndicator26 { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// HUD Copy from Itemization 27 [NEWHUD.X548]
    /// </summary>
    public bool? CopyFromGfeIndicator27 { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// HUD Copy from Itemization 28 [NEWHUD.X549]
    /// </summary>
    public bool? CopyFromGfeIndicator28 { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// HUD Copy from Itemization 29 [NEWHUD.X550]
    /// </summary>
    public bool? CopyFromGfeIndicator29 { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// HUD Copy from Itemization 3 [NEWHUD.X524]
    /// </summary>
    public bool? CopyFromGfeIndicator3 { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// HUD Copy from Itemization 30 [NEWHUD.X551]
    /// </summary>
    public bool? CopyFromGfeIndicator30 { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// HUD Copy from Itemization 31 [NEWHUD.X552]
    /// </summary>
    public bool? CopyFromGfeIndicator31 { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// HUD Copy from Itemization 32 [NEWHUD.X553]
    /// </summary>
    public bool? CopyFromGfeIndicator32 { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// HUD Copy from Itemization 33 [NEWHUD.X554]
    /// </summary>
    public bool? CopyFromGfeIndicator33 { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// HUD Copy from Itemization 34 [NEWHUD.X620]
    /// </summary>
    public bool? CopyFromGfeIndicator34 { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// HUD Copy from Itemization 35 [NEWHUD.X621]
    /// </summary>
    public bool? CopyFromGfeIndicator35 { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// HUD Copy from Itemization 4 [NEWHUD.X525]
    /// </summary>
    public bool? CopyFromGfeIndicator4 { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// HUD Copy from Itemization 5 [NEWHUD.X526]
    /// </summary>
    public bool? CopyFromGfeIndicator5 { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// HUD Copy from Itemization 6 [NEWHUD.X527]
    /// </summary>
    public bool? CopyFromGfeIndicator6 { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// HUD Copy from Itemization 7 [NEWHUD.X528]
    /// </summary>
    public bool? CopyFromGfeIndicator7 { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// HUD Copy from Itemization 8 [NEWHUD.X529]
    /// </summary>
    public bool? CopyFromGfeIndicator8 { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// HUD Copy from Itemization 9 [NEWHUD.X530]
    /// </summary>
    public bool? CopyFromGfeIndicator9 { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// GFE Credit Amount [NEWHUD.X718]
    /// </summary>
    public decimal? CreditAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Borr Orig Fee Credit for Int Rate [NEWHUD.X721]
    /// </summary>
    public decimal? CreditAmountForPrint { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Can Monthly Payment Rise [NEWHUD.X14]
    /// </summary>
    public StringEnumValue<CreditChargeType> CreditChargeType { get => GetValue<StringEnumValue<CreditChargeType>>(); set => SetValue(value); }

    /// <summary>
    /// Cred/Chrgs for Spec Int Rate Applied to GFE [NEWHUD.X13]
    /// </summary>
    public decimal? CreditOrChange { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Cured Fees Adj Orig Chrgs Applied to GFE [NEWHUD.CuredX16]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? CuredAdjustedOriginationCharges { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Cured Cred/Chrgs for Spec Int Rate Applied to GFE [NEWHUD.CuredX13]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? CuredCreditOrChange { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Cured Total Est Origination Charges [NEWHUD.CuredX12]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? CuredOriginationCharges { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Cured Transfer Tax Total GFE [NEWHUD.CuredX76]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? CuredTotalTransferTaxes { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Daily Int Chrgs Applied to GFE [NEWHUD.X701]
    /// </summary>
    public decimal? DailyInterestCharges { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Avail Date for All Other GFE Sttlmnt Chrgs [NEWHUD.X2]
    /// </summary>
    public DateTime? DateForCharges { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Avail Date for GFE Interest Rate [NEWHUD.X1]
    /// </summary>
    public string? DateForRate { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// No. Days from Rate Lock to Settlement [NEWHUD.X719]
    /// </summary>
    public string? DaysToSettlement { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// ARM Rate Adj Period [NEWHUD.X557]
    /// </summary>
    public int? DurationMonths { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Escrow Acct Chrg Type All Insurance [NEWHUD.X350]
    /// </summary>
    public bool? EscrowChargeAllInsuranceIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Escrow Acct Chrg Type All Prop Taxes [NEWHUD.X349]
    /// </summary>
    public bool? EscrowChargeAllPropertyTaxesIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Escrow Acct Chrg Type Other [NEWHUD.X351]
    /// </summary>
    public bool? EscrowChargeOtherIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Other Escrow Descr [NEWHUD.X78]
    /// </summary>
    public string? EscrowOtherDescription { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borr Total of Prepaid Financed Fees [NEWHUD.X1704]
    /// </summary>
    public decimal? FinancedFeesFromPrepaid { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Gfe2010 Gfe2010Fees
    /// </summary>
    [AllowNull]
    public IList<Gfe2010Fee> Gfe2010Fees { get => GetList<Gfe2010Fee>(); set => SetList(value); }

    /// <summary>
    /// Gfe2010 Gfe2010WholePocs
    /// </summary>
    [AllowNull]
    public IList<Gfe2010WholePoc> Gfe2010WholePocs { get => GetList<Gfe2010WholePoc>(); set => SetList(value); }

    /// <summary>
    /// Fees Line 1201 Applied to GFE [NEWHUD.X214]
    /// </summary>
    public decimal? GfeGovernmentRecordingCharges { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Homeowner's Ins Fee Applied to GFE [NEWHUD.X650]
    /// </summary>
    public decimal? HazardInsurance { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Homeowner Ins Total Amt [NEWHUD.X79]
    /// </summary>
    public decimal? HomeownerInsurance { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 1010 Guarantee Fee Applied to GFE [NEWHUD.X1709]
    /// </summary>
    public decimal? HudGuaranteeFee { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Gfe2010 Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Include Points/Credit in Orig Chrg [NEWHUD.X714]
    /// </summary>
    public StringEnumValue<IncludeOriginationPointsCreditType> IncludeOriginationPointsCreditType { get => GetValue<StringEnumValue<IncludeOriginationPointsCreditType>>(); set => SetValue(value); }

    /// <summary>
    /// Initial Loan Amount [NEWHUD.X4]
    /// </summary>
    public decimal? InitialLoanAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Initial Mthly Pymt Princpl, Int, &amp; Mrtg Ins [NEWHUD.X217]
    /// </summary>
    public decimal? InitialMonthlyAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Can Your Interest Rate Rise [NEWHUD.X5]
    /// </summary>
    public bool? InterestRateRiseIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Is CD Valid for Earliest Closing Date Calculation [4082]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public bool? IsCDValidForEarliestClosingDate { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 1001 Applied to GFE [NEWHUD.X691]
    /// </summary>
    public decimal? Line1001Fee { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 1002 Applied to GFE [NEWHUD.X692]
    /// </summary>
    public decimal? Line1002Fee { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 1003 Applied to GFE [NEWHUD.X693]
    /// </summary>
    public decimal? Line1003Fee { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 1004 Applied to GFE [NEWHUD.X694]
    /// </summary>
    public decimal? Line1004Fee { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 1005 Applied to GFE [NEWHUD.X695]
    /// </summary>
    public decimal? Line1005Fee { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 1006 Applied to GFE [NEWHUD.X696]
    /// </summary>
    public decimal? Line1006Fee { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 1007 Applied to GFE [NEWHUD.X697]
    /// </summary>
    public decimal? Line1007Fee { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 1008 Applied to GFE [NEWHUD.X698]
    /// </summary>
    public decimal? Line1008Fee { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 1009 Applied to GFE [NEWHUD.X699]
    /// </summary>
    public decimal? Line1009Fee { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 801 HUD GFE Broker Compensation Additional Amount [NEWHUD.X247]
    /// </summary>
    public decimal? Line801BrokerCompensationAdditionalAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 801 HUD GFE Broker Compensation Fees [NEWHUD.X250]
    /// </summary>
    public decimal? Line801BrokerCompensationFees { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 801 HUD GFE Broker Compensation Rate [NEWHUD.X246]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? Line801BrokerCompensationRate { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 808 Fee Applied to GFE [NEWHUD.X662]
    /// </summary>
    public decimal? Line808Fee { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 809 Fee Applied to GFE [NEWHUD.X663]
    /// </summary>
    public decimal? Line809Fee { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 810 Fee Applied to GFE [NEWHUD.X664]
    /// </summary>
    public decimal? Line810Fee { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 811 Fee Applied to GFE [NEWHUD.X665]
    /// </summary>
    public decimal? Line811Fee { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 812 Fee Applied to GFE [NEWHUD.X666]
    /// </summary>
    public decimal? Line812Fee { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 813 Fee Applied to GFE [NEWHUD.X667]
    /// </summary>
    public decimal? Line813Fee { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 814 Fee Applied to GFE [NEWHUD.X668]
    /// </summary>
    public decimal? Line814Fee { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 815 Fee Applied to GFE [NEWHUD.X669]
    /// </summary>
    public decimal? Line815Fee { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 816 Fee Applied to GFE [NEWHUD.X670]
    /// </summary>
    public decimal? Line816Fee { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 817 Fee Applied to GFE [NEWHUD.X671]
    /// </summary>
    public decimal? Line817Fee { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 818 Fee Applied to GFE [NEWHUD.X1525]
    /// </summary>
    public decimal? Line818Fee { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 819 Fee Applied to GFE [NEWHUD.X1526]
    /// </summary>
    public decimal? Line819Fee { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 820 Fee Applied to GFE [NEWHUD.X1527]
    /// </summary>
    public decimal? Line820Fee { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 821 Fee Applied to GFE [NEWHUD.X1528]
    /// </summary>
    public decimal? Line821Fee { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 822 Fee Applied to GFE [NEWHUD.X1529]
    /// </summary>
    public decimal? Line822Fee { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 823 Fee Applied to GFE [NEWHUD.X1530]
    /// </summary>
    public decimal? Line823Fee { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 824 Fee Applied to GFE [NEWHUD.X1531]
    /// </summary>
    public decimal? Line824Fee { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 825 Fee Applied to GFE [NEWHUD.X1532]
    /// </summary>
    public decimal? Line825Fee { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 826 Fee Applied to GFE [NEWHUD.X1533]
    /// </summary>
    public decimal? Line826Fee { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 827 Fee Applied to GFE [NEWHUD.X1534]
    /// </summary>
    public decimal? Line827Fee { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 828 Fee Applied to GFE [NEWHUD.X1535]
    /// </summary>
    public decimal? Line828Fee { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 829 Fee Applied to GFE [NEWHUD.X1536]
    /// </summary>
    public decimal? Line829Fee { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 830 Fee Applied to GFE [NEWHUD.X1537]
    /// </summary>
    public decimal? Line830Fee { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 831 Fee Applied to GFE [NEWHUD.X1538]
    /// </summary>
    public decimal? Line831Fee { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 832 Fee Applied to GFE [NEWHUD.X1539]
    /// </summary>
    public decimal? Line832Fee { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 833 Fee Applied to GFE [NEWHUD.X1540]
    /// </summary>
    public decimal? Line833Fee { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Can Your Loan Balance Rise [NEWHUD.X6]
    /// </summary>
    public bool? LoanBalanceRiseIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Origination Fees Applied to GFE [NEWHUD.X770]
    /// </summary>
    public decimal? LoanOriginationFees { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Origination Fees Percent [NEWHUD.X769]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? LoanOriginationPercentage { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// 2010 GFE Loan Originator Name [NEWHUD.X806]
    /// </summary>
    public string? LoanOriginatorName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Lower Int Rate-Initial Interest Rate [NEWHUD.X101]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? LowerInterestInitialInterestRate { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Lower Int Rate-Initial Monthly Amt Owed [NEWHUD.X102]
    /// </summary>
    public decimal? LowerInterestInitialMonthlyAmountOwed { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Lower Int Rate-Mnthly Pymt Reduction [NEWHUD.X103]
    /// </summary>
    public decimal? LowerInterestMonthlyPaymentReduced { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Lower Int Rate-Sttlmnt Chrgs Increase [NEWHUD.X104]
    /// </summary>
    public decimal? LowerInterestServiceChargeIncreasedAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Lower Int Rate-Total Est Sttlmnt Chrgs [NEWHUD.X105]
    /// </summary>
    public decimal? LowerInterestTotalSettlementCharges { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Lower Sttlmnt Chrgs-Intl Int Rate [NEWHUD.X95]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? LowerSettlementInitialInterestRate { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Lower Sttlmnt Chrgs-Intl  Mnthly Amt Owed [NEWHUD.X96]
    /// </summary>
    public decimal? LowerSettlementInitialMonthlyAmountOwed { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Lower Sttlmnt Chrgs-Mthly Pymt Increase [NEWHUD.X97]
    /// </summary>
    public decimal? LowerSettlementMonthlyPaymentIncreased { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Lower Sttlmnt Chrgs-Sttlmnt Chrgs Reduction [NEWHUD.X98]
    /// </summary>
    public decimal? LowerSettlementServiceChargeReducedAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Lower Sttlmnt Chrgs-Total Est Sttlmnt Chrgs [NEWHUD.X99]
    /// </summary>
    public decimal? LowerSettlementTotalSettlementCharges { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// HUD-Maximum Loan Balance [NEWHUD.X7]
    /// </summary>
    public decimal? MaximumLoanBalance { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Max Mthly Pymt After 1st Increase [NEWHUD.X10]
    /// </summary>
    public decimal? MaximumOwedMonthlyPayment { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ARM Max Life Interest Cap [NEWHUD.X555]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? MaxLifeInterestCapPercent { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ARM Max Life Interest Cap - Display fields with KBYO rounding rules [KBYO.NEWHUDXD555]
    /// </summary>
    public string? MaxLifeInterestCapPercentUI { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Mnths Until 1st Mnthly Pymt Increase [NEWHUD.X9]
    /// </summary>
    public int? MonthlyPaymentFirstIncreaseDate { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Can Monthly Payments Rise [NEWHUD.X8]
    /// </summary>
    public bool? MonthlyPaymentRiseIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Mtg Ins Premium Applied to GFE [NEWHUD.X622]
    /// </summary>
    public decimal? MortgageInsurancePremium { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Days Before Sttlmtn to Lock Int Rate [NEWHUD.X3]
    /// </summary>
    public string? MustLockRateDays { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Gfe2010 NewHudSection1100Line1104BorPaidAmount
    /// </summary>
    public decimal? NewHudSection1100Line1104BorPaidAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Gfe2010 NewHudSection1100Line1104SelPaidAmount
    /// </summary>
    public decimal? NewHudSection1100Line1104SelPaidAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Gfe2010 NewHudSection1100Line1107BorPaidAmount
    /// </summary>
    public decimal? NewHudSection1100Line1107BorPaidAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Gfe2010 NewHudSection1100Line1108BorPaidAmount
    /// </summary>
    public decimal? NewHudSection1100Line1108BorPaidAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Total Est Origination Charges [NEWHUD.X12]
    /// </summary>
    public decimal? OriginationCharges { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Origination Credit (YSP) [NEWHUD.X712]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? OriginationCreditYsp { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Loan Origination Fee + $ [NEWHUD.X741]
    /// </summary>
    public decimal? OriginationCreditYspAdditional { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Orig Charge Paid by Borrower [NEWHUD.X711]
    /// </summary>
    public decimal? OriginationPoints { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Origination Points Additional [NEWHUD.X710]
    /// </summary>
    public decimal? OriginationPointsAdditional { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Origination Points [NEWHUD.X709]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? OriginationPointsPercentage { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Owner's Title Ins Applied to GFE [NEWHUD.X39]
    /// </summary>
    public NA<decimal> OwnerTitleInsuranceAmount { get => GetValue<NA<decimal>>(); set => SetValue(value); }

    /// <summary>
    /// Print N/A to Days Before Sttlmtn to Lock Int Rate [NEWHUD.X1717]
    /// </summary>
    public bool? PrintNAInLockRateDays { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// 2010 GFE Print Shopping Chart 1st Column [NEWHUD.X807]
    /// </summary>
    public bool? PrintShoppingChartIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Processing Fees Applied to GFE [NEWHUD.X703]
    /// </summary>
    public decimal? ProcessingFees { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Apprsl Fee Applied to GFE [NEWHUD.X609]
    /// </summary>
    public decimal? RequiredAppraisalFee { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Credit Report Fee Applied to GFE [NEWHUD.X610]
    /// </summary>
    public decimal? RequiredCreditReportFee { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Flood Cert Fee Applied to GFE [NEWHUD.X612]
    /// </summary>
    public decimal? RequiredFloodCertificationFee { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Required Services We Select [NEWHUD.X17]
    /// </summary>
    public decimal? RequiredServicesAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Tax Service Fee Applied to GFE [NEWHUD.X611]
    /// </summary>
    public decimal? RequiredTaxServiceFee { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Line 1000 Total Borrower Paid Amount [NEWHUD2.X36]
    /// </summary>
    public decimal? Section1000TotalBorrowerPaidAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Line 1000 Total Other Paid Amount [NEWHUD2.X38]
    /// </summary>
    public decimal? Section1000TotalOtherPaidAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Line 1000 Total Paid Amount [NEWHUD2.X39]
    /// </summary>
    public decimal? Section1000TotalPaidAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Line 1000 Total Seller Paid Amount [NEWHUD2.X37]
    /// </summary>
    public decimal? Section1000TotalSellerPaidAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Line 1100 Total Borrower Paid Amount [NEWHUD2.X40]
    /// </summary>
    public decimal? Section1100TotalBorrowerPaidAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Line 1100 Total Other Paid Amount [NEWHUD2.X42]
    /// </summary>
    public decimal? Section1100TotalOtherPaidAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Line 1100 Total Paid Amount [NEWHUD2.X43]
    /// </summary>
    public decimal? Section1100TotalPaidAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Line 1100 Total Seller Paid Amount [NEWHUD2.X41]
    /// </summary>
    public decimal? Section1100TotalSellerPaidAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Line 1200 Total Borrower Paid Amount [NEWHUD2.X44]
    /// </summary>
    public decimal? Section1200TotalBorrowerPaidAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Line 1200 Total Other Paid Amount [NEWHUD2.X46]
    /// </summary>
    public decimal? Section1200TotalOtherPaidAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Line 1200 Total Paid Amount [NEWHUD2.X47]
    /// </summary>
    public decimal? Section1200TotalPaidAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Line 1200 Total Seller Paid Amount [NEWHUD2.X45]
    /// </summary>
    public decimal? Section1200TotalSellerPaidAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Line 1300 Total Borrower Paid Amount [NEWHUD2.X48]
    /// </summary>
    public decimal? Section1300TotalBorrowerPaidAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Line 1300 Total Other Paid Amount [NEWHUD2.X50]
    /// </summary>
    public decimal? Section1300TotalOtherPaidAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Line 1300 Total Paid Amount [NEWHUD2.X51]
    /// </summary>
    public decimal? Section1300TotalPaidAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Line 1300 Total Seller Paid Amount [NEWHUD2.X49]
    /// </summary>
    public decimal? Section1300TotalSellerPaidAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Line 1400 Total Borrower Paid Amount [NEWHUD2.X4427]
    /// </summary>
    public decimal? Section1400TotalBorrowerPaidAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Line 1400 Total Other Paid Amount [NEWHUD2.X52]
    /// </summary>
    public decimal? Section1400TotalOtherPaidAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Line 1400 Total Paid Amount [NEWHUD2.X53]
    /// </summary>
    public decimal? Section1400TotalPaidAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Line 1400 Total Seller Amount [NEWHUD2.X4428]
    /// </summary>
    public decimal? Section1400TotalSellerPaidAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Line 700 Total Borrower Paid Amount [NEWHUD2.X24]
    /// </summary>
    public decimal? Section700TotalBorrowerPaidAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Line 700 Total Other Paid Amount [NEWHUD2.X26]
    /// </summary>
    public decimal? Section700TotalOtherPaidAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Line 700 Total Paid Amount [NEWHUD2.X27]
    /// </summary>
    public decimal? Section700TotalPaidAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Line 700 Total Seller Paid Amount [NEWHUD2.X25]
    /// </summary>
    public decimal? Section700TotalSellerPaidAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Line 800 Total Borrower Paid Amount [NEWHUD2.X28]
    /// </summary>
    public decimal? Section800TotalBorrowerPaidAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Line 800 Total Other Paid Amount [NEWHUD2.X30]
    /// </summary>
    public decimal? Section800TotalOtherPaidAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Line 800 Total Paid Amount [NEWHUD2.X31]
    /// </summary>
    public decimal? Section800TotalPaidAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Line 800 Total Seller Paid Amount [NEWHUD2.X29]
    /// </summary>
    public decimal? Section800TotalSellerPaidAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Line 900 Total Borrower Paid Amount [NEWHUD2.X32]
    /// </summary>
    public decimal? Section900TotalBorrowerPaidAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Line 900 Total Other Paid Amount [NEWHUD2.X34]
    /// </summary>
    public decimal? Section900TotalOtherPaidAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Line 900 Total Paid Amount [NEWHUD2.X35]
    /// </summary>
    public decimal? Section900TotalPaidAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Line 900 Total Seller Paid Amount [NEWHUD2.X33]
    /// </summary>
    public decimal? Section900TotalSellerPaidAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Line PC Total Borrower Paid Amount [NEWHUD2.X4760]
    /// </summary>
    public decimal? SectionPCTotalBorrowerPaidAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Line PC Total Other Paid Amount [NEWHUD2.X4762]
    /// </summary>
    public decimal? SectionPCTotalOtherPaidAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Line PC Total Paid Amount [NEWHUD2.X4763]
    /// </summary>
    public decimal? SectionPCTotalPaidAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Line PC Total Seller Amount [NEWHUD2.X4761]
    /// </summary>
    public decimal? SectionPCTotalSellerPaidAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 1301l Applied to GFE [NEWHUD.X40]
    /// </summary>
    public decimal? ShopRequiredServicesAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ARM Rate Cap [NEWHUD.X558]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? SubsequentCapPercent { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Section PC Subsequently Paid Finance Charge [NEWHUD2.X4768]
    /// </summary>
    public decimal? SubsequentlyPaidFinanceCharge { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ARM First Period Change [NEWHUD.X556]
    /// </summary>
    public int? SubsequentRateAdjustmentMonths { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Table Funded Transactions Indicator [NEWHUD.X1068]
    /// </summary>
    public bool? TableFundedIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Avail Time for GFE Interest Rate [NEWHUD.X725]
    /// </summary>
    public string? TimeForRate { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Title Serv &amp; Lender's Title Ins Applied to GFE [NEWHUD.X38]
    /// </summary>
    public decimal? TitleServiceAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Chrgs That Cannot Incr 10% in Total [NEWHUD.X61]
    /// </summary>
    public decimal? TotalBelow10 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Borr Total of Financed Fees [NEWHUD.X1585]
    /// </summary>
    public decimal? TotalOfFinancedFees { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// HUD-Est Total Settlement Charges [NEWHUD.X93]
    /// </summary>
    public decimal? TotalSettlementCharges { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Transfer Tax Total GFE [NEWHUD.X76]
    /// </summary>
    public decimal? TotalTransferTaxes { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 1203 Borr [NEWHUD.X730]
    /// </summary>
    public decimal? TransferTaxes { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Underwriting Fees Applied to GFE [NEWHUD.X704]
    /// </summary>
    public decimal? UnderwritingFees { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 801 Broker Compensation Use LO Comp Tool [NEWHUD.X1718]
    /// </summary>
    public bool? UseLOCompTool { get => GetValue<bool?>(); set => SetValue(value); }
}