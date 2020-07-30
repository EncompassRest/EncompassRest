using System;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// CreditReport
    /// </summary>
    [Entity(SerializeWholeListWhenDirty = true)]
    public sealed partial class CreditReport : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<EntityReference>? _contact;
        private DirtyValue<string?>? _creditReportCompany;
        private DirtyValue<DateTime?>? _creditReportDate;
        private DirtyValue<string?>? _creditReportId;
        private DirtyValue<DateTime?>? _dateOfBirth;
        private DirtyValue<bool?>? _entityDeleted;
        private DirtyValue<string?>? _id;
        private DirtyValue<bool?>? _nonTraditionalCredit;
        private DirtyValue<string?>? _verifySsn;

        /// <summary>
        /// CreditReport Contact (Nullable)
        /// </summary>
        public EntityReference Contact { get => _contact; set => SetField(ref _contact, value); }

        /// <summary>
        /// CreditReport CreditReportCompany
        /// </summary>
        public string? CreditReportCompany { get => _creditReportCompany; set => SetField(ref _creditReportCompany, value); }

        /// <summary>
        /// CreditReport CreditReportDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? CreditReportDate { get => _creditReportDate; set => SetField(ref _creditReportDate, value); }

        /// <summary>
        /// CreditReport CreditReportId
        /// </summary>
        public string? CreditReportId { get => _creditReportId; set => SetField(ref _creditReportId, value); }

        /// <summary>
        /// CreditReport DateOfBirth
        /// </summary>
        public DateTime? DateOfBirth { get => _dateOfBirth; set => SetField(ref _dateOfBirth, value); }

        /// <summary>
        /// CreditReport EntityDeleted
        /// </summary>
        public bool? EntityDeleted { get => _entityDeleted; set => SetField(ref _entityDeleted, value); }

        /// <summary>
        /// CreditReport Id
        /// </summary>
        public string? Id { get => _id; set => SetField(ref _id, value); }

        /// <summary>
        /// CreditReport NonTraditionalCredit
        /// </summary>
        public bool? NonTraditionalCredit { get => _nonTraditionalCredit; set => SetField(ref _nonTraditionalCredit, value); }

        /// <summary>
        /// CreditReport VerifySsn
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.SSN)]
        public string? VerifySsn { get => _verifySsn; set => SetField(ref _verifySsn, value); }
    }
}