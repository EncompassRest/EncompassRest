using System;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// EClose
    /// </summary>
    public sealed partial class EClose : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<bool?>? _eSignComplete;
        private DirtyValue<string?>? _id;
        private DirtyValue<DateTime?>? _packageAvailableDate;
        private DirtyValue<DateTime?>? _packageDeliveryDate;
        private DirtyValue<DateTime?>? _packageExpirationDate;

        /// <summary>
        /// eClose eSign Complete [4797]
        /// </summary>
        public bool? ESignComplete { get => _eSignComplete; set => SetField(ref _eSignComplete, value); }

        /// <summary>
        /// EClose Id
        /// </summary>
        public string? Id { get => _id; set => SetField(ref _id, value); }

        /// <summary>
        /// eClose Package Available Date [4799]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? PackageAvailableDate { get => _packageAvailableDate; set => SetField(ref _packageAvailableDate, value); }

        /// <summary>
        /// eClose Package Delivery Date [4798]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? PackageDeliveryDate { get => _packageDeliveryDate; set => SetField(ref _packageDeliveryDate, value); }

        /// <summary>
        /// eClose Package Expiration Date [4800]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? PackageExpirationDate { get => _packageExpirationDate; set => SetField(ref _packageExpirationDate, value); }
    }
}