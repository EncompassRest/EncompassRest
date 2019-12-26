using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Loans
{
    /// <summary>
    /// ServicingPrintLog
    /// </summary>
    public sealed partial class ServicingPrintLog : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyList<ServicingPrintLogFieldList>? _fieldLists;
        private DirtyValue<string?>? _id;

        /// <summary>
        /// ServicingPrintLog FieldLists
        /// </summary>
        [AllowNull]
        public IList<ServicingPrintLogFieldList> FieldLists { get => GetField(ref _fieldLists); set => SetField(ref _fieldLists, value); }

        /// <summary>
        /// ServicingPrintLog Id
        /// </summary>
        public string? Id { get => _id; set => SetField(ref _id, value); }
    }
}