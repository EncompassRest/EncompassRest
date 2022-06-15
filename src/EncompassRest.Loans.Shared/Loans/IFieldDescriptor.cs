using System.Collections.ObjectModel;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// The loan field descriptor.
    /// </summary>
    public interface IFieldDescriptor
    {
        /// <summary>
        /// The field's description.
        /// </summary>
        string Description { get; }
        /// <summary>
        /// The field id.
        /// </summary>
        string FieldId { get; }
        /// <summary>
        /// The loan field's format.
        /// </summary>
        LoanFieldFormat? Format { get; }
        /// <summary>
        /// The instance specifier for an instance field descriptor.
        /// </summary>
        string? InstanceSpecifier { get; }
        /// <summary>
        /// Indicates if the field descriptor is borrower pair specific.
        /// </summary>
        bool IsBorrowerPairSpecific { get; }
        /// <summary>
        /// Indicates if the field descriptor is an instance of a multi-instance descriptor.
        /// </summary>
        bool IsInstance { get; }
        /// <summary>
        /// The field's loan entity.
        /// </summary>
        string? LoanEntity { get; }
        /// <summary>
        /// The field model path for use with loan field locking.
        /// </summary>
        string ModelPath { get; }
        /// <summary>
        /// Indicates if the field descriptor is a multi-instance descriptor.
        /// </summary>
        bool MultiInstance { get; }
        /// <summary>
        /// The field's options.
        /// </summary>
        ReadOnlyCollection<FieldOption> Options { get; }
        /// <summary>
        /// The parent descriptor for instance field descriptors.
        /// </summary>
        IFieldDescriptor? ParentDescriptor { get; }
        /// <summary>
        /// Indicates if the field is read only.
        /// </summary>
        bool ReadOnly { get; }
        /// <summary>
        /// The loan field's type.
        /// </summary>
        LoanFieldType Type { get; }
        /// <summary>
        /// The loan field's value type.
        /// </summary>
        LoanFieldValueType ValueType { get; }

        /// <summary>
        /// Creates an instance descriptor with the specified <paramref name="instanceSpecifier"/>.
        /// </summary>
        /// <param name="instanceSpecifier">The instance specifier for an instance field descriptor.</param>
        /// <returns></returns>
        IFieldDescriptor GetInstanceDescriptor(string instanceSpecifier);
    }
}