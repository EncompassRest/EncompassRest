using EnumsNET;

namespace EncompassRest.Filters
{
    public sealed class NotEmptyFieldFilter : FieldFilter
    {
        public NotEmptyFieldFilter(CanonicalField canonicalField)
            : this(canonicalField.Validate(nameof(canonicalField)).GetCanonicalName())
        {
        }

        public NotEmptyFieldFilter(string canonicalName)
            : base(canonicalName)
        {
        }

        private NotEmptyFieldFilter(NotEmptyFieldFilter notEmptyFieldFilter)
            : base(notEmptyFieldFilter)
        {
        }

        public new NotEmptyFieldFilter Clone() => new NotEmptyFieldFilter(this);

        protected override FieldFilter CloneFieldFilter() => Clone();

        protected override string GetMatchType() => "isNotEmpty";
    }
}