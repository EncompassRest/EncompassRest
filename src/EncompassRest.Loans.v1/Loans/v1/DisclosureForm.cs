using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans.v1
{
    /// <summary>
    /// DisclosureForm
    /// </summary>
    public sealed partial class DisclosureForm : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<string?>? _formName;
        private DirtyValue<StringEnumValue<DisclosureFormType>>? _formType;
        private DirtyValue<string?>? _id;

        /// <summary>
        /// DisclosureForm FormName
        /// </summary>
        public string? FormName { get => _formName; set => SetField(ref _formName, value); }

        /// <summary>
        /// DisclosureForm FormType
        /// </summary>
        public StringEnumValue<DisclosureFormType> FormType { get => _formType; set => SetField(ref _formType, value); }

        /// <summary>
        /// DisclosureForm Id
        /// </summary>
        public string? Id { get => _id; set => SetField(ref _id, value); }
    }
}