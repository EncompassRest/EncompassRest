namespace EncompassApi.Company.Users.Rights
{
    /// <summary>
    /// FeeVarianceWorksheetRights
    /// </summary>
    public sealed class FeeVarianceWorksheetRights : ParentAccessRights
    {
        private DirtyValue<bool?>? _cureVariance;

        /// <summary>
        /// FeeVarianceWorksheetRights CureVariance
        /// </summary>
        public bool? CureVariance { get => _cureVariance; set => SetField(ref _cureVariance, value); }
    }
}