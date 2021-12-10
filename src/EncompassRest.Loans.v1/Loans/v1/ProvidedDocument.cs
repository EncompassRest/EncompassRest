using System;
using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans.v1
{
    /// <summary>
    /// ProvidedDocument
    /// </summary>
    [Entity(SerializeWholeListWhenDirty = true)]
    public sealed partial class ProvidedDocument : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<string?>? _altId;
        private DirtyValue<StringEnumValue<Owner>>? _borrowerType;
        private DirtyValue<DateTime?>? _dateProvided;
        private DirtyValue<string?>? _documentName;
        private DirtyValue<bool?>? _entityDeleted;
        private DirtyValue<string?>? _id;
        private DirtyValue<bool?>? _requiredIndicator;

        /// <summary>
        /// Documents Provided - ID [DOCPROVNN99]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string? AltId { get => _altId; set => SetField(ref _altId, value); }

        /// <summary>
        /// Documents Provided - Borrower Type [DOCPROVNN01]
        /// </summary>
        public StringEnumValue<Owner> BorrowerType { get => _borrowerType; set => SetField(ref _borrowerType, value); }

        /// <summary>
        /// Documents Provided - Date Provided [DOCPROVNN04]
        /// </summary>
        public DateTime? DateProvided { get => _dateProvided; set => SetField(ref _dateProvided, value); }

        /// <summary>
        /// Documents Provided - Document Name [DOCPROVNN02]
        /// </summary>
        public string? DocumentName { get => _documentName; set => SetField(ref _documentName, value); }

        /// <summary>
        /// ProvidedDocument EntityDeleted
        /// </summary>
        public bool? EntityDeleted { get => _entityDeleted; set => SetField(ref _entityDeleted, value); }

        /// <summary>
        /// ProvidedDocument Id
        /// </summary>
        public string? Id { get => _id; set => SetField(ref _id, value); }

        /// <summary>
        /// Documents Provided - Required Indicator [DOCPROVNN03]
        /// </summary>
        public bool? RequiredIndicator { get => _requiredIndicator; set => SetField(ref _requiredIndicator, value); }
    }
}