namespace EncompassRest.Organizations
{
    public abstract class ParentInformation : DirtyExtensibleObject
    {
        private DirtyValue<bool?> _useParentInformation;

        public bool? UseParentInformation { get => _useParentInformation; set => SetField(ref _useParentInformation, value); }

        internal ParentInformation()
        {
        }
    }
}