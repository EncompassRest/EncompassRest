namespace EncompassRest.Loans
{
    public interface ILoanFields
    {
        ILoanField this[string fieldId] { get; }

        bool AllowWritesToReadOnlyFieldsLocally { get; set; }
    }
}