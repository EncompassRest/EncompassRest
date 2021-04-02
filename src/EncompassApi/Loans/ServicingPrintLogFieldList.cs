using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace EncompassApi.Loans
{
    /// <summary>
    /// ServicingPrintLogFieldList
    /// </summary>
    public sealed partial class ServicingPrintLogFieldList : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyList<string>? _fieldList;
        private DirtyValue<string?>? _id;

        /// <summary>
        /// ServicingPrintLogFieldList FieldList
        /// </summary>
        [AllowNull]
        public IList<string> FieldList { get => GetField(ref _fieldList); set => SetField(ref _fieldList, value); }

        /// <summary>
        /// ServicingPrintLogFieldList Id
        /// </summary>
        public string? Id { get => _id; set => SetField(ref _id, value); }
    }
}