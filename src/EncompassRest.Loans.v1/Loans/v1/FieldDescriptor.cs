using System;
using System.Globalization;
using EncompassRest.Utilities;
using EnumsNET;

namespace EncompassRest.Loans.v1;

/// <summary>
/// The loan field descriptor.
/// </summary>
public class FieldDescriptor : FieldDescriptorBase
{
    private bool _loanEntityIsSet;
    private LoanEntity? _loanEntity;

    /// <summary>
    /// The field attribute path for use with Webhook filter attributes.
    /// </summary>
    public string AttributePath
    {
        get
        {
            if (MultiInstance && !IsInstance)
            {
                throw new InvalidOperationException("field descriptor must be an instance descriptor for multi-instance descriptors");
            }

            return _modelPath.ToString(name => JsonHelper.CamelCaseNamingStrategy.GetPropertyName(name, false), true).Replace("/currentApplication", "/applications/*");
        }
    }

    /// <summary>
    /// The field's loan entity.
    /// </summary>
    public new virtual LoanEntity? LoanEntity
    {
        get
        {
            var loanEntity = _loanEntity;
            if (!_loanEntityIsSet)
            {
                loanEntity = ParentDescriptor?.LoanEntity;
                if (loanEntity == null)
                {
                    if (Type == LoanFieldType.Virtual)
                    {
                        loanEntity = v1.LoanEntity.VirtualFields;
                    }
                    else if (_modelPath.Segments.Count == 1)
                    {
                        loanEntity = v1.LoanEntity.Loan;
                    }
                    else
                    {
                        var finalSegmentIndex = _modelPath.Segments.Count - 2;

                        Type? declaredType = TypeData<Loan>.Type;
                        for (var i = 0; i <= finalSegmentIndex && declaredType != null; ++i)
                        {
                            declaredType = _modelPath.Segments[i].GetDeclaredType(declaredType);
                        }
                        if (declaredType != null && EnumsNET.Enums.TryParse<LoanEntity>(declaredType.Name, ignoreCase: false, out var newLoanEntity, EnumFormat.Name))
                        {
                            loanEntity = newLoanEntity;
                        }
                    }
                }

                _loanEntity = loanEntity;
                _loanEntityIsSet = true;
            }
            return loanEntity;
        }
    }

    internal override string? LoanEntityInternal => LoanEntity?.GetValue();

    /// <inheritdoc cref="IFieldDescriptor.ParentDescriptor"/>
    public new FieldDescriptor? ParentDescriptor => (FieldDescriptor?)base.ParentDescriptor;

    internal FieldDescriptor(string fieldId, ModelPath modelPath, string modelPathString, string? description, bool multiInstance = false, string? instanceSpecifier = null, FieldDescriptor? parentDescriptor = null)
        : base(fieldId, modelPath, modelPathString, description, TypeData<Loan>.Type, multiInstance, instanceSpecifier, parentDescriptor)
    {
    }

    /// <summary>
    /// Creates an instance descriptor with the specified <paramref name="instanceSpecifier"/>.
    /// </summary>
    /// <param name="instanceSpecifier">The instance specifier for an instance field descriptor.</param>
    /// <returns></returns>
    public new FieldDescriptor GetInstanceDescriptor(string instanceSpecifier)
    {
        Preconditions.NotNullOrEmpty(instanceSpecifier, nameof(instanceSpecifier));

        if (!MultiInstance)
        {
            throw new InvalidOperationException("field must be multi-instance to retrieve an instance descriptor");
        }
        if (IsInstance)
        {
            throw new InvalidOperationException("cannot retrieve an instance descriptor of an instance descriptor");
        }

        var formatArg = int.TryParse(instanceSpecifier, NumberStyles.None, null, out var i) ? (object)i : instanceSpecifier;
        var modelPathString = string.Format(ModelPath, formatArg);
        return new FieldDescriptor(string.Format(FieldId, formatArg), LoanFieldDescriptors.CreateModelPath(modelPathString)!, modelPathString, string.Format(Description, formatArg), MultiInstance, instanceSpecifier, this);
    }

    internal override IFieldDescriptor GetInstanceDescriptorInternal(string instanceSpecifier) => GetInstanceDescriptor(instanceSpecifier);
}