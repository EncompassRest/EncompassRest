using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans
{
    /// <summary>
    /// SpecialFeatureCode
    /// </summary>
    [Entity(SerializeWholeListWhenDirty = true)]
    public sealed partial class SpecialFeatureCode : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<string?>? _code;
        private DirtyValue<string?>? _comments;
        private DirtyValue<string?>? _description;
        private DirtyValue<bool?>? _entityDeleted;
        private DirtyValue<string?>? _id;
        private DirtyValue<StringEnumValue<SpecialFeatureCodeSource>>? _source;
        private DirtyValue<string?>? _sourceOther;

        /// <summary>
        /// Special Feature Code - Code [SFCNN01]
        /// </summary>
        public string? Code { get => _code; set => SetField(ref _code, value); }

        /// <summary>
        /// Special Feature Code - Comments [SFCNN03]
        /// </summary>
        public string? Comments { get => _comments; set => SetField(ref _comments, value); }

        /// <summary>
        /// Special Feature Code - Description [SFCNN02]
        /// </summary>
        public string? Description { get => _description; set => SetField(ref _description, value); }

        /// <summary>
        /// SpecialFeatureCode EntityDeleted
        /// </summary>
        public bool? EntityDeleted { get => _entityDeleted; set => SetField(ref _entityDeleted, value); }

        /// <summary>
        /// SpecialFeatureCode Id
        /// </summary>
        public string? Id { get => _id; set => SetField(ref _id, value); }

        /// <summary>
        /// Special Feature Code - Source [SFCNN04]
        /// </summary>
        public StringEnumValue<SpecialFeatureCodeSource> Source { get => _source; set => SetField(ref _source, value); }

        /// <summary>
        /// Special Feature Code - Source Other [SFCNN05]
        /// </summary>
        public string? SourceOther { get => _sourceOther; set => SetField(ref _sourceOther, value); }
    }
}