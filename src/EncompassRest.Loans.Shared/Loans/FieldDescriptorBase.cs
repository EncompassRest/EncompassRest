using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using EncompassRest.Schema;
using EncompassRest.Utilities;
using EnumsNET;

namespace EncompassRest.Loans
{
    /// <summary>
    /// The loan field descriptor.
    /// </summary>
    public abstract class FieldDescriptorBase : IFieldDescriptor
    {
        private readonly Type _loanType;
        internal readonly ModelPath _modelPath;
        internal bool _userAdded;
        private LoanFieldValueType? _valueType;
        private bool _propertyAttributeIsSet;
        private LoanFieldPropertyAttribute? _propertyAttribute;
        private ReadOnlyCollection<FieldOption>? _options;
        private bool _declaredTypeIsSet;
        private Type? _declaredType;
        private bool _enumTypeIsSet;
        private Type? _enumType;

        /// <summary>
        /// The field id.
        /// </summary>
        public string FieldId { get; }

        /// <summary>
        /// The field model path for use with loan field locking.
        /// </summary>
        public string ModelPath { get; }

        /// <summary>
        /// Indicates if the field descriptor is a multi-instance descriptor.
        /// </summary>
        public bool MultiInstance { get; }

        /// <summary>
        /// The instance specifier for an instance field descriptor.
        /// </summary>
        public string? InstanceSpecifier { get; }

        /// <summary>
        /// Indicates if the field descriptor is an instance of a multi-instance descriptor.
        /// </summary>
        public bool IsInstance => MultiInstance && !string.IsNullOrEmpty(InstanceSpecifier);

        /// <summary>
        /// Indicates if the field descriptor is borrower pair specific.
        /// </summary>
        public bool IsBorrowerPairSpecific { get; }

        /// <summary>
        /// The loan field's value type.
        /// </summary>
        public virtual LoanFieldValueType ValueType
        {
            get
            {
                var valueType = ParentDescriptor?.ValueType ?? _valueType;
                if (!valueType.HasValue)
                {
                    var declaredType = DeclaredType;
                    if (declaredType == TypeData<string>.Type || declaredType == TypeData<StringDecimalValue>.Type)
                    {
                        valueType = LoanFieldValueType.String;
                    }
                    else if (declaredType == TypeData<DateTime?>.Type)
                    {
                        valueType = LoanFieldValueType.DateTime;
                    }
                    else if (declaredType == TypeData<decimal?>.Type)
                    {
                        valueType = LoanFieldValueType.Decimal;
                    }
                    else if (declaredType == TypeData<int?>.Type)
                    {
                        valueType = LoanFieldValueType.Int32;
                    }
                    else if (declaredType == TypeData<bool?>.Type)
                    {
                        valueType = LoanFieldValueType.Boolean;
                    }
                    else if (declaredType == TypeData<object>.Type)
                    {
                        valueType = LoanFieldValueType.Object;
                    }
                    else
                    {
                        valueType = LoanFieldValueType.Unknown;
                        if (declaredType != null)
                        {
                            if (declaredType.IsGenericType && !declaredType.IsGenericTypeDefinition)
                            {
                                var genericTypeDefinition = declaredType.GetGenericTypeDefinition();
                                if (genericTypeDefinition == TypeData.OpenStringEnumValueType)
                                {
                                    valueType = LoanFieldValueType.String;
                                }
                                else if (genericTypeDefinition == TypeData.OpenNaType)
                                {
                                    valueType = LoanFieldValueType.NADecimal;
                                }
                            }
                        }
                    }
                    _valueType = valueType;
                }
                return valueType.GetValueOrDefault();
            }
        }

        /// <summary>
        /// The loan field's type.
        /// </summary>
        public LoanFieldType Type { get; }

        /// <summary>
        /// The loan field's format.
        /// </summary>
        public virtual LoanFieldFormat? Format
        {
            get
            {
                var format = ParentDescriptor?.Format ?? PropertyAttribute?._format;
                if (format.HasValue)
                {
                    return format;
                }
                if (EnumType == TypeData<State>.Type)
                {
                    return LoanFieldFormat.STATE;
                }
                return ValueType switch
                {
                    LoanFieldValueType.Boolean => LoanFieldFormat.YN,
                    LoanFieldValueType.DateTime => LoanFieldFormat.DATE,
                    LoanFieldValueType.Int32 => LoanFieldFormat.INTEGER,
                    LoanFieldValueType.String => LoanFieldFormat.STRING,
                    LoanFieldValueType.Decimal => LoanFieldFormat.DECIMAL_2,
                    _ => null,
                };
            }
        }

        /// <summary>
        /// Indicates if the field is read only.
        /// </summary>
        public virtual bool ReadOnly => ParentDescriptor?.ReadOnly ?? (Type == LoanFieldType.Virtual || PropertyAttribute?.ReadOnly == true);

        /// <summary>
        /// The field's description.
        /// </summary>
        public string Description { get; }

        /// <inheritdoc/>
        public string? LoanEntity => LoanEntityInternal;

        internal abstract string? LoanEntityInternal { get; }

        /// <summary>
        /// The field's options.
        /// </summary>
        public virtual ReadOnlyCollection<FieldOption> Options
        {
            get
            {
                var options = ParentDescriptor?.Options ?? _options;
                if (options == null)
                {
                    var dictionary = new Dictionary<string, string>();
                    var declaredType = DeclaredType;
                    if (declaredType != null)
                    {
                        if (declaredType == TypeData<bool?>.Type)
                        {
                            dictionary.Add("Y", "Yes");
                            dictionary.Add("N", "No");
                        }
                        else
                        {
                            var enumType = EnumType;
                            if (enumType != null)
                            {
                                foreach (var member in EnumsNET.Enums.GetMembers(enumType))
                                {
                                    var value = member.AsString(EnumFormat.EnumMemberValue, EnumFormat.Name)!;
                                    if (!dictionary.ContainsKey(value))
                                    {
                                        dictionary.Add(value, member.AsString(EnumFormat.Description, EnumFormat.EnumMemberValue, EnumFormat.Name)!);
                                    }
                                }
                            }
                        }
                    }
                    var propertyOptions = PropertyAttribute?.Options;
                    if (propertyOptions != null)
                    {
                        foreach (var pair in propertyOptions)
                        {
                            dictionary[pair.Key] = pair.Value;
                        }
                    }
                    var missingOptions = PropertyAttribute?.MissingOptions;
                    if (missingOptions != null)
                    {
                        foreach (var missingOption in missingOptions)
                        {
                            dictionary.Remove(missingOption);
                        }
                    }

                    options = new ReadOnlyCollection<FieldOption>(dictionary.Select(p => new FieldOption(p.Key, p.Value)).ToList());
                    _options = options;
                }
                return options;
            }
        }

        /// <inheritdoc/>
        public IFieldDescriptor? ParentDescriptor { get; }

        private LoanFieldPropertyAttribute? PropertyAttribute
        {
            get
            {
                var propertyAttribute = _propertyAttribute;
                if (!_propertyAttributeIsSet)
                {
                    propertyAttribute = _modelPath.GetAttribute<LoanFieldPropertyAttribute>(_loanType);
                    _propertyAttribute = propertyAttribute;
                    _propertyAttributeIsSet = true;
                }
                return propertyAttribute;
            }
        }

        private Type? DeclaredType
        {
            get
            {
                var declaredType = _declaredType;
                if (!_declaredTypeIsSet)
                {
                    declaredType = _modelPath.GetDeclaredType(_loanType);
                    _declaredType = declaredType;
                    _declaredTypeIsSet = true;
                }
                return declaredType;
            }
        }

        private Type? EnumType
        {
            get
            {
                var enumType = _enumType;
                if (!_enumTypeIsSet)
                {
                    var declaredType = DeclaredType;
                    if (declaredType != null)
                    {
                        if (declaredType.IsGenericType && !declaredType.IsGenericTypeDefinition)
                        {
                            var genericTypeDefinition = declaredType.GetGenericTypeDefinition();
                            if (genericTypeDefinition == TypeData.OpenStringEnumValueType)
                            {
                                enumType = declaredType.GenericTypeArguments[0];
                                _enumType = enumType;
                            }
                        }
                    }
                    _enumTypeIsSet = true;
                }
                return enumType;
            }
        }

        internal FieldDescriptorBase(string fieldId, ModelPath modelPath, string modelPathString, string? description, Type loanType, bool multiInstance = false, string? instanceSpecifier = null, IFieldDescriptor? parentDescriptor = null)
        {
            FieldId = fieldId;
            _modelPath = modelPath;
            ModelPath = modelPathString;

            if (modelPathString.StartsWith("Loan.CustomFields", StringComparison.OrdinalIgnoreCase))
            {
                Type = LoanFieldType.Custom;
            }
            else if (modelPathString.StartsWith("Loan.VirtualFields", StringComparison.OrdinalIgnoreCase))
            {
                Type = LoanFieldType.Virtual;
            }
            else if (modelPathString.StartsWith("Loan.CurrentApplication.", StringComparison.OrdinalIgnoreCase))
            {
                IsBorrowerPairSpecific = true;
            }

            Description = description ?? string.Empty;
            _loanType = loanType;
            MultiInstance = multiInstance;
            InstanceSpecifier = instanceSpecifier;
            ParentDescriptor = parentDescriptor;
        }

        /// <inheritdoc/>
        public IFieldDescriptor GetInstanceDescriptor(string instanceSpecifier) => GetInstanceDescriptorInternal(instanceSpecifier);

        internal abstract IFieldDescriptor GetInstanceDescriptorInternal(string instanceSpecifier);
    }
}