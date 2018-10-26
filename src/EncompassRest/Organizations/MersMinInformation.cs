namespace EncompassRest.Organizations
{
    public sealed class MersMinInformation : ParentInformation
    {
        private DirtyValue<string> _code;

        public string Code { get => _code; set => SetField(ref _code, value); }
    }
}