using System;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// AdditionalLoan
    /// </summary>
    [Entity(SerializeWholeListWhenDirty = true)]
    public sealed partial class AdditionalLoan : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<StringEnumValue<AccountType>>? _accountType;
        private DirtyValue<DateTime?>? _additionalLoanRequestDate;
        private DirtyValue<bool?>? _affordableLoan;
        private DirtyValue<string?>? _altId;
        private DirtyValue<decimal?>? _amountAppliedToDownpayment;
        private DirtyValue<string?>? _attention;
        private DirtyValue<StringEnumValue<Owner>>? _borrowerType;
        private DirtyValue<EntityReference>? _contact;
        private DirtyValue<bool?>? _entityDeleted;
        private DirtyValue<decimal?>? _hELOCCreditLimitAmount;
        private DirtyValue<decimal?>? _hELOCInitialDraw;
        private DirtyValue<string?>? _holderAddressCity;
        private DirtyValue<string?>? _holderAddressPostalCode;
        private DirtyValue<StringEnumValue<State>>? _holderAddressState;
        private DirtyValue<string?>? _holderAddressStreetLine1;
        private DirtyValue<string?>? _holderEmail;
        private DirtyValue<string?>? _holderFax;
        private DirtyValue<string?>? _holderName;
        private DirtyValue<string?>? _holderPhone;
        private DirtyValue<string?>? _id;
        private DirtyValue<bool?>? _individualCreditorIndicator;
        private DirtyValue<StringEnumValue<AdditionalLoanLienPosition>>? _lienPosition;
        private DirtyValue<bool?>? _linkedPiggybackIndicator;
        private DirtyValue<decimal?>? _maximumPILoanAmount;
        private DirtyValue<decimal?>? _maximumPINoteRate;
        private DirtyValue<int?>? _maximumPITerm;
        private DirtyValue<decimal?>? _maximumPrincipalAndInterestIn5Years;
        private DirtyValue<decimal?>? _monthlyPILoanAmount;
        private DirtyValue<decimal?>? _monthlyPINoteRate;
        private DirtyValue<int?>? _monthlyPITerm;
        private DirtyValue<decimal?>? _monthlyPrincipalAndInterest;
        private DirtyValue<bool?>? _paymentDeferredFirstFiveYears;
        private DirtyValue<bool?>? _printAttachmentIndicator;
        private DirtyValue<bool?>? _printUserJobTitleIndicator;
        private DirtyValue<bool?>? _printUserNameIndicator;
        private DirtyValue<string?>? _title;
        private DirtyValue<string?>? _titleFax;
        private DirtyValue<string?>? _titlePhone;

        /// <summary>
        /// Additional Loans AccountType [URLARALNN16]
        /// </summary>
        public StringEnumValue<AccountType> AccountType { get => _accountType; set => SetField(ref _accountType, value); }

        /// <summary>
        /// Additional Loans Request Date [URLARALNN98]
        /// </summary>
        public DateTime? AdditionalLoanRequestDate { get => _additionalLoanRequestDate; set => SetField(ref _additionalLoanRequestDate, value); }

        /// <summary>
        /// Additional Loans  Affordable Loan Indicator [URLARALNN24]
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"Y\":\"Affordable Loan \"}")]
        public bool? AffordableLoan { get => _affordableLoan; set => SetField(ref _affordableLoan, value); }

        /// <summary>
        /// Additional Loans ID [URLARALNN99]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string? AltId { get => _altId; set => SetField(ref _altId, value); }

        /// <summary>
        /// Additional Loans Amount Applied To Downpayment [URLARALNN22]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? AmountAppliedToDownpayment { get => _amountAppliedToDownpayment; set => SetField(ref _amountAppliedToDownpayment, value); }

        /// <summary>
        /// Depository Attention Contact [URLARALNN03]
        /// </summary>
        public string? Attention { get => _attention; set => SetField(ref _attention, value); }

        /// <summary>
        /// Additional Loans Borrower Type [URLARALNN01]
        /// </summary>
        public StringEnumValue<Owner> BorrowerType { get => _borrowerType; set => SetField(ref _borrowerType, value); }

        /// <summary>
        /// AdditionalLoan Contact (Nullable)
        /// </summary>
        public EntityReference Contact { get => _contact; set => SetField(ref _contact, value); }

        /// <summary>
        /// AdditionalLoan EntityDeleted
        /// </summary>
        public bool? EntityDeleted { get => _entityDeleted; set => SetField(ref _entityDeleted, value); }

        /// <summary>
        /// Additional Loans : Loan Amount/HELOC Credit Limit [URLARALNN20]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? HELOCCreditLimitAmount { get => _hELOCCreditLimitAmount; set => SetField(ref _hELOCCreditLimitAmount, value); }

        /// <summary>
        /// Additional Loans HELOC Initial Draw [URLARALNN21]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? HELOCInitialDraw { get => _hELOCInitialDraw; set => SetField(ref _hELOCInitialDraw, value); }

        /// <summary>
        /// Depository Attention City [URLARALNN05]
        /// </summary>
        public string? HolderAddressCity { get => _holderAddressCity; set => SetField(ref _holderAddressCity, value); }

        /// <summary>
        /// Depository Attention Zipcode [URLARALNN07]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
        public string? HolderAddressPostalCode { get => _holderAddressPostalCode; set => SetField(ref _holderAddressPostalCode, value); }

        /// <summary>
        /// Depository Attention State [URLARALNN06]
        /// </summary>
        public StringEnumValue<State> HolderAddressState { get => _holderAddressState; set => SetField(ref _holderAddressState, value); }

        /// <summary>
        /// Depository Address [URLARALNN04]
        /// </summary>
        public string? HolderAddressStreetLine1 { get => _holderAddressStreetLine1; set => SetField(ref _holderAddressStreetLine1, value); }

        /// <summary>
        /// Depository Email [URLARALNN10]
        /// </summary>
        public string? HolderEmail { get => _holderEmail; set => SetField(ref _holderEmail, value); }

        /// <summary>
        /// Depository Fax [URLARALNN09]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
        public string? HolderFax { get => _holderFax; set => SetField(ref _holderFax, value); }

        /// <summary>
        /// Depository Name [URLARALNN02]
        /// </summary>
        public string? HolderName { get => _holderName; set => SetField(ref _holderName, value); }

        /// <summary>
        /// Depository Phone [URLARALNN08]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
        public string? HolderPhone { get => _holderPhone; set => SetField(ref _holderPhone, value); }

        /// <summary>
        /// AdditionalLoan Id
        /// </summary>
        public string? Id { get => _id; set => SetField(ref _id, value); }

        /// <summary>
        /// Creditor is an individual Indicator [URLARALNN32]
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"Y\":\"Creditor is an individual\"}")]
        public bool? IndividualCreditorIndicator { get => _individualCreditorIndicator; set => SetField(ref _individualCreditorIndicator, value); }

        /// <summary>
        /// Additional Loans Lien Position [URLARALNN17]
        /// </summary>
        public StringEnumValue<AdditionalLoanLienPosition> LienPosition { get => _lienPosition; set => SetField(ref _lienPosition, value); }

        /// <summary>
        /// Additional Loans Linked Piggyback Indicator [URLARALNN25]
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"Y\":\"Linked Piggyback Indicator \"}")]
        public bool? LinkedPiggybackIndicator { get => _linkedPiggybackIndicator; set => SetField(ref _linkedPiggybackIndicator, value); }

        /// <summary>
        /// Additional Loans MaximumPILoanAmount [URLARALNN31]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? MaximumPILoanAmount { get => _maximumPILoanAmount; set => SetField(ref _maximumPILoanAmount, value); }

        /// <summary>
        /// Additional Loans : MaximumPINoteRate [URLARALNN29]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? MaximumPINoteRate { get => _maximumPINoteRate; set => SetField(ref _maximumPINoteRate, value); }

        /// <summary>
        /// Additional Loans MaximumPITerm [URLARALNN30]
        /// </summary>
        public int? MaximumPITerm { get => _maximumPITerm; set => SetField(ref _maximumPITerm, value); }

        /// <summary>
        /// Additional Loans Maximum Principal and Interest within 5 Years [URLARALNN19]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? MaximumPrincipalAndInterestIn5Years { get => _maximumPrincipalAndInterestIn5Years; set => SetField(ref _maximumPrincipalAndInterestIn5Years, value); }

        /// <summary>
        /// Additional Loans MonthlyPILoanAmount [URLARALNN28]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? MonthlyPILoanAmount { get => _monthlyPILoanAmount; set => SetField(ref _monthlyPILoanAmount, value); }

        /// <summary>
        /// Additional Loans calculator : MonthlyPINoteRate [URLARALNN26]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? MonthlyPINoteRate { get => _monthlyPINoteRate; set => SetField(ref _monthlyPINoteRate, value); }

        /// <summary>
        /// Additional Loans MonthlyPITerm [URLARALNN27]
        /// </summary>
        public int? MonthlyPITerm { get => _monthlyPITerm; set => SetField(ref _monthlyPITerm, value); }

        /// <summary>
        /// Additional Loans Monthly Principal and Interest [URLARALNN18]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? MonthlyPrincipalAndInterest { get => _monthlyPrincipalAndInterest; set => SetField(ref _monthlyPrincipalAndInterest, value); }

        /// <summary>
        /// Additional Loans Payment Deferred First Five Years [URLARALNN23]
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"Y\":\"Payment Deferred for First Five Years\"}")]
        public bool? PaymentDeferredFirstFiveYears { get => _paymentDeferredFirstFiveYears; set => SetField(ref _paymentDeferredFirstFiveYears, value); }

        /// <summary>
        /// Depository Print - See Attached Authorization [URLARALNN15]
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"Y\":\"Print \\\"See attached borrower's authorization\\\" on signature line.\"}")]
        public bool? PrintAttachmentIndicator { get => _printAttachmentIndicator; set => SetField(ref _printAttachmentIndicator, value); }

        /// <summary>
        /// Depository Print User Job Title [URLARALNN64]
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"Y\":\"Print user's job title\"}")]
        public bool? PrintUserJobTitleIndicator { get => _printUserJobTitleIndicator; set => SetField(ref _printUserJobTitleIndicator, value); }

        /// <summary>
        /// Depository Print User Name as Title [URLARALNN12]
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"Y\":\"Print user's name as title\"}")]
        public bool? PrintUserNameIndicator { get => _printUserNameIndicator; set => SetField(ref _printUserNameIndicator, value); }

        /// <summary>
        /// Depository From Title [URLARALNN11]
        /// </summary>
        public string? Title { get => _title; set => SetField(ref _title, value); }

        /// <summary>
        /// Depository From Fax [URLARALNN14]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
        public string? TitleFax { get => _titleFax; set => SetField(ref _titleFax, value); }

        /// <summary>
        /// Depository From Phone [URLARALNN13]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
        public string? TitlePhone { get => _titlePhone; set => SetField(ref _titlePhone, value); }
    }
}