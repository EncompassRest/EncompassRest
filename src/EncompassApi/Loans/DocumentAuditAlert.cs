using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace EncompassApi.Loans
{
    /// <summary>
    /// DocumentAuditAlert
    /// </summary>
    public sealed partial class DocumentAuditAlert : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyList<string>? _fields;
        private DirtyValue<string?>? _source;
        private DirtyValue<string?>? _text;
        private DirtyValue<string?>? _type;

        /// <summary>
        /// DocumentAuditAlert Fields
        /// </summary>
        [AllowNull]
        public IList<string> Fields { get => GetField(ref _fields); set => SetField(ref _fields, value); }

        /// <summary>
        /// DocumentAuditAlert Source
        /// </summary>
        public string? Source { get => _source; set => SetField(ref _source, value); }

        /// <summary>
        /// DocumentAuditAlert Text
        /// </summary>
        public string? Text { get => _text; set => SetField(ref _text, value); }

        /// <summary>
        /// DocumentAuditAlert Type
        /// </summary>
        public string? Type { get => _type; set => SetField(ref _type, value); }
    }
}