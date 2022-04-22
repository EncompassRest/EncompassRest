namespace EncompassRest.Company.v1
{
    /// <summary>
    /// ParentInformation
    /// </summary>
    public abstract class ParentInformation : DirtyExtensibleObject
    {
        /// <summary>
        /// Indicates whether to use the parent information above it. Changes made to the parent's information are reflected in this entity.
        /// </summary>
        public bool? UseParentInformation { get => GetValue<bool?>(); set => SetValue(value); }

        internal ParentInformation()
        {
        }
    }
}