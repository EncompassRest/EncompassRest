using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class InterimServicing
    {
        private Value<string> _borrCellPhoneNumber;
        public string BorrCellPhoneNumber { get { return _borrCellPhoneNumber; } set { _borrCellPhoneNumber = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorrCellPhoneNumber() => !_borrCellPhoneNumber.Clean;
        private Value<string> _borrHomeEmail;
        public string BorrHomeEmail { get { return _borrHomeEmail; } set { _borrHomeEmail = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorrHomeEmail() => !_borrHomeEmail.Clean;
        private Value<string> _borrHomePhoneNumber;
        public string BorrHomePhoneNumber { get { return _borrHomePhoneNumber; } set { _borrHomePhoneNumber = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorrHomePhoneNumber() => !_borrHomePhoneNumber.Clean;
        private Value<string> _borrowerFirstName;
        public string BorrowerFirstName { get { return _borrowerFirstName; } set { _borrowerFirstName = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorrowerFirstName() => !_borrowerFirstName.Clean;
        private Value<string> _borrowerLastName;
        public string BorrowerLastName { get { return _borrowerLastName; } set { _borrowerLastName = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorrowerLastName() => !_borrowerLastName.Clean;
        private Value<string> _borrWorkPhoneNumber;
        public string BorrWorkPhoneNumber { get { return _borrWorkPhoneNumber; } set { _borrWorkPhoneNumber = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorrWorkPhoneNumber() => !_borrWorkPhoneNumber.Clean;
        private Value<string> _calcTriggered;
        public string CalcTriggered { get { return _calcTriggered; } set { _calcTriggered = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCalcTriggered() => !_calcTriggered.Clean;
        private Value<decimal?> _cityInsurance;
        public decimal? CityInsurance { get { return _cityInsurance; } set { _cityInsurance = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCityInsurance() => !_cityInsurance.Clean;
        private Value<string> _comments;
        public string Comments { get { return _comments; } set { _comments = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeComments() => !_comments.Clean;
        private Value<decimal?> _currentPrincipalBalance;
        public decimal? CurrentPrincipalBalance { get { return _currentPrincipalBalance; } set { _currentPrincipalBalance = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCurrentPrincipalBalance() => !_currentPrincipalBalance.Clean;
        private Value<decimal?> _escrowBalance;
        public decimal? EscrowBalance { get { return _escrowBalance; } set { _escrowBalance = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEscrowBalance() => !_escrowBalance.Clean;
        private Value<List<EscrowDisbursementTransaction>> _escrowDisbursementTransactions;
        public List<EscrowDisbursementTransaction> EscrowDisbursementTransactions { get { return _escrowDisbursementTransactions; } set { _escrowDisbursementTransactions = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEscrowDisbursementTransactions() => !_escrowDisbursementTransactions.Clean;
        private Value<List<EscrowInterestTransaction>> _escrowInterestTransactions;
        public List<EscrowInterestTransaction> EscrowInterestTransactions { get { return _escrowInterestTransactions; } set { _escrowInterestTransactions = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEscrowInterestTransactions() => !_escrowInterestTransactions.Clean;
        private Value<decimal?> _floodInsurance;
        public decimal? FloodInsurance { get { return _floodInsurance; } set { _floodInsurance = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFloodInsurance() => !_floodInsurance.Clean;
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !_id.Clean;
        private Value<List<InterimServicingTransaction>> _interimServicingTransactions;
        public List<InterimServicingTransaction> InterimServicingTransactions { get { return _interimServicingTransactions; } set { _interimServicingTransactions = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInterimServicingTransactions() => !_interimServicingTransactions.Clean;
        private Value<decimal?> _lastPaymentAdditionalEscrow;
        public decimal? LastPaymentAdditionalEscrow { get { return _lastPaymentAdditionalEscrow; } set { _lastPaymentAdditionalEscrow = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLastPaymentAdditionalEscrow() => !_lastPaymentAdditionalEscrow.Clean;
        private Value<decimal?> _lastPaymentAdditionalPrincipal;
        public decimal? LastPaymentAdditionalPrincipal { get { return _lastPaymentAdditionalPrincipal; } set { _lastPaymentAdditionalPrincipal = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLastPaymentAdditionalPrincipal() => !_lastPaymentAdditionalPrincipal.Clean;
        private Value<decimal?> _lastPaymentBuydownSubsidyAmount;
        public decimal? LastPaymentBuydownSubsidyAmount { get { return _lastPaymentBuydownSubsidyAmount; } set { _lastPaymentBuydownSubsidyAmount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLastPaymentBuydownSubsidyAmount() => !_lastPaymentBuydownSubsidyAmount.Clean;
        private Value<decimal?> _lastPaymentEscrowAmount;
        public decimal? LastPaymentEscrowAmount { get { return _lastPaymentEscrowAmount; } set { _lastPaymentEscrowAmount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLastPaymentEscrowAmount() => !_lastPaymentEscrowAmount.Clean;
        private Value<decimal?> _lastPaymentEscrowCityPropertyTax;
        public decimal? LastPaymentEscrowCityPropertyTax { get { return _lastPaymentEscrowCityPropertyTax; } set { _lastPaymentEscrowCityPropertyTax = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLastPaymentEscrowCityPropertyTax() => !_lastPaymentEscrowCityPropertyTax.Clean;
        private Value<decimal?> _lastPaymentEscrowFloodInsurance;
        public decimal? LastPaymentEscrowFloodInsurance { get { return _lastPaymentEscrowFloodInsurance; } set { _lastPaymentEscrowFloodInsurance = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLastPaymentEscrowFloodInsurance() => !_lastPaymentEscrowFloodInsurance.Clean;
        private Value<decimal?> _lastPaymentEscrowHazardInsurance;
        public decimal? LastPaymentEscrowHazardInsurance { get { return _lastPaymentEscrowHazardInsurance; } set { _lastPaymentEscrowHazardInsurance = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLastPaymentEscrowHazardInsurance() => !_lastPaymentEscrowHazardInsurance.Clean;
        private Value<decimal?> _lastPaymentEscrowMortgageInsurance;
        public decimal? LastPaymentEscrowMortgageInsurance { get { return _lastPaymentEscrowMortgageInsurance; } set { _lastPaymentEscrowMortgageInsurance = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLastPaymentEscrowMortgageInsurance() => !_lastPaymentEscrowMortgageInsurance.Clean;
        private Value<decimal?> _lastPaymentEscrowOther1;
        public decimal? LastPaymentEscrowOther1 { get { return _lastPaymentEscrowOther1; } set { _lastPaymentEscrowOther1 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLastPaymentEscrowOther1() => !_lastPaymentEscrowOther1.Clean;
        private Value<decimal?> _lastPaymentEscrowOther2;
        public decimal? LastPaymentEscrowOther2 { get { return _lastPaymentEscrowOther2; } set { _lastPaymentEscrowOther2 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLastPaymentEscrowOther2() => !_lastPaymentEscrowOther2.Clean;
        private Value<decimal?> _lastPaymentEscrowOther3;
        public decimal? LastPaymentEscrowOther3 { get { return _lastPaymentEscrowOther3; } set { _lastPaymentEscrowOther3 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLastPaymentEscrowOther3() => !_lastPaymentEscrowOther3.Clean;
        private Value<decimal?> _lastPaymentEscrowTax;
        public decimal? LastPaymentEscrowTax { get { return _lastPaymentEscrowTax; } set { _lastPaymentEscrowTax = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLastPaymentEscrowTax() => !_lastPaymentEscrowTax.Clean;
        private Value<decimal?> _lastPaymentEscrowUSDAMonthlyPremium;
        public decimal? LastPaymentEscrowUSDAMonthlyPremium { get { return _lastPaymentEscrowUSDAMonthlyPremium; } set { _lastPaymentEscrowUSDAMonthlyPremium = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLastPaymentEscrowUSDAMonthlyPremium() => !_lastPaymentEscrowUSDAMonthlyPremium.Clean;
        private Value<string> _lastPaymentGuid;
        public string LastPaymentGuid { get { return _lastPaymentGuid; } set { _lastPaymentGuid = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLastPaymentGuid() => !_lastPaymentGuid.Clean;
        private Value<decimal?> _lastPaymentInterest;
        public decimal? LastPaymentInterest { get { return _lastPaymentInterest; } set { _lastPaymentInterest = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLastPaymentInterest() => !_lastPaymentInterest.Clean;
        private Value<decimal?> _lastPaymentLateFee;
        public decimal? LastPaymentLateFee { get { return _lastPaymentLateFee; } set { _lastPaymentLateFee = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLastPaymentLateFee() => !_lastPaymentLateFee.Clean;
        private Value<decimal?> _lastPaymentMiscFee;
        public decimal? LastPaymentMiscFee { get { return _lastPaymentMiscFee; } set { _lastPaymentMiscFee = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLastPaymentMiscFee() => !_lastPaymentMiscFee.Clean;
        private Value<int?> _lastPaymentNumber;
        public int? LastPaymentNumber { get { return _lastPaymentNumber; } set { _lastPaymentNumber = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLastPaymentNumber() => !_lastPaymentNumber.Clean;
        private Value<decimal?> _lastPaymentPrincipal;
        public decimal? LastPaymentPrincipal { get { return _lastPaymentPrincipal; } set { _lastPaymentPrincipal = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLastPaymentPrincipal() => !_lastPaymentPrincipal.Clean;
        private Value<decimal?> _lastPaymentPrincipalAndInterest;
        public decimal? LastPaymentPrincipalAndInterest { get { return _lastPaymentPrincipalAndInterest; } set { _lastPaymentPrincipalAndInterest = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLastPaymentPrincipalAndInterest() => !_lastPaymentPrincipalAndInterest.Clean;
        private Value<DateTime?> _lastPaymentReceivedDate;
        public DateTime? LastPaymentReceivedDate { get { return _lastPaymentReceivedDate; } set { _lastPaymentReceivedDate = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLastPaymentReceivedDate() => !_lastPaymentReceivedDate.Clean;
        private Value<DateTime?> _lastPaymentStatementDate;
        public DateTime? LastPaymentStatementDate { get { return _lastPaymentStatementDate; } set { _lastPaymentStatementDate = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLastPaymentStatementDate() => !_lastPaymentStatementDate.Clean;
        private Value<decimal?> _lastPaymentTotalAmountReceived;
        public decimal? LastPaymentTotalAmountReceived { get { return _lastPaymentTotalAmountReceived; } set { _lastPaymentTotalAmountReceived = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLastPaymentTotalAmountReceived() => !_lastPaymentTotalAmountReceived.Clean;
        public SchedulePaymentTransaction LastScheduledPayment { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLastScheduledPayment() => LastScheduledPayment?.Clean == false;
        private Value<DateTime?> _lastStatementPrintedDate;
        public DateTime? LastStatementPrintedDate { get { return _lastStatementPrintedDate; } set { _lastStatementPrintedDate = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLastStatementPrintedDate() => !_lastStatementPrintedDate.Clean;
        private Value<string> _loanSnapshotXml;
        public string LoanSnapshotXml { get { return _loanSnapshotXml; } set { _loanSnapshotXml = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanSnapshotXml() => !_loanSnapshotXml.Clean;
        private Value<string> _mailingCity;
        public string MailingCity { get { return _mailingCity; } set { _mailingCity = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMailingCity() => !_mailingCity.Clean;
        private Value<string> _mailingPostalCode;
        public string MailingPostalCode { get { return _mailingPostalCode; } set { _mailingPostalCode = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMailingPostalCode() => !_mailingPostalCode.Clean;
        private Value<string> _mailingState;
        public string MailingState { get { return _mailingState; } set { _mailingState = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMailingState() => !_mailingState.Clean;
        private Value<string> _mailingStreetAddress;
        public string MailingStreetAddress { get { return _mailingStreetAddress; } set { _mailingStreetAddress = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMailingStreetAddress() => !_mailingStreetAddress.Clean;
        private Value<string> _mortgageAccount;
        public string MortgageAccount { get { return _mortgageAccount; } set { _mortgageAccount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMortgageAccount() => !_mortgageAccount.Clean;
        private Value<decimal?> _nextEscrowTotalFloodInsurance;
        public decimal? NextEscrowTotalFloodInsurance { get { return _nextEscrowTotalFloodInsurance; } set { _nextEscrowTotalFloodInsurance = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNextEscrowTotalFloodInsurance() => !_nextEscrowTotalFloodInsurance.Clean;
        private Value<DateTime?> _nextEscrowTotalFloodInsuranceDueDate;
        public DateTime? NextEscrowTotalFloodInsuranceDueDate { get { return _nextEscrowTotalFloodInsuranceDueDate; } set { _nextEscrowTotalFloodInsuranceDueDate = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNextEscrowTotalFloodInsuranceDueDate() => !_nextEscrowTotalFloodInsuranceDueDate.Clean;
        private Value<decimal?> _nextEscrowTotalHazardInsurance;
        public decimal? NextEscrowTotalHazardInsurance { get { return _nextEscrowTotalHazardInsurance; } set { _nextEscrowTotalHazardInsurance = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNextEscrowTotalHazardInsurance() => !_nextEscrowTotalHazardInsurance.Clean;
        private Value<DateTime?> _nextEscrowTotalHazardInsuranceDueDate;
        public DateTime? NextEscrowTotalHazardInsuranceDueDate { get { return _nextEscrowTotalHazardInsuranceDueDate; } set { _nextEscrowTotalHazardInsuranceDueDate = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNextEscrowTotalHazardInsuranceDueDate() => !_nextEscrowTotalHazardInsuranceDueDate.Clean;
        private Value<decimal?> _nextEscrowTotalMortgageInsurance;
        public decimal? NextEscrowTotalMortgageInsurance { get { return _nextEscrowTotalMortgageInsurance; } set { _nextEscrowTotalMortgageInsurance = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNextEscrowTotalMortgageInsurance() => !_nextEscrowTotalMortgageInsurance.Clean;
        private Value<DateTime?> _nextEscrowTotalMortgageInsuranceDueDate;
        public DateTime? NextEscrowTotalMortgageInsuranceDueDate { get { return _nextEscrowTotalMortgageInsuranceDueDate; } set { _nextEscrowTotalMortgageInsuranceDueDate = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNextEscrowTotalMortgageInsuranceDueDate() => !_nextEscrowTotalMortgageInsuranceDueDate.Clean;
        private Value<decimal?> _nextEscrowTotalOtherTax1;
        public decimal? NextEscrowTotalOtherTax1 { get { return _nextEscrowTotalOtherTax1; } set { _nextEscrowTotalOtherTax1 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNextEscrowTotalOtherTax1() => !_nextEscrowTotalOtherTax1.Clean;
        private Value<DateTime?> _nextEscrowTotalOtherTax1DueDate;
        public DateTime? NextEscrowTotalOtherTax1DueDate { get { return _nextEscrowTotalOtherTax1DueDate; } set { _nextEscrowTotalOtherTax1DueDate = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNextEscrowTotalOtherTax1DueDate() => !_nextEscrowTotalOtherTax1DueDate.Clean;
        private Value<decimal?> _nextEscrowTotalOtherTax2;
        public decimal? NextEscrowTotalOtherTax2 { get { return _nextEscrowTotalOtherTax2; } set { _nextEscrowTotalOtherTax2 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNextEscrowTotalOtherTax2() => !_nextEscrowTotalOtherTax2.Clean;
        private Value<DateTime?> _nextEscrowTotalOtherTax2DueDate;
        public DateTime? NextEscrowTotalOtherTax2DueDate { get { return _nextEscrowTotalOtherTax2DueDate; } set { _nextEscrowTotalOtherTax2DueDate = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNextEscrowTotalOtherTax2DueDate() => !_nextEscrowTotalOtherTax2DueDate.Clean;
        private Value<decimal?> _nextEscrowTotalOtherTax3;
        public decimal? NextEscrowTotalOtherTax3 { get { return _nextEscrowTotalOtherTax3; } set { _nextEscrowTotalOtherTax3 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNextEscrowTotalOtherTax3() => !_nextEscrowTotalOtherTax3.Clean;
        private Value<DateTime?> _nextEscrowTotalOtherTax3DueDate;
        public DateTime? NextEscrowTotalOtherTax3DueDate { get { return _nextEscrowTotalOtherTax3DueDate; } set { _nextEscrowTotalOtherTax3DueDate = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNextEscrowTotalOtherTax3DueDate() => !_nextEscrowTotalOtherTax3DueDate.Clean;
        private Value<decimal?> _nextEscrowTotalPropertyTax;
        public decimal? NextEscrowTotalPropertyTax { get { return _nextEscrowTotalPropertyTax; } set { _nextEscrowTotalPropertyTax = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNextEscrowTotalPropertyTax() => !_nextEscrowTotalPropertyTax.Clean;
        private Value<DateTime?> _nextEscrowTotalPropertyTaxDueDate;
        public DateTime? NextEscrowTotalPropertyTaxDueDate { get { return _nextEscrowTotalPropertyTaxDueDate; } set { _nextEscrowTotalPropertyTaxDueDate = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNextEscrowTotalPropertyTaxDueDate() => !_nextEscrowTotalPropertyTaxDueDate.Clean;
        private Value<decimal?> _nextEscrowTotalTax;
        public decimal? NextEscrowTotalTax { get { return _nextEscrowTotalTax; } set { _nextEscrowTotalTax = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNextEscrowTotalTax() => !_nextEscrowTotalTax.Clean;
        private Value<DateTime?> _nextEscrowTotalTaxDueDate;
        public DateTime? NextEscrowTotalTaxDueDate { get { return _nextEscrowTotalTaxDueDate; } set { _nextEscrowTotalTaxDueDate = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNextEscrowTotalTaxDueDate() => !_nextEscrowTotalTaxDueDate.Clean;
        private Value<decimal?> _nextEscrowTotalUsdaMonthlyPremium;
        public decimal? NextEscrowTotalUsdaMonthlyPremium { get { return _nextEscrowTotalUsdaMonthlyPremium; } set { _nextEscrowTotalUsdaMonthlyPremium = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNextEscrowTotalUsdaMonthlyPremium() => !_nextEscrowTotalUsdaMonthlyPremium.Clean;
        private Value<DateTime?> _nextEscrowTotalUsdaMonthlyPremiumDueDate;
        public DateTime? NextEscrowTotalUsdaMonthlyPremiumDueDate { get { return _nextEscrowTotalUsdaMonthlyPremiumDueDate; } set { _nextEscrowTotalUsdaMonthlyPremiumDueDate = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNextEscrowTotalUsdaMonthlyPremiumDueDate() => !_nextEscrowTotalUsdaMonthlyPremiumDueDate.Clean;
        private Value<decimal?> _nextPaymentBuydownSubsidyAmount;
        public decimal? NextPaymentBuydownSubsidyAmount { get { return _nextPaymentBuydownSubsidyAmount; } set { _nextPaymentBuydownSubsidyAmount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNextPaymentBuydownSubsidyAmount() => !_nextPaymentBuydownSubsidyAmount.Clean;
        private Value<decimal?> _nextPaymentEscrowAmount;
        public decimal? NextPaymentEscrowAmount { get { return _nextPaymentEscrowAmount; } set { _nextPaymentEscrowAmount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNextPaymentEscrowAmount() => !_nextPaymentEscrowAmount.Clean;
        private Value<decimal?> _nextPaymentEscrowCityPropertyTax;
        public decimal? NextPaymentEscrowCityPropertyTax { get { return _nextPaymentEscrowCityPropertyTax; } set { _nextPaymentEscrowCityPropertyTax = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNextPaymentEscrowCityPropertyTax() => !_nextPaymentEscrowCityPropertyTax.Clean;
        private Value<decimal?> _nextPaymentEscrowFloodInsurance;
        public decimal? NextPaymentEscrowFloodInsurance { get { return _nextPaymentEscrowFloodInsurance; } set { _nextPaymentEscrowFloodInsurance = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNextPaymentEscrowFloodInsurance() => !_nextPaymentEscrowFloodInsurance.Clean;
        private Value<decimal?> _nextPaymentEscrowHazardInsurance;
        public decimal? NextPaymentEscrowHazardInsurance { get { return _nextPaymentEscrowHazardInsurance; } set { _nextPaymentEscrowHazardInsurance = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNextPaymentEscrowHazardInsurance() => !_nextPaymentEscrowHazardInsurance.Clean;
        private Value<decimal?> _nextPaymentEscrowMortgageInsurance;
        public decimal? NextPaymentEscrowMortgageInsurance { get { return _nextPaymentEscrowMortgageInsurance; } set { _nextPaymentEscrowMortgageInsurance = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNextPaymentEscrowMortgageInsurance() => !_nextPaymentEscrowMortgageInsurance.Clean;
        private Value<decimal?> _nextPaymentEscrowOther1;
        public decimal? NextPaymentEscrowOther1 { get { return _nextPaymentEscrowOther1; } set { _nextPaymentEscrowOther1 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNextPaymentEscrowOther1() => !_nextPaymentEscrowOther1.Clean;
        private Value<decimal?> _nextPaymentEscrowOther2;
        public decimal? NextPaymentEscrowOther2 { get { return _nextPaymentEscrowOther2; } set { _nextPaymentEscrowOther2 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNextPaymentEscrowOther2() => !_nextPaymentEscrowOther2.Clean;
        private Value<decimal?> _nextPaymentEscrowOther3;
        public decimal? NextPaymentEscrowOther3 { get { return _nextPaymentEscrowOther3; } set { _nextPaymentEscrowOther3 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNextPaymentEscrowOther3() => !_nextPaymentEscrowOther3.Clean;
        private Value<decimal?> _nextPaymentEscrowTax;
        public decimal? NextPaymentEscrowTax { get { return _nextPaymentEscrowTax; } set { _nextPaymentEscrowTax = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNextPaymentEscrowTax() => !_nextPaymentEscrowTax.Clean;
        private Value<decimal?> _nextPaymentEscrowUSDAMonthlyPremium;
        public decimal? NextPaymentEscrowUSDAMonthlyPremium { get { return _nextPaymentEscrowUSDAMonthlyPremium; } set { _nextPaymentEscrowUSDAMonthlyPremium = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNextPaymentEscrowUSDAMonthlyPremium() => !_nextPaymentEscrowUSDAMonthlyPremium.Clean;
        private Value<decimal?> _nextPaymentIndexCurrentValuePercent;
        public decimal? NextPaymentIndexCurrentValuePercent { get { return _nextPaymentIndexCurrentValuePercent; } set { _nextPaymentIndexCurrentValuePercent = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNextPaymentIndexCurrentValuePercent() => !_nextPaymentIndexCurrentValuePercent.Clean;
        private Value<decimal?> _nextPaymentInterest;
        public decimal? NextPaymentInterest { get { return _nextPaymentInterest; } set { _nextPaymentInterest = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNextPaymentInterest() => !_nextPaymentInterest.Clean;
        private Value<decimal?> _nextPaymentLateFee;
        public decimal? NextPaymentLateFee { get { return _nextPaymentLateFee; } set { _nextPaymentLateFee = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNextPaymentLateFee() => !_nextPaymentLateFee.Clean;
        private Value<DateTime?> _nextPaymentLatePaymentDate;
        public DateTime? NextPaymentLatePaymentDate { get { return _nextPaymentLatePaymentDate; } set { _nextPaymentLatePaymentDate = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNextPaymentLatePaymentDate() => !_nextPaymentLatePaymentDate.Clean;
        private Value<decimal?> _nextPaymentMiscFee;
        public decimal? NextPaymentMiscFee { get { return _nextPaymentMiscFee; } set { _nextPaymentMiscFee = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNextPaymentMiscFee() => !_nextPaymentMiscFee.Clean;
        private Value<decimal?> _nextPaymentPastDueAmount;
        public decimal? NextPaymentPastDueAmount { get { return _nextPaymentPastDueAmount; } set { _nextPaymentPastDueAmount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNextPaymentPastDueAmount() => !_nextPaymentPastDueAmount.Clean;
        private Value<DateTime?> _nextPaymentPaymentDueDate;
        public DateTime? NextPaymentPaymentDueDate { get { return _nextPaymentPaymentDueDate; } set { _nextPaymentPaymentDueDate = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNextPaymentPaymentDueDate() => !_nextPaymentPaymentDueDate.Clean;
        private Value<DateTime?> _nextPaymentPaymentIndexDate;
        public DateTime? NextPaymentPaymentIndexDate { get { return _nextPaymentPaymentIndexDate; } set { _nextPaymentPaymentIndexDate = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNextPaymentPaymentIndexDate() => !_nextPaymentPaymentIndexDate.Clean;
        private Value<decimal?> _nextPaymentPrincipal;
        public decimal? NextPaymentPrincipal { get { return _nextPaymentPrincipal; } set { _nextPaymentPrincipal = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNextPaymentPrincipal() => !_nextPaymentPrincipal.Clean;
        private Value<decimal?> _nextPaymentPrincipalAndInterest;
        public decimal? NextPaymentPrincipalAndInterest { get { return _nextPaymentPrincipalAndInterest; } set { _nextPaymentPrincipalAndInterest = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNextPaymentPrincipalAndInterest() => !_nextPaymentPrincipalAndInterest.Clean;
        private Value<decimal?> _nextPaymentRequestedInterestRatePercent;
        public decimal? NextPaymentRequestedInterestRatePercent { get { return _nextPaymentRequestedInterestRatePercent; } set { _nextPaymentRequestedInterestRatePercent = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNextPaymentRequestedInterestRatePercent() => !_nextPaymentRequestedInterestRatePercent.Clean;
        private Value<DateTime?> _nextPaymentStatementDueDate;
        public DateTime? NextPaymentStatementDueDate { get { return _nextPaymentStatementDueDate; } set { _nextPaymentStatementDueDate = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNextPaymentStatementDueDate() => !_nextPaymentStatementDueDate.Clean;
        private Value<decimal?> _nextPaymentTotalAmountDue;
        public decimal? NextPaymentTotalAmountDue { get { return _nextPaymentTotalAmountDue; } set { _nextPaymentTotalAmountDue = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNextPaymentTotalAmountDue() => !_nextPaymentTotalAmountDue.Clean;
        private Value<decimal?> _nextPaymentTotalAmountWithLateFee;
        public decimal? NextPaymentTotalAmountWithLateFee { get { return _nextPaymentTotalAmountWithLateFee; } set { _nextPaymentTotalAmountWithLateFee = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNextPaymentTotalAmountWithLateFee() => !_nextPaymentTotalAmountWithLateFee.Clean;
        private Value<decimal?> _nextPaymentUnpaidLateFee;
        public decimal? NextPaymentUnpaidLateFee { get { return _nextPaymentUnpaidLateFee; } set { _nextPaymentUnpaidLateFee = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNextPaymentUnpaidLateFee() => !_nextPaymentUnpaidLateFee.Clean;
        public SchedulePaymentTransaction NextScheduledPayment { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNextScheduledPayment() => NextScheduledPayment?.Clean == false;
        private Value<int?> _numberOfDisbursement;
        public int? NumberOfDisbursement { get { return _numberOfDisbursement; } set { _numberOfDisbursement = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNumberOfDisbursement() => !_numberOfDisbursement.Clean;
        private Value<List<OtherTransaction>> _otherTransactions;
        public List<OtherTransaction> OtherTransactions { get { return _otherTransactions; } set { _otherTransactions = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOtherTransactions() => !_otherTransactions.Clean;
        private Value<DateTime?> _paymentDueDatePrinted;
        public DateTime? PaymentDueDatePrinted { get { return _paymentDueDatePrinted; } set { _paymentDueDatePrinted = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePaymentDueDatePrinted() => !_paymentDueDatePrinted.Clean;
        private Value<List<PaymentReversalTransaction>> _paymentReversalTransactions;
        public List<PaymentReversalTransaction> PaymentReversalTransactions { get { return _paymentReversalTransactions; } set { _paymentReversalTransactions = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePaymentReversalTransactions() => !_paymentReversalTransactions.Clean;
        private Value<List<PaymentTransaction>> _paymentTransactions;
        public List<PaymentTransaction> PaymentTransactions { get { return _paymentTransactions; } set { _paymentTransactions = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePaymentTransactions() => !_paymentTransactions.Clean;
        private Value<string> _printedByUserId;
        public string PrintedByUserId { get { return _printedByUserId; } set { _printedByUserId = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePrintedByUserId() => !_printedByUserId.Clean;
        private Value<string> _printedByUserName;
        public string PrintedByUserName { get { return _printedByUserName; } set { _printedByUserName = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePrintedByUserName() => !_printedByUserName.Clean;
        private Value<decimal?> _purchasedPrincipal;
        public decimal? PurchasedPrincipal { get { return _purchasedPrincipal; } set { _purchasedPrincipal = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePurchasedPrincipal() => !_purchasedPrincipal.Clean;
        private Value<List<SchedulePaymentTransaction>> _scheduledPayments;
        public List<SchedulePaymentTransaction> ScheduledPayments { get { return _scheduledPayments; } set { _scheduledPayments = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeScheduledPayments() => !_scheduledPayments.Clean;
        private Value<List<SchedulePaymentTransaction>> _schedulePaymentTransactions;
        public List<SchedulePaymentTransaction> SchedulePaymentTransactions { get { return _schedulePaymentTransactions; } set { _schedulePaymentTransactions = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSchedulePaymentTransactions() => !_schedulePaymentTransactions.Clean;
        private Value<string> _servicerLoanNumber;
        public string ServicerLoanNumber { get { return _servicerLoanNumber; } set { _servicerLoanNumber = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeServicerLoanNumber() => !_servicerLoanNumber.Clean;
        private Value<string> _servicingStatus;
        public string ServicingStatus { get { return _servicingStatus; } set { _servicingStatus = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeServicingStatus() => !_servicingStatus.Clean;
        private Value<DateTime?> _servicingTransferDate;
        public DateTime? ServicingTransferDate { get { return _servicingTransferDate; } set { _servicingTransferDate = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeServicingTransferDate() => !_servicingTransferDate.Clean;
        private Value<string> _subServicer;
        public string SubServicer { get { return _subServicer; } set { _subServicer = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSubServicer() => !_subServicer.Clean;
        private Value<string> _subServicerLoanNumber;
        public string SubServicerLoanNumber { get { return _subServicerLoanNumber; } set { _subServicerLoanNumber = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSubServicerLoanNumber() => !_subServicerLoanNumber.Clean;
        private Value<decimal?> _totalAdditionalEscrow;
        public decimal? TotalAdditionalEscrow { get { return _totalAdditionalEscrow; } set { _totalAdditionalEscrow = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalAdditionalEscrow() => !_totalAdditionalEscrow.Clean;
        private Value<decimal?> _totalAdditionalEscrowYearToDate;
        public decimal? TotalAdditionalEscrowYearToDate { get { return _totalAdditionalEscrowYearToDate; } set { _totalAdditionalEscrowYearToDate = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalAdditionalEscrowYearToDate() => !_totalAdditionalEscrowYearToDate.Clean;
        private Value<decimal?> _totalAdditionalPrincipal;
        public decimal? TotalAdditionalPrincipal { get { return _totalAdditionalPrincipal; } set { _totalAdditionalPrincipal = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalAdditionalPrincipal() => !_totalAdditionalPrincipal.Clean;
        private Value<decimal?> _totalAdditionalPrincipalYearToDate;
        public decimal? TotalAdditionalPrincipalYearToDate { get { return _totalAdditionalPrincipalYearToDate; } set { _totalAdditionalPrincipalYearToDate = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalAdditionalPrincipalYearToDate() => !_totalAdditionalPrincipalYearToDate.Clean;
        private Value<decimal?> _totalAmountDisbursed;
        public decimal? TotalAmountDisbursed { get { return _totalAmountDisbursed; } set { _totalAmountDisbursed = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalAmountDisbursed() => !_totalAmountDisbursed.Clean;
        private Value<decimal?> _totalBuydownSubsidyAmount;
        public decimal? TotalBuydownSubsidyAmount { get { return _totalBuydownSubsidyAmount; } set { _totalBuydownSubsidyAmount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalBuydownSubsidyAmount() => !_totalBuydownSubsidyAmount.Clean;
        private Value<decimal?> _totalBuydownSubsidyAmountYearToDate;
        public decimal? TotalBuydownSubsidyAmountYearToDate { get { return _totalBuydownSubsidyAmountYearToDate; } set { _totalBuydownSubsidyAmountYearToDate = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalBuydownSubsidyAmountYearToDate() => !_totalBuydownSubsidyAmountYearToDate.Clean;
        private Value<decimal?> _totalEscrow;
        public decimal? TotalEscrow { get { return _totalEscrow; } set { _totalEscrow = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalEscrow() => !_totalEscrow.Clean;
        private Value<decimal?> _totalEscrowYearToDate;
        public decimal? TotalEscrowYearToDate { get { return _totalEscrowYearToDate; } set { _totalEscrowYearToDate = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalEscrowYearToDate() => !_totalEscrowYearToDate.Clean;
        private Value<decimal?> _totalHazardInsurance;
        public decimal? TotalHazardInsurance { get { return _totalHazardInsurance; } set { _totalHazardInsurance = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalHazardInsurance() => !_totalHazardInsurance.Clean;
        private Value<decimal?> _totalInterest;
        public decimal? TotalInterest { get { return _totalInterest; } set { _totalInterest = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalInterest() => !_totalInterest.Clean;
        private Value<decimal?> _totalInterestYearToDate;
        public decimal? TotalInterestYearToDate { get { return _totalInterestYearToDate; } set { _totalInterestYearToDate = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalInterestYearToDate() => !_totalInterestYearToDate.Clean;
        private Value<decimal?> _totalLateFee;
        public decimal? TotalLateFee { get { return _totalLateFee; } set { _totalLateFee = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalLateFee() => !_totalLateFee.Clean;
        private Value<decimal?> _totalLateFeeYearToDate;
        public decimal? TotalLateFeeYearToDate { get { return _totalLateFeeYearToDate; } set { _totalLateFeeYearToDate = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalLateFeeYearToDate() => !_totalLateFeeYearToDate.Clean;
        private Value<decimal?> _totalMiscFee;
        public decimal? TotalMiscFee { get { return _totalMiscFee; } set { _totalMiscFee = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalMiscFee() => !_totalMiscFee.Clean;
        private Value<decimal?> _totalMiscFeeYearToDate;
        public decimal? TotalMiscFeeYearToDate { get { return _totalMiscFeeYearToDate; } set { _totalMiscFeeYearToDate = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalMiscFeeYearToDate() => !_totalMiscFeeYearToDate.Clean;
        private Value<decimal?> _totalMortgageInsurance;
        public decimal? TotalMortgageInsurance { get { return _totalMortgageInsurance; } set { _totalMortgageInsurance = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalMortgageInsurance() => !_totalMortgageInsurance.Clean;
        private Value<int?> _totalNumberOfLatePayment;
        public int? TotalNumberOfLatePayment { get { return _totalNumberOfLatePayment; } set { _totalNumberOfLatePayment = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalNumberOfLatePayment() => !_totalNumberOfLatePayment.Clean;
        private Value<int?> _totalNumberOfPayment;
        public int? TotalNumberOfPayment { get { return _totalNumberOfPayment; } set { _totalNumberOfPayment = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalNumberOfPayment() => !_totalNumberOfPayment.Clean;
        private Value<decimal?> _totalOtherTaxes;
        public decimal? TotalOtherTaxes { get { return _totalOtherTaxes; } set { _totalOtherTaxes = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalOtherTaxes() => !_totalOtherTaxes.Clean;
        private Value<decimal?> _totalPAndI;
        public decimal? TotalPAndI { get { return _totalPAndI; } set { _totalPAndI = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalPAndI() => !_totalPAndI.Clean;
        private Value<decimal?> _totalPAndIYearToDate;
        public decimal? TotalPAndIYearToDate { get { return _totalPAndIYearToDate; } set { _totalPAndIYearToDate = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalPAndIYearToDate() => !_totalPAndIYearToDate.Clean;
        private Value<decimal?> _totalPaymentCollected;
        public decimal? TotalPaymentCollected { get { return _totalPaymentCollected; } set { _totalPaymentCollected = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalPaymentCollected() => !_totalPaymentCollected.Clean;
        private Value<decimal?> _totalPaymentCollectedYearToDate;
        public decimal? TotalPaymentCollectedYearToDate { get { return _totalPaymentCollectedYearToDate; } set { _totalPaymentCollectedYearToDate = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalPaymentCollectedYearToDate() => !_totalPaymentCollectedYearToDate.Clean;
        private Value<decimal?> _totalPrincipal;
        public decimal? TotalPrincipal { get { return _totalPrincipal; } set { _totalPrincipal = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalPrincipal() => !_totalPrincipal.Clean;
        private Value<decimal?> _totalPrincipalYearToDate;
        public decimal? TotalPrincipalYearToDate { get { return _totalPrincipalYearToDate; } set { _totalPrincipalYearToDate = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalPrincipalYearToDate() => !_totalPrincipalYearToDate.Clean;
        private Value<decimal?> _totalTaxes;
        public decimal? TotalTaxes { get { return _totalTaxes; } set { _totalTaxes = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalTaxes() => !_totalTaxes.Clean;
        private Value<decimal?> _totalUsdaMonthlyPremium;
        public decimal? TotalUsdaMonthlyPremium { get { return _totalUsdaMonthlyPremium; } set { _totalUsdaMonthlyPremium = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalUsdaMonthlyPremium() => !_totalUsdaMonthlyPremium.Clean;
        private Value<decimal?> _unpaidBuydownSubsidyAmount;
        public decimal? UnpaidBuydownSubsidyAmount { get { return _unpaidBuydownSubsidyAmount; } set { _unpaidBuydownSubsidyAmount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUnpaidBuydownSubsidyAmount() => !_unpaidBuydownSubsidyAmount.Clean;
        private Value<decimal?> _unpaidEscrow;
        public decimal? UnpaidEscrow { get { return _unpaidEscrow; } set { _unpaidEscrow = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUnpaidEscrow() => !_unpaidEscrow.Clean;
        private Value<decimal?> _unpaidEscrowCityPropertyTax;
        public decimal? UnpaidEscrowCityPropertyTax { get { return _unpaidEscrowCityPropertyTax; } set { _unpaidEscrowCityPropertyTax = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUnpaidEscrowCityPropertyTax() => !_unpaidEscrowCityPropertyTax.Clean;
        private Value<decimal?> _unpaidEscrowFloodInsurance;
        public decimal? UnpaidEscrowFloodInsurance { get { return _unpaidEscrowFloodInsurance; } set { _unpaidEscrowFloodInsurance = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUnpaidEscrowFloodInsurance() => !_unpaidEscrowFloodInsurance.Clean;
        private Value<decimal?> _unpaidEscrowHazardInsurance;
        public decimal? UnpaidEscrowHazardInsurance { get { return _unpaidEscrowHazardInsurance; } set { _unpaidEscrowHazardInsurance = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUnpaidEscrowHazardInsurance() => !_unpaidEscrowHazardInsurance.Clean;
        private Value<decimal?> _unpaidEscrowMortgageInsurance;
        public decimal? UnpaidEscrowMortgageInsurance { get { return _unpaidEscrowMortgageInsurance; } set { _unpaidEscrowMortgageInsurance = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUnpaidEscrowMortgageInsurance() => !_unpaidEscrowMortgageInsurance.Clean;
        private Value<decimal?> _unpaidEscrowOther1;
        public decimal? UnpaidEscrowOther1 { get { return _unpaidEscrowOther1; } set { _unpaidEscrowOther1 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUnpaidEscrowOther1() => !_unpaidEscrowOther1.Clean;
        private Value<decimal?> _unpaidEscrowOther2;
        public decimal? UnpaidEscrowOther2 { get { return _unpaidEscrowOther2; } set { _unpaidEscrowOther2 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUnpaidEscrowOther2() => !_unpaidEscrowOther2.Clean;
        private Value<decimal?> _unpaidEscrowOther3;
        public decimal? UnpaidEscrowOther3 { get { return _unpaidEscrowOther3; } set { _unpaidEscrowOther3 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUnpaidEscrowOther3() => !_unpaidEscrowOther3.Clean;
        private Value<decimal?> _unpaidEscrowTax;
        public decimal? UnpaidEscrowTax { get { return _unpaidEscrowTax; } set { _unpaidEscrowTax = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUnpaidEscrowTax() => !_unpaidEscrowTax.Clean;
        private Value<decimal?> _unpaidEscrowUSDAMonthlyPremium;
        public decimal? UnpaidEscrowUSDAMonthlyPremium { get { return _unpaidEscrowUSDAMonthlyPremium; } set { _unpaidEscrowUSDAMonthlyPremium = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUnpaidEscrowUSDAMonthlyPremium() => !_unpaidEscrowUSDAMonthlyPremium.Clean;
        private Value<decimal?> _unpaidInterest;
        public decimal? UnpaidInterest { get { return _unpaidInterest; } set { _unpaidInterest = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUnpaidInterest() => !_unpaidInterest.Clean;
        private Value<decimal?> _unpaidLateFee;
        public decimal? UnpaidLateFee { get { return _unpaidLateFee; } set { _unpaidLateFee = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUnpaidLateFee() => !_unpaidLateFee.Clean;
        private Value<decimal?> _unpaidMiscrFee;
        public decimal? UnpaidMiscrFee { get { return _unpaidMiscrFee; } set { _unpaidMiscrFee = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUnpaidMiscrFee() => !_unpaidMiscrFee.Clean;
        private Value<decimal?> _unpaidPrincipal;
        public decimal? UnpaidPrincipal { get { return _unpaidPrincipal; } set { _unpaidPrincipal = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUnpaidPrincipal() => !_unpaidPrincipal.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = _borrCellPhoneNumber.Clean
                    && _borrHomeEmail.Clean
                    && _borrHomePhoneNumber.Clean
                    && _borrowerFirstName.Clean
                    && _borrowerLastName.Clean
                    && _borrWorkPhoneNumber.Clean
                    && _calcTriggered.Clean
                    && _cityInsurance.Clean
                    && _comments.Clean
                    && _currentPrincipalBalance.Clean
                    && _escrowBalance.Clean
                    && _escrowDisbursementTransactions.Clean
                    && _escrowInterestTransactions.Clean
                    && _floodInsurance.Clean
                    && _id.Clean
                    && _interimServicingTransactions.Clean
                    && _lastPaymentAdditionalEscrow.Clean
                    && _lastPaymentAdditionalPrincipal.Clean
                    && _lastPaymentBuydownSubsidyAmount.Clean
                    && _lastPaymentEscrowAmount.Clean
                    && _lastPaymentEscrowCityPropertyTax.Clean
                    && _lastPaymentEscrowFloodInsurance.Clean
                    && _lastPaymentEscrowHazardInsurance.Clean
                    && _lastPaymentEscrowMortgageInsurance.Clean
                    && _lastPaymentEscrowOther1.Clean
                    && _lastPaymentEscrowOther2.Clean
                    && _lastPaymentEscrowOther3.Clean
                    && _lastPaymentEscrowTax.Clean
                    && _lastPaymentEscrowUSDAMonthlyPremium.Clean
                    && _lastPaymentGuid.Clean
                    && _lastPaymentInterest.Clean
                    && _lastPaymentLateFee.Clean
                    && _lastPaymentMiscFee.Clean
                    && _lastPaymentNumber.Clean
                    && _lastPaymentPrincipal.Clean
                    && _lastPaymentPrincipalAndInterest.Clean
                    && _lastPaymentReceivedDate.Clean
                    && _lastPaymentStatementDate.Clean
                    && _lastPaymentTotalAmountReceived.Clean
                    && _lastStatementPrintedDate.Clean
                    && _loanSnapshotXml.Clean
                    && _mailingCity.Clean
                    && _mailingPostalCode.Clean
                    && _mailingState.Clean
                    && _mailingStreetAddress.Clean
                    && _mortgageAccount.Clean
                    && _nextEscrowTotalFloodInsurance.Clean
                    && _nextEscrowTotalFloodInsuranceDueDate.Clean
                    && _nextEscrowTotalHazardInsurance.Clean
                    && _nextEscrowTotalHazardInsuranceDueDate.Clean
                    && _nextEscrowTotalMortgageInsurance.Clean
                    && _nextEscrowTotalMortgageInsuranceDueDate.Clean
                    && _nextEscrowTotalOtherTax1.Clean
                    && _nextEscrowTotalOtherTax1DueDate.Clean
                    && _nextEscrowTotalOtherTax2.Clean
                    && _nextEscrowTotalOtherTax2DueDate.Clean
                    && _nextEscrowTotalOtherTax3.Clean
                    && _nextEscrowTotalOtherTax3DueDate.Clean
                    && _nextEscrowTotalPropertyTax.Clean
                    && _nextEscrowTotalPropertyTaxDueDate.Clean
                    && _nextEscrowTotalTax.Clean
                    && _nextEscrowTotalTaxDueDate.Clean
                    && _nextEscrowTotalUsdaMonthlyPremium.Clean
                    && _nextEscrowTotalUsdaMonthlyPremiumDueDate.Clean
                    && _nextPaymentBuydownSubsidyAmount.Clean
                    && _nextPaymentEscrowAmount.Clean
                    && _nextPaymentEscrowCityPropertyTax.Clean
                    && _nextPaymentEscrowFloodInsurance.Clean
                    && _nextPaymentEscrowHazardInsurance.Clean
                    && _nextPaymentEscrowMortgageInsurance.Clean
                    && _nextPaymentEscrowOther1.Clean
                    && _nextPaymentEscrowOther2.Clean
                    && _nextPaymentEscrowOther3.Clean
                    && _nextPaymentEscrowTax.Clean
                    && _nextPaymentEscrowUSDAMonthlyPremium.Clean
                    && _nextPaymentIndexCurrentValuePercent.Clean
                    && _nextPaymentInterest.Clean
                    && _nextPaymentLateFee.Clean
                    && _nextPaymentLatePaymentDate.Clean
                    && _nextPaymentMiscFee.Clean
                    && _nextPaymentPastDueAmount.Clean
                    && _nextPaymentPaymentDueDate.Clean
                    && _nextPaymentPaymentIndexDate.Clean
                    && _nextPaymentPrincipal.Clean
                    && _nextPaymentPrincipalAndInterest.Clean
                    && _nextPaymentRequestedInterestRatePercent.Clean
                    && _nextPaymentStatementDueDate.Clean
                    && _nextPaymentTotalAmountDue.Clean
                    && _nextPaymentTotalAmountWithLateFee.Clean
                    && _nextPaymentUnpaidLateFee.Clean
                    && _numberOfDisbursement.Clean
                    && _otherTransactions.Clean
                    && _paymentDueDatePrinted.Clean
                    && _paymentReversalTransactions.Clean
                    && _paymentTransactions.Clean
                    && _printedByUserId.Clean
                    && _printedByUserName.Clean
                    && _purchasedPrincipal.Clean
                    && _scheduledPayments.Clean
                    && _schedulePaymentTransactions.Clean
                    && _servicerLoanNumber.Clean
                    && _servicingStatus.Clean
                    && _servicingTransferDate.Clean
                    && _subServicer.Clean
                    && _subServicerLoanNumber.Clean
                    && _totalAdditionalEscrow.Clean
                    && _totalAdditionalEscrowYearToDate.Clean
                    && _totalAdditionalPrincipal.Clean
                    && _totalAdditionalPrincipalYearToDate.Clean
                    && _totalAmountDisbursed.Clean
                    && _totalBuydownSubsidyAmount.Clean
                    && _totalBuydownSubsidyAmountYearToDate.Clean
                    && _totalEscrow.Clean
                    && _totalEscrowYearToDate.Clean
                    && _totalHazardInsurance.Clean
                    && _totalInterest.Clean
                    && _totalInterestYearToDate.Clean
                    && _totalLateFee.Clean
                    && _totalLateFeeYearToDate.Clean
                    && _totalMiscFee.Clean
                    && _totalMiscFeeYearToDate.Clean
                    && _totalMortgageInsurance.Clean
                    && _totalNumberOfLatePayment.Clean
                    && _totalNumberOfPayment.Clean
                    && _totalOtherTaxes.Clean
                    && _totalPAndI.Clean
                    && _totalPAndIYearToDate.Clean
                    && _totalPaymentCollected.Clean
                    && _totalPaymentCollectedYearToDate.Clean
                    && _totalPrincipal.Clean
                    && _totalPrincipalYearToDate.Clean
                    && _totalTaxes.Clean
                    && _totalUsdaMonthlyPremium.Clean
                    && _unpaidBuydownSubsidyAmount.Clean
                    && _unpaidEscrow.Clean
                    && _unpaidEscrowCityPropertyTax.Clean
                    && _unpaidEscrowFloodInsurance.Clean
                    && _unpaidEscrowHazardInsurance.Clean
                    && _unpaidEscrowMortgageInsurance.Clean
                    && _unpaidEscrowOther1.Clean
                    && _unpaidEscrowOther2.Clean
                    && _unpaidEscrowOther3.Clean
                    && _unpaidEscrowTax.Clean
                    && _unpaidEscrowUSDAMonthlyPremium.Clean
                    && _unpaidInterest.Clean
                    && _unpaidLateFee.Clean
                    && _unpaidMiscrFee.Clean
                    && _unpaidPrincipal.Clean
                    && LastScheduledPayment.Clean
                    && NextScheduledPayment.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = _borrCellPhoneNumber; v0.Clean = value; _borrCellPhoneNumber = v0;
                var v1 = _borrHomeEmail; v1.Clean = value; _borrHomeEmail = v1;
                var v2 = _borrHomePhoneNumber; v2.Clean = value; _borrHomePhoneNumber = v2;
                var v3 = _borrowerFirstName; v3.Clean = value; _borrowerFirstName = v3;
                var v4 = _borrowerLastName; v4.Clean = value; _borrowerLastName = v4;
                var v5 = _borrWorkPhoneNumber; v5.Clean = value; _borrWorkPhoneNumber = v5;
                var v6 = _calcTriggered; v6.Clean = value; _calcTriggered = v6;
                var v7 = _cityInsurance; v7.Clean = value; _cityInsurance = v7;
                var v8 = _comments; v8.Clean = value; _comments = v8;
                var v9 = _currentPrincipalBalance; v9.Clean = value; _currentPrincipalBalance = v9;
                var v10 = _escrowBalance; v10.Clean = value; _escrowBalance = v10;
                var v11 = _escrowDisbursementTransactions; v11.Clean = value; _escrowDisbursementTransactions = v11;
                var v12 = _escrowInterestTransactions; v12.Clean = value; _escrowInterestTransactions = v12;
                var v13 = _floodInsurance; v13.Clean = value; _floodInsurance = v13;
                var v14 = _id; v14.Clean = value; _id = v14;
                var v15 = _interimServicingTransactions; v15.Clean = value; _interimServicingTransactions = v15;
                var v16 = _lastPaymentAdditionalEscrow; v16.Clean = value; _lastPaymentAdditionalEscrow = v16;
                var v17 = _lastPaymentAdditionalPrincipal; v17.Clean = value; _lastPaymentAdditionalPrincipal = v17;
                var v18 = _lastPaymentBuydownSubsidyAmount; v18.Clean = value; _lastPaymentBuydownSubsidyAmount = v18;
                var v19 = _lastPaymentEscrowAmount; v19.Clean = value; _lastPaymentEscrowAmount = v19;
                var v20 = _lastPaymentEscrowCityPropertyTax; v20.Clean = value; _lastPaymentEscrowCityPropertyTax = v20;
                var v21 = _lastPaymentEscrowFloodInsurance; v21.Clean = value; _lastPaymentEscrowFloodInsurance = v21;
                var v22 = _lastPaymentEscrowHazardInsurance; v22.Clean = value; _lastPaymentEscrowHazardInsurance = v22;
                var v23 = _lastPaymentEscrowMortgageInsurance; v23.Clean = value; _lastPaymentEscrowMortgageInsurance = v23;
                var v24 = _lastPaymentEscrowOther1; v24.Clean = value; _lastPaymentEscrowOther1 = v24;
                var v25 = _lastPaymentEscrowOther2; v25.Clean = value; _lastPaymentEscrowOther2 = v25;
                var v26 = _lastPaymentEscrowOther3; v26.Clean = value; _lastPaymentEscrowOther3 = v26;
                var v27 = _lastPaymentEscrowTax; v27.Clean = value; _lastPaymentEscrowTax = v27;
                var v28 = _lastPaymentEscrowUSDAMonthlyPremium; v28.Clean = value; _lastPaymentEscrowUSDAMonthlyPremium = v28;
                var v29 = _lastPaymentGuid; v29.Clean = value; _lastPaymentGuid = v29;
                var v30 = _lastPaymentInterest; v30.Clean = value; _lastPaymentInterest = v30;
                var v31 = _lastPaymentLateFee; v31.Clean = value; _lastPaymentLateFee = v31;
                var v32 = _lastPaymentMiscFee; v32.Clean = value; _lastPaymentMiscFee = v32;
                var v33 = _lastPaymentNumber; v33.Clean = value; _lastPaymentNumber = v33;
                var v34 = _lastPaymentPrincipal; v34.Clean = value; _lastPaymentPrincipal = v34;
                var v35 = _lastPaymentPrincipalAndInterest; v35.Clean = value; _lastPaymentPrincipalAndInterest = v35;
                var v36 = _lastPaymentReceivedDate; v36.Clean = value; _lastPaymentReceivedDate = v36;
                var v37 = _lastPaymentStatementDate; v37.Clean = value; _lastPaymentStatementDate = v37;
                var v38 = _lastPaymentTotalAmountReceived; v38.Clean = value; _lastPaymentTotalAmountReceived = v38;
                var v39 = _lastStatementPrintedDate; v39.Clean = value; _lastStatementPrintedDate = v39;
                var v40 = _loanSnapshotXml; v40.Clean = value; _loanSnapshotXml = v40;
                var v41 = _mailingCity; v41.Clean = value; _mailingCity = v41;
                var v42 = _mailingPostalCode; v42.Clean = value; _mailingPostalCode = v42;
                var v43 = _mailingState; v43.Clean = value; _mailingState = v43;
                var v44 = _mailingStreetAddress; v44.Clean = value; _mailingStreetAddress = v44;
                var v45 = _mortgageAccount; v45.Clean = value; _mortgageAccount = v45;
                var v46 = _nextEscrowTotalFloodInsurance; v46.Clean = value; _nextEscrowTotalFloodInsurance = v46;
                var v47 = _nextEscrowTotalFloodInsuranceDueDate; v47.Clean = value; _nextEscrowTotalFloodInsuranceDueDate = v47;
                var v48 = _nextEscrowTotalHazardInsurance; v48.Clean = value; _nextEscrowTotalHazardInsurance = v48;
                var v49 = _nextEscrowTotalHazardInsuranceDueDate; v49.Clean = value; _nextEscrowTotalHazardInsuranceDueDate = v49;
                var v50 = _nextEscrowTotalMortgageInsurance; v50.Clean = value; _nextEscrowTotalMortgageInsurance = v50;
                var v51 = _nextEscrowTotalMortgageInsuranceDueDate; v51.Clean = value; _nextEscrowTotalMortgageInsuranceDueDate = v51;
                var v52 = _nextEscrowTotalOtherTax1; v52.Clean = value; _nextEscrowTotalOtherTax1 = v52;
                var v53 = _nextEscrowTotalOtherTax1DueDate; v53.Clean = value; _nextEscrowTotalOtherTax1DueDate = v53;
                var v54 = _nextEscrowTotalOtherTax2; v54.Clean = value; _nextEscrowTotalOtherTax2 = v54;
                var v55 = _nextEscrowTotalOtherTax2DueDate; v55.Clean = value; _nextEscrowTotalOtherTax2DueDate = v55;
                var v56 = _nextEscrowTotalOtherTax3; v56.Clean = value; _nextEscrowTotalOtherTax3 = v56;
                var v57 = _nextEscrowTotalOtherTax3DueDate; v57.Clean = value; _nextEscrowTotalOtherTax3DueDate = v57;
                var v58 = _nextEscrowTotalPropertyTax; v58.Clean = value; _nextEscrowTotalPropertyTax = v58;
                var v59 = _nextEscrowTotalPropertyTaxDueDate; v59.Clean = value; _nextEscrowTotalPropertyTaxDueDate = v59;
                var v60 = _nextEscrowTotalTax; v60.Clean = value; _nextEscrowTotalTax = v60;
                var v61 = _nextEscrowTotalTaxDueDate; v61.Clean = value; _nextEscrowTotalTaxDueDate = v61;
                var v62 = _nextEscrowTotalUsdaMonthlyPremium; v62.Clean = value; _nextEscrowTotalUsdaMonthlyPremium = v62;
                var v63 = _nextEscrowTotalUsdaMonthlyPremiumDueDate; v63.Clean = value; _nextEscrowTotalUsdaMonthlyPremiumDueDate = v63;
                var v64 = _nextPaymentBuydownSubsidyAmount; v64.Clean = value; _nextPaymentBuydownSubsidyAmount = v64;
                var v65 = _nextPaymentEscrowAmount; v65.Clean = value; _nextPaymentEscrowAmount = v65;
                var v66 = _nextPaymentEscrowCityPropertyTax; v66.Clean = value; _nextPaymentEscrowCityPropertyTax = v66;
                var v67 = _nextPaymentEscrowFloodInsurance; v67.Clean = value; _nextPaymentEscrowFloodInsurance = v67;
                var v68 = _nextPaymentEscrowHazardInsurance; v68.Clean = value; _nextPaymentEscrowHazardInsurance = v68;
                var v69 = _nextPaymentEscrowMortgageInsurance; v69.Clean = value; _nextPaymentEscrowMortgageInsurance = v69;
                var v70 = _nextPaymentEscrowOther1; v70.Clean = value; _nextPaymentEscrowOther1 = v70;
                var v71 = _nextPaymentEscrowOther2; v71.Clean = value; _nextPaymentEscrowOther2 = v71;
                var v72 = _nextPaymentEscrowOther3; v72.Clean = value; _nextPaymentEscrowOther3 = v72;
                var v73 = _nextPaymentEscrowTax; v73.Clean = value; _nextPaymentEscrowTax = v73;
                var v74 = _nextPaymentEscrowUSDAMonthlyPremium; v74.Clean = value; _nextPaymentEscrowUSDAMonthlyPremium = v74;
                var v75 = _nextPaymentIndexCurrentValuePercent; v75.Clean = value; _nextPaymentIndexCurrentValuePercent = v75;
                var v76 = _nextPaymentInterest; v76.Clean = value; _nextPaymentInterest = v76;
                var v77 = _nextPaymentLateFee; v77.Clean = value; _nextPaymentLateFee = v77;
                var v78 = _nextPaymentLatePaymentDate; v78.Clean = value; _nextPaymentLatePaymentDate = v78;
                var v79 = _nextPaymentMiscFee; v79.Clean = value; _nextPaymentMiscFee = v79;
                var v80 = _nextPaymentPastDueAmount; v80.Clean = value; _nextPaymentPastDueAmount = v80;
                var v81 = _nextPaymentPaymentDueDate; v81.Clean = value; _nextPaymentPaymentDueDate = v81;
                var v82 = _nextPaymentPaymentIndexDate; v82.Clean = value; _nextPaymentPaymentIndexDate = v82;
                var v83 = _nextPaymentPrincipal; v83.Clean = value; _nextPaymentPrincipal = v83;
                var v84 = _nextPaymentPrincipalAndInterest; v84.Clean = value; _nextPaymentPrincipalAndInterest = v84;
                var v85 = _nextPaymentRequestedInterestRatePercent; v85.Clean = value; _nextPaymentRequestedInterestRatePercent = v85;
                var v86 = _nextPaymentStatementDueDate; v86.Clean = value; _nextPaymentStatementDueDate = v86;
                var v87 = _nextPaymentTotalAmountDue; v87.Clean = value; _nextPaymentTotalAmountDue = v87;
                var v88 = _nextPaymentTotalAmountWithLateFee; v88.Clean = value; _nextPaymentTotalAmountWithLateFee = v88;
                var v89 = _nextPaymentUnpaidLateFee; v89.Clean = value; _nextPaymentUnpaidLateFee = v89;
                var v90 = _numberOfDisbursement; v90.Clean = value; _numberOfDisbursement = v90;
                var v91 = _otherTransactions; v91.Clean = value; _otherTransactions = v91;
                var v92 = _paymentDueDatePrinted; v92.Clean = value; _paymentDueDatePrinted = v92;
                var v93 = _paymentReversalTransactions; v93.Clean = value; _paymentReversalTransactions = v93;
                var v94 = _paymentTransactions; v94.Clean = value; _paymentTransactions = v94;
                var v95 = _printedByUserId; v95.Clean = value; _printedByUserId = v95;
                var v96 = _printedByUserName; v96.Clean = value; _printedByUserName = v96;
                var v97 = _purchasedPrincipal; v97.Clean = value; _purchasedPrincipal = v97;
                var v98 = _scheduledPayments; v98.Clean = value; _scheduledPayments = v98;
                var v99 = _schedulePaymentTransactions; v99.Clean = value; _schedulePaymentTransactions = v99;
                var v100 = _servicerLoanNumber; v100.Clean = value; _servicerLoanNumber = v100;
                var v101 = _servicingStatus; v101.Clean = value; _servicingStatus = v101;
                var v102 = _servicingTransferDate; v102.Clean = value; _servicingTransferDate = v102;
                var v103 = _subServicer; v103.Clean = value; _subServicer = v103;
                var v104 = _subServicerLoanNumber; v104.Clean = value; _subServicerLoanNumber = v104;
                var v105 = _totalAdditionalEscrow; v105.Clean = value; _totalAdditionalEscrow = v105;
                var v106 = _totalAdditionalEscrowYearToDate; v106.Clean = value; _totalAdditionalEscrowYearToDate = v106;
                var v107 = _totalAdditionalPrincipal; v107.Clean = value; _totalAdditionalPrincipal = v107;
                var v108 = _totalAdditionalPrincipalYearToDate; v108.Clean = value; _totalAdditionalPrincipalYearToDate = v108;
                var v109 = _totalAmountDisbursed; v109.Clean = value; _totalAmountDisbursed = v109;
                var v110 = _totalBuydownSubsidyAmount; v110.Clean = value; _totalBuydownSubsidyAmount = v110;
                var v111 = _totalBuydownSubsidyAmountYearToDate; v111.Clean = value; _totalBuydownSubsidyAmountYearToDate = v111;
                var v112 = _totalEscrow; v112.Clean = value; _totalEscrow = v112;
                var v113 = _totalEscrowYearToDate; v113.Clean = value; _totalEscrowYearToDate = v113;
                var v114 = _totalHazardInsurance; v114.Clean = value; _totalHazardInsurance = v114;
                var v115 = _totalInterest; v115.Clean = value; _totalInterest = v115;
                var v116 = _totalInterestYearToDate; v116.Clean = value; _totalInterestYearToDate = v116;
                var v117 = _totalLateFee; v117.Clean = value; _totalLateFee = v117;
                var v118 = _totalLateFeeYearToDate; v118.Clean = value; _totalLateFeeYearToDate = v118;
                var v119 = _totalMiscFee; v119.Clean = value; _totalMiscFee = v119;
                var v120 = _totalMiscFeeYearToDate; v120.Clean = value; _totalMiscFeeYearToDate = v120;
                var v121 = _totalMortgageInsurance; v121.Clean = value; _totalMortgageInsurance = v121;
                var v122 = _totalNumberOfLatePayment; v122.Clean = value; _totalNumberOfLatePayment = v122;
                var v123 = _totalNumberOfPayment; v123.Clean = value; _totalNumberOfPayment = v123;
                var v124 = _totalOtherTaxes; v124.Clean = value; _totalOtherTaxes = v124;
                var v125 = _totalPAndI; v125.Clean = value; _totalPAndI = v125;
                var v126 = _totalPAndIYearToDate; v126.Clean = value; _totalPAndIYearToDate = v126;
                var v127 = _totalPaymentCollected; v127.Clean = value; _totalPaymentCollected = v127;
                var v128 = _totalPaymentCollectedYearToDate; v128.Clean = value; _totalPaymentCollectedYearToDate = v128;
                var v129 = _totalPrincipal; v129.Clean = value; _totalPrincipal = v129;
                var v130 = _totalPrincipalYearToDate; v130.Clean = value; _totalPrincipalYearToDate = v130;
                var v131 = _totalTaxes; v131.Clean = value; _totalTaxes = v131;
                var v132 = _totalUsdaMonthlyPremium; v132.Clean = value; _totalUsdaMonthlyPremium = v132;
                var v133 = _unpaidBuydownSubsidyAmount; v133.Clean = value; _unpaidBuydownSubsidyAmount = v133;
                var v134 = _unpaidEscrow; v134.Clean = value; _unpaidEscrow = v134;
                var v135 = _unpaidEscrowCityPropertyTax; v135.Clean = value; _unpaidEscrowCityPropertyTax = v135;
                var v136 = _unpaidEscrowFloodInsurance; v136.Clean = value; _unpaidEscrowFloodInsurance = v136;
                var v137 = _unpaidEscrowHazardInsurance; v137.Clean = value; _unpaidEscrowHazardInsurance = v137;
                var v138 = _unpaidEscrowMortgageInsurance; v138.Clean = value; _unpaidEscrowMortgageInsurance = v138;
                var v139 = _unpaidEscrowOther1; v139.Clean = value; _unpaidEscrowOther1 = v139;
                var v140 = _unpaidEscrowOther2; v140.Clean = value; _unpaidEscrowOther2 = v140;
                var v141 = _unpaidEscrowOther3; v141.Clean = value; _unpaidEscrowOther3 = v141;
                var v142 = _unpaidEscrowTax; v142.Clean = value; _unpaidEscrowTax = v142;
                var v143 = _unpaidEscrowUSDAMonthlyPremium; v143.Clean = value; _unpaidEscrowUSDAMonthlyPremium = v143;
                var v144 = _unpaidInterest; v144.Clean = value; _unpaidInterest = v144;
                var v145 = _unpaidLateFee; v145.Clean = value; _unpaidLateFee = v145;
                var v146 = _unpaidMiscrFee; v146.Clean = value; _unpaidMiscrFee = v146;
                var v147 = _unpaidPrincipal; v147.Clean = value; _unpaidPrincipal = v147;
                if (LastScheduledPayment != null) LastScheduledPayment.Clean = value;
                if (NextScheduledPayment != null) NextScheduledPayment.Clean = value;
                _settingClean = 0;
            }
        }
    }
}