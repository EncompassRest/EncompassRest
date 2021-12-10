namespace EncompassRest.Loans.Enums;

/// <summary>
/// RecipientType
/// </summary>
public enum RecipientType
{
    /// <summary>
    /// Borrower
    /// </summary>
    Borrower = 0,
    /// <summary>
    /// CoBorrower
    /// </summary>
    CoBorrower = 1,
    /// <summary>
    /// NonBorrowingOwner
    /// </summary>
    NonBorrowingOwner = 2,
    /// <summary>
    /// LoanAssociate
    /// </summary>
    LoanAssociate = 3,
    /// <summary>
    /// Other
    /// </summary>
    Other = 4
}