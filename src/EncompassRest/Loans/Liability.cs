using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// Liability
    /// </summary>
    [Entity(PropertiesToAlwaysSerialize = nameof(AccountIndicator) + "," + nameof(LiabilityType), SerializeWholeListWhenDirty = true)]
    public sealed partial class Liability : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<string> _accountIdentifier;
        private DirtyValue<bool?> _accountIndicator;
        private DirtyValue<string> _attention;
        private DirtyValue<EntityReference> _contact;
        private DirtyValue<DateTime?> _date;
        private DirtyValue<string> _description;
        private DirtyValue<string> _descriptionOfPurpose;
        private DirtyValue<bool?> _entityDeleted;
        private DirtyValue<bool?> _exclusionIndicator;
        private DirtyValue<string> _holderAddressCity;
        private DirtyValue<string> _holderAddressPostalCode;
        private DirtyValue<StringEnumValue<State>> _holderAddressState;
        private DirtyValue<string> _holderAddressStreetLine1;
        private DirtyValue<string> _holderComments;
        private DirtyValue<string> _holderEmail;
        private DirtyValue<string> _holderFax;
        private DirtyValue<string> _holderName;
        private DirtyValue<string> _holderPhone;
        private DirtyValue<string> _id;
        private DirtyValue<bool?> _isDebtNotSecuredToSubjectPropertyIndicator;
        private DirtyValue<int?> _lates12Month120Day;
        private DirtyValue<int?> _lates12Month150Day;
        private DirtyValue<int?> _lates12Month30Day;
        private DirtyValue<int?> _lates12Month60Day;
        private DirtyValue<int?> _lates12Month90Day;
        private DirtyValue<int?> _lates24Month120Day;
        private DirtyValue<int?> _lates24Month150Day;
        private DirtyValue<int?> _lates24Month30Day;
        private DirtyValue<int?> _lates24Month60Day;
        private DirtyValue<int?> _lates24Month90Day;
        private DirtyValue<int?> _lates25Month120Day;
        private DirtyValue<int?> _lates25Month150Day;
        private DirtyValue<int?> _lates25Month30Day;
        private DirtyValue<int?> _lates25Month60Day;
        private DirtyValue<int?> _lates25Month90Day;
        private DirtyValue<int?> _liabilityIndex;
        private DirtyValue<StringEnumValue<LiabilityType>> _liabilityType;
        private DirtyValue<decimal?> _monthlyPaymentAmount;
        private DirtyValue<int?> _monthsToExclude;
        private DirtyValue<string> _nameInAccount;
        private DirtyValue<bool?> _noLinkToDocTrackIndicator;
        private DirtyValue<StringEnumValue<Owner>> _owner;
        private DirtyValue<bool?> _payoffIncludedIndicator;
        private DirtyValue<bool?> _payoffStatusIndicator;
        private DirtyValue<decimal?> _prepaymentPenaltyAmount;
        private DirtyValue<bool?> _printAttachmentIndicator;
        private DirtyValue<bool?> _printUserNameIndicator;
        private DirtyValue<int?> _remainingTermMonths;
        private DirtyValue<string> _reoId;
        private DirtyValue<string> _requestId;
        private DirtyValue<bool?> _subjectLoanResubordinationIndicator;
        private DirtyValue<string> _title;
        private DirtyValue<string> _titleFax;
        private DirtyValue<string> _titlePhone;
        private DirtyValue<decimal?> _toBePaidOffAmount;
        private DirtyValue<StringEnumValue<UCDPayoffType>> _uCDPayoffType;
        private DirtyValue<decimal?> _unpaidBalanceAmount;
        private DirtyValue<int?> _volIndex;

        /// <summary>
        /// Liability AccountIdentifier [FLNN10]
        /// </summary>
        public string AccountIdentifier { get => _accountIdentifier; set => SetField(ref _accountIdentifier, value); }

        /// <summary>
        /// Liability AccountIndicator
        /// </summary>
        public bool? AccountIndicator { get => _accountIndicator; set => SetField(ref _accountIndicator, value); }

        /// <summary>
        /// Liability Creditor Contact [FLNN03]
        /// </summary>
        [LoanFieldProperty(Description = "Liability Creditor Contact")]
        public string Attention { get => _attention; set => SetField(ref _attention, value); }

        /// <summary>
        /// Liability Contact (Nullable)
        /// </summary>
        public EntityReference Contact { get => _contact; set => SetField(ref _contact, value); }

        /// <summary>
        /// Liability Request Date [FLNN98]
        /// </summary>
        [LoanFieldProperty(Description = "Liability Request Date")]
        public DateTime? Date { get => _date; set => SetField(ref _date, value); }

        /// <summary>
        /// Liabilities Alimony/Child Support Descr [271]
        /// </summary>
        [LoanFieldProperty(Description = "Liabilities Alimony/Child Support Descr")]
        public string Description { get => _description; set => SetField(ref _description, value); }

        /// <summary>
        /// .Description Of Purpose [FLNN43]
        /// </summary>
        [LoanFieldProperty(Description = ".Description Of Purpose")]
        public string DescriptionOfPurpose { get => _descriptionOfPurpose; set => SetField(ref _descriptionOfPurpose, value); }

        /// <summary>
        /// Liability EntityDeleted
        /// </summary>
        public bool? EntityDeleted { get => _entityDeleted; set => SetField(ref _entityDeleted, value); }

        /// <summary>
        /// Liability Exclude from URLA Total [FLNN17]
        /// </summary>
        [LoanFieldProperty(Description = "Liability Exclude from URLA Total", OptionsJson = "{\"true\":\"Exclude from URLA page 2 Liabilities Total\"}")]
        public bool? ExclusionIndicator { get => _exclusionIndicator; set => SetField(ref _exclusionIndicator, value); }

        /// <summary>
        /// Liability Creditor City [FLNN05]
        /// </summary>
        [LoanFieldProperty(Description = "Liability Creditor City")]
        public string HolderAddressCity { get => _holderAddressCity; set => SetField(ref _holderAddressCity, value); }

        /// <summary>
        /// Liability Creditor Zipcode [FLNN07]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE, Description = "Liability Creditor Zipcode")]
        public string HolderAddressPostalCode { get => _holderAddressPostalCode; set => SetField(ref _holderAddressPostalCode, value); }

        /// <summary>
        /// Liability Creditor State [FLNN06]
        /// </summary>
        [LoanFieldProperty(Description = "Liability Creditor State")]
        public StringEnumValue<State> HolderAddressState { get => _holderAddressState; set => SetField(ref _holderAddressState, value); }

        /// <summary>
        /// Liability Creditor Address [FLNN04]
        /// </summary>
        [LoanFieldProperty(Description = "Liability Creditor Address")]
        public string HolderAddressStreetLine1 { get => _holderAddressStreetLine1; set => SetField(ref _holderAddressStreetLine1, value); }

        /// <summary>
        /// Liability Creditor Comments [FLNN23]
        /// </summary>
        [LoanFieldProperty(Description = "Liability Creditor Comments")]
        public string HolderComments { get => _holderComments; set => SetField(ref _holderComments, value); }

        /// <summary>
        /// Liability Creditor Email [FLNN22]
        /// </summary>
        [LoanFieldProperty(Description = "Liability Creditor Email")]
        public string HolderEmail { get => _holderEmail; set => SetField(ref _holderEmail, value); }

        /// <summary>
        /// Liability Creditor Fax [FLNN21]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE, Description = "Liability Creditor Fax")]
        public string HolderFax { get => _holderFax; set => SetField(ref _holderFax, value); }

        /// <summary>
        /// Liability Creditor Name [FLNN02]
        /// </summary>
        [LoanFieldProperty(Description = "Liability Creditor Name")]
        public string HolderName { get => _holderName; set => SetField(ref _holderName, value); }

        /// <summary>
        /// Liability Creditor Phone [FLNN20]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE, Description = "Liability Creditor Phone")]
        public string HolderPhone { get => _holderPhone; set => SetField(ref _holderPhone, value); }

        /// <summary>
        /// Liability Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }

        /// <summary>
        /// Liability Debt is NOT secured to Subject Property [FLNN61]
        /// </summary>
        [LoanFieldProperty(Description = "Liability Debt is NOT secured to Subject Property", OptionsJson = "{\"true\":\"This Debt is NOT secured to Subject Property?\"}")]
        public bool? IsDebtNotSecuredToSubjectPropertyIndicator { get => _isDebtNotSecuredToSubjectPropertyIndicator; set => SetField(ref _isDebtNotSecuredToSubjectPropertyIndicator, value); }

        /// <summary>
        /// Liability 12 Month 120 Day Lates [FLNN55]
        /// </summary>
        [LoanFieldProperty(Description = "Liability 12 Month 120 Day Lates")]
        public int? Lates12Month120Day { get => _lates12Month120Day; set => SetField(ref _lates12Month120Day, value); }

        /// <summary>
        /// Liability 12 Month 150 Day Lates [FLNN58]
        /// </summary>
        [LoanFieldProperty(Description = "Liability 12 Month 150 Day Lates")]
        public int? Lates12Month150Day { get => _lates12Month150Day; set => SetField(ref _lates12Month150Day, value); }

        /// <summary>
        /// Liability 12 Month 30 Day Lates [FLNN46]
        /// </summary>
        [LoanFieldProperty(Description = "Liability 12 Month 30 Day Lates")]
        public int? Lates12Month30Day { get => _lates12Month30Day; set => SetField(ref _lates12Month30Day, value); }

        /// <summary>
        /// Liability 12 Month 60 Day Lates [FLNN49]
        /// </summary>
        [LoanFieldProperty(Description = "Liability 12 Month 60 Day Lates")]
        public int? Lates12Month60Day { get => _lates12Month60Day; set => SetField(ref _lates12Month60Day, value); }

        /// <summary>
        /// Liability 12 Month 90 Day Lates [FLNN52]
        /// </summary>
        [LoanFieldProperty(Description = "Liability 12 Month 90 Day Lates")]
        public int? Lates12Month90Day { get => _lates12Month90Day; set => SetField(ref _lates12Month90Day, value); }

        /// <summary>
        /// Liability 24 Month 120 Day Lates [FLNN56]
        /// </summary>
        [LoanFieldProperty(Description = "Liability 24 Month 120 Day Lates")]
        public int? Lates24Month120Day { get => _lates24Month120Day; set => SetField(ref _lates24Month120Day, value); }

        /// <summary>
        /// Liability 24 Month 150 Day Lates [FLNN59]
        /// </summary>
        [LoanFieldProperty(Description = "Liability 24 Month 150 Day Lates")]
        public int? Lates24Month150Day { get => _lates24Month150Day; set => SetField(ref _lates24Month150Day, value); }

        /// <summary>
        /// Liability 24 Month 30 Day Lates [FLNN47]
        /// </summary>
        [LoanFieldProperty(Description = "Liability 24 Month 30 Day Lates")]
        public int? Lates24Month30Day { get => _lates24Month30Day; set => SetField(ref _lates24Month30Day, value); }

        /// <summary>
        /// Liability 24 Month 60 Day Lates [FLNN50]
        /// </summary>
        [LoanFieldProperty(Description = "Liability 24 Month 60 Day Lates")]
        public int? Lates24Month60Day { get => _lates24Month60Day; set => SetField(ref _lates24Month60Day, value); }

        /// <summary>
        /// Liability 24 Month 90 Day Lates [FLNN53]
        /// </summary>
        [LoanFieldProperty(Description = "Liability 24 Month 90 Day Lates")]
        public int? Lates24Month90Day { get => _lates24Month90Day; set => SetField(ref _lates24Month90Day, value); }

        /// <summary>
        /// Liability 25 Month 120 Day Lates [FLNN57]
        /// </summary>
        [LoanFieldProperty(Description = "Liability 25 Month 120 Day Lates")]
        public int? Lates25Month120Day { get => _lates25Month120Day; set => SetField(ref _lates25Month120Day, value); }

        /// <summary>
        /// Liability 25 Month 150 Day Lates [FLNN60]
        /// </summary>
        [LoanFieldProperty(Description = "Liability 25 Month 150 Day Lates")]
        public int? Lates25Month150Day { get => _lates25Month150Day; set => SetField(ref _lates25Month150Day, value); }

        /// <summary>
        /// Liability 25 Month 30 Day Lates [FLNN48]
        /// </summary>
        [LoanFieldProperty(Description = "Liability 25 Month 30 Day Lates")]
        public int? Lates25Month30Day { get => _lates25Month30Day; set => SetField(ref _lates25Month30Day, value); }

        /// <summary>
        /// Liability 25 Month 60 Day Lates [FLNN51]
        /// </summary>
        [LoanFieldProperty(Description = "Liability 25 Month 60 Day Lates")]
        public int? Lates25Month60Day { get => _lates25Month60Day; set => SetField(ref _lates25Month60Day, value); }

        /// <summary>
        /// Liability 25 Month 90 Day Lates [FLNN54]
        /// </summary>
        [LoanFieldProperty(Description = "Liability 25 Month 90 Day Lates")]
        public int? Lates25Month90Day { get => _lates25Month90Day; set => SetField(ref _lates25Month90Day, value); }

        /// <summary>
        /// Liability LiabilityIndex
        /// </summary>
        public int? LiabilityIndex { get => _liabilityIndex; set => SetField(ref _liabilityIndex, value); }

        /// <summary>
        /// Liability Account Type [FLNN08]
        /// </summary>
        [LoanFieldProperty(Description = "Liability Account Type")]
        public StringEnumValue<LiabilityType> LiabilityType { get => _liabilityType; set => SetField(ref _liabilityType, value); }

        /// <summary>
        /// Liability MonthlyPaymentAmount [FLNN11]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? MonthlyPaymentAmount { get => _monthlyPaymentAmount; set => SetField(ref _monthlyPaymentAmount, value); }

        /// <summary>
        /// Liabilities Install Mos to Exclude [FLNN14]
        /// </summary>
        [LoanFieldProperty(Description = "Liabilities Install Mos to Exclude")]
        public int? MonthsToExclude { get => _monthsToExclude; set => SetField(ref _monthsToExclude, value); }

        /// <summary>
        /// Liability Account Name [FLNN09]
        /// </summary>
        [LoanFieldProperty(Description = "Liability Account Name")]
        public string NameInAccount { get => _nameInAccount; set => SetField(ref _nameInAccount, value); }

        /// <summary>
        /// Liability No Link to Doc Tracking [FLNN97]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Liability No Link to Doc Tracking")]
        public bool? NoLinkToDocTrackIndicator { get => _noLinkToDocTrackIndicator; set => SetField(ref _noLinkToDocTrackIndicator, value); }

        /// <summary>
        /// Liability Verif is For [FLNN15]
        /// </summary>
        [LoanFieldProperty(Description = "Liability Verif is For")]
        public StringEnumValue<Owner> Owner { get => _owner; set => SetField(ref _owner, value); }

        /// <summary>
        /// Liability Will be Paid Off and will be included [FLNN63]
        /// </summary>
        [LoanFieldProperty(Description = "Liability Will be Paid Off and will be included", OptionsJson = "{\"true\":\"Paid off (*) will be included\"}")]
        public bool? PayoffIncludedIndicator { get => _payoffIncludedIndicator; set => SetField(ref _payoffIncludedIndicator, value); }

        /// <summary>
        /// Liability Will be Paid Off [FLNN18]
        /// </summary>
        [LoanFieldProperty(Description = "Liability Will be Paid Off", OptionsJson = "{\"true\":\"Will be paid off (*)\"}")]
        public bool? PayoffStatusIndicator { get => _payoffStatusIndicator; set => SetField(ref _payoffStatusIndicator, value); }

        /// <summary>
        /// Liability Prepayment Penalty [FLNN39]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Liability Prepayment Penalty")]
        public decimal? PrepaymentPenaltyAmount { get => _prepaymentPenaltyAmount; set => SetField(ref _prepaymentPenaltyAmount, value); }

        /// <summary>
        /// Liability Print - See Attached Authorization [FLNN36]
        /// </summary>
        [LoanFieldProperty(Description = "Liability Print - See Attached Authorization", OptionsJson = "{\"true\":\"Print \\\"See attached borrower's authorization\\\" on signature line.\"}")]
        public bool? PrintAttachmentIndicator { get => _printAttachmentIndicator; set => SetField(ref _printAttachmentIndicator, value); }

        /// <summary>
        /// Liability Print User Name as Title [FLNN38]
        /// </summary>
        [LoanFieldProperty(Description = "Liability Print User Name as Title", OptionsJson = "{\"true\":\"Print user's name as title\"}")]
        public bool? PrintUserNameIndicator { get => _printUserNameIndicator; set => SetField(ref _printUserNameIndicator, value); }

        /// <summary>
        /// Liability RemainingTermMonths [FLNN12]
        /// </summary>
        public int? RemainingTermMonths { get => _remainingTermMonths; set => SetField(ref _remainingTermMonths, value); }

        /// <summary>
        /// Liability REO ID [FLNN25]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Liability REO ID")]
        public string ReoId { get => _reoId; set => SetField(ref _reoId, value); }

        /// <summary>
        /// Liability Request ID [FLNN99]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Liability Request ID")]
        public string RequestId { get => _requestId; set => SetField(ref _requestId, value); }

        /// <summary>
        /// Liability Resubordinated Indicator [FLNN26]
        /// </summary>
        [LoanFieldProperty(Description = "Liability Resubordinated Indicator", OptionsJson = "{\"true\":\"Resubordinated Indicator\"}")]
        public bool? SubjectLoanResubordinationIndicator { get => _subjectLoanResubordinationIndicator; set => SetField(ref _subjectLoanResubordinationIndicator, value); }

        /// <summary>
        /// Liability From Title [FLNN37]
        /// </summary>
        [LoanFieldProperty(Description = "Liability From Title")]
        public string Title { get => _title; set => SetField(ref _title, value); }

        /// <summary>
        /// Liability From Fax [FLNN45]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE, Description = "Liability From Fax")]
        public string TitleFax { get => _titleFax; set => SetField(ref _titleFax, value); }

        /// <summary>
        /// Liability From Phone [FLNN44]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE, Description = "Liability From Phone")]
        public string TitlePhone { get => _titlePhone; set => SetField(ref _titlePhone, value); }

        /// <summary>
        /// Liability Payoff Amount [FLNN16]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Liability Payoff Amount")]
        public decimal? ToBePaidOffAmount { get => _toBePaidOffAmount; set => SetField(ref _toBePaidOffAmount, value); }

        /// <summary>
        /// Liability UCD Payoff Type [FLNN62]
        /// </summary>
        [LoanFieldProperty(Description = "Liability UCD Payoff Type")]
        public StringEnumValue<UCDPayoffType> UCDPayoffType { get => _uCDPayoffType; set => SetField(ref _uCDPayoffType, value); }

        /// <summary>
        /// Liability Balance [FLNN13]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Liability Balance")]
        public decimal? UnpaidBalanceAmount { get => _unpaidBalanceAmount; set => SetField(ref _unpaidBalanceAmount, value); }

        /// <summary>
        /// Liability VolIndex
        /// </summary>
        public int? VolIndex { get => _volIndex; set => SetField(ref _volIndex, value); }
    }
}