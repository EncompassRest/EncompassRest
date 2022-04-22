using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using EncompassRest.Utilities;
using EnumsNET;
using Newtonsoft.Json;

namespace EncompassRest.Contacts.v1
{
    /// <summary>
    /// BusinessContact
    /// </summary>
    public sealed class BusinessContact : Contact
    {
        /// <summary>
        /// The business category ID for the business contact.
        /// </summary>
        [EnumFormat(EnumFormat.DecimalValue)]
        public BusinessContactCategory? CategoryId { get => GetValue<BusinessContactCategory?>(); set => SetValue(value); }

        /// <summary>
        /// BusinessContact CategoryFields
        /// </summary>
        [AllowNull]
        public IList<BusinessCategoryField> CategoryFields { get => GetList<BusinessCategoryField>(); set => SetList(value); }

        /// <summary>
        /// The contact's company name.
        /// </summary>
        public string? CompanyName { get => GetValue<string?>(); set => SetValue(value); }

        /// <summary>
        /// Rate or fee charged by the contact’s services.
        /// </summary>
        public int? Fees { get => GetValue<int?>(); set => SetValue(value); }

        /// <summary>
        /// Licensing information.
        /// </summary>
        [AllowNull]
        public BusinessContactLicense PersonalContactLicense { get => GetEntity<BusinessContactLicense>(); set => SetEntity(value); }

        /// <summary>
        /// Business licensing information.
        /// </summary>
        [AllowNull]
        public BusinessContactLicense BusinessContactLicense { get => GetEntity<BusinessContactLicense>(); set => SetEntity(value); }

        /// <summary>
        /// BusinessContact NoSpam
        /// </summary>
        public bool? NoSpam { get => GetValue<bool?>(); set => SetValue(value); }

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
        public BusinessContact(IEncompassRestClient client, string contactId, string firstName, string personalEmail)
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