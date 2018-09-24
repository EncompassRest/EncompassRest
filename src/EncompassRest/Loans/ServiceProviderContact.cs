using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// ServiceProviderContact
    /// </summary>
    [Entity(SerializeWholeListWhenDirty = true)]
    public sealed partial class ServiceProviderContact : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<string> _address;
        private DirtyValue<string> _city;
        private DirtyValue<string> _contactName;
        private DirtyValue<decimal?> _cost;
        private DirtyValue<string> _email;
        private DirtyValue<string> _fax;
        private DirtyValue<decimal?> _feeAmt1;
        private DirtyValue<decimal?> _feeAmt10;
        private DirtyValue<decimal?> _feeAmt2;
        private DirtyValue<decimal?> _feeAmt3;
        private DirtyValue<decimal?> _feeAmt4;
        private DirtyValue<decimal?> _feeAmt5;
        private DirtyValue<decimal?> _feeAmt6;
        private DirtyValue<decimal?> _feeAmt7;
        private DirtyValue<decimal?> _feeAmt8;
        private DirtyValue<decimal?> _feeAmt9;
        private DirtyValue<string> _feeDesc1;
        private DirtyValue<string> _feeDesc10;
        private DirtyValue<string> _feeDesc2;
        private DirtyValue<string> _feeDesc3;
        private DirtyValue<string> _feeDesc4;
        private DirtyValue<string> _feeDesc5;
        private DirtyValue<string> _feeDesc6;
        private DirtyValue<string> _feeDesc7;
        private DirtyValue<string> _feeDesc8;
        private DirtyValue<string> _feeDesc9;
        private DirtyValue<string> _id;
        private DirtyValue<string> _lineItemNumber;
        private DirtyValue<string> _phone;
        private DirtyValue<string> _postalCode;
        private DirtyValue<int?> _providerIndex;
        private DirtyValue<string> _providerName;
        private DirtyValue<string> _relationship;
        private DirtyValue<string> _serviceProvided;
        private DirtyValue<string> _serviceProviderId;
        private DirtyValue<StringEnumValue<ServiceType>> _serviceType;
        private DirtyValue<bool?> _shopFor;
        private DirtyValue<StringEnumValue<State>> _state;
        private DirtyValue<string> _webUrl;

        /// <summary>
        /// Settlement Service Provider Address [SPNN03]
        /// </summary>
        [LoanFieldProperty(Description = "Settlement Service Provider Address")]
        public string Address { get => _address; set => SetField(ref _address, value); }

        /// <summary>
        /// Settlement Service Provider City [SPNN04]
        /// </summary>
        [LoanFieldProperty(Description = "Settlement Service Provider City")]
        public string City { get => _city; set => SetField(ref _city, value); }

        /// <summary>
        /// Settlement Service Provider ContactName [SPNN14]
        /// </summary>
        [LoanFieldProperty(Description = "Settlement Service Provider ContactName")]
        public string ContactName { get => _contactName; set => SetField(ref _contactName, value); }

        /// <summary>
        /// Settlement Service Provider Cost [SPNN11]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Settlement Service Provider Cost")]
        public decimal? Cost { get => _cost; set => SetField(ref _cost, value); }

        /// <summary>
        /// Settlement Service Provider Email [SPNN15]
        /// </summary>
        [LoanFieldProperty(Description = "Settlement Service Provider Email")]
        public string Email { get => _email; set => SetField(ref _email, value); }

        /// <summary>
        /// Settlement Service Provider Fax [SPNN16]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE, Description = "Settlement Service Provider Fax")]
        public string Fax { get => _fax; set => SetField(ref _fax, value); }

        /// <summary>
        /// Settlement Service Provider Fee Amount 1 [SPNN18]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Settlement Service Provider Fee Amount 1")]
        public decimal? FeeAmt1 { get => _feeAmt1; set => SetField(ref _feeAmt1, value); }

        /// <summary>
        /// Settlement Service Provider Fee Amount 10 [SPNN36]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Settlement Service Provider Fee Amount 10")]
        public decimal? FeeAmt10 { get => _feeAmt10; set => SetField(ref _feeAmt10, value); }

        /// <summary>
        /// Settlement Service Provider Fee Amount 2 [SPNN20]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Settlement Service Provider Fee Amount 2")]
        public decimal? FeeAmt2 { get => _feeAmt2; set => SetField(ref _feeAmt2, value); }

        /// <summary>
        /// Settlement Service Provider Fee Amount 3 [SPNN22]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Settlement Service Provider Fee Amount 3")]
        public decimal? FeeAmt3 { get => _feeAmt3; set => SetField(ref _feeAmt3, value); }

        /// <summary>
        /// Settlement Service Provider Fee Amount 4 [SPNN24]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Settlement Service Provider Fee Amount 4")]
        public decimal? FeeAmt4 { get => _feeAmt4; set => SetField(ref _feeAmt4, value); }

        /// <summary>
        /// Settlement Service Provider Fee Amount 5 [SPNN26]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Settlement Service Provider Fee Amount 5")]
        public decimal? FeeAmt5 { get => _feeAmt5; set => SetField(ref _feeAmt5, value); }

        /// <summary>
        /// Settlement Service Provider Fee Amount 6 [SPNN28]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Settlement Service Provider Fee Amount 6")]
        public decimal? FeeAmt6 { get => _feeAmt6; set => SetField(ref _feeAmt6, value); }

        /// <summary>
        /// Settlement Service Provider Fee Amount 7 [SPNN30]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Settlement Service Provider Fee Amount 7")]
        public decimal? FeeAmt7 { get => _feeAmt7; set => SetField(ref _feeAmt7, value); }

        /// <summary>
        /// Settlement Service Provider Fee Amount 8 [SPNN32]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Settlement Service Provider Fee Amount 8")]
        public decimal? FeeAmt8 { get => _feeAmt8; set => SetField(ref _feeAmt8, value); }

        /// <summary>
        /// Settlement Service Provider Fee Amount 9 [SPNN34]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Settlement Service Provider Fee Amount 9")]
        public decimal? FeeAmt9 { get => _feeAmt9; set => SetField(ref _feeAmt9, value); }

        /// <summary>
        /// Settlement Service Provider Fee Description 1 [SPNN17]
        /// </summary>
        [LoanFieldProperty(Description = "Settlement Service Provider Fee Description 1")]
        public string FeeDesc1 { get => _feeDesc1; set => SetField(ref _feeDesc1, value); }

        /// <summary>
        /// Settlement Service Provider Fee Description 10 [SPNN35]
        /// </summary>
        [LoanFieldProperty(Description = "Settlement Service Provider Fee Description 10")]
        public string FeeDesc10 { get => _feeDesc10; set => SetField(ref _feeDesc10, value); }

        /// <summary>
        /// Settlement Service Provider Fee Description 2 [SPNN19]
        /// </summary>
        [LoanFieldProperty(Description = "Settlement Service Provider Fee Description 2")]
        public string FeeDesc2 { get => _feeDesc2; set => SetField(ref _feeDesc2, value); }

        /// <summary>
        /// Settlement Service Provider Fee Description 3 [SPNN21]
        /// </summary>
        [LoanFieldProperty(Description = "Settlement Service Provider Fee Description 3")]
        public string FeeDesc3 { get => _feeDesc3; set => SetField(ref _feeDesc3, value); }

        /// <summary>
        /// Settlement Service Provider Fee Description 4 [SPNN23]
        /// </summary>
        [LoanFieldProperty(Description = "Settlement Service Provider Fee Description 4")]
        public string FeeDesc4 { get => _feeDesc4; set => SetField(ref _feeDesc4, value); }

        /// <summary>
        /// Settlement Service Provider Fee Description 5 [SPNN25]
        /// </summary>
        [LoanFieldProperty(Description = "Settlement Service Provider Fee Description 5")]
        public string FeeDesc5 { get => _feeDesc5; set => SetField(ref _feeDesc5, value); }

        /// <summary>
        /// Settlement Service Provider Fee Description 6 [SPNN27]
        /// </summary>
        [LoanFieldProperty(Description = "Settlement Service Provider Fee Description 6")]
        public string FeeDesc6 { get => _feeDesc6; set => SetField(ref _feeDesc6, value); }

        /// <summary>
        /// Settlement Service Provider Fee Description 7 [SPNN29]
        /// </summary>
        [LoanFieldProperty(Description = "Settlement Service Provider Fee Description 7")]
        public string FeeDesc7 { get => _feeDesc7; set => SetField(ref _feeDesc7, value); }

        /// <summary>
        /// Settlement Service Provider Fee Description 8 [SPNN31]
        /// </summary>
        [LoanFieldProperty(Description = "Settlement Service Provider Fee Description 8")]
        public string FeeDesc8 { get => _feeDesc8; set => SetField(ref _feeDesc8, value); }

        /// <summary>
        /// Settlement Service Provider Fee Description 9 [SPNN33]
        /// </summary>
        [LoanFieldProperty(Description = "Settlement Service Provider Fee Description 9")]
        public string FeeDesc9 { get => _feeDesc9; set => SetField(ref _feeDesc9, value); }

        /// <summary>
        /// ServiceProviderContact Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }

        /// <summary>
        /// Settlement Service Provider Line Item Number [SPNN09]
        /// </summary>
        [LoanFieldProperty(Description = "Settlement Service Provider Line Item Number")]
        public string LineItemNumber { get => _lineItemNumber; set => SetField(ref _lineItemNumber, value); }

        /// <summary>
        /// Settlement Service Provider Phone [SPNN07]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE, Description = "Settlement Service Provider Phone")]
        public string Phone { get => _phone; set => SetField(ref _phone, value); }

        /// <summary>
        /// Settlement Service Provider Postal Code [SPNN06]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE, Description = "Settlement Service Provider Postal Code")]
        public string PostalCode { get => _postalCode; set => SetField(ref _postalCode, value); }

        /// <summary>
        /// ServiceProviderContact ProviderIndex
        /// </summary>
        public int? ProviderIndex { get => _providerIndex; set => SetField(ref _providerIndex, value); }

        /// <summary>
        /// Settlement Service Provider Name [SPNN02]
        /// </summary>
        [LoanFieldProperty(Description = "Settlement Service Provider Name")]
        public string ProviderName { get => _providerName; set => SetField(ref _providerName, value); }

        /// <summary>
        /// Settlement Service Provider Relationship [SPNN08]
        /// </summary>
        [LoanFieldProperty(Description = "Settlement Service Provider Relationship")]
        public string Relationship { get => _relationship; set => SetField(ref _relationship, value); }

        /// <summary>
        /// Settlement Service Provided [SPNN01]
        /// </summary>
        [LoanFieldProperty(Description = "Settlement Service Provided")]
        public string ServiceProvided { get => _serviceProvided; set => SetField(ref _serviceProvided, value); }

        /// <summary>
        /// ServiceProviderContact ServiceProviderId
        /// </summary>
        public string ServiceProviderId { get => _serviceProviderId; set => SetField(ref _serviceProviderId, value); }

        /// <summary>
        /// Settlement Service Provider Service Type [SPNN10]
        /// </summary>
        [LoanFieldProperty(Description = "Settlement Service Provider Service Type")]
        public StringEnumValue<ServiceType> ServiceType { get => _serviceType; set => SetField(ref _serviceType, value); }

        /// <summary>
        /// Settlement Service Provider Cannot Shop For [SPNN13]
        /// </summary>
        [LoanFieldProperty(Description = "Settlement Service Provider Cannot Shop For")]
        public bool? ShopFor { get => _shopFor; set => SetField(ref _shopFor, value); }

        /// <summary>
        /// Settlement Service Provider State [SPNN05]
        /// </summary>
        [LoanFieldProperty(Description = "Settlement Service Provider State")]
        public StringEnumValue<State> State { get => _state; set => SetField(ref _state, value); }

        /// <summary>
        /// Settlement Service Provider Web Url [SPNN12]
        /// </summary>
        [LoanFieldProperty(Description = "Settlement Service Provider Web Url")]
        public string WebUrl { get => _webUrl; set => SetField(ref _webUrl, value); }
    }
}