﻿using EncompassRest.Loans.Enums;
using EncompassRest.Utilities;
using EnumsNET;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    [Entity(PropertiesToAlwaysSerialize = nameof(ApplicationId))]
    partial class Application
    {
        string IIdentifiable.Id { get => Id ?? ApplicationId; set { Id = value; ApplicationId = value; } }
    }

    partial class CustomField
    {
        [IdPropertyName(nameof(FieldName))]
        string IIdentifiable.Id { get => FieldName; set => FieldName = value; }
    }

    partial class FieldLockData
    {
        internal ModelPath _modelPathInternal;

        [IdPropertyName(nameof(ModelPath))]
        string IIdentifiable.Id { get => ModelPath; set => ModelPath = value; }

        internal override void OnPropertyChanged(string propertyName)
        {
            base.OnPropertyChanged(propertyName);
            switch (propertyName)
            {
                case nameof(ModelPath):
                    _modelPathInternal = LoanFieldDescriptors.CreateModelPath(_modelPath);
                    break;
            }
        }
    }

    [Entity(PropertiesToAlwaysSerialize = nameof(LoanAssociateType))]
    partial class LoanAssociate
    {
        public LoanAssociate(string id, LoanAssociateType loanAssociateType)
            : this(id, loanAssociateType.Validate(nameof(loanAssociateType)).AsString(EnumFormat.EnumMemberValue, EnumFormat.Name))
        {
        }

        public LoanAssociate(string id, string loanAssociateType)
        {
            Preconditions.NotNullOrEmpty(id, nameof(id));
            Preconditions.NotNullOrEmpty(loanAssociateType, nameof(loanAssociateType));

            Id = id;
            LoanAssociateType = loanAssociateType;
        }

        [JsonConstructor]
        public LoanAssociate()
        {
        }
    }
}