namespace EncompassRest
{
    /// <summary>
    /// Address
    /// </summary>
    public sealed class Address : DirtyExtensibleObject
    {
        /// <summary>
        /// The city in which the address is located.
        /// </summary>
        public string? City { get => GetValue<string?>(); set => SetValue(value); }

        /// <summary>
        /// The state in which the address is located.
        /// </summary>
        public StringEnumValue<State> State { get => GetValue<StringEnumValue<State>>(); set => SetValue(value); }

        /// <summary>
        /// Line 1 of the address.
        /// </summary>
        public string? Street1 { get => GetValue<string?>(); set => SetValue(value); }

        /// <summary>
        /// Line 2 of the address.
        /// </summary>
        public string? Street2 { get => GetValue<string?>(); set => SetValue(value); }

        /// <summary>
        /// The address's ZIP code.
        /// </summary>
        public string? Zip { get => GetValue<string?>(); set => SetValue(value); }
    }
}