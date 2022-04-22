namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// FeeVarianceWorksheetRights
    /// </summary>
    public sealed class FeeVarianceWorksheetRights : ParentAccessRights
    {
        /// <summary>
        /// FeeVarianceWorksheetRights CureVariance
        /// </summary>
        public bool? CureVariance { get => GetValue<bool?>(); set => SetValue(value); }
    }
}