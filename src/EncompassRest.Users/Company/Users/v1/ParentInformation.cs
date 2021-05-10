namespace EncompassRest.Company.v1
{
    /// <summary>
    /// ParentInformation
    /// </summary>
    public abstract class ParentInformation : DirtyExtensibleObject
    {
        private DirtyValue<bool?>? _useParentInformation;

        /// <summary>
        /// Indicates whether to use the parent information above it. Changes made to the parent's information are reflected in this entity.
        /// </summary>
        public bool? UseParentInformation { get => _useParentInformation; set => SetField(ref _useParentInformation, value); }

        internal ParentInformation()
        {
        }
    }
}