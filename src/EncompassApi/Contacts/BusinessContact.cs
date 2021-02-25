using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using EncompassApi.Utilities;
using EnumsNET;
using Newtonsoft.Json;

namespace EncompassApi.Contacts
{
    /// <summary>
    /// BusinessContact
    /// </summary>
    public sealed class BusinessContact : Contact
    {
        private DirtyValue<BusinessContactCategory?>? _categoryId;
        private DirtyList<BusinessCategoryField>? _categoryFields;
        private DirtyValue<string?>? _companyName;
        private DirtyValue<int?>? _fees;
        private BusinessContactLicense? _personalContactLicense;
        private BusinessContactLicense? _businessContactLicense;
        private DirtyValue<bool?>? _noSpam;

        /// <summary>
        /// The business category ID for the business contact.
        /// </summary>
        [EnumFormat(EnumFormat.DecimalValue)]
        public BusinessContactCategory? CategoryId { get => _categoryId; set => SetField(ref _categoryId, value); }

        /// <summary>
        /// BusinessContact CategoryFields
        /// </summary>
        [AllowNull]
        public IList<BusinessCategoryField> CategoryFields { get => GetField(ref _categoryFields); set => SetField(ref _categoryFields, value); }

        /// <summary>
        /// The contact's company name.
        /// </summary>
        public string? CompanyName { get => _companyName; set => SetField(ref _companyName, value); }

        /// <summary>
        /// Rate or fee charged by the contact’s services.
        /// </summary>
        public int? Fees { get => _fees; set => SetField(ref _fees, value); }

        /// <summary>
        /// Licensing information.
        /// </summary>
        [AllowNull]
        public BusinessContactLicense PersonalContactLicense { get => GetField(ref _personalContactLicense); set => SetField(ref _personalContactLicense, value); }

        /// <summary>
        /// Business licensing information.
        /// </summary>
        [AllowNull]
        public BusinessContactLicense BusinessContactLicense { get => GetField(ref _businessContactLicense); set => SetField(ref _businessContactLicense, value); }

        /// <summary>
        /// BusinessContact NoSpam
        /// </summary>
        public bool? NoSpam { get => _noSpam; set => SetField(ref _noSpam, value); }

        /// <summary>
        /// The contact type.
        /// </summary>
        [JsonIgnore]
        public override ContactType Type => ContactType.Business;

        /// <summary>
        /// Business contact creation constructor
        /// </summary>
        /// <param name="firstName">The contact's first name.</param>
        /// <param name="personalEmail">The contact's personal email address.</param>
        public BusinessContact(string firstName, string personalEmail)
            : base(firstName, personalEmail)
        {
        }

        /// <summary>
        /// Business contact update constructor
        /// </summary>
        /// <param name="client">The client to initialize the contact object with.</param>
        /// <param name="contactId">The contactId (or id) is the unique identifier of the contact.</param>
        /// <param name="firstName">The contact's first name.</param>
        /// <param name="personalEmail">The contact's personal email address.</param>
        public BusinessContact(EncompassApiClient client, string contactId, string firstName, string personalEmail)
            : this((IEncompassApiClient)client, contactId, firstName, personalEmail)
        {
        }

        /// <summary>
        /// Business contact update constructor
        /// </summary>
        /// <param name="client">The client to initialize the contact object with.</param>
        /// <param name="contactId">The contactId (or id) is the unique identifier of the contact.</param>
        /// <param name="firstName">The contact's first name.</param>
        /// <param name="personalEmail">The contact's personal email address.</param>
        public BusinessContact(IEncompassApiClient client, string contactId, string firstName, string personalEmail)
            : base(client, contactId, firstName, personalEmail)
        {
        }

        /// <summary>
        /// Business contact deserialization constructor
        /// </summary>
        [Obsolete("Use another constructor instead.")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [JsonConstructor]
        public BusinessContact()
        {
        }
    }
}