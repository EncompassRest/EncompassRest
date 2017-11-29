using EnumsNET;

namespace EncompassRest.Filters
{
    public sealed class EmptyFieldFilter : FieldFilter
    {
        public EmptyFieldFilter(CanonicalLoanField canonicalField)
            : this(canonicalField.Validate(nameof(canonicalField)).GetCanonicalName())
        {
        }

        public EmptyFieldFilter(string canonicalName)
            : base(canonicalName)
        {
        }

        private EmptyFieldFilter(EmptyFieldFilter emptyFieldFilter)
            : base(emptyFieldFilter)
        {
        }

        public new EmptyFieldFilter Clone() => new EmptyFieldFilter(this);

        protected override FieldFilter CloneFieldFilter() => Clone();

        protected override string GetMatchType() => "isEmpty";
    }
}