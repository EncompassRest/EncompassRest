using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// ServiceProviderContact
    /// </summary>
    public sealed partial class ServiceProviderContact : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<string> _address;
        /// <summary>
        /// Settlement Service Provider Address [SPNN03]
        /// </summary>
        [LoanFieldProperty(Description = "Settlement Service Provider Address")]
        public string Address { get => _address; set => _address = value; }
        private DirtyValue<string> _city;
        /// <summary>
        /// Settlement Service Provider City [SPNN04]
        /// </summary>
        [LoanFieldProperty(Description = "Settlement Service Provider City")]
        public string City { get => _city; set => _city = value; }
        private DirtyValue<string> _contactName;
        /// <summary>
        /// Settlement Service Provider ContactName [SPNN14]
        /// </summary>
        [LoanFieldProperty(Description = "Settlement Service Provider ContactName")]
        public string ContactName { get => _contactName; set => _contactName = value; }
        private DirtyValue<decimal?> _cost;
        /// <summary>
        /// Settlement Service Provider Cost [SPNN11]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Settlement Service Provider Cost")]
        public decimal? Cost { get => _cost; set => _cost = value; }
        private DirtyValue<string> _email;
        /// <summary>
        /// Settlement Service Provider Email [SPNN15]
        /// </summary>
        [LoanFieldProperty(Description = "Settlement Service Provider Email")]
        public string Email { get => _email; set => _email = value; }
        private DirtyValue<string> _fax;
        /// <summary>
        /// Settlement Service Provider Fax [SPNN16]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE, Description = "Settlement Service Provider Fax")]
        public string Fax { get => _fax; set => _fax = value; }
        private DirtyValue<decimal?> _feeAmt1;
        /// <summary>
        /// Settlement Service Provider Fee Amount 1 [SPNN18]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Settlement Service Provider Fee Amount 1")]
        public decimal? FeeAmt1 { get => _feeAmt1; set => _feeAmt1 = value; }
        private DirtyValue<decimal?> _feeAmt10;
        /// <summary>
        /// Settlement Service Provider Fee Amount 10 [SPNN36]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Settlement Service Provider Fee Amount 10")]
        public decimal? FeeAmt10 { get => _feeAmt10; set => _feeAmt10 = value; }
        private DirtyValue<decimal?> _feeAmt2;
        /// <summary>
        /// Settlement Service Provider Fee Amount 2 [SPNN20]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Settlement Service Provider Fee Amount 2")]
        public decimal? FeeAmt2 { get => _feeAmt2; set => _feeAmt2 = value; }
        private DirtyValue<decimal?> _feeAmt3;
        /// <summary>
        /// Settlement Service Provider Fee Amount 3 [SPNN22]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Settlement Service Provider Fee Amount 3")]
        public decimal? FeeAmt3 { get => _feeAmt3; set => _feeAmt3 = value; }
        private DirtyValue<decimal?> _feeAmt4;
        /// <summary>
        /// Settlement Service Provider Fee Amount 4 [SPNN24]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Settlement Service Provider Fee Amount 4")]
        public decimal? FeeAmt4 { get => _feeAmt4; set => _feeAmt4 = value; }
        private DirtyValue<decimal?> _feeAmt5;
        /// <summary>
        /// Settlement Service Provider Fee Amount 5 [SPNN26]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Settlement Service Provider Fee Amount 5")]
        public decimal? FeeAmt5 { get => _feeAmt5; set => _feeAmt5 = value; }
        private DirtyValue<decimal?> _feeAmt6;
        /// <summary>
        /// Settlement Service Provider Fee Amount 6 [SPNN28]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Settlement Service Provider Fee Amount 6")]
        public decimal? FeeAmt6 { get => _feeAmt6; set => _feeAmt6 = value; }
        private DirtyValue<decimal?> _feeAmt7;
        /// <summary>
        /// Settlement Service Provider Fee Amount 7 [SPNN30]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Settlement Service Provider Fee Amount 7")]
        public decimal? FeeAmt7 { get => _feeAmt7; set => _feeAmt7 = value; }
        private DirtyValue<decimal?> _feeAmt8;
        /// <summary>
        /// Settlement Service Provider Fee Amount 8 [SPNN32]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Settlement Service Provider Fee Amount 8")]
        public decimal? FeeAmt8 { get => _feeAmt8; set => _feeAmt8 = value; }
        private DirtyValue<decimal?> _feeAmt9;
        /// <summary>
        /// Settlement Service Provider Fee Amount 9 [SPNN34]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Settlement Service Provider Fee Amount 9")]
        public decimal? FeeAmt9 { get => _feeAmt9; set => _feeAmt9 = value; }
        private DirtyValue<string> _feeDesc1;
        /// <summary>
        /// Settlement Service Provider Fee Description 1 [SPNN17]
        /// </summary>
        [LoanFieldProperty(Description = "Settlement Service Provider Fee Description 1")]
        public string FeeDesc1 { get => _feeDesc1; set => _feeDesc1 = value; }
        private DirtyValue<string> _feeDesc10;
        /// <summary>
        /// Settlement Service Provider Fee Description 10 [SPNN35]
        /// </summary>
        [LoanFieldProperty(Description = "Settlement Service Provider Fee Description 10")]
        public string FeeDesc10 { get => _feeDesc10; set => _feeDesc10 = value; }
        private DirtyValue<string> _feeDesc2;
        /// <summary>
        /// Settlement Service Provider Fee Description 2 [SPNN19]
        /// </summary>
        [LoanFieldProperty(Description = "Settlement Service Provider Fee Description 2")]
        public string FeeDesc2 { get => _feeDesc2; set => _feeDesc2 = value; }
        private DirtyValue<string> _feeDesc3;
        /// <summary>
        /// Settlement Service Provider Fee Description 3 [SPNN21]
        /// </summary>
        [LoanFieldProperty(Description = "Settlement Service Provider Fee Description 3")]
        public string FeeDesc3 { get => _feeDesc3; set => _feeDesc3 = value; }
        private DirtyValue<string> _feeDesc4;
        /// <summary>
        /// Settlement Service Provider Fee Description 4 [SPNN23]
        /// </summary>
        [LoanFieldProperty(Description = "Settlement Service Provider Fee Description 4")]
        public string FeeDesc4 { get => _feeDesc4; set => _feeDesc4 = value; }
        private DirtyValue<string> _feeDesc5;
        /// <summary>
        /// Settlement Service Provider Fee Description 5 [SPNN25]
        /// </summary>
        [LoanFieldProperty(Description = "Settlement Service Provider Fee Description 5")]
        public string FeeDesc5 { get => _feeDesc5; set => _feeDesc5 = value; }
        private DirtyValue<string> _feeDesc6;
        /// <summary>
        /// Settlement Service Provider Fee Description 6 [SPNN27]
        /// </summary>
        [LoanFieldProperty(Description = "Settlement Service Provider Fee Description 6")]
        public string FeeDesc6 { get => _feeDesc6; set => _feeDesc6 = value; }
        private DirtyValue<string> _feeDesc7;
        /// <summary>
        /// Settlement Service Provider Fee Description 7 [SPNN29]
        /// </summary>
        [LoanFieldProperty(Description = "Settlement Service Provider Fee Description 7")]
        public string FeeDesc7 { get => _feeDesc7; set => _feeDesc7 = value; }
        private DirtyValue<string> _feeDesc8;
        /// <summary>
        /// Settlement Service Provider Fee Description 8 [SPNN31]
        /// </summary>
        [LoanFieldProperty(Description = "Settlement Service Provider Fee Description 8")]
        public string FeeDesc8 { get => _feeDesc8; set => _feeDesc8 = value; }
        private DirtyValue<string> _feeDesc9;
        /// <summary>
        /// Settlement Service Provider Fee Description 9 [SPNN33]
        /// </summary>
        [LoanFieldProperty(Description = "Settlement Service Provider Fee Description 9")]
        public string FeeDesc9 { get => _feeDesc9; set => _feeDesc9 = value; }
        private DirtyValue<string> _id;
        /// <summary>
        /// ServiceProviderContact Id
        /// </summary>
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<string> _lineItemNumber;
        /// <summary>
        /// Settlement Service Provider Line Item Number [SPNN09]
        /// </summary>
        [LoanFieldProperty(Description = "Settlement Service Provider Line Item Number")]
        public string LineItemNumber { get => _lineItemNumber; set => _lineItemNumber = value; }
        private DirtyValue<string> _phone;
        /// <summary>
        /// Settlement Service Provider Phone [SPNN07]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE, Description = "Settlement Service Provider Phone")]
        public string Phone { get => _phone; set => _phone = value; }
        private DirtyValue<string> _postalCode;
        /// <summary>
        /// Settlement Service Provider Postal Code [SPNN06]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE, Description = "Settlement Service Provider Postal Code")]
        public string PostalCode { get => _postalCode; set => _postalCode = value; }
        private DirtyValue<int?> _providerIndex;
        /// <summary>
        /// ServiceProviderContact ProviderIndex
        /// </summary>
        public int? ProviderIndex { get => _providerIndex; set => _providerIndex = value; }
        private DirtyValue<string> _providerName;
        /// <summary>
        /// Settlement Service Provider Name [SPNN02]
        /// </summary>
        [LoanFieldProperty(Description = "Settlement Service Provider Name")]
        public string ProviderName { get => _providerName; set => _providerName = value; }
        private DirtyValue<string> _relationship;
        /// <summary>
        /// Settlement Service Provider Relationship [SPNN08]
        /// </summary>
        [LoanFieldProperty(Description = "Settlement Service Provider Relationship")]
        public string Relationship { get => _relationship; set => _relationship = value; }
        private DirtyValue<string> _serviceProvided;
        /// <summary>
        /// Settlement Service Provided [SPNN01]
        /// </summary>
        [LoanFieldProperty(Description = "Settlement Service Provided")]
        public string ServiceProvided { get => _serviceProvided; set => _serviceProvided = value; }
        private DirtyValue<string> _serviceProviderId;
        /// <summary>
        /// ServiceProviderContact ServiceProviderId
        /// </summary>
        public string ServiceProviderId { get => _serviceProviderId; set => _serviceProviderId = value; }
        private DirtyValue<StringEnumValue<ServiceType>> _serviceType;
        /// <summary>
        /// Settlement Service Provider Service Type [SPNN10]
        /// </summary>
        [LoanFieldProperty(Description = "Settlement Service Provider Service Type")]
        public StringEnumValue<ServiceType> ServiceType { get => _serviceType; set => _serviceType = value; }
        private DirtyValue<bool?> _shopFor;
        /// <summary>
        /// Settlement Service Provider Cannot Shop For [SPNN13]
        /// </summary>
        [LoanFieldProperty(Description = "Settlement Service Provider Cannot Shop For")]
        public bool? ShopFor { get => _shopFor; set => _shopFor = value; }
        private DirtyValue<StringEnumValue<State>> _state;
        /// <summary>
        /// Settlement Service Provider State [SPNN05]
        /// </summary>
        [LoanFieldProperty(Description = "Settlement Service Provider State")]
        public StringEnumValue<State> State { get => _state; set => _state = value; }
        private DirtyValue<string> _webUrl;
        /// <summary>
        /// Settlement Service Provider Web Url [SPNN12]
        /// </summary>
        [LoanFieldProperty(Description = "Settlement Service Provider Web Url")]
        public string WebUrl { get => _webUrl; set => _webUrl = value; }
    }
}