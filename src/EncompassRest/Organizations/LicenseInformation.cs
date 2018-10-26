namespace EncompassRest.Organizations
{
    public sealed class LicenseInformation : ParentInformation
    {
        private DirtyValue<StringEnumValue<AtrExemptCreditors>> _atrExemptCreditors;
        private DirtyValue<StringEnumValue<AtrSmallCreditors>> _atrSmallCreditors;
        private DirtyValue<StringEnumValue<State>> _homeState;
        private DirtyValue<string> _lenderType;
        private StateLicenseExtTypes _stateLicenseExtTypes;
        private DirtyValue<StringEnumValue<StatutoryStatusKansasType>> _statutoryStatusKansasType;
        private DirtyValue<StringEnumValue<StatutoryStatusMarylandType>> _statutoryStatusMarylandType;
        private DirtyValue<bool?> _useCustomLenderProfileForECS;

        public StringEnumValue<AtrExemptCreditors> AtrExemptCreditors { get => _atrExemptCreditors; set => SetField(ref _atrExemptCreditors, value); }

        public StringEnumValue<AtrSmallCreditors> AtrSmallCreditors { get => _atrSmallCreditors; set => SetField(ref _atrSmallCreditors, value); }

        public StringEnumValue<State> HomeState { get => _homeState; set => SetField(ref _homeState, value); }

        public string LenderType { get => _lenderType; set => SetField(ref _lenderType, value); }

        public StateLicenseExtTypes StateLicenseExtTypes { get => GetField(ref _stateLicenseExtTypes); set => SetField(ref _stateLicenseExtTypes, value); }

        public StringEnumValue<StatutoryStatusKansasType> StatutoryStatusKansasType { get => _statutoryStatusKansasType; set => SetField(ref _statutoryStatusKansasType, value); }

        public StringEnumValue<StatutoryStatusMarylandType> StatutoryStatusMarylandType { get => _statutoryStatusMarylandType; set => SetField(ref _statutoryStatusMarylandType, value); }

        public bool? UseCustomLenderProfileForECS { get => _useCustomLenderProfileForECS; set => SetField(ref _useCustomLenderProfileForECS, value); }
    }
}