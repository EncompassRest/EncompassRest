namespace EncompassRest.Organizations
{
    public sealed class ConsumerConnectLOSearchInformation : ParentInformation
    {
        private DirtyValue<string> _name;
        private DirtyValue<bool?> _showInSearch;

        public string Name { get => _name; set => SetField(ref _name, value); }

        public bool? ShowInSearch { get => _showInSearch; set => SetField(ref _showInSearch, value); }
    }
}