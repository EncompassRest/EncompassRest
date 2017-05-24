using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class LoanEstimate3
    {
        public Value<string> Appraisal { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAppraisal() => !Appraisal.Clean;
        public Value<string> Assumption { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAssumption() => !Assumption.Clean;
        public Value<bool?> ConstructionLoan { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeConstructionLoan() => !ConstructionLoan.Clean;
        public Value<bool?> HomeownerInsurance { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHomeownerInsurance() => !HomeownerInsurance.Clean;
        public Value<string> Id { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !Id.Clean;
        public Value<int?> In5YearsPrincipalYouWillHavePaidOff { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIn5YearsPrincipalYouWillHavePaidOff() => !In5YearsPrincipalYouWillHavePaidOff.Clean;
        public Value<int?> In5YearsTotalYouWillHavePaid { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIn5YearsTotalYouWillHavePaid() => !In5YearsTotalYouWillHavePaid.Clean;
        public Value<string> LenderEmail { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLenderEmail() => !LenderEmail.Clean;
        public Value<string> LenderLicenseID { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLenderLicenseID() => !LenderLicenseID.Clean;
        public Value<string> LenderLicenseState { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLenderLicenseState() => !LenderLicenseState.Clean;
        public Value<string> LenderLoanOfficer { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLenderLoanOfficer() => !LenderLoanOfficer.Clean;
        public Value<string> LenderLoanOfficerLicenseState { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLenderLoanOfficerLicenseState() => !LenderLoanOfficerLicenseState.Clean;
        public Value<string> LenderLoanOfficerNMLSId { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLenderLoanOfficerNMLSId() => !LenderLoanOfficerNMLSId.Clean;
        public Value<string> LenderPhone { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLenderPhone() => !LenderPhone.Clean;
        public Value<string> MortgageBrokerEmail { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMortgageBrokerEmail() => !MortgageBrokerEmail.Clean;
        public Value<string> MortgageBrokerLicenseID { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMortgageBrokerLicenseID() => !MortgageBrokerLicenseID.Clean;
        public Value<string> MortgageBrokerLicenseState { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMortgageBrokerLicenseState() => !MortgageBrokerLicenseState.Clean;
        public Value<string> MortgageBrokerLoanOfficer { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMortgageBrokerLoanOfficer() => !MortgageBrokerLoanOfficer.Clean;
        public Value<string> MortgageBrokerLoanOfficerLicenseID { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMortgageBrokerLoanOfficerLicenseID() => !MortgageBrokerLoanOfficerLicenseID.Clean;
        public Value<string> MortgageBrokerLoanOfficerLicenseState { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMortgageBrokerLoanOfficerLicenseState() => !MortgageBrokerLoanOfficerLicenseState.Clean;
        public Value<string> MortgageBrokerLoanOfficerNMLSId { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMortgageBrokerLoanOfficerNMLSId() => !MortgageBrokerLoanOfficerNMLSId.Clean;
        public Value<string> MortgageBrokerPhone { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMortgageBrokerPhone() => !MortgageBrokerPhone.Clean;
        public Value<string> MortgageLenderLoanOfficerLicenseID { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMortgageLenderLoanOfficerLicenseID() => !MortgageLenderLoanOfficerLicenseID.Clean;
        public Value<string> Servicing { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeServicing() => !Servicing.Clean;
        public Value<string> SignatureType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSignatureType() => !SignatureType.Clean;
        public Value<decimal?> TotalInterestPercentage { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalInterestPercentage() => !TotalInterestPercentage.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = Appraisal.Clean
                    && Assumption.Clean
                    && ConstructionLoan.Clean
                    && HomeownerInsurance.Clean
                    && Id.Clean
                    && In5YearsPrincipalYouWillHavePaidOff.Clean
                    && In5YearsTotalYouWillHavePaid.Clean
                    && LenderEmail.Clean
                    && LenderLicenseID.Clean
                    && LenderLicenseState.Clean
                    && LenderLoanOfficer.Clean
                    && LenderLoanOfficerLicenseState.Clean
                    && LenderLoanOfficerNMLSId.Clean
                    && LenderPhone.Clean
                    && MortgageBrokerEmail.Clean
                    && MortgageBrokerLicenseID.Clean
                    && MortgageBrokerLicenseState.Clean
                    && MortgageBrokerLoanOfficer.Clean
                    && MortgageBrokerLoanOfficerLicenseID.Clean
                    && MortgageBrokerLoanOfficerLicenseState.Clean
                    && MortgageBrokerLoanOfficerNMLSId.Clean
                    && MortgageBrokerPhone.Clean
                    && MortgageLenderLoanOfficerLicenseID.Clean
                    && Servicing.Clean
                    && SignatureType.Clean
                    && TotalInterestPercentage.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = Appraisal; v0.Clean = value; Appraisal = v0;
                var v1 = Assumption; v1.Clean = value; Assumption = v1;
                var v2 = ConstructionLoan; v2.Clean = value; ConstructionLoan = v2;
                var v3 = HomeownerInsurance; v3.Clean = value; HomeownerInsurance = v3;
                var v4 = Id; v4.Clean = value; Id = v4;
                var v5 = In5YearsPrincipalYouWillHavePaidOff; v5.Clean = value; In5YearsPrincipalYouWillHavePaidOff = v5;
                var v6 = In5YearsTotalYouWillHavePaid; v6.Clean = value; In5YearsTotalYouWillHavePaid = v6;
                var v7 = LenderEmail; v7.Clean = value; LenderEmail = v7;
                var v8 = LenderLicenseID; v8.Clean = value; LenderLicenseID = v8;
                var v9 = LenderLicenseState; v9.Clean = value; LenderLicenseState = v9;
                var v10 = LenderLoanOfficer; v10.Clean = value; LenderLoanOfficer = v10;
                var v11 = LenderLoanOfficerLicenseState; v11.Clean = value; LenderLoanOfficerLicenseState = v11;
                var v12 = LenderLoanOfficerNMLSId; v12.Clean = value; LenderLoanOfficerNMLSId = v12;
                var v13 = LenderPhone; v13.Clean = value; LenderPhone = v13;
                var v14 = MortgageBrokerEmail; v14.Clean = value; MortgageBrokerEmail = v14;
                var v15 = MortgageBrokerLicenseID; v15.Clean = value; MortgageBrokerLicenseID = v15;
                var v16 = MortgageBrokerLicenseState; v16.Clean = value; MortgageBrokerLicenseState = v16;
                var v17 = MortgageBrokerLoanOfficer; v17.Clean = value; MortgageBrokerLoanOfficer = v17;
                var v18 = MortgageBrokerLoanOfficerLicenseID; v18.Clean = value; MortgageBrokerLoanOfficerLicenseID = v18;
                var v19 = MortgageBrokerLoanOfficerLicenseState; v19.Clean = value; MortgageBrokerLoanOfficerLicenseState = v19;
                var v20 = MortgageBrokerLoanOfficerNMLSId; v20.Clean = value; MortgageBrokerLoanOfficerNMLSId = v20;
                var v21 = MortgageBrokerPhone; v21.Clean = value; MortgageBrokerPhone = v21;
                var v22 = MortgageLenderLoanOfficerLicenseID; v22.Clean = value; MortgageLenderLoanOfficerLicenseID = v22;
                var v23 = Servicing; v23.Clean = value; Servicing = v23;
                var v24 = SignatureType; v24.Clean = value; SignatureType = v24;
                var v25 = TotalInterestPercentage; v25.Clean = value; TotalInterestPercentage = v25;
                _settingClean = 0;
            }
        }
    }
}