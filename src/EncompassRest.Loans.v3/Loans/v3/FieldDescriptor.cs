using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Reflection;
using EncompassRest.Schema;
using EncompassRest.Utilities;
using EnumsNET;

namespace EncompassRest.Loans.v3
{
    /// <summary>
    /// The loan field descriptor.
    /// </summary>
    public class FieldDescriptor
    {
        internal readonly ModelPath _modelPath;
        internal bool _userAdded;
        private LoanFieldValueType? _valueType;
        private bool _loanEntityIsSet;
        //private LoanEntity? _loanEntity;
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
                    else
                    {
                        valueType = LoanFieldValueType.Unknown;
                        if (declaredType != null)
                        {
                            var typeInfo = declaredType.GetTypeInfo();
                            if (typeInfo.IsGenericType && !typeInfo.IsGenericTypeDefinition)
                            {
                                var genericTypeDefinition = typeInfo.GetGenericTypeDefinition();
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
                switch (ValueType)
                {
                    case LoanFieldValueType.Boolean:
                        return LoanFieldFormat.YN;
                    case LoanFieldValueType.DateTime:
                        return LoanFieldFormat.DATE;
                    case LoanFieldValueType.Int32:
                        return LoanFieldFormat.INTEGER;
                    case LoanFieldValueType.String:
                        return LoanFieldFormat.STRING;
                    case LoanFieldValueType.Decimal:
                        return LoanFieldFormat.DECIMAL_2;
                    default:
                        return null;
                }
            }
        }

        /// <summary>
        /// Indicates if the field is read only.
        /// </summary>
        public virtual bool ReadOnly => ParentDescriptor?.ReadOnly ?? Type == LoanFieldType.Virtual || PropertyAttribute?.ReadOnly == true;

        /// <summary>
        /// The field's description.
        /// </summary>
        public string Description { get; }

        ///// <summary>
        ///// The field's loan entity.
        ///// </summary>
        //public virtual LoanEntity? LoanEntity
        //{
        //    get
        //    {
        //        var loanEntity = _loanEntity;
        //        if (!_loanEntityIsSet)
        //        {
        //            loanEntity = ParentDescriptor?.LoanEntity;
        //            if (loanEntity == null)
        //            {
        //                if (Type == LoanFieldType.Virtual)
        //                {
        //                    loanEntity = v1.LoanEntity.VirtualFields;
        //                }
        //                else if (_modelPath.Segments.Count == 1)
        //                {
        //                    loanEntity = v1.LoanEntity.Loan;
        //                }
        //                else
        //                {
        //                    var finalSegmentIndex = _modelPath.Segments.Count - 2;

        //                    Type? declaredType = TypeData<Loan>.Type;
        //                    for (var i = 0; i <= finalSegmentIndex && declaredType != null; ++i)
        //                    {
        //                        declaredType = _modelPath.Segments[i].GetDeclaredType(declaredType);
        //                    }
        //                    if (declaredType != null && EnumsNET.Enums.TryParse<LoanEntity>(declaredType.Name, ignoreCase: false, out var newLoanEntity, EnumFormat.Name))
        //                    {
        //                        loanEntity = newLoanEntity;
        //                    }
        //                }
        //            }

        //            _loanEntity = loanEntity;
        //            _loanEntityIsSet = true;
        //        }
        //        return loanEntity;
        //    }
        //}

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

        /// <summary>
        /// The parent descriptor for instance field descriptors.
        /// </summary>
        public FieldDescriptor? ParentDescriptor { get; }

        private LoanFieldPropertyAttribute? PropertyAttribute
        {
            get
            {
                var propertyAttribute = _propertyAttribute;
                if (!_propertyAttributeIsSet)
                {
                    propertyAttribute = _modelPath.GetAttribute<LoanFieldPropertyAttribute>(TypeData<Loan>.Type);
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
                    declaredType = _modelPath.GetDeclaredType(TypeData<Loan>.Type);
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
                        var typeInfo = declaredType.GetTypeInfo();
                        if (typeInfo.IsGenericType && !typeInfo.IsGenericTypeDefinition)
                        {
                            var genericTypeDefinition = typeInfo.GetGenericTypeDefinition();
                            if (genericTypeDefinition == TypeData.OpenStringEnumValueType)
                            {
                                enumType = typeInfo.GenericTypeArguments[0];
                                _enumType = enumType;
                            }
                        }
                    }
                    _enumTypeIsSet = true;
                }
                return enumType;
            }
        }

        internal FieldDescriptor(string fieldId, ModelPath modelPath, string modelPathString, string? description, bool multiInstance = false, string? instanceSpecifier = null, FieldDescriptor? parentDescriptor = null)
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
            MultiInstance = multiInstance;
            InstanceSpecifier = instanceSpecifier;
            ParentDescriptor = parentDescriptor;
        }

        /// <summary>
        /// Creates an instance descriptor with the specified <paramref name="instanceSpecifier"/>.
        /// </summary>
        /// <param name="instanceSpecifier">The instance specifier for an instance field descriptor.</param>
        /// <returns></returns>
        public FieldDescriptor GetInstanceDescriptor(string instanceSpecifier)
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
    }
}